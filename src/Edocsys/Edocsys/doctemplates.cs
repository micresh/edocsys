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
            this.templatesDataTableTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.docTemplatesTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;

            this.templatesDataTableTableAdapter.Fill(this.edocbaseDataSet.TemplatesDataTable);
            this.docTemplatesTableAdapter.Fill(this.edocbaseDataSet.DocTemplates);
        }

        private void loadTemplateButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);

                byte[] tmplData = new byte[fs.Length];
                fs.Read(tmplData, 0, Convert.ToInt32(fs.Length));

                fs.Close();

                if (templatesDataTableBindingSource.Position >= 0)
                {
                    DataRow currentRow = edocbaseDataSet.Tables["TemplatesDataTable"].DefaultView[templatesDataTableBindingSource.Position].Row;
                    int idContractType = Convert.ToInt32(currentRow["id"]);

                    int currentTemplate = GetTemplateID(idContractType);

                    if (currentTemplate < 0)
                    {
                        //template not found -> add new template

                        DataRowView rowView = edocbaseDataSet.Tables["DocTemplates"].DefaultView.AddNew();

                        rowView["type"] = idContractType;
                        rowView["template"] = tmplData;

                        rowView.EndEdit();

                        UpdateAndRefresh();
                    }
                    else
                    {
                        //template exists -> update?
                        if (MessageBox.Show("Обновить шаблон для типа '" + currentRow["name"] + "'", "Подтвердить обновление шаблона", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            try
                            {
                                DataRow row = edocbaseDataSet.Tables["DocTemplates"].DefaultView[currentTemplate].Row;

                                row["template"] = tmplData;
                                row.EndEdit();
   
                                UpdateAndRefresh();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Save Error");
                            }
                        }
                    }
                }
            }
        }

        private int GetTemplateID(int idContractType)
        {
            edocbaseDataSet.Tables["DocTemplates"].DefaultView.Sort = "type";

            int currentTemplate = edocbaseDataSet.Tables["DocTemplates"].DefaultView.Find(idContractType);
            return currentTemplate;
        }

        private void UpdateAndRefresh()
        {
            this.tableAdapterManager.UpdateAll(this.edocbaseDataSet);

            edocbaseDataSet.AcceptChanges();

            this.docTemplatesTableAdapter.Fill(this.edocbaseDataSet.DocTemplates);
            this.templatesDataTableTableAdapter.Fill(this.edocbaseDataSet.TemplatesDataTable);
        }

        private void saveTemplateButton_Click(object sender, EventArgs e)
        {

            if (templatesDataTableBindingSource.Position >= 0)
            {
                DataRow currentRow = edocbaseDataSet.Tables["TemplatesDataTable"].DefaultView[templatesDataTableBindingSource.Position].Row;

                bool exists = Convert.ToBoolean(currentRow["template_presence"]);

                int idContractType = Convert.ToInt32(currentRow["id"]);

                if (exists)
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        SaveTemplateByID(saveFileDialog.FileName, idContractType);
                    }
                }
                else
                {
                    MessageBox.Show("Шаблон отсутствует в БД", "Отсутствие шаблона");
                }
            }
        }

        private void SaveTemplateByID(string filename, int idContractType)
        {
            edocbaseDataSet.Tables["DocTemplates"].DefaultView.Sort = "type";

            int currentTemplate = edocbaseDataSet.Tables["DocTemplates"].DefaultView.Find(idContractType);
            if (currentTemplate >= 0)
            {
                //template not found -> add new template

                DataRow row = edocbaseDataSet.Tables["DocTemplates"].DefaultView[currentTemplate].Row;


                byte[] tmplData = (byte[])row["template"];

                FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);


                fs.Write(tmplData, 0, tmplData.Length);

                fs.Close();

            }
        }

        private void editTemplateButton_Click(object sender, EventArgs e)
        {
            if (templatesDataTableBindingSource.Position >= 0)
            {
                DataRow currentRow = edocbaseDataSet.Tables["TemplatesDataTable"].DefaultView[templatesDataTableBindingSource.Position].Row;

                bool exists = Convert.ToBoolean(currentRow["template_presence"]);
                int idContractType = Convert.ToInt32(currentRow["id"]);

                if (exists)
                {
                    string extension = "docx";
                    //make temporary file
                    string filename = System.IO.Path.GetTempFileName() + "." + extension;

                    SaveTemplateByID(filename, idContractType);

                    var process = Process.Start(filename);
                    
                    process.WaitForExit();


                    int currentTemplate = GetTemplateID(idContractType);


                    FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                    byte[] tmplData = new byte[fs.Length];
                    fs.Read(tmplData, 0, Convert.ToInt32(fs.Length));
                    fs.Close();

                    //template exists -> update?
                    if (MessageBox.Show("Обновить шаблон для типа '" + currentRow["name"] + "'", "Подтвердить обновление шаблона", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            DataRow row = edocbaseDataSet.Tables["DocTemplates"].DefaultView[currentTemplate].Row;

                            row["template"] = tmplData;
                            row.EndEdit();
   
                            UpdateAndRefresh();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Save Error");
                        }
                    }
                    // Clean up temporary file
                    System.IO.File.Delete(filename); 

                }
                else
                {
                    MessageBox.Show("Шаблон отсутствует в БД", "Отсутствие шаблона");
                }
            }
        }
    }
}
