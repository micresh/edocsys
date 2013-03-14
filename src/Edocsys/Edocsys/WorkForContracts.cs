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
                MessageBox.Show(ex.Message, "Save Error");
            }
            /**/
        }

        private void RefreshDatabase()
        {
            try
            {
                this.contractPrepareForWorkTAdapter.Fill(this.edocbaseDataSet.ContractPrepareForWork);
                this.contractInWorkTableAdapter.Fill(this.edocbaseDataSet.ContractInWork);

                this.contractPrepareForWorkDataGridView.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Refresh Error");
            }
            /**/
        }


        private void toolStripButton12_Click(object sender, EventArgs e)
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

                DataRow currentRow = edocbaseDataSet.ContractPrepareForWork.DefaultView[contractPrepareForWorkBindingSource.Position].Row;
                int idContract = Convert.ToInt32(currentRow["id"]);

                if (MessageBox.Show("Начать работы по договору #" + idContract, "Подтвердить начало работ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        //set task processed
                        this.contractPrepareForWorkTAdapter.StartWork((int)Constants.ContractStatuses.InWork, idContract);

                        ////add executed contract
                        //DateTime now = DateTime.Now;
                        //DateTime nxt = now; ;
                        //nxt = nxt.AddMonths(9);


                        //refresh data
                        UpdateDatabase();
                        RefreshDatabase();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Save Error");
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

                DataRow currentRow = edocbaseDataSet.ContractInWork.DefaultView[contractInWorkBindingSource.Position].Row;
                int idContract = Convert.ToInt32(currentRow["id"]);

                if (MessageBox.Show("Подтвердить завершение работ по договору #" + idContract, "Подтвердить завершение работ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        //set task finished
                        this.contractInWorkTableAdapter.WorkDone((int)Constants.ContractStatuses.ComplitionManagerConfrim, idContract);

                        //refresh data
                        UpdateDatabase();
                        RefreshDatabase();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Save Error");
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
    }
}
