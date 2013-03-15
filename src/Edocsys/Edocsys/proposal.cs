using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;



namespace Edocsys
{
    public partial class ProposalForm : Form
    {
        public ProposalForm()
        {
            InitializeComponent();
        }

        private void contractsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveProposal();
            RefreshData();
        }

        private FilterHelper filter;
        private DocGeneratorHelper proposalGenerator;
        public int currentContractID;
        public int currentProductID;

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
                MessageBox.Show(ex.Message, "Save Error");
            }
        }

        private void RefreshData()
        {
            try
            {
                int pos = contractInfoDataTableBindingSource.Position;

                this.productsTableAdapter.Fill(this.edocbaseDataSet.products);
                this.agentsTableAdapter.Fill(this.edocbaseDataSet.agents);

                this.contractInfoTableAdapter.Fill(this.edocbaseDataSet.ContractInfoDataTable);

                this.proposalsDataGridView.Refresh();

                contractInfoDataTableBindingSource.Position = pos;
            }   
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Refresh Error");
            }
        }

        private void ProposalForm_Load(object sender, EventArgs e)
        {

            this.agentsTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.productsTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.contract_typesTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.emission_typesTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;

            this.contractInfoTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;

            this.contract_typesTableAdapter.FillContractDocs(this.edocbaseDataSet.contract_types);

            this.emission_typesTableAdapter.Fill(this.edocbaseDataSet.emission_types);

            RefreshData();

            // Add filter
            filter = new FilterHelper(proposalsDataGridView, filterToolStripTextBox.TextBox);

            proposalGenerator = new DocGeneratorHelper(edocbaseDataSet.documents, edocbaseDataSet.doc_templates, edocbaseDataSet.ContractDocData);
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
                    if (MessageBox.Show("Внимание! Документ заявки #" + id + " не сгенерирован! Продолжить обработку?", "Подтвердить отправку заявки", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                }


                if (MessageBox.Show("Отправить заявку #" + id, "Подтвердить отправку заявки", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        //send proposal to Expert Assignment
                        this.contractInfoTableAdapter.SendProposal((int)Constants.ContractStatuses.ExpertAssignment, id);

                        SaveProposal();
                        RefreshData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Save Error");
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
                MessageBox.Show("Ошибка получения данных для заполнения" + ex.Message, "Ошибка");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "GenerateDoc Error");
            }

            RefreshData();
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
                MessageBox.Show("Файл заявки отсутствует в БД" + ex.Message, "Отсутствие заявки");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "EditDoc ERROR");
            }

            RefreshData();
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
                MessageBox.Show("Файл заявки отсутствует в БД: " + ex.Message, "Отсутствие заявки");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SaveDoc ERROR");
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
                MessageBox.Show("Ошибка загрузки документа: " + ex.Message, "Ошибка");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LoadDoc ERROR");
            }
            
            RefreshData();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.contractInfoDataTableBindingSource.AddNew();
            DataRowView currentDoc = (DataRowView)this.contractInfoDataTableBindingSource.Current;
            currentDoc["contract_status_id"] = (int)Constants.ContractStatuses.NewProposal;
            currentDoc["experts_id"] = 1;     //assign all to admin?????
            currentDoc["contract_types_id"] = (int)Constants.ContractTypes.Sertefication;
            currentDoc["source_types_id"] = (int)Constants.SourceTypes.Personal;
            currentDoc["date_proposal"] = DateTime.Now.Date;

            //reset gost controls
            checkBoxCustomGOSTS.Checked = false;
            GOSTsTextBox.Text = "";

            FillGOSTsList();
        }

        private void buttonGOSTSelection_Click(object sender, EventArgs e)
        {
            //SaveProposal();
            int pos = contractInfoDataTableBindingSource.Position;


            DataRowView currentRow = (DataRowView)this.contractInfoDataTableBindingSource.Current;

            if ((int)(currentRow["id"]) < 0)
            {
                SaveProposal();
                RefreshData();
                contractInfoDataTableBindingSource.Position = pos;
            }

            currentRow = (DataRowView)this.contractInfoDataTableBindingSource.Current;

            this.currentProductID = Convert.ToInt32(currentRow["products_id"]);
            this.currentContractID = Convert.ToInt32(currentRow["id"]);

            GOSTSelectionForm gsf = new GOSTSelectionForm(this);

            gsf.ShowDialog();

            RefreshData();

            contractInfoDataTableBindingSource.Position = pos;

            FillGOSTsList();
        }

        private void checkBoxCustomGOSTS_CheckedChanged(object sender, EventArgs e)
        {
            if (contractInfoDataTableBindingSource.Position < 0)
                return;

            bool selected = ((CheckBox)sender).Checked;


            GOSTsTextBox.Enabled = selected;
            buttonGOSTSelection.Enabled = selected;
            buttonFillGosts.Enabled = !selected;

            DataRowView currentRow = (DataRowView)this.contractInfoDataTableBindingSource.Current;

            int pos = contractInfoDataTableBindingSource.Position;

            if ((int)(currentRow["id"]) < 0)
            {
                SaveProposal();
                RefreshData();
                //return;
                contractInfoDataTableBindingSource.Position = pos;
            }

            currentRow = (DataRowView)this.contractInfoDataTableBindingSource.Current;

            this.currentProductID = Convert.ToInt32(currentRow["products_id"]);
            this.currentContractID = Convert.ToInt32(currentRow["id"]);

            if (selected)
            {
                // use custom gosts
                currentRow["custom_gosts"] = true;
            }
            else
            {
                // remove custom => clear all and refill again
                currentRow["custom_gosts"] = false;

                gOSTSelectionTableAdapter.ClearAll(currentContractID);
                gOSTSelectionTableAdapter.FillAll(currentContractID, currentProductID);
            }

            FillGOSTsList();
        }

        private void buttonFillGosts_Click(object sender, EventArgs e)
        {
            // remove custom => clear all and refill again
            DataRowView currentRow = (DataRowView)this.contractInfoDataTableBindingSource.Current;

            int pos = contractInfoDataTableBindingSource.Position;

            if ((int)(currentRow["id"]) < 0)
            {
                SaveProposal();
                RefreshData();
                //return;
                contractInfoDataTableBindingSource.Position = pos;
            }

            currentRow = (DataRowView)this.contractInfoDataTableBindingSource.Current;

            if (currentRow["products_id"] == null)
            {
                return;
            }

            this.currentProductID = Convert.ToInt32(currentRow["products_id"]);
            this.currentContractID = Convert.ToInt32(currentRow["id"]);

            gOSTSelectionTableAdapter.ClearAll(currentContractID);
            gOSTSelectionTableAdapter.FillAll(currentContractID, currentProductID);


            FillGOSTsList();
        }

        private void FillGOSTsList()
        {
            if ((contractInfoDataTableBindingSource.Position < 0) ||
            (contractInfoDataTableBindingSource.Position >= contractInfoDataTableBindingSource.Count))
            {
                return;
            }

            DataRowView currentRow = (DataRowView)this.contractInfoDataTableBindingSource.Current;

            int currentContractID = Convert.ToInt32(currentRow["id"]);
            if (currentContractID < 0)
                return;

            string res = GetGOSTsList(currentContractID);
            GOSTsTextBox.Text = res;
        }

        private string GetGOSTsList(int contractID)
        {

            this.gOSTSelectionTableAdapter.FillByContract(this.edocbaseDataSet.GOSTSelection, contractID);

            string list = "";
            foreach (DataRowView x in this.gOSTSelectionBindingSource)
            {
                if (x["using_gost"] != DBNull.Value)
                    if ((bool)x["using_gost"])
                        list += x["number"] + "; ";
            }

            return list;
        }

        private void contractInfoDataTableBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            FillGOSTsList();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void prepaymentLabel_Click(object sender, EventArgs e)
        {

        }

        private void prepaymentTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
