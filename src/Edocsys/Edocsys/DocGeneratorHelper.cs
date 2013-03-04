using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

using System.Windows.Forms;

using System.Diagnostics;

namespace Edocsys
{
    class DocGeneratorHelper
    {
        public DocGeneratorHelper(EdocbaseDataSet.documentsDataTable documents, EdocbaseDataSet.doc_templatesDataTable templates, EdocbaseDataSet.ContractDocDataDataTable contractData)
        {
            this.documents = documents;
            this.templates = templates;
            this.contractData = contractData;

            this.documentsTA = new EdocbaseDataSetTableAdapters.documentsTableAdapter();
            this.documentsTA.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.documentsTA.Fill(this.documents);

            this.templatesTA = new EdocbaseDataSetTableAdapters.doc_templatesTableAdapter();
            this.templatesTA.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.templatesTA.Fill(this.templates);

            this.contractDataTA = new EdocbaseDataSetTableAdapters.ContractDocDataTableAdapter();
            this.contractDataTA.Connection.ConnectionString = ConnectionManager.ConnectionString;

        }
        private void Refresh()
        {
            this.documentsTA.Fill(this.documents);
            this.templatesTA.Fill(this.templates);
        }

        private EdocbaseDataSet.documentsDataTable documents;
        private EdocbaseDataSet.doc_templatesDataTable templates;
        private EdocbaseDataSet.ContractDocDataDataTable contractData;

        private EdocbaseDataSetTableAdapters.documentsTableAdapter documentsTA;
        private EdocbaseDataSetTableAdapters.doc_templatesTableAdapter templatesTA;
        private EdocbaseDataSetTableAdapters.ContractDocDataTableAdapter contractDataTA;


        public delegate bool UpdateDocInDatabase(int id);


        public int GetContractID(BindingSource bs)
        {
            int id = -1;
            DataRowView currentRow = (DataRowView)bs.Current;

            id = Convert.ToInt32(currentRow["id"]);

            return id;
        }

        public int GetContractTypeID(BindingSource bs)
        {
            int id = -1;

            DataRowView currentRow = (DataRowView)bs.Current;

            id = Convert.ToInt32(currentRow["contract_types_id"]);

            return id;
        }

        private DataRowView GetDocumentsDataRow(int contract_id, int type)
        {
            documents.DefaultView.Sort = "contracts_id";

            DataRowView[] currentDocs = documents.DefaultView.FindRows(contract_id);

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

        public void SaveDoc(int contract_id, int docType, string filename)
        {

            DataRowView currentDoc = GetDocumentsDataRow(contract_id, docType);

            if (currentDoc == null)
            {
                //doc not found -> error
                throw new NullReferenceException("document not found");
            }

            byte[] data = (byte[])currentDoc["document"];

            BlobLoader.SaveToFile(filename, data);
        }

        public void LoadDoc(int contract_id, int docType, string filename)
        {
            DataRowView currentDoc = GetDocumentsDataRow(contract_id, docType);

            if (currentDoc == null)
            {
                //doc not found -> add new
                currentDoc = documents.DefaultView.AddNew();
            }

            byte[] data = BlobLoader.LoadFormFile(filename);

            FillDocData(contract_id, docType, data, currentDoc);

            AcceptDocUpdate();
        }


        public void EditDoc(int contract_id, int docType, UpdateDocInDatabase checker)
        {
            DataRowView currentDoc = GetDocumentsDataRow(contract_id, docType);

            if (currentDoc == null)
            {
                //doc not found -> error
                throw new NullReferenceException("document not found");
            }

            byte[] data = (byte[])currentDoc["document"];

            string filename = BlobLoader.SaveToTemporaryFile(data);

            //run word
            Process process = Process.Start(filename);

            process.WaitForExit();


            if (checker(contract_id))
            {
                data = BlobLoader.LoadFormFile(filename);

                FillDocData(contract_id, docType, data, currentDoc);

                AcceptDocUpdate();
            }

            // Clean up temporary file
            System.IO.File.Delete(filename);
        }


        private DataRow GetContractInfoDataRow(int contract_id)
        {
            this.contractDataTA.Fill(this.contractData, contract_id);

            string tmp = contractData.DefaultView.Sort;

            contractData.DefaultView.Sort = "id";

            DataRow row = null;

            int currentContractId = contractData.DefaultView.Find(contract_id);
            if (currentContractId >= 0)
            {
                row = contractData.DefaultView[currentContractId].Row;
            }

            contractData.DefaultView.Sort = tmp;

            return row;
        }

        private DataRow GetTemplateDataRow(int type)
        {
            templates.DefaultView.Sort = "contract_types_id";

            int currentTemplate = templates.DefaultView.Find(type);

            DataRow row = null;

            if (currentTemplate >= 0)
            {
                //get template for proposal
                row = templates.DefaultView[currentTemplate].Row;
            }

            return row;
        }

        public void GenerateDoc(int contract_id, int docType, UpdateDocInDatabase checker)
        {

            //get template row for proposal
            DataRow row = GetTemplateDataRow(docType);

            if (row == null)
            {
                throw new NullReferenceException("template not found");
            }

            byte[] data = (byte[])row["template"];
            string filename = BlobLoader.SaveToTemporaryFile(data);

            DataRow currentContact = GetContractInfoDataRow(contract_id);

            if (currentContact == null)
            {
                //contract can't be received
                throw new NullReferenceException("document not found");
            }


            Dictionary<string, string> subs = DocXGenerator.GetReplacementKeyValues(currentContact);

            //replace placeholders in doc
            DocXGenerator.RepalceKeyValuesInDocX(filename, subs);

            //load generated contract to DB
            data = BlobLoader.LoadFormFile(filename);

            DataRowView currentDoc = GetDocumentsDataRow(contract_id, docType);

            if (currentDoc == null)
            {
                //proper doc not found in db -> add new
                currentDoc = documents.DefaultView.AddNew();
            }

            if (checker(contract_id)){
                FillDocData(contract_id, docType, data, currentDoc);
            }
        }

        private void FillDocData(int contract_id, int docType, byte[] data, DataRowView currentDoc)
        {
            if (!currentDoc.IsEdit)
                currentDoc.BeginEdit();
            currentDoc["document"] = data;
            currentDoc["contract_types_id"] = docType;
            currentDoc["contracts_id"] = contract_id;
            currentDoc["date_modify"] = DateTime.Now;
            currentDoc["users_id"] = ConnectionManager.CurrentUser.UserID;

            currentDoc.EndEdit();

            AcceptDocUpdate();
        }

        private void AcceptDocUpdate()
        {
            documentsTA.Update(documents);
            documents.AcceptChanges();
        }
    }
}
