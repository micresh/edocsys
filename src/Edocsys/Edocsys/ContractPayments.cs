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
                this.contractPaymentsTableAdapter.Fill(this.edocbaseDataSet.ContractPayments);
                this.payedContractsTableAdapter.Fill(this.edocbaseDataSet.PayedContracts);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Refresh Error");
            }
            /**/
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
                        MessageBox.Show(ex.Message, "Save Error");
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
                        MessageBox.Show(ex.Message, "Save Error");
                    }
                }
            }
            
        }

        private void contractPaymentsDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            DataGridView s = sender as DataGridView;

            if (e.RowIndex < 0)
                return;
            try
            {
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
            catch { };
        }

        private void payedContractsdataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            DataGridView s = sender as DataGridView;

            if (e.RowIndex < 0)
                return;
            try
            {
                int days_left = Convert.ToInt32(s.Rows[e.RowIndex].Cells["daystodeadlineDataGridViewTextBoxColumn1"].Value);

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
            catch { };
        }

    }
}
