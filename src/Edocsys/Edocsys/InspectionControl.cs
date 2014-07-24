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
    public partial class InspectionControlForm : Form
    {
        public InspectionControlForm()
        {
            InitializeComponent();
        }

        private DocGeneratorHelper contractGenerator;
        private FilterHelper filterInspection, filterOnInspection;

        private DataGridViewFooterDecorator fdInspectionContractsDataGridView, fdContractsOnInspectionDataGridView;


        private void ContractsForm_Load(object sender, EventArgs e)
        {

            this.contractsOnInspectionTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.inspectionContractsTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;

            RefreshDatabase();

            //
            filterInspection = new FilterHelper(inspectionContractsDataGridView, filterInspectionContractsTextBox.TextBox);
            filterOnInspection = new FilterHelper(contractsOnInspectionDataGridView, filterInspectionContractsTextBox.TextBox);

            //doc helper
            contractGenerator = new DocGeneratorHelper(edocbaseDataSet.documents, edocbaseDataSet.doc_templates, edocbaseDataSet.ContractDocData);

            //performance tuning
            DataGridViewHelper.DoubleBuffered(inspectionContractsDataGridView, true);
            DataGridViewHelper.DoubleBuffered(contractsOnInspectionDataGridView, true);

            fdInspectionContractsDataGridView = new DataGridViewFooterDecorator(inspectionContractsDataGridView, new Dictionary<string, ColumnHandler>
                        {
                            {"number", new ColumnHandler (DataGridViewFooterDecorator.StaticText, "number", "ИТОГО", null)}, 
                            {"totalcostDataGridViewTextBoxColumn", new ColumnHandler (DataGridViewFooterDecorator.Sum, "total_cost", null, inspectionContractsDataGridView)}, 
                        }
            );

            fdContractsOnInspectionDataGridView = new DataGridViewFooterDecorator(contractsOnInspectionDataGridView, new Dictionary<string, ColumnHandler>
                        {
                            {"dataGridViewTextBoxColumn1", new ColumnHandler (DataGridViewFooterDecorator.StaticText, "products_name", "ИТОГО", null)}, 
                            {"dataGridViewTextBoxColumn9", new ColumnHandler (DataGridViewFooterDecorator.Sum, "total_cost", null, contractsOnInspectionDataGridView)}, 
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
                string type = "Save ERROR";
                string msg = ex.Message;
                string title = type;
                TraceHelper.LogError(type, ex, this);
                MessageBox.Show(msg, title);
            }
        }

        private void RefreshDatabase()
        {
            try
            {
                RefreshInspectionControl();
                RefreshContractsOnInspection();
            }
            catch (Exception ex)
            {
                string type = "Refresh ERROR";
                string msg = ex.Message;
                string title = type;
                TraceHelper.LogError(type, ex, this);
                MessageBox.Show(msg, title);
            }
        }

        private void RefreshContractsOnInspection()
        {
            int pos = this.contractsOnInspectionBindingSource.Position;

            this.contractsOnInspectionTableAdapter.Fill(this.edocbaseDataSet.ContractsOnInspection);

            this.contractsOnInspectionBindingSource.Position = pos;

            contractsOnInspectionDataGridView.Refresh();
        }

        private void RefreshInspectionControl()
        {
            int pos = this.inspectionContractsBindingSource.Position;

            this.inspectionContractsTableAdapter.Fill(this.edocbaseDataSet.InspectionContracts);

            this.inspectionContractsBindingSource.Position = pos;

            inspectionContractsDataGridView.Refresh();
        }

        private void buttonGenerateContract_Click(object sender, EventArgs e)
        {
            if ((inspectionContractsBindingSource.Position < 0) ||
                (inspectionContractsBindingSource.Position >= inspectionContractsBindingSource.Count))
            {
                //contract not selected
                MessageBox.Show("Не выбран договор", "Ошибка");
                return;
            }

            int docType = (int)Constants.ContractTypes.Reattestation;
            int contract_id = DocGeneratorHelper.GetContractID(inspectionContractsBindingSource);

            try
            {
                contractGenerator.GenerateDoc(contract_id, docType, (id) =>
                {
                    //found doc -> update?
                    return MessageBox.Show("Обновить документ для контракта #" + id, "Подтвердить обновление документа", MessageBoxButtons.YesNo) == DialogResult.Yes;
                });
            }
            catch (NullReferenceException ex)
            {
                string type = "GenerateDoc GetData ERROR";
                string msg = "Ошибка получения данных для заполнения: " + ex.Message;
                string title = "Ошибка";
                TraceHelper.LogError(type, ex, this);
                MessageBox.Show(msg, title);
            }
            catch (Exception ex)
            {
                string type = "GenerateDoc ERROR";
                string msg = ex.Message;
                string title = type;
                TraceHelper.LogError(type, ex, this);
                MessageBox.Show(msg, title);
            }

            RefreshDatabase();
        }

        private void buttonEditContract_Click(object sender, EventArgs e)
        {
            if ((inspectionContractsBindingSource.Position < 0) ||
                (inspectionContractsBindingSource.Position >= inspectionContractsBindingSource.Count))
            {
                //contract not selected
                MessageBox.Show("Не выбран договор", "Ошибка");
                return;
            }

            int docType = (int)Constants.ContractTypes.Reattestation;
            int contract_id = DocGeneratorHelper.GetContractID(inspectionContractsBindingSource);

            try
            {
                contractGenerator.EditDoc(contract_id, docType, (id) =>
                {
                    //file changed -> update?
                    return MessageBox.Show("Обновить документ договора #" + id, "Подтвердить обновление документа", MessageBoxButtons.YesNo) == DialogResult.Yes;
                });
            }
            catch (NullReferenceException ex)
            {
                string type = "EditDoc ERROR";
                string msg = "Файл заявки отсутствует в БД: " + ex.Message;
                string title = "Отсутствие договора";
                TraceHelper.LogError(type, ex, this);
                MessageBox.Show(msg, title);
            }
            catch (Exception ex)
            {
                string type = "EditDoc ERROR";
                string msg = ex.Message;
                string title = type;
                TraceHelper.LogError(type, ex, this);
                MessageBox.Show(msg, title);
            }

            RefreshDatabase();
        }

        private void buttonSaveContract_Click(object sender, EventArgs e)
        {
            if ((inspectionContractsBindingSource.Position < 0) ||
                (inspectionContractsBindingSource.Position >= inspectionContractsBindingSource.Count))
            {
                //contract not selected
                MessageBox.Show("Не выбран договор", "Ошибка");
                return;
            }

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            int docType = (int)Constants.ContractTypes.Reattestation;
            int contract_id = DocGeneratorHelper.GetContractID(inspectionContractsBindingSource);

            try
            {
                contractGenerator.SaveDoc(contract_id, docType, saveFileDialog.FileName);
            }
            catch (NullReferenceException ex)
            {
                string type = "SaveDoc GetData ERROR";
                string msg = "Файл договора отсутствует в БД: " + ex.Message;
                string title = "Отсутствие договора";
                TraceHelper.LogError(type, ex, this);
                MessageBox.Show(msg, title);
            }
            catch (Exception ex)
            {
                string type = "SaveDoc ERROR";
                string msg = ex.Message;
                string title = type;
                TraceHelper.LogError(type, ex, this);
                MessageBox.Show(msg, title);
            }

            RefreshDatabase();
        }

        private void buttonLoadContract_Click(object sender, EventArgs e)
        {
            if ((inspectionContractsBindingSource.Position < 0) ||
                (inspectionContractsBindingSource.Position >= inspectionContractsBindingSource.Count))
            {
                //contract not selected
                MessageBox.Show("Не выбран договор", "Ошибка");
                return;
            }

            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            int docType = (int)Constants.ContractTypes.Reattestation;
            int contract_id = DocGeneratorHelper.GetContractID(inspectionContractsBindingSource);

            try
            {
                contractGenerator.SaveDoc(contract_id, docType, openFileDialog.FileName);
            }
            catch (NullReferenceException ex)
            {
                string type = "LoadDoc GetData ERROR";
                string msg = "Ошибка загрузки документа: " + ex.Message;
                string title = "Ошибка";
                TraceHelper.LogError(type, ex, this);
                MessageBox.Show(msg, title);
            }
            catch (Exception ex)
            {
                string type = "LoadDoc ERROR";
                string msg = ex.Message;
                string title = type;
                TraceHelper.LogError(type, ex, this);
                MessageBox.Show(msg, title);
            }

            RefreshDatabase();
        }

        private void toolStripButton6_Click_1(object sender, EventArgs e)
        {
            ////set data to current date if it is null
            //if ((inspectionContractsBindingSource.Position < 0) ||
            //    (inspectionContractsBindingSource.Position >= inspectionContractsBindingSource.Count))
            //{
            //    DataRowView currentRow = (DataRowView)inspectionContractsBindingSource.Current;
            //    int id = Convert.ToInt32(currentRow["id"]);

            //    DateTime now = DateTime.Now.Date;

            //    if ((currentRow["date_planed_reatt_1"] == null)
            //        || (currentRow["date_planed_reatt_1"] == DBNull.Value))
            //    {
            //        currentRow["date_planed_reatt_1"] = now;
            //    }

            //    if ((currentRow["date_planed_reatt_2"] == null)
            //        || (currentRow["date_planed_reatt_2"] == DBNull.Value))
            //    {
            //        DateTime nxt = now.AddMonths(9);
            //        currentRow["date_planed_reatt_2"] = nxt;
            //    }

            //    if ((currentRow["date_planed_resert"] == null)
            //        || (currentRow["date_planed_resert"] == DBNull.Value))
            //    {
            //        DateTime nxt = now.AddMonths(12);
            //        currentRow["date_planed_resert"] = nxt;
            //    }
            //}
            SaveContractsOnInspectionControl();
        }

        private void SaveContractsOnInspectionControl()
        {
            this.Validate();
            this.contractsOnInspectionBindingSource.EndEdit();

            this.contractsOnInspectionTableAdapter.Update(this.edocbaseDataSet.ContractsOnInspection);

            this.edocbaseDataSet.AcceptChanges();
        }

        private void SaveInspectionControl()
        {

            this.Validate();
            this.inspectionContractsBindingSource.EndEdit();

            this.inspectionContractsTableAdapter.Update(this.edocbaseDataSet.InspectionContracts);

            this.edocbaseDataSet.AcceptChanges();
        }

        private void usersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            //set data to current date if it is null
            if (inspectionContractsBindingSource.Position >= 0)
            {
                DataRowView currentRow = (DataRowView)inspectionContractsBindingSource.Current;
                int id = Convert.ToInt32(currentRow["id"]);

                DateTime now = DateTime.Now.Date;

                if ((currentRow["date_planed_reatt_1"] == null)
                    || (currentRow["date_planed_reatt_1"] == DBNull.Value))
                {
                    currentRow["date_planed_reatt_1"] = now;
                }

                if ((currentRow["date_planed_reatt_2"] == null)
                    || (currentRow["date_planed_reatt_2"] == DBNull.Value))
                {
                    DateTime nxt = now.AddMonths(9);
                    currentRow["date_planed_reatt_2"] = nxt;
                }

                if ((currentRow["date_planed_resert"] == null)
                    || (currentRow["date_planed_resert"] == DBNull.Value))
                {
                    DateTime nxt = now.AddMonths(12);
                    currentRow["date_planed_resert"] = nxt;
                }
            }

            SaveInspectionControl();

            RefreshInspectionControl();
        }

        private void buttonReatt1_Click(object sender, EventArgs e)
        {
            if (contractsOnInspectionBindingSource.Position >= 0)
            {
                DataRowView currentRow = (DataRowView)contractsOnInspectionBindingSource.Current;
                int id = Convert.ToInt32(currentRow["id"]);

                DateTime now = DateTime.Now.Date;

                if ((currentRow["date_real_reatt_1"] == null)
                    || (currentRow["date_real_reatt_1"] == DBNull.Value))
                {
                    currentRow["date_real_reatt_1"] = now;
                }
            }
            SaveContractsOnInspectionControl();
            RefreshContractsOnInspection();
        }

        private void buttonReatt2_Click(object sender, EventArgs e)
        {
            if (contractsOnInspectionBindingSource.Position >= 0)
            {
                DataRowView currentRow = (DataRowView)contractsOnInspectionBindingSource.Current;
                int id = Convert.ToInt32(currentRow["id"]);

                DateTime now = DateTime.Now.Date;

                if ((currentRow["date_real_reatt_2"] == null)
                    || (currentRow["date_real_reatt_2"] == DBNull.Value))
                {
                    currentRow["date_real_reatt_2"] = now;
                }
            }
            SaveContractsOnInspectionControl();
            RefreshContractsOnInspection();
        }

        private void buttonResert_Click(object sender, EventArgs e)
        {
            if (contractsOnInspectionBindingSource.Position >= 0)
            {
                DataRowView currentRow = (DataRowView)contractsOnInspectionBindingSource.Current;
                int id = Convert.ToInt32(currentRow["id"]);

                DateTime now = DateTime.Now.Date;

                if ((currentRow["date_real_resert"] == null)
                    || (currentRow["date_real_resert"] == DBNull.Value))
                {
                    currentRow["date_real_resert"] = now;
                }
            }
            SaveContractsOnInspectionControl();
            RefreshContractsOnInspection();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if ((inspectionContractsBindingSource.Position < 0) ||
                (inspectionContractsBindingSource.Position >= inspectionContractsBindingSource.Count))
            {
                //contract not selected
                MessageBox.Show("Не выбран договор", "Ошибка");
                return;
            }

            int contract_id = DocGeneratorHelper.GetContractID(inspectionContractsBindingSource);
            wmgr.ShowDeleteContractForm(contract_id);

            RefreshInspectionControl();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if ((contractsOnInspectionBindingSource.Position < 0) ||
                (contractsOnInspectionBindingSource.Position >= contractsOnInspectionBindingSource.Count))
            {
                //contract not selected
                MessageBox.Show("Не выбран договор", "Ошибка");
                return;
            }

            int contract_id = DocGeneratorHelper.GetContractID(contractsOnInspectionBindingSource);
            wmgr.ShowDeleteContractForm(contract_id);

            RefreshContractsOnInspection();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            RefreshDatabase();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            RefreshDatabase();
        }

        private void contractsOnInspectionDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == contractsOnInspectionDataGridView.Columns["FinishInspectionControlColumn"].Index)
            {
                if ((contractsOnInspectionBindingSource.Position < 0) ||
                    (contractsOnInspectionBindingSource.Position >= contractsOnInspectionBindingSource.Count))
                {
                    //contract not selected
                    MessageBox.Show("Не выбран договор", "Ошибка");
                    return;
                }

                DataRowView currentRow = (DataRowView)contractsOnInspectionBindingSource.Current;
                int id = Convert.ToInt32(currentRow["id"]);

                //validate data
                if ((currentRow["date_real_reatt_1"] == null)
                    || (currentRow["date_real_reatt_1"] == DBNull.Value))
                {
                    MessageBox.Show("Не проведена 1-я реаттестация");
                    return;
                }

                if ((currentRow["date_real_reatt_2"] == null)
                    || (currentRow["date_real_reatt_2"] == DBNull.Value))
                {
                    MessageBox.Show("Не проведена 2-я реаттестация");
                    return;
                }

                if ((currentRow["date_real_resert"] == null)
                    || (currentRow["date_real_resert"] == DBNull.Value))
                {
                    MessageBox.Show("Не проведена ресертификация");
                    return;
                }

                TimeSpan days = Convert.ToDateTime(currentRow["date_real_reatt_2"]) - Convert.ToDateTime(currentRow["date_real_reatt_1"]);
                if (days.Days < 0)
                {
                    if (MessageBox.Show("Внимание! Дата проведения 2-ой реаттестации позже даты 1-ой! Начать контроль?", "Подтвердить окончание инспекционного контроля", MessageBoxButtons.YesNo) != DialogResult.Yes)
                        return;
                }


                days = Convert.ToDateTime(currentRow["date_real_resert"]) - Convert.ToDateTime(currentRow["date_real_reatt_2"]);
                if (days.Days < 0)
                {
                    if (MessageBox.Show("Внимание! Дата проведения ресертификации позже даты 2-ой реаттестации! Начать контроль?", "Подтвердить окончание  инспекционного контроля", MessageBoxButtons.YesNo) != DialogResult.Yes)
                        return;
                }

                if (MessageBox.Show("Заврешить испрекционной контроль по договору #" + id, "Подтвердить окончание  инспекционного контроля", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        //start inspection control
                        this.contractsOnInspectionTableAdapter.FinishInspectionControl((int)Constants.ContractStatuses.FinishedTasks, id);

                        //refresh data
                        UpdateDatabase();
                        RefreshDatabase();
                    }
                    catch (Exception ex)
                    {
                        string type = "Save On Inspection ERROR";
                        string msg = ex.Message;
                        string title = type;
                        TraceHelper.LogError(type, ex, this);
                        MessageBox.Show(msg, title);
                    }
                }
            }
        }

        private void inspectionContractsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == inspectionContractsDataGridView.Columns["StartControlColumn"].Index)
            {
                if ((inspectionContractsBindingSource.Position < 0) ||
                    (inspectionContractsBindingSource.Position >= inspectionContractsBindingSource.Count))
                {
                    //contract not selected
                    MessageBox.Show("Не выбран договор", "Ошибка");
                    return;
                }

                DataRowView currentRow = (DataRowView)inspectionContractsBindingSource.Current;
                int id = Convert.ToInt32(currentRow["id"]);

                //validate data
                if ((currentRow["date_planed_reatt_1"] == null)
                    || (currentRow["date_planed_reatt_1"] == DBNull.Value))
                {
                    MessageBox.Show("Не установлена дата 1-ой реаттестации");
                    return;
                }

                if ((currentRow["date_planed_reatt_2"] == null)
                    || (currentRow["date_planed_reatt_2"] == DBNull.Value))
                {
                    MessageBox.Show("Не установлена дата 2-ой реаттестации");
                    return;
                }

                if ((currentRow["date_planed_resert"] == null)
                    || (currentRow["date_planed_resert"] == DBNull.Value))
                {
                    MessageBox.Show("Не установлена дата ресертификации");
                    return;
                }

                TimeSpan days = Convert.ToDateTime(currentRow["date_planed_reatt_2"]) - Convert.ToDateTime(currentRow["date_planed_reatt_1"]);
                if (days.Days < 0)
                {
                    if (MessageBox.Show("Внимание! Дата начала 2-ой реаттестации позже даты 1-ой! Начать контроль?", "Подтвердить начало инспекционного контроля", MessageBoxButtons.YesNo) != DialogResult.Yes)
                        return;
                }

                days = Convert.ToDateTime(currentRow["date_planed_resert"]) - Convert.ToDateTime(currentRow["date_planed_reatt_2"]);
                if (days.Days < 0)
                {
                    if (MessageBox.Show("Внимание! Дата начала ресертификации позже даты 2-ой реаттестации! Начать контроль?", "Подтвердить начало инспекционного контроля", MessageBoxButtons.YesNo) != DialogResult.Yes)
                        return;
                }

                bool hasDocument = Convert.ToBoolean(currentRow["has_inspection_document"]);

                if (!hasDocument)
                {
                    if (MessageBox.Show("Внимание! Документ договра контроля #" + id + " не сгенерирован! Начать контроль?", "Подтвердить начало инспекционного контроля", MessageBoxButtons.YesNo) != DialogResult.Yes)
                        return;
                }

                if (MessageBox.Show("Начать испрекционной контроль по договору #" + id, "Подтвердить начало инспекционного контроля", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        //start inspection control
                        this.inspectionContractsTableAdapter.StartInspectionControl((int)Constants.ContractStatuses.InspectionControl, id);

                        //refresh data
                        UpdateDatabase();
                        RefreshDatabase();
                    }
                    catch (Exception ex)
                    {
                        string type = "Save Start Inspection ERROR";
                        string msg = ex.Message;
                        string title = type;
                        TraceHelper.LogError(type, ex, this);
                        MessageBox.Show(msg, title);
                    }
                }
            }
        }

        private void buttonSetDateReatt1_Click(object sender, EventArgs e)
        {
            if (inspectionContractsBindingSource.Position >= 0)
            {
                DataRowView currentRow = (DataRowView)inspectionContractsBindingSource.Current;
                int id = Convert.ToInt32(currentRow["id"]);

                DateTime now = DateTime.Now.Date;

                if ((currentRow["date_planed_reatt_1"] == null)
                    || (currentRow["date_planed_reatt_1"] == DBNull.Value))
                {
                    currentRow["date_planed_reatt_1"] = now.Date;
                }
            }

            SaveInspectionControl();

            RefreshInspectionControl();
        }

        private void buttonSetDateReatt2_Click(object sender, EventArgs e)
        {
            if (inspectionContractsBindingSource.Position >= 0)
            {
                DataRowView currentRow = (DataRowView)inspectionContractsBindingSource.Current;
                int id = Convert.ToInt32(currentRow["id"]);

                DateTime now = DateTime.Now.Date;

                if ((currentRow["date_planed_reatt_2"] == null)
                    || (currentRow["date_planed_reatt_2"] == DBNull.Value))
                {
                    currentRow["date_planed_reatt_2"] = now.Date;
                }
            }

            SaveInspectionControl();

            RefreshInspectionControl();
        }

        private void buttonSetDateResert_Click(object sender, EventArgs e)
        {
            if (inspectionContractsBindingSource.Position >= 0)
            {
                DataRowView currentRow = (DataRowView)inspectionContractsBindingSource.Current;
                int id = Convert.ToInt32(currentRow["id"]);

                DateTime now = DateTime.Now.Date;

                if ((currentRow["date_planed_resert"] == null)
                    || (currentRow["date_planed_resert"] == DBNull.Value))
                {
                    currentRow["date_planed_resert"] = now.Date;
                }
            }

            SaveInspectionControl();

            RefreshInspectionControl();
        }

        private void contractsOnInspectionDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {
                DataGridView s = sender as DataGridView;

                //skip errors
                if (s.Rows[e.RowIndex].Cells["date_real_reatt_1"].Value == null)
                    return;

                if ((s.Rows[e.RowIndex].Cells["days_to_deadline_reatt_1"].Value == null) ||
                    (s.Rows[e.RowIndex].Cells["days_to_deadline_reatt_1"].Value == DBNull.Value))
                    return;

                if (s.Rows[e.RowIndex].Cells["date_real_reatt_2"].Value == null)
                    return;

                if ((s.Rows[e.RowIndex].Cells["days_to_deadline_reatt_2"].Value == null) ||
                    (s.Rows[e.RowIndex].Cells["days_to_deadline_reatt_2"].Value == DBNull.Value))
                    return;

                if (s.Rows[e.RowIndex].Cells["date_real_resert"].Value == null)
                    return;

                if ((s.Rows[e.RowIndex].Cells["days_to_deadline_resert"].Value == null) ||
                    (s.Rows[e.RowIndex].Cells["days_to_deadline_resert"].Value == DBNull.Value))
                    return;

                //count days
                int days_left = (int)Constants.DeadlineAlerts.Fortnight + 1;

                if (s.Rows[e.RowIndex].Cells["date_real_reatt_1"].Value == DBNull.Value)
                {
                    days_left = Math.Min(Convert.ToInt32(s.Rows[e.RowIndex].Cells["days_to_deadline_reatt_1"].Value), days_left);
                }

                if (s.Rows[e.RowIndex].Cells["date_real_reatt_2"].Value == DBNull.Value)
                {
                    days_left = Math.Min(Convert.ToInt32(s.Rows[e.RowIndex].Cells["days_to_deadline_reatt_2"].Value), days_left);
                }

                if (s.Rows[e.RowIndex].Cells["date_real_resert"].Value == DBNull.Value)
                {
                    days_left = Math.Min(Convert.ToInt32(s.Rows[e.RowIndex].Cells["days_to_deadline_resert"].Value), days_left);
                }

                DataGridViewRow row = s.Rows[e.RowIndex];

                DataGridViewHelper.ChangeGridRowColor(row, days_left);
            }
        }

        private void InspectionControlForm_Activated(object sender, EventArgs e)
        {
            RefreshDatabase();
        }
    }
}
