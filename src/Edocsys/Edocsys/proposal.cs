using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using System.Diagnostics;



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
                this.documentsTableAdapter.Fill(this.edocbaseDataSet.documents);

                this.contractInfoTableAdapter.Fill(this.edocbaseDataSet.ContractInfoDataTable);

                contractInfoDataTableBindingSource.Position = pos;

                this.proposalsDataGridView.Refresh();
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
            this.templatesDataTableTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.documentsTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.emission_typesTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;

            this.contractInfoTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;


            this.contract_typesTableAdapter.FillContractDocs(this.edocbaseDataSet.contract_types);
            this.templatesDataTableTableAdapter.Fill(this.edocbaseDataSet.templatesDataTable);
            this.emission_typesTableAdapter.Fill(this.edocbaseDataSet.emission_types);

            RefreshData();

            // Add filter
            filter = new FilterHelper(proposalsDataGridView, filterToolStripTextBox.TextBox);
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

                if (MessageBox.Show("Отправить заявку #" + id, "Подтвердить отправку заявки", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        //send proposal to Expert Assignment
                        this.contractInfoTableAdapter.SendProposal((int)Constants.ContractStatuses.ExpertAssignment, id);

                        //refresh data
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

        private DataRow GetTemplateDataRow(int type)
        {
            edocbaseDataSet.templatesDataTable.DefaultView.Sort = "contract_types_id";

            int currentTemplate = edocbaseDataSet.templatesDataTable.DefaultView.Find(type);

            DataRow row = null;

            if (currentTemplate >= 0)
            {
                //get template for proposal
                row = edocbaseDataSet.templatesDataTable.DefaultView[currentTemplate].Row;
            }

            return row;
        }

        private int GetContractID()
        {
            int id = -1;

            DataRow currentRow = edocbaseDataSet.ContractInfoDataTable.DefaultView[contractInfoDataTableBindingSource.Position].Row;

            id = Convert.ToInt32(currentRow["id"]);

            return id;
        }

        private int GetContractTypeID()
        {
            int id = -1;

            DataRow currentRow = edocbaseDataSet.ContractInfoDataTable.DefaultView[contractInfoDataTableBindingSource.Position].Row;

            id = Convert.ToInt32(currentRow["contract_types_id"]);

            return id;
        }
        
        private DataRow GetContractInfoDataRow(int idContract)
        {
            string tmp = edocbaseDataSet.ContractInfoDataTable.DefaultView.Sort;

            edocbaseDataSet.ContractInfoDataTable.DefaultView.Sort = "id";

            DataRow row = null;

            int currentContractId = edocbaseDataSet.ContractInfoDataTable.DefaultView.Find(idContract);
            if (currentContractId >= 0)
            {
                row = edocbaseDataSet.ContractInfoDataTable.DefaultView[currentContractId].Row;
            }

            edocbaseDataSet.ContractInfoDataTable.DefaultView.Sort = tmp;

            return row;
        }

        private DataRowView GetDocumentsDataRow(int idContract, int type)
        {
            edocbaseDataSet.documents.DefaultView.Sort = "contracts_id";

            DataRowView[] currentDocs = edocbaseDataSet.documents.DefaultView.FindRows(idContract);

            DataRowView row = null;

            if (currentDocs.Length > 0)
            {
                //found docs -> check for our type

                int i = 0;
                while (i < currentDocs.Length)
                {
                    if (Convert.ToInt32(currentDocs[i]["contract_types_id"]) == type)
                    {
                        //found doc -> return it
                        return currentDocs[i];
                    }
                    i++;
                }
            }

            return row;
        }

        private void buttonGenerateProposalDoc_Click(object sender, EventArgs e)
        {
            GenerateDoc((int)Constants.ContractTypes.Proposal);
        }

        private void GenerateDoc(int docType)
        {

            if ((contractInfoDataTableBindingSource.Position < 0) ||
                (contractInfoDataTableBindingSource.Position >= contractInfoDataTableBindingSource.Count))
            {
                //contract not selected
                MessageBox.Show("Не выбрана заявка", "Ошибка");
                return;
            }


            int idContract = GetContractID();

            DataRow currentContact = GetContractInfoDataRow(idContract);

            if (currentContact == null)
            {
                //contract can't be received
                MessageBox.Show("Ошибка получения данных для заполнения", "Ошибка");
                return;
            }

            Dictionary<string, string> subs = DocXGenerator.GetReplacementKeyValues(currentContact);

            //get template row for proposal
            DataRow row = GetTemplateDataRow(docType);

            if (row == null)
            {
                MessageBox.Show("Шаблон отсутствует в БД", "Отсутствие шаблона");
                return;
            }

            byte[] data = (byte[])row["template"];
            string filename = BlobLoader.SaveToTemporaryFile(data);


            //replace placeholders in doc
            DocXGenerator.RepalceKeyValuesInDocX(filename, subs);



            //load generated contract to DB
            data = BlobLoader.LoadFormFile(filename);

            DataRowView currentDoc = GetDocumentsDataRow(idContract, docType);


            if (currentDoc == null)
            {
                //proper doc not found in db -> add new
                currentDoc = edocbaseDataSet.documents.DefaultView.AddNew();
            }
            else
            {
                //found doc -> update?
                if (MessageBox.Show("Обновить документ для заявки #" + idContract, "Подтвердить обновление документа", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }

            try
            {
                currentDoc["document"] = data;
                currentDoc["contract_types_id"] = docType;
                currentDoc["contracts_id"] = idContract;
                currentDoc["users_id"] = idContract;

                currentDoc.EndEdit();

                UpdateDocuments();

                RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save Error");
            }
        }

        private void UpdateDocuments()
        {
            this.documentsTableAdapter.Update(this.edocbaseDataSet.documents);

            this.edocbaseDataSet.AcceptChanges();
        }

        private void buttonEditProposal_Click(object sender, EventArgs e)
        {
            int docType = (int)Constants.ContractTypes.Proposal;
            EditDoc(docType);
        }

        private void EditDoc(int docType)
        {
            if ((contractInfoDataTableBindingSource.Position < 0) ||
                (contractInfoDataTableBindingSource.Position >= contractInfoDataTableBindingSource.Count))
            {
                //contract not selected
                MessageBox.Show("Не выбрана заявка", "Ошибка");
                return;
            }

            int idContract = GetContractID();

            DataRowView currentDoc = GetDocumentsDataRow(idContract, docType);

            if (currentDoc == null)
            {
                //doc not found -> error
                MessageBox.Show("Файл заявки отсутствует в БД", "Отсутствие заявки");
                return;
            }

            byte[] data = (byte[])currentDoc["document"];

            string filename = BlobLoader.SaveToTemporaryFile(data);

            //run word
            Process process = Process.Start(filename);

            process.WaitForExit();



            //file changed -> update?
            if (MessageBox.Show("Обновить документ для заявки #" + idContract, "Подтвердить обновление документа", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }


            try
            {
                data = BlobLoader.LoadFormFile(filename);

                currentDoc["document"] = data;
                currentDoc.EndEdit();

                UpdateDocuments();

                RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save Error");
            }


            // Clean up temporary file
            System.IO.File.Delete(filename);
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
            SaveDoc(docType);
        }

        private void SaveDoc(int docType)
        {

            int idContract = GetContractID();

            DataRowView currentDoc = GetDocumentsDataRow(idContract, docType);

            if (currentDoc == null)
            {
                //doc not found -> error
                MessageBox.Show("Файл заявки отсутствует в БД", "Отсутствие заявки");
                return;
            }

            byte[] data = (byte[])currentDoc["document"];

            BlobLoader.SaveToFile(saveFileDialog.FileName, data);
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

            LoadDoc(docType);
        }

        private void LoadDoc(int docType)
        {
            int idContract = GetContractID();

            DataRowView currentDoc = GetDocumentsDataRow(idContract, docType);

            try
            {
                byte[] data = BlobLoader.LoadFormFile(openFileDialog.FileName);

                currentDoc["document"] = data;
                currentDoc.EndEdit();

                UpdateDocuments();

                RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save Error");
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.contractInfoDataTableBindingSource.AddNew();
            DataRowView currentDoc = (DataRowView)this.contractInfoDataTableBindingSource.Current;
            currentDoc["contract_status_id"] = (int)Constants.ContractStatuses.NewProposal;
            currentDoc["products_id"] = 0;
            currentDoc["agents_id"] = 0;
            currentDoc["experts_id"] = 1; //assign all to admin
            currentDoc["contract_types_id"] = (int)Constants.ContractTypes.Sertefication;
            currentDoc["source_types_id"] = (int)Constants.SourceTypes.Personal;
            currentDoc["date_proposal"] = DateTime.Now;

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
    }
}
