using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Edocsys
{
    public partial class ContractStatsForm : Form
    {
        public ContractStatsForm()
        {
            InitializeComponent();
        }

        private DocGeneratorHelper contractGenerator;
        private FilterHelper filterFinishedContracts, filterBadContracts, filterCurrentContracts;

        private DataGridViewFooterDecorator fdCurrentContractsDataGridView, fdFinishedContractsDataGridView, fdBadContractsDataTableDataGridView;

        private int status_id = -1;


        private void ContractsForm_Load(object sender, EventArgs e)
        {
            this.badContractsTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.finishedContractsTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.currentContractsTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.agentsContactsForFinishedContractsTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            

            RefreshDatabase();

            //add filters
            filterFinishedContracts= new FilterHelper(finishedContractsDataGridView, filterFinishedContractsText.TextBox);
            filterBadContracts = new FilterHelper(badContractsDataTableDataGridView, filterBadContractsTextBox.TextBox);
            filterCurrentContracts = new FilterHelper(currentContractsDataGridView, filterCurrentContractsToolStripTextBox.TextBox);

            //doc helper
            contractGenerator = new DocGeneratorHelper(edocbaseDataSet.documents, edocbaseDataSet.doc_templates, edocbaseDataSet.ContractDocData);

            //performance tuning
            DataGridViewHelper.DoubleBuffered(currentContractsDataGridView, true);
            DataGridViewHelper.DoubleBuffered(badContractsDataTableDataGridView, true);
            DataGridViewHelper.DoubleBuffered(finishedContractsDataGridView, true);

            //Add FooterDecorators
            fdCurrentContractsDataGridView = new DataGridViewFooterDecorator(currentContractsDataGridView, new Dictionary<string, ColumnHandler>
                        {
                            {"dataGridViewTextBoxColumn1", new ColumnHandler (DataGridViewFooterDecorator.StaticText, "products_name", "ИТОГО", null)}, 
                            {"dataGridViewTextBoxColumn3", new ColumnHandler (DataGridViewFooterDecorator.Sum, "total_cost", null, currentContractsDataGridView)}, 
                        }
                        );
            fdFinishedContractsDataGridView = new DataGridViewFooterDecorator(finishedContractsDataGridView, new Dictionary<string, ColumnHandler>
                        {
                            {"dataGridViewTextBoxColumn8", new ColumnHandler (DataGridViewFooterDecorator.StaticText, "date_proposal", "ИТОГО", null)}, 
                            {"dataGridViewTextBoxColumn17", new ColumnHandler (DataGridViewFooterDecorator.Sum, "total_cost", null, finishedContractsDataGridView)}, 
                        }
                        );
            fdBadContractsDataTableDataGridView = new DataGridViewFooterDecorator(badContractsDataTableDataGridView, new Dictionary<string, ColumnHandler>
                        {
                            {"contractstatusnameDataGridViewTextBoxColumn", new ColumnHandler (DataGridViewFooterDecorator.StaticText, "contract_status_name", "ИТОГО", null)}, 
                            {"totalcostDataGridViewTextBoxColumn", new ColumnHandler (DataGridViewFooterDecorator.Sum, "total_cost", null, badContractsDataTableDataGridView)}, 
                        }
                        );
        }


        private void UpdateDatabase()
        {
            try
            {
                this.Validate();

                this.tableAdapterManager.UpdateAll(this.edocbaseDataSet);

                this.edocbaseDataSet.AcceptChanges();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                string title = "Save ERROR";
                string type = "Save ERROR";
                TraceHelper.LogError(type, ex, this);
                MessageBox.Show(msg, title);
            }
        }

        private void RefreshDatabase()
        {
            RefreshCurrentContracts();
            RefreshBadContracts();
            RefreshFinishedContracts();
        }

        private void RefreshBadContracts()
        {
            try
            {
                int pos = badContractsBindingSource.Position;

                this.badContractsTableAdapter.Fill(this.edocbaseDataSet.BadContracts);

                badContractsBindingSource.Position = pos;

                this.badContractsDataTableDataGridView.Refresh();

                RefreshFinishedContractsAgentsContacts();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                string title = "Refresh ERROR";
                string type = "Refresh ERROR RefreshBadContracts";
                TraceHelper.LogError(type, ex, this);
                MessageBox.Show(msg, title);
            }
        }


        private void RefreshFinishedContractsAgentsContacts()
        {
            try
            {
                int id = GetCurrentFinishedContractID(finishedContractsBindingSource);
                this.agentsContactsForFinishedContractsTableAdapter.Fill(this.edocbaseDataSet.AgentsContactsForFinishedContracts, id);
                this.agents_contactsDataGridView.Refresh();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                string title = "Refresh ERROR";
                string type = "Refresh ERROR RefreshFinishedContractsAgentsContacts";
                TraceHelper.LogError(type, ex, this);
                MessageBox.Show(msg, title);
            }
        }

        private void RefreshFinishedContracts()
        {
            try
            {
                int pos = finishedContractsBindingSource.Position;

                this.finishedContractsTableAdapter.Fill(this.edocbaseDataSet.FinishedContracts);

                finishedContractsBindingSource.Position = pos;

                this.finishedContractsDataGridView.Refresh();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                string title = "Refresh ERROR";
                string type = "Refresh ERROR RefreshFinishedContracts";
                TraceHelper.LogError(type, ex, this);
                MessageBox.Show(msg, title);
            }
        }

        private void RefreshCurrentContracts()
        {
            try
            {
                int pos = currentContractsBindingSource.Position;

                bool dont_filter_status = true;

                if (status_id != -1)
                    dont_filter_status = false;

                this.currentContractsTableAdapter.Fill(this.edocbaseDataSet.CurrentContracts, dont_filter_status, status_id);

                currentContractsBindingSource.Position = pos;

                this.currentContractsDataGridView.Refresh();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                string title = "Refresh ERROR";
                string type = "Refresh ERROR RefreshCurrentContracts";
                TraceHelper.LogError(type, ex, this);
                MessageBox.Show(msg, title);
            }
        }


        private void buttonEditContract_Click(object sender, EventArgs e)
        {
            int docType = DocGeneratorHelper.GetContractTypeID(finishedContractsBindingSource);
            OpenDoc(docType);
        }

        private void OpenDoc(int docType)
        {
            if ((finishedContractsBindingSource.Position < 0) ||
                (finishedContractsBindingSource.Position >= finishedContractsBindingSource.Count))
            {
                //contract not selected
                MessageBox.Show("Не выбран договор", "Ошибка");
                return;
            }

            int contract_id = DocGeneratorHelper.GetContractID(finishedContractsBindingSource);

            try
            {
                contractGenerator.EditDoc(contract_id, docType, (id) =>
                {
                    //newver update
                    return false;
                });
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Файл заявки отсутствует в БД: " + ex.Message, "Отсутствие заявки");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "EditDoc ERROR");
            }

            RefreshDatabase();
        }


        private void SaveDoc(int docType)
        {
            if ((finishedContractsBindingSource.Position < 0) ||
                (finishedContractsBindingSource.Position >= finishedContractsBindingSource.Count))
            {
                //contract not selected
                MessageBox.Show("Не выбран договор", "Ошибка");
                return;
            }

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            int contract_id = DocGeneratorHelper.GetContractID(finishedContractsBindingSource);

            try
            {
                contractGenerator.SaveDoc(contract_id, docType, saveFileDialog.FileName);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Ошибка загрузки документа: " + ex.Message, "Ошибка");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LoadDoc ERROR");
            }

            RefreshDatabase();
        }

        private void toolStripButtonSaveContract_Click(object sender, EventArgs e)
        {
            try
            {
                int docType = DocGeneratorHelper.GetContractTypeID(finishedContractsBindingSource);
                SaveDoc(docType);
            }
            catch
            {
                MessageBox.Show("Ошибка выбора контракта");
            }
        }

        private void toolStripButtonSaveAct_Click(object sender, EventArgs e)
        {
            SaveDoc((int)Constants.ContractTypes.Act);
        }

        private void toolStripButtonSaveProposal_Click(object sender, EventArgs e)
        {
            SaveDoc((int)Constants.ContractTypes.Proposal);
        }

        private void toolStripButtonOpenProposal_Click(object sender, EventArgs e)
        {
            OpenDoc((int)Constants.ContractTypes.Proposal);
        }

        private void toolStripButtonOpenAct_Click(object sender, EventArgs e)
        {
            OpenDoc((int)Constants.ContractTypes.Act);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            RefreshDatabase();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            RefreshDatabase();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if ((finishedContractsBindingSource.Position < 0) ||
                (finishedContractsBindingSource.Position >= finishedContractsBindingSource.Count))
            {
                return;
            }

            int id = DocGeneratorHelper.GetContractID(finishedContractsBindingSource);

            if (MessageBox.Show("Удалить договор #" + id, "Подтвердить удаление договора", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                finishedContractsBindingSource.RemoveCurrent();
            }

            RefreshDatabase();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if ((badContractsBindingSource.Position < 0) ||
                (badContractsBindingSource.Position >= badContractsBindingSource.Count))
            {
                return;
            }

            int id = DocGeneratorHelper.GetContractID(badContractsBindingSource);

            if (MessageBox.Show("Удалить договор #" + id, "Подтвердить удаление договора", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                badContractsBindingSource.RemoveCurrent();
            }

            RefreshDatabase();
        }

        private void radioButtonAll_CheckedChanged(object sender, EventArgs e)
        {
            this.status_id = -1;
            RefreshCurrentContracts();
        }

        private void radioButtonNewProposal_CheckedChanged(object sender, EventArgs e)
        {
            this.status_id = (int)Constants.ContractStatuses.NewProposal;
            RefreshCurrentContracts();
        }

        private void radioButtonExpertAssignment_CheckedChanged(object sender, EventArgs e)
        {
            this.status_id = (int)Constants.ContractStatuses.ExpertAssignment;
            RefreshCurrentContracts();
        }

        private void radioButtonContractSigning_CheckedChanged(object sender, EventArgs e)
        {
            this.status_id = (int)Constants.ContractStatuses.ContractSigning;
            RefreshCurrentContracts();
        }

        private void radioButtonPrepareForWork_CheckedChanged(object sender, EventArgs e)
        {
            this.status_id = (int)Constants.ContractStatuses.PrepareForWork;
            RefreshCurrentContracts();
        }

        private void radioButtonInWork_CheckedChanged(object sender, EventArgs e)
        {
            this.status_id = (int)Constants.ContractStatuses.InWork;
            RefreshCurrentContracts();
        }

        private void radioButtonComplitionManagerConfrim_CheckedChanged(object sender, EventArgs e)
        {
            this.status_id = (int)Constants.ContractStatuses.ComplitionManagerConfrim;
            RefreshCurrentContracts();
        }

        private void radioButtonComplitionAgentConfrim_CheckedChanged(object sender, EventArgs e)
        {
            this.status_id = (int)Constants.ContractStatuses.ComplitionAgentConfrim;
            RefreshCurrentContracts();
        }

        private void radioButtonReattestationSign_CheckedChanged(object sender, EventArgs e)
        {
            this.status_id = (int)Constants.ContractStatuses.ReattestationSign;
            RefreshCurrentContracts();
        }

        private void radioButtonInspectionControl_CheckedChanged(object sender, EventArgs e)
        {
            this.status_id = (int)Constants.ContractStatuses.InspectionControl;
            RefreshCurrentContracts();
        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            RefreshCurrentContracts();
        }

        private void currentContractsDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {
                DataGridView s = sender as DataGridView;

                DataGridViewHelper.HighlightStandartStats(s, e.RowIndex);
            }
        }

        private void finishedContractsBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if ((finishedContractsBindingSource.Position >= 0)
                && (edocbaseDataSet.FinishedContracts.DefaultView.Count > finishedContractsBindingSource.Position))
            {
                DataRow currentRow = edocbaseDataSet.FinishedContracts.DefaultView[finishedContractsBindingSource.Position].Row;
                if (currentRow.RowState != DataRowState.Deleted)
                {
                    string agent = String.Format("Контрагент: {0}", Convert.ToString(currentRow["agents_name"]));

                    toolStripLabelAgent.Text = agent;

                    RefreshFinishedContractsAgentsContacts();
                }
            }
        }

        private int GetCurrentFinishedContractID(BindingSource bindingSource)
        {
            if ((bindingSource.Position >= 0)
                && (edocbaseDataSet.FinishedContracts.DefaultView.Count > bindingSource.Position))
            {
                DataRow currentRow = edocbaseDataSet.FinishedContracts.DefaultView[bindingSource.Position].Row;
                if (currentRow.RowState != DataRowState.Deleted)
                {
                   return Convert.ToInt32(currentRow["id"]);
                }
            }
            return 0;
        }
    }
}
