using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using Edocsys.Helpers;

namespace Edocsys
{
    public partial class ProposalForm : Form
    {
        public ProposalForm()
        {
            InitializeComponent();
        }

        private FilterHelper filter;
        private DocGeneratorHelper proposalGenerator;
        private DataGridViewColumnsSerializer dgvcs_p;

        private void ProposalForm_Load(object sender, EventArgs e)
        {
            this.documentsTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;

            this.documentsTableAdapter.Fill(this.edocbaseDataSet.documents);

            this.agentsTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.productsTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.contract_typesTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.emission_typesTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;

            this.contractInfoTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;

            this.contract_typesTableAdapter.FillContractDocs(this.edocbaseDataSet.contract_types);

            this.emission_typesTableAdapter.Fill(this.edocbaseDataSet.emission_types);

            RefreshDatabase();

            // Add filter
            filter = new FilterHelper(proposalsDataGridView, filterToolStripTextBox.TextBox);

            //Add column serializers
            dgvcs_p = new DataGridViewColumnsSerializer(this, this.proposalsDataGridView);

            proposalGenerator = new DocGeneratorHelper(edocbaseDataSet.documents, edocbaseDataSet.doc_templates, edocbaseDataSet.ContractDocData);

            date_proposalDateTimePicker.Value = DateTime.Now.Date;
        }


        public int currentContractID;
        public int currentProductID;
        public string GOSTsList;
        public string ProductionDocuments;
        public bool UseTUIsteadGosts;


        private void contractsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveProposal();
            RefreshDatabase();
        }

        private void SaveProposal()
        {
            try
            {
                this.Validate();

                this.contractInfoDataTableBindingSource.EndEdit();

                this.contractInfoTableAdapter.Update(this.edocbaseDataSet.ContractInfoDataTable);
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
            try
            {
                int pos = contractInfoDataTableBindingSource.Position;

                this.productsTableAdapter.Fill(this.edocbaseDataSet.products);
                this.agentsTableAdapter.Fill(this.edocbaseDataSet.agents);

                this.contractInfoTableAdapter.Fill(this.edocbaseDataSet.ContractInfoDataTable);

                contractInfoDataTableBindingSource.Position = pos;

                this.proposalsDataGridView.Refresh();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                string title = "Refresh ERROR";
                string type = "Refresh ERROR";
                TraceHelper.LogError(type, ex, this);
                MessageBox.Show(msg, title);
            }
        }

        private void contractsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == proposalsDataGridView.Columns["SendProposalColumn"].Index)
            {

                if ((contractInfoDataTableBindingSource.Position < 0) ||
                    (contractInfoDataTableBindingSource.Position >= contractInfoDataTableBindingSource.Count))
                {
                    //contract not selected
                    MessageBox.Show("Не выбрана заявка", "Ошибка");
                    return;
                }

                DataRow currentRow = edocbaseDataSet.ContractInfoDataTable.DefaultView[contractInfoDataTableBindingSource.Position].Row;
                int id = Convert.ToInt32(currentRow["id"]);
                bool hasDocument = Convert.ToBoolean(currentRow["has_proposal_document"]);

                if (!hasDocument)
                {
                    if (MessageBox.Show("Внимание! Документ заявки #" + id + " не сгенерирован! Продолжить отправку заявки?", "Подтвердить отправку заявки", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                }


                if (MessageBox.Show("Отправить заявку #" + id, "Подтвердить отправку заявки", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        //send proposal to Expert Assignment
                        this.contractInfoTableAdapter.SendProposal((int)Constants.ContractStatuses.ExpertAssignment, id);

                        SaveProposal();
                        RefreshDatabase();
                    }
                    catch (Exception ex)
                    {
                        string msg = ex.Message;
                        string title = "Send save ERROR";
                        string type = "Send save ERROR";
                        TraceHelper.LogError(type, ex, sender);
                        MessageBox.Show(msg, title);
                    }
                }
            }
        }

        private void buttonGenerateProposalDoc_Click(object sender, EventArgs e)
        {
            if ((contractInfoDataTableBindingSource.Position < 0) ||
                (contractInfoDataTableBindingSource.Position >= contractInfoDataTableBindingSource.Count))
            {
                //contract not selected
                MessageBox.Show("Не выбрана заявка", "Ошибка");
                return;
            }

            int idContract = DocGeneratorHelper.GetContractID(contractInfoDataTableBindingSource);

            try
            {
                proposalGenerator.GenerateDoc(idContract, (int)Constants.ContractTypes.Proposal, (id) =>
                    {
                        //found doc -> update?
                        return MessageBox.Show("Обновить документ для заявки #" + id, "Подтвердить обновление документа", MessageBoxButtons.YesNo) == DialogResult.Yes;
                    });
            }
            catch (NullReferenceException ex)
            {
                string msg = ex.Message;
                string title = "Ошибка получения данных для заполнения";
                string type = "GenerateDoc GetData ERROR";
                TraceHelper.LogError(type, ex, sender);
                MessageBox.Show(msg, title);
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                string title = "GenerateDoc ERROR";
                string type = "GenerateDoc ERROR";
                TraceHelper.LogError(type, ex, sender);
                MessageBox.Show(msg, title);
            }

            RefreshDatabase();
        }

        private void buttonEditProposal_Click(object sender, EventArgs e)
        {
            if ((contractInfoDataTableBindingSource.Position < 0) ||
                (contractInfoDataTableBindingSource.Position >= contractInfoDataTableBindingSource.Count))
            {
                //contract not selected
                MessageBox.Show("Не выбрана заявка", "Ошибка");
                return;
            }

            int docType = (int)Constants.ContractTypes.Proposal;
            int idContract = DocGeneratorHelper.GetContractID(contractInfoDataTableBindingSource);
            try
            {
                proposalGenerator.EditDoc(idContract, docType, (id) =>
                {
                    //file changed -> update?
                    return MessageBox.Show("Обновить документ для заявки #" + id, "Подтвердить обновление документа", MessageBoxButtons.YesNo) == DialogResult.Yes;
                });
            }
            catch (NullReferenceException ex)
            {
                string msg = "Файл заявки отсутствует в БД " + ex.Message;
                string title = "Отсутствие заявки";
                string type = "EditDoc GetData ERROR";
                TraceHelper.LogError(type, ex, sender);
                MessageBox.Show(msg, title);
            }
            catch (Exception ex)
            {
                string msg = "Ошибка получения данных для заполнения" + ex.Message;
                string title = "EditDoc ERROR";
                string type = "EditDoc ERROR";
                TraceHelper.LogError(type, ex, sender);
                MessageBox.Show(msg, title);
            }

            RefreshDatabase();
        }


        private void buttonSaveProposal_Click(object sender, EventArgs e)
        {
            if ((contractInfoDataTableBindingSource.Position < 0) ||
                (contractInfoDataTableBindingSource.Position >= contractInfoDataTableBindingSource.Count))
            {
                //contract not selected
                MessageBox.Show("Не выбрана заявка", "Ошибка");
                return;
            }

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            int docType = (int)Constants.ContractTypes.Proposal;
            int idContract = DocGeneratorHelper.GetContractID(contractInfoDataTableBindingSource);

            try
            {
                proposalGenerator.SaveDoc(idContract, docType, saveFileDialog.FileName);
            }
            catch (NullReferenceException ex)
            {
                string msg = "Файл заявки отсутствует в БД";
                string title = "Отсутствие заявки";
                string type = "SaveDoc GetData ERROR";
                TraceHelper.LogError(type, ex, sender);
                MessageBox.Show(msg, title);
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                string title = "SaveDoc ERROR";
                string type = "SaveDoc ERROR";
                TraceHelper.LogError(type, ex, sender);
                MessageBox.Show(msg, title);
            }
        }

        private void buttonLoadProposal_Click(object sender, EventArgs e)
        {
            if ((contractInfoDataTableBindingSource.Position < 0) ||
                (contractInfoDataTableBindingSource.Position >= contractInfoDataTableBindingSource.Count))
            {
                //contract not selected
                MessageBox.Show("Не выбрана заявка", "Ошибка");
                return;
            }

            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            int docType = (int)Constants.ContractTypes.Proposal;
            int idContract = DocGeneratorHelper.GetContractID(contractInfoDataTableBindingSource);

            try
            {
                proposalGenerator.LoadDoc(idContract, docType, openFileDialog.FileName);
            }
            catch (NullReferenceException ex)
            {
                string msg = "Ошибка загрузки документа: " + ex.Message;
                string title = "Ошибка";
                string type = "LoadDoc GetData ERROR";
                TraceHelper.LogError(type, ex, sender);
                MessageBox.Show(msg, title);
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                string title = "LoadDoc ERROR";
                string type = "LoadDoc ERROR";
                TraceHelper.LogError(type, ex, sender);
                MessageBox.Show(msg, title);
            }
            
            RefreshDatabase();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.contractInfoDataTableBindingSource.AddNew();

            DataRowView currentRow = (DataRowView)this.contractInfoDataTableBindingSource.Current;

            InitNewProposal(currentRow);

            //TODO: (Workaround) Fill all fileds with default values
            //first avail agent
            DataRowView agentRow = (DataRowView)this.agentsBindingSource.Current;
            currentRow["agents_id"] = agentRow["id"];

            //first avail product
            DataRowView productRow = (DataRowView)this.productsBindingSource.Current;
            currentRow["products_id"] = productRow["id"];

        }

        public void AddNewProposalWithAgent(int agents_id)
        {
            this.contractInfoDataTableBindingSource.AddNew();

            DataRowView currentRow = (DataRowView)this.contractInfoDataTableBindingSource.Current;

            InitNewProposal(currentRow);

            currentRow["agents_id"] = agents_id;

            //first avail product
            DataRowView productRow = (DataRowView)this.productsBindingSource.Current;

            currentRow["products_id"] = productRow["id"];

            SaveProposal();
            RefreshDatabase();
        }


        private void InitNewProposal(DataRowView currentRow)
        {
            currentRow["contract_status_id"] = (int)Constants.ContractStatuses.NewProposal;
            currentRow["experts_id"] = 1;     //BUGGY: ????? assign all to admin by default?
            currentRow["contract_types_id"] = (int)Constants.ContractTypes.Sertefication;
            currentRow["source_types_id"] = (int)Constants.SourceTypes.Personal;
            currentRow["date_proposal"] = DateTime.Now.Date;

            currentRow["custom_gosts"] = false;
            currentRow["production_documents"] = "(нет)";
            currentRow["gosts_list"] = "(нет)";
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            RefreshDatabase();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if ((contractInfoDataTableBindingSource.Position < 0) ||
                (contractInfoDataTableBindingSource.Position >= contractInfoDataTableBindingSource.Count))
            {
                return;
            }

            int id = DocGeneratorHelper.GetContractID(contractInfoDataTableBindingSource);

            if (MessageBox.Show("Удалить заявку #" + id, "Подтвердить удаление заявки", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.documentsTableAdapter.RemoveDocumentByContractID(id);
                this.edocbaseDataSet.AcceptChanges();

                contractInfoDataTableBindingSource.RemoveCurrent();
                SaveProposal();
            }

            RefreshDatabase();
        }

        private void gostsListLabel_DoubleClick(object sender, EventArgs e)
        {
            if ((contractInfoDataTableBindingSource.Position < 0) ||
                (contractInfoDataTableBindingSource.Position >= contractInfoDataTableBindingSource.Count))
            {
                return;
            }

            int pos = contractInfoDataTableBindingSource.Position;

            DataRowView currentRow = (DataRowView)this.contractInfoDataTableBindingSource.Current;

            int id = Convert.ToInt32(currentRow["id"]);
            if (id < 0)
            {
                //not saved => save
                SaveProposal();
                RefreshDatabase();

                contractInfoDataTableBindingSource.Position = pos;
            }

            currentRow = (DataRowView)this.contractInfoDataTableBindingSource.Current;

            if (currentRow["products_id"] == null)
            {
                MessageBox.Show("Не выбран вид продукции");
                return;
            }

            this.currentProductID = Convert.ToInt32(currentRow["products_id"]);
            this.currentContractID = Convert.ToInt32(currentRow["id"]);

            this.currentProductID = Convert.ToInt32(currentRow["products_id"]);
            this.currentContractID = Convert.ToInt32(currentRow["id"]);
            this.ProductionDocuments = Convert.ToString(currentRow["production_documents"]);
            this.GOSTsList = Convert.ToString(currentRow["gosts_list"]);
            this.UseTUIsteadGosts = Convert.ToBoolean(currentRow["custom_gosts"]);

            GOSTSelectionForm gsf = new GOSTSelectionForm(this);

            if (gsf.ShowDialog() == DialogResult.OK)
            {
                currentRow["production_documents"] = this.ProductionDocuments;
                currentRow["gosts_list"] = this.GOSTsList;
                currentRow["custom_gosts"] = this.UseTUIsteadGosts;

                SaveProposal();
                RefreshDatabase();
            }

            contractInfoDataTableBindingSource.Position = pos;
        }

        private void ProposalForm_Activated(object sender, EventArgs e)
        {
            RefreshDatabase();
        }
    }
}
