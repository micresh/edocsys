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
    public partial class DocTemplatesForm : Form
    {
        public DocTemplatesForm()
        {
            InitializeComponent();
        }

        private void DocTemplatesForm_Load(object sender, EventArgs e)
        {
            //this.templatesDataTableTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            //this.docTemplatesTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;

            //this.templatesDataTableTableAdapter.Fill(this.edocbaseDataSet.TemplatesDataTable);
            //this.docTemplatesTableAdapter.Fill(this.edocbaseDataSet.DocTemplates);
        }

        private void loadTemplateButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            byte[] data = BlobLoader.LoadFormFile(openFileDialog.FileName);


            if ((templatesDataTableBindingSource.Position < 0) ||
                (templatesDataTableBindingSource.Position >= templatesDataTableBindingSource.Count))
            {
                //contract not selected
                MessageBox.Show("Не выбран шаблон", "Ошибка");
                return;
            }


            DataRow currentRow = edocbaseDataSet.Tables["TemplatesDataTable"].DefaultView[templatesDataTableBindingSource.Position].Row;
            int idContractType = Convert.ToInt32(currentRow["id"]);

            DataRowView row = GetTemplateDataRow(idContractType);

            if (row == null)
            {
                //template not found -> add new template
                row = edocbaseDataSet.Tables["DocTemplates"].DefaultView.AddNew();
            }
            else
            {
                //template exists -> update?
                if (MessageBox.Show("Обновить шаблон для типа '" + currentRow["name"] + "'", "Подтвердить обновление шаблона", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    return;
                }
            }

            //save
            try
            {
                row["type"] = idContractType;
                row["template"] = data;

                row.EndEdit();

                UpdateChanges();
                RefreshDataTables();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save Error");
            }
        }

        private DataRowView GetTemplateDataRow(int idContractType)
        {
            edocbaseDataSet.Tables["DocTemplates"].DefaultView.Sort = "type";

            DataRowView[] docTempls = edocbaseDataSet.Tables["DocTemplates"].DefaultView.FindRows(idContractType);

            DataRowView row = null;

            if (docTempls.Length == 1)
            {
                row = docTempls[0];
            }

            return row;
        }

        private void UpdateChanges()
        {
            this.tableAdapterManager.UpdateAll(this.edocbaseDataSet);

            edocbaseDataSet.AcceptChanges();
        }

        private void RefreshDataTables()
        {
            //int pos = this.templatesDataTableBindingSource.Position;

            //this.docTemplatesTableAdapter.Fill(this.edocbaseDataSet.DocTemplates);
            //this.templatesDataTableTableAdapter.Fill(this.edocbaseDataSet.TemplatesDataTable);

            //this.templatesDataTableBindingSource.Position = pos;
        }

        private void saveTemplateButton_Click(object sender, EventArgs e)
        {
            //if ((templatesDataTableBindingSource.Position < 0) ||
            //    (templatesDataTableBindingSource.Position >= templatesDataTableBindingSource.Count))
            //{
            //    //contract not selected
            //    MessageBox.Show("Не выбран шаблон", "Ошибка");
            //    return;
            //}

            //DataRow currentRow = edocbaseDataSet.Tables["TemplatesDataTable"].DefaultView[templatesDataTableBindingSource.Position].Row;

            //bool exists = Convert.ToBoolean(currentRow["template_presence"]);

            //int idContractType = Convert.ToInt32(currentRow["id"]);

            //if (!exists)
            //{
            //    MessageBox.Show("Шаблон отсутствует в БД", "Отсутствие шаблона");
            //}

            //if (saveFileDialog.ShowDialog() != DialogResult.OK)
            //{
            //    return;
            //}

            //DataRowView row = GetTemplatessDataRow(idContractType);

            //if (row == null)
            //{
            //    MessageBox.Show("Шаблон отсутствует в БД", "Отсутствие шаблона");
            //}

            //byte[] data = (byte[])row["template"];

            //BlobLoader.SaveToFile(saveFileDialog.FileName, data);

        }


        private DataRowView GetTemplatessDataRow(int type)
        {
            //edocbaseDataSet.Tables["DocTemplates"].DefaultView.Sort = "type";
            
            //DataRowView[] currentDocs = edocbaseDataSet.Tables["DocTemplates"].DefaultView.FindRows(type);

            //DataRowView row = null;

            //if (currentDocs.Length > 0)
            //{
            //    //found docs -> check for our type

            //    int i = 0;
            //    while (i < currentDocs.Length)
            //    {
            //        if (Convert.ToInt32(currentDocs[i]["type"]) == type)
            //        {
            //            //found doc -> return it
            //            return currentDocs[i];
            //        }
            //        i++;
            //    }
            //}

            //return row;
            return null;
        }

        private void editTemplateButton_Click(object sender, EventArgs e)
        {
            if ((templatesDataTableBindingSource.Position < 0) ||
                (templatesDataTableBindingSource.Position >= templatesDataTableBindingSource.Count))
            {
                //contract not selected
                MessageBox.Show("Не выбран шаблон", "Ошибка");
                return;
            }

            DataRow currentRow = edocbaseDataSet.Tables["TemplatesDataTable"].DefaultView[templatesDataTableBindingSource.Position].Row;

            bool exists = Convert.ToBoolean(currentRow["template_presence"]);
            int type = Convert.ToInt32(currentRow["id"]);

            if (!exists)
            {
                MessageBox.Show("Шаблон отсутствует в БД", "Отсутствие шаблона");
            }

            DataRowView row = GetTemplatessDataRow(type);

            if (row == null)
            {
                MessageBox.Show("Шаблон отсутствует в БД", "Отсутствие шаблона");
            }

            byte[] data = (byte[])row["template"];
                
            string filename = BlobLoader.SaveToTemporaryFile(data);


            Process process = Process.Start(filename);
            
            process.WaitForExit();


            data = BlobLoader.LoadFormFile(filename);


            //template exists -> update?
            if (MessageBox.Show("Обновить шаблон для типа '" + currentRow["name"] + "'", "Подтвердить обновление шаблона", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }
            try
            {
                row["template"] = data;
                row.EndEdit();
                
                UpdateChanges();
                RefreshDataTables();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save Error");
            }
            // Clean up temporary file
            System.IO.File.Delete(filename); 
        }
    }
}
