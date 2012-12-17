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
            UpdateDatabaseAndRefresh();
        }

        private void UpdateDatabaseAndRefresh()
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
                MessageBox.Show(ex.Message, "Save Error");
            }
            /**/
        }

        private void ProposalForm_Load(object sender, EventArgs e)
        {

            this.agentsTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.productsTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.contractsTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.contractTypesTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;



            this.contractTypesTableAdapter.Fill(this.edocbaseDataSet.ContractTypes);
            this.productsTableAdapter.Fill(this.edocbaseDataSet.Products);
            this.contractsTableAdapter.FillProposal(this.edocbaseDataSet.Contracts);
            this.agentsTableAdapter.Fill(this.edocbaseDataSet.Agents);
        }

        private void contractsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == contractsDataGridView.Columns["SendProposalColumn"].Index)
            {
                if (contractsBindingSource.Position >= 0)
                {
                    DataRow currentRow = edocbaseDataSet.Tables["Contracts"].DefaultView[contractsBindingSource.Position].Row;
                    int idContract = Convert.ToInt32(currentRow["idContract"]);

                    if (MessageBox.Show("Отправить заявку #" + idContract, "Подтвердить отправку заявки", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            //send proposal
                            this.contractsTableAdapter.SendProposal(Constants.ContractStatuses.WaitForExpertAssigment, idContract);

                            //refresh data
                            this.edocbaseDataSet.AcceptChanges();

                            this.contractsTableAdapter.FillProposal(this.edocbaseDataSet.Contracts);
                            this.contractsDataGridView.Refresh();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Save Error");
                        }
                    }
                }
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            contractsDataGridView.CurrentRow.Cells["Contract_type"].Value = 0;
        }
    }
}
