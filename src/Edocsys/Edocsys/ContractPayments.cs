using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Reflection;

namespace Edocsys
{
    public partial class ContractPaymentsForm : Form
    {
        public ContractPaymentsForm()
        {
            InitializeComponent();
        }

        private FilterHelper filterPayedContracts, filterContractsPayments;

        private void ContractsForm_Load(object sender, EventArgs e)
        {

            this.contractPaymentsTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.payedContractsTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;

            RefreshDatabase();

            filterContractsPayments = new FilterHelper(contractPaymentsDataGridView, filterContractPaymentsTextBox.TextBox);
            filterPayedContracts = new FilterHelper(payedContractsdataGridView, filterPayedContractsTextBox.TextBox);


            typeof(DataGridView).InvokeMember(
                           "DoubleBuffered",
                           BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                           null,
                           payedContractsdataGridView,
                           new object[] { true });


            typeof(DataGridView).InvokeMember(
               "DoubleBuffered",
               BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
               null,
               contractPaymentsDataGridView,
               new object[] { true });
            //public void DoubleBuffered(this DataGridView dgv, bool setting)
            // {
            //     Type dgvType = dgv.GetType();
            //     PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
            //         BindingFlags.Instance | BindingFlags.NonPublic);
            //     pi.SetValue(dgv, setting, null);
            // }
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
                RefreshContractPayments();
                RefreshPayedContract();
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

        private void RefreshContractPayments()
        {
            int pos = contractPaymentsBindingSource.Position;

            this.contractPaymentsTableAdapter.Fill(this.edocbaseDataSet.ContractPayments);

            contractPaymentsBindingSource.Position = pos;

            this.contractPaymentsDataGridView.Refresh();
        }

        private void RefreshPayedContract()
        {
            int pos = payedContractsBindingSource.Position;

            this.payedContractsTableAdapter.Fill(this.edocbaseDataSet.PayedContracts);

            payedContractsBindingSource.Position = pos;

            this.payedContractsdataGridView.Refresh();
        }

        private void contractInWorkDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == contractPaymentsDataGridView.Columns["ConfirmPaymentColumn"].Index)
            {
                if ((contractPaymentsBindingSource.Position < 0) ||
                    (contractPaymentsBindingSource.Position >= contractPaymentsBindingSource.Count))
                {
                    //contract not selected
                    MessageBox.Show("Не выбран договор", "Ошибка");
                    return;
                }

                DataRow currentRow = edocbaseDataSet.ContractPayments.DefaultView[contractPaymentsBindingSource.Position].Row;
                int idContract = Convert.ToInt32(currentRow["id"]);

                if (MessageBox.Show("Подтвердить оплату работ по договору #" + idContract, "Подтвердить оплату работ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        DateTime now = DateTime.Now;

                        this.contractPaymentsTableAdapter.SetPaymentComplete(true, now, idContract);

                        //refresh data
                        UpdateDatabase();
                        RefreshDatabase();
                    }
                    catch (Exception ex)
                    {
                        string type = "Save set payment ERROR";
                        string msg = ex.Message;
                        string title = type;
                        TraceHelper.LogError(type, ex, this);
                        MessageBox.Show(msg, title);

                    }
                }
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contractPaymentsBindingSource.EndEdit();
            //this.contractPaymentsBindingSource.Update(this.edocbaseDataSet.ContractSigning);

            this.edocbaseDataSet.AcceptChanges();

            RefreshDatabase();
        }

        private void payedContractsdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == payedContractsdataGridView.Columns["CancelPaymentColumn"].Index)
            {
                if ((payedContractsBindingSource.Position < 0) ||
                    (payedContractsBindingSource.Position >= payedContractsBindingSource.Count))
                {
                    //contract not selected
                    MessageBox.Show("Не выбран договор", "Ошибка");
                    return;
                }

                DataRow currentRow = edocbaseDataSet.PayedContracts.DefaultView[payedContractsBindingSource.Position].Row;
                int idContract = Convert.ToInt32(currentRow["id"]);

                if (MessageBox.Show("Подтвердить оплату работ по договору #" + idContract, "Подтвердить оплату работ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        DateTime now = DateTime.Now;

                        this.payedContractsTableAdapter.CancelPayment(false, now, idContract);

                        //refresh data
                        UpdateDatabase();
                        RefreshDatabase();
                    }
                    catch (Exception ex)
                    {
                        string type = "Save cancel payment ERROR";
                        string msg = ex.Message;
                        string title = type;
                        TraceHelper.LogError(type, ex, this);
                        MessageBox.Show(msg, title);

                    }
                }
            }
            
        }

        private void contractPaymentsDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {
                DataGridView s = sender as DataGridView;
                if ((s.Rows[e.RowIndex].Cells["daystodeadlineDataGridViewTextBoxColumn"].Value == null) ||
                    (s.Rows[e.RowIndex].Cells["daystodeadlineDataGridViewTextBoxColumn"].Value == DBNull.Value))
                    return;

                int days_left = Convert.ToInt32(s.Rows[e.RowIndex].Cells["daystodeadlineDataGridViewTextBoxColumn"].Value);
                ChangeGridRowColor(s, e, days_left);
            }
        }

        private void payedContractsdataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {
                DataGridView s = sender as DataGridView;
                if ((s.Rows[e.RowIndex].Cells["daystodeadlineDataGridViewTextBoxColumn1"].Value == null) ||
                    (s.Rows[e.RowIndex].Cells["daystodeadlineDataGridViewTextBoxColumn1"].Value == DBNull.Value))
                    return;

                int days_left = Convert.ToInt32(s.Rows[e.RowIndex].Cells["daystodeadlineDataGridViewTextBoxColumn1"].Value);
                ChangeGridRowColor(s, e, days_left);
            }
        }

        private static void ChangeGridRowColor(DataGridView s, DataGridViewCellPaintingEventArgs e, int days_left)
        {
            Color bk, sbk;
            try
            {
                bk = s.Rows[e.RowIndex].DefaultCellStyle.BackColor;
                sbk = s.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor;

                

                if (days_left < (int)Constants.DeadlineAlerts.Fortnight)
                {
                    bk = Color.FromArgb(0xFF, 0xCB, 0xDB);
                    sbk = Color.FromArgb(255, 0, 0);
                }
                if (days_left < (int)Constants.DeadlineAlerts.Week)
                {
                    bk = Color.FromArgb(0xFA, 0xDA, 0xDD);
                    sbk = Color.FromArgb(255, 0, 0);
                }
                if (days_left < (int)Constants.DeadlineAlerts.Overdue)
                {
                    bk = Color.FromArgb(0xFD, 0xD7, 0xE4);
                    sbk = Color.FromArgb(255, 0, 0);
                }

                s.Rows[e.RowIndex].DefaultCellStyle.BackColor = bk;
                s.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = sbk;
                //e.CellStyle.BackColor = bk;
                //e.CellStyle.SelectionBackColor = sbk;
            }
            catch { };
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            RefreshContractPayments();
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            RefreshPayedContract();
        }

    }
}
