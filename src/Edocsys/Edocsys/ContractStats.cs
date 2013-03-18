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
        private FilterHelper filterFinishedContracts, filterBadContracts;


        private void ContractsForm_Load(object sender, EventArgs e)
        {
            this.badContractsTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.finishedContractsTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;

            RefreshDatabase();

            //add filters
            filterFinishedContracts= new FilterHelper(finishedContractsDataGridView, filterFinishedContractsText.TextBox);
            filterBadContracts = new FilterHelper(badContractsDataTableDataGridView, filterBadContractsTextBox.TextBox);

            //doc helper
            contractGenerator = new DocGeneratorHelper(edocbaseDataSet.documents, edocbaseDataSet.doc_templates, edocbaseDataSet.ContractDocData);
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
                MessageBox.Show(ex.Message, "Save Error");
            }
            /**/
        }

        private void RefreshDatabase()
        {
            try
            {
                this.badContractsTableAdapter.Fill(this.edocbaseDataSet.BadContracts);
                this.finishedContractsTableAdapter.Fill(this.edocbaseDataSet.FinishedContracts);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Refresh Error");
            }
            /**/
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
    }
}
