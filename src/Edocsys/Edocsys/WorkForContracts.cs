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
    public partial class WorkForContractsForm : Form
    {
        public WorkForContractsForm()
        {
            InitializeComponent();
        }

        private FilterHelper filterPrepareForWork, filterInWork;


        private void ContractsForm_Load(object sender, EventArgs e)
        {
            this.contractInWorkTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.contractPrepareForWorkTAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;

            RefreshDatabase();

            //add filters
            filterPrepareForWork = new FilterHelper(contractPrepareForWorkDataGridView, filterPrepareForWorkTextBox.TextBox);
            filterInWork = new FilterHelper(contractInWorkDataGridView, filterInWorkTextBox.TextBox);
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
                RefreshContractInWork();
                RefreshContractPrepareForWork();
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

        private void RefreshContractPrepareForWork()
        {
            int pos = contractPrepareForWorkBindingSource.Position;

            this.contractPrepareForWorkTAdapter.Fill(this.edocbaseDataSet.ContractPrepareForWork);

            contractPrepareForWorkBindingSource.Position = pos;

            this.contractPrepareForWorkDataGridView.Refresh();
        }

        private void RefreshContractInWork()
        {
            int pos = contractInWorkBindingSource.Position;

            this.contractInWorkTableAdapter.Fill(this.edocbaseDataSet.ContractInWork);

            contractInWorkBindingSource.Position = pos;

            this.contractInWorkDataGridView.Refresh();
        }


        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            if ((contractPrepareForWorkBindingSource.Position < 0) ||
                (contractPrepareForWorkBindingSource.Position >= contractPrepareForWorkBindingSource.Count))
            {
                DataRowView currentRow = (DataRowView)contractPrepareForWorkBindingSource.Current;
                int id = Convert.ToInt32(currentRow["id"]);

                DateTime now = DateTime.Now.Date;

                if ((currentRow["date_start"] == null)
                    || (currentRow["date_start"] == DBNull.Value))
                {
                    currentRow["date_start"] = now;
                }

                if ((currentRow["date_end"] == null)
                    || (currentRow["date_end"] == DBNull.Value))
                {
                    DateTime nxt = now.AddMonths(3);
                    currentRow["date_end"] = nxt.Date;
                }
            }

            SaveContractPrepareData();
        }

        private void SaveContractPrepareData()
        {
            this.Validate();
            this.contractPrepareForWorkBindingSource.EndEdit();
            this.contractPrepareForWorkTAdapter.Update(this.edocbaseDataSet.ContractPrepareForWork);

            this.edocbaseDataSet.AcceptChanges();

            RefreshDatabase();
        }

        private void contractPrepareForWorkDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == contractPrepareForWorkDataGridView.Columns["StartWorkColumn"].Index)
            {
                if ((contractPrepareForWorkBindingSource.Position < 0) ||
                    (contractPrepareForWorkBindingSource.Position >= contractPrepareForWorkBindingSource.Count))
                {
                    //contract not selected
                    MessageBox.Show("Не выбран договор", "Ошибка");
                    return;
                }

                DataRowView currentRow = (DataRowView)contractPrepareForWorkBindingSource.Current;
                int id = Convert.ToInt32(currentRow["id"]);

                //validate data


                if ((currentRow["date_start"] == null)
                    || (currentRow["date_start"] == DBNull.Value))
                {
                    MessageBox.Show("Не установлена дата начала работ");
                    return;
                }

                if ((currentRow["date_end"] == null)
                    || (currentRow["date_end"] == DBNull.Value))
                {
                    MessageBox.Show("Не установлена дата окончания работ");
                    return;
                }


                if ((currentRow["date_sample_income"] == null)
                    || (currentRow["date_sample_income"] == DBNull.Value))
                {
                    if (MessageBox.Show("Внимание! Не установлена дата поступления образца. Начать работы?", "Подтвердить начало работ", MessageBoxButtons.YesNo) != DialogResult.Yes)
                        return;
                }

                if ((currentRow["date_protocol_income"] == null)
                    || (currentRow["date_protocol_income"] == DBNull.Value))
                {
                    if (MessageBox.Show("Внимание! Не установлена дата поступления протокола. Начать работы?", "Подтвердить начало работ", MessageBoxButtons.YesNo) != DialogResult.Yes)
                        return;
                }

                TimeSpan days = Convert.ToDateTime(currentRow["date_end"]) - Convert.ToDateTime(currentRow["date_start"]);
                if (days.Days < 0)
                {
                    if (MessageBox.Show("Внимание! Дата начала работ позже даты окончания! Начать работы?", "Подтвердить начало работ", MessageBoxButtons.YesNo) != DialogResult.Yes)
                        return;
                }


                if (MessageBox.Show("Начать работы по договору #" + id, "Подтвердить начало работ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        //set task processed
                        this.contractPrepareForWorkTAdapter.StartWork((int)Constants.ContractStatuses.InWork, id);

                        //refresh data
                        UpdateDatabase();
                        RefreshDatabase();
                    }
                    catch (Exception ex)
                    {
                        string type = "Save ERROR";
                        string msg = ex.Message;
                        string title = type;
                        TraceHelper.LogError(type, ex, sender);
                        MessageBox.Show(msg, title);
                    }
                }
                
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contractInWorkBindingSource.EndEdit();
            //this.contractInWorkTableAdapter.Update(this.edocbaseDataSet.ContractInWork);

            this.edocbaseDataSet.AcceptChanges();

            RefreshDatabase();
        }

        private void contractInWorkDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == contractInWorkDataGridView.Columns["WorkDoneColumn"].Index)
            {
                if ((contractInWorkBindingSource.Position < 0) ||
                    (contractInWorkBindingSource.Position >= contractInWorkBindingSource.Count))
                {
                    //contract not selected
                    MessageBox.Show("Не выбран договор", "Ошибка");
                    return;
                }

                //validate data

                DataRowView currentRow = (DataRowView)contractInWorkBindingSource.Current;
                int id = Convert.ToInt32(currentRow["id"]);

                if (MessageBox.Show("Подтвердить завершение работ по договору #" + id, "Подтвердить завершение работ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        //set task finished
                        this.contractInWorkTableAdapter.WorkDone((int)Constants.ContractStatuses.ComplitionManagerConfrim, id);

                        //refresh data
                        UpdateDatabase();
                        RefreshDatabase();
                    }
                    catch (Exception ex)
                    {
                        string type = "Save ERROR";
                        string msg = ex.Message;
                        string title = type;
                        TraceHelper.LogError(type, ex, sender);
                        MessageBox.Show(msg, title);
                    }
                }
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if ((contractPrepareForWorkBindingSource.Position < 0) ||
                (contractPrepareForWorkBindingSource.Position >= contractPrepareForWorkBindingSource.Count))
            {
                //contract not selected
                MessageBox.Show("Не выбран договор", "Ошибка");
                return;
            }

            int contract_id = DocGeneratorHelper.GetContractID(contractPrepareForWorkBindingSource);
            wmgr.ShowDeleteContractForm(contract_id);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if ((contractInWorkBindingSource.Position < 0) ||
                (contractInWorkBindingSource.Position >= contractInWorkBindingSource.Count))
            {
                //contract not selected
                MessageBox.Show("Не выбран договор", "Ошибка");
                return;
            }

            int contract_id = DocGeneratorHelper.GetContractID(contractInWorkBindingSource);
            wmgr.ShowDeleteContractForm(contract_id);
        }

        private void contractInWorkDataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            /*
            DataGridView s = sender as DataGridView;

            
            int days_left = Convert.ToInt32(s.Rows[e.RowIndex].Cells["daystodeadlineDataGridViewTextBoxColumn"].Value);

            if (days_left < (int)Constants.DeadlineAlerts.Week)
            {
                e.InheritedRowStyle.BackColor = Color.FromArgb(255, 0, 0);
                e.InheritedRowStyle.SelectionBackColor = Color.Pink;// .FromArgb(255, 0, 0);
            }
            /**/
        }

        private void contractInWorkDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            DataGridView s = sender as DataGridView;

            if (e.RowIndex < 0)
                return;

            int days_left = Convert.ToInt32(s.Rows[e.RowIndex].Cells["daystodeadlineDataGridViewTextBoxColumn"].Value);

            if (days_left < (int)Constants.DeadlineAlerts.Fortnight)
            {
                e.CellStyle.BackColor = Color.FromArgb(0xFF, 0xCB, 0xDB);
                e.CellStyle.SelectionBackColor = Color.FromArgb(255, 0, 0);
            }
            if (days_left < (int)Constants.DeadlineAlerts.Week)
            {
                e.CellStyle.BackColor = Color.FromArgb(0xFA, 0xDA, 0xDD);
                e.CellStyle.SelectionBackColor = Color.FromArgb(255, 0, 0);
            }
            if (days_left < (int)Constants.DeadlineAlerts.Overdue)
            {
                e.CellStyle.BackColor = Color.FromArgb(0xFD, 0xD7, 0xE4);
                e.CellStyle.SelectionBackColor = Color.FromArgb(255, 0, 0);
            }
        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            RefreshDatabase();
        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            RefreshDatabase();
        }

        private void buttonSetDateStart_Click(object sender, EventArgs e)
        {
            SaveContractPrepareData();
        }

        private void buttonSetDateEnd_Click(object sender, EventArgs e)
        {
            SaveContractPrepareData();
        }

        private void buttonSetDateSampleIncome_Click(object sender, EventArgs e)
        {
            SaveContractPrepareData();
        }

        private void buttonSetDateProtocolIncome_Click(object sender, EventArgs e)
        {
            SaveContractPrepareData();
        }
    }
}
