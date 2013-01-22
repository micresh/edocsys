﻿using System;
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


        private void SaveProposal()
        {
            this.Validate();

            this.contractsBindingSource.EndEdit();

            //this.contractsTableAdapter.Update(this.edocbaseDataSet.Contracts);
            this.tableAdapterManager.UpdateAll(this.edocbaseDataSet);

            this.edocbaseDataSet.AcceptChanges();
        }

        private void RefreshData()
        {
            try
            {
                int pos = contractsBindingSource.Position;

                this.productsTableAdapter.Fill(this.edocbaseDataSet.Products);
                this.agentsTableAdapter.Fill(this.edocbaseDataSet.Agents);

                this.contractInfoDataTableTableAdapter.Fill(this.edocbaseDataSet.ContractInfoDataTable);
                this.contractsTableAdapter.FillProposal(this.edocbaseDataSet.Contracts);
                this.exec_contractsTableAdapter.Fill(this.edocbaseDataSet.Exec_contracts);

                this.templatesDataTableTableAdapter.Fill(this.edocbaseDataSet.TemplatesDataTable);
                this.documentsTableAdapter.Fill(this.edocbaseDataSet.Documents);


                this.contractTypesTableAdapter.Fill(this.edocbaseDataSet.ContractTypes);

                contractsBindingSource.Position = pos;
                this.contractsDataGridView.Refresh();
            }   
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save Error");
            }
            /**/
        }



        private void ProposalForm_Load(object sender, EventArgs e)
        {
            this.agentsTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.productsTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.contractsTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.contractTypesTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.exec_contractsTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;

            this.templatesDataTableTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.contractInfoDataTableTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.documentsTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;



            this.productsTableAdapter.Fill(this.edocbaseDataSet.Products);
            this.agentsTableAdapter.Fill(this.edocbaseDataSet.Agents);

            this.contractInfoDataTableTableAdapter.Fill(this.edocbaseDataSet.ContractInfoDataTable);
            this.contractsTableAdapter.FillProposal(this.edocbaseDataSet.Contracts);
            this.exec_contractsTableAdapter.Fill(this.edocbaseDataSet.Exec_contracts);

            this.templatesDataTableTableAdapter.Fill(this.edocbaseDataSet.TemplatesDataTable);
            this.documentsTableAdapter.Fill(this.edocbaseDataSet.Documents);

            
            this.contractTypesTableAdapter.Fill(this.edocbaseDataSet.ContractTypes);
        }

        private void contractsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == contractsDataGridView.Columns["SendProposalColumn"].Index)
            {
                if (contractsBindingSource.Position >= 0)
                {
                    DataRow currentRow = edocbaseDataSet.Tables["Contracts"].DefaultView[contractsBindingSource.Position].Row;
                    int idContract = Convert.ToInt32(currentRow["idContract"]);

                    if (MessageBox.Show("Отправить заявку #" + idContract, "Подтвердить отправку заявки", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            //send proposal
                            this.contractsTableAdapter.SendProposal((int)Constants.ContractStatuses.WaitForExpertAssigment, idContract);

                            //add executed contract
                            this.exec_contractsTableAdapter.TaskStart(idContract);

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
        }

        private DataRow GetTemplateDataRow(int type)
        {
            edocbaseDataSet.Tables["TemplatesDataTable"].DefaultView.Sort = "id";

            int currentTemplate = edocbaseDataSet.Tables["TemplatesDataTable"].DefaultView.Find(type);

            DataRow row = null;

            if (currentTemplate >= 0)
            {
                //get template for proposal
                row = edocbaseDataSet.Tables["TemplatesDataTable"].DefaultView[currentTemplate].Row;
            }

            return row;
        }

        private int GetContractID()
        {
            int idContract = -1;

            DataRow currentRow = edocbaseDataSet.Tables["Contracts"].DefaultView[contractsBindingSource.Position].Row;

            idContract = Convert.ToInt32(currentRow["idContract"]);

            return idContract;
        }

        private DataRow GetContractInfoDataRow(int idContract)
        {

            edocbaseDataSet.Tables["ContractInfoDataTable"].DefaultView.Sort = "idContract";

            DataRow row = null;

            int currentContractId = edocbaseDataSet.Tables["ContractInfoDataTable"].DefaultView.Find(idContract);
            if (currentContractId >= 0)
            {
                row = edocbaseDataSet.Tables["ContractInfoDataTable"].DefaultView[currentContractId].Row;
            }

            return row;
        }


        private DataRowView GetDocumentsDataRow(int idContract, int type)
        {
            edocbaseDataSet.Tables["Documents"].DefaultView.Sort = "idContract";
            
            DataRowView[] currentDocs = edocbaseDataSet.Tables["Documents"].DefaultView.FindRows(idContract);

            DataRowView row = null;

            if (currentDocs.Length > 0)
            {
                //found docs -> check for our type

                int i = 0;
                while (i < currentDocs.Length)
                {
                    if (Convert.ToInt32(currentDocs[i]["type"]) == type)
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

            if ((contractsBindingSource.Position < 0) ||
                (contractsBindingSource.Position >= contractsBindingSource.Count))
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
            DataRow row = GetTemplateDataRow((int)Constants.ContractTypes.Proposal);

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

            DataRowView currentDoc = GetDocumentsDataRow(idContract, (int)Constants.ContractTypes.Proposal);


            if (currentDoc == null)
            {
                //proper doc not found in db -> add new
                currentDoc = edocbaseDataSet.Tables["Documents"].DefaultView.AddNew();
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
                currentDoc["type"] = Convert.ToInt32(Constants.ContractTypes.Proposal);
                currentDoc["idContract"] = idContract;

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
            this.documentsTableAdapter.Update(this.edocbaseDataSet.Documents);

            this.edocbaseDataSet.AcceptChanges();
        }

        private void buttonEditProposal_Click(object sender, EventArgs e)
        {
            if ((contractsBindingSource.Position < 0) ||
                (contractsBindingSource.Position >= contractsBindingSource.Count))
            {
                //contract not selected
                MessageBox.Show("Не выбрана заявка", "Ошибка");
                return;
            }

            int idContract = GetContractID();

            DataRowView currentDoc = GetDocumentsDataRow(idContract, (int)Constants.ContractTypes.Proposal);

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
            if ((contractsBindingSource.Position < 0) ||
                (contractsBindingSource.Position >= contractsBindingSource.Count))
            {
                //contract not selected
                MessageBox.Show("Не выбрана заявка", "Ошибка");
                return;
            }

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }


            int idContract = GetContractID();

            DataRowView currentDoc = GetDocumentsDataRow(idContract, (int)Constants.ContractTypes.Proposal);

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
            if ((contractsBindingSource.Position < 0) ||
                (contractsBindingSource.Position >= contractsBindingSource.Count))
            {
                //contract not selected
                MessageBox.Show("Не выбрана заявка", "Ошибка");
                return;
            }

            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }


            int idContract = GetContractID();

            DataRowView currentDoc = GetDocumentsDataRow(idContract, (int)Constants.ContractTypes.Proposal);

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
            DataRowView currentDoc = edocbaseDataSet.Tables["Contracts"].DefaultView.AddNew();
            currentDoc["Contract_type"] = (int)Constants.ContractTypes.Proposal;
            currentDoc["Contract_status"] = (int)Constants.ContractStatuses.NewProposal;

        }
    }
}
