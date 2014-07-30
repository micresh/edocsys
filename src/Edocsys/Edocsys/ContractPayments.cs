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
        private DataGridViewFooterDecorator fdContractPaymentsDataGridView;
        private DataGridViewFooterDecorator fdPayedContractsdataGridView;

        private void ContractsForm_Load(object sender, EventArgs e)
        {

            this.contractPaymentsTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.payedContractsTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;

            RefreshDatabase();

            //add filters
            filterContractsPayments = new FilterHelper(contractPaymentsDataGridView, filterContractPaymentsTextBox.TextBox);
            filterPayedContracts = new FilterHelper(payedContractsdataGridView, filterPayedContractsTextBox.TextBox);

            //performance tuning
            DataGridViewHelper.DoubleBuffered(contractPaymentsDataGridView, true);
            DataGridViewHelper.DoubleBuffered(payedContractsdataGridView, true);

            fdContractPaymentsDataGridView = new DataGridViewFooterDecorator(contractPaymentsDataGridView, new Dictionary<string, ColumnHandler>
                        {
                            {"totalcostDataGridViewTextBoxColumn2", new ColumnHandler (DataGridViewFooterDecorator.Sum, "total_cost", null, contractPaymentsDataGridView)},
                            {"prepayment", new ColumnHandler (DataGridViewFooterDecorator.Sum, "prepayment", null, contractPaymentsDataGridView)},
                            {"numberDataGridViewTextBoxColumn1", new ColumnHandler (DataGridViewFooterDecorator.StaticText, "number", "ИТОГО", null)}, 
                        }
                        );
            fdPayedContractsdataGridView = new DataGridViewFooterDecorator(payedContractsdataGridView, new Dictionary<string, ColumnHandler>
                        {
                            {"totalcostDataGridViewTextBoxColumn", new ColumnHandler (DataGridViewFooterDecorator.Sum, "total_cost", null, payedContractsdataGridView)}, 
                            {"dataGridViewTextBoxColumn1", new ColumnHandler (DataGridViewFooterDecorator.Sum, "prepayment", null, payedContractsdataGridView)}, 
                            {"numberDataGridViewTextBoxColumn", new ColumnHandler (DataGridViewFooterDecorator.StaticText, "number", "ИТОГО", null)}, 
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
            SaveContractPayments();

            RefreshContractPayments();
        }

        private void SaveContractPayments()
        {
            this.Validate();
            this.contractPaymentsBindingSource.EndEdit();
            this.contractPaymentsTableAdapter.Update(this.edocbaseDataSet.ContractPayments);

            this.edocbaseDataSet.AcceptChanges();
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

                int prepayment = Convert.ToInt32(currentRow["prepayment"]);
                int total_cost = Convert.ToInt32(currentRow["total_cost"]);

                if (prepayment < total_cost)
                {
                    if (MessageBox.Show("Внимание!\nСумма полсуенных средств меньше стоимости договора!\nПодтвердить оплату работ по договору #" + idContract, "Подтвердить оплату работ", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }

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
                DataGridViewRow row = s.Rows[e.RowIndex];
                DataGridViewHelper.ChangeGridRowColor(row, days_left);
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
                DataGridViewRow row = s.Rows[e.RowIndex];
                DataGridViewHelper.ChangeGridRowColor(row, days_left);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            RefreshContractPayments();
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            RefreshPayedContract();
        }

        private void ContractPaymentsForm_Activated(object sender, EventArgs e)
        {
            RefreshDatabase();
        }

        private void buttonAddSumm_Click(object sender, EventArgs e)
        {
            if (contractPaymentsBindingSource.Position >= 0)
            {
                DataRowView currentRow = (DataRowView)contractPaymentsBindingSource.Current;
                int id = Convert.ToInt32(currentRow["id"]);

                int sum = Convert.ToInt32(textBoxSum.Text);

                if ((currentRow["prepayment"] == null)
                    || (currentRow["prepayment"] == DBNull.Value))
                {
                    currentRow["prepayment"] = 0;
                }

                int newSum = Convert.ToInt32(currentRow["prepayment"]) + sum;

                if (newSum > Convert.ToInt32(currentRow["total_cost"]))
                {
                    if (MessageBox.Show("Внимание!\nСумма средств больше стоимости договора!\nПодтвердить получение суммы за работу по договору #" + id, "Подтвердить получение суммы", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }

                currentRow["prepayment"] = newSum;
            }

            SaveContractPayments();

            RefreshContractPayments();

            textBoxSum.Text = "0";
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDatabase();
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            RefreshPayedContract();
        }
    }
}
