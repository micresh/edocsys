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
    public partial class ProposalForm : Form
    {
        public ProposalForm()
        {
            InitializeComponent();
        }

        private void contractsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {

                this.Validate();
                this.contractsBindingSource.EndEdit();

                this.tableAdapterManager.UpdateAll(this.edocbaseDataSet);
                this.edocbaseDataSet.AcceptChanges();
                this.contractsTableAdapter.FillProposal(this.edocbaseDataSet.Contracts);
                this.contractsDataGridView.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save Errror");
            }
        }

        private void ProposalForm_Load(object sender, EventArgs e)
        {
            this.productsTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.contractsTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.contractTypesTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;


            // TODO: This line of code loads data into the 'edocbaseDataSet.ContractTypes' table. You can move, or remove it, as needed.
            this.contractTypesTableAdapter.Fill(this.edocbaseDataSet.ContractTypes);
            // TODO: This line of code loads data into the 'edocbaseDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.edocbaseDataSet.Products);
            // TODO: This line of code loads data into the 'edocbaseDataSet.Contracts' table. You can move, or remove it, as needed.
            this.contractsTableAdapter.FillProposal(this.edocbaseDataSet.Contracts);
        }

        private void contractsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == contractsDataGridView.Columns["SendProposalColumn"].Index)
            {
                if (MessageBox.Show("Подтвердить отправку заявки #" , "Подтвердить отправку заявки", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    //MessageBox.Show("MessageBox.Show");
                    //if (contractsBindingSource.AllowEdit)
                    {
                        int x = Convert.ToInt32(contractsDataGridView.Rows[e.RowIndex].Cells["idContract"].Value);
                        this.contractsTableAdapter.SendProposal(1, x);

                        this.Validate();
                        this.contractsBindingSource.EndEdit();
                        this.tableAdapterManager.ContractsTableAdapter.Update(this.edocbaseDataSet.Contracts);
                        this.edocbaseDataSet.AcceptChanges();
                        this.contractsTableAdapter.FillProposal(this.edocbaseDataSet.Contracts);
                        this.contractsDataGridView.Refresh();

                    }

                }
                   
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            contractsDataGridView.CurrentRow.Cells["contract_type"].Value = 0;
        }
    }
}
