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
    public partial class AssignExpertForm : Form
    {
        public AssignExpertForm()
        {
            InitializeComponent();
        }

        private void contractsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.expertAssignmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.edocbaseDataSet);

        }
        private FilterHelper assignedFilter, proposalsFilter;

        private void AssignExpertForm_Load(object sender, EventArgs e)
        {


            this.expertsTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.expertAssignmentTAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.assignedContractsTAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;

            RefreshDatabase();

            //add filters
            assignedFilter = new FilterHelper(assignedContractsDataGridView, filterAssignedToolStripTextBox.TextBox);
            proposalsFilter = new FilterHelper(proposalsDataGridView, filterProposalsToolStripTextBox.TextBox);
        }

        private void RefreshDatabase()
        {
            this.expertAssignmentTAdapter.Fill(this.edocbaseDataSet.ExpertAssignment);
            this.expertsTableAdapter.Fill(this.edocbaseDataSet.experts);
            this.assignedContractsTAdapter.Fill(this.edocbaseDataSet.AssignedContracts);
        }

        private void assignButton_Click(object sender, EventArgs e)
        {
            if (expertAssignmentBindingSource.Position < 0)
            {
                MessageBox.Show("Не выбрана заявка?", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            if (expertsListBox.SelectedIndex < 0)
            {
                MessageBox.Show("Не выбран эксперт?", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Назначить эксперта для заявки?", "Подтвердить назначение эксперта", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                DataRow currentRow = edocbaseDataSet.ExpertAssignment.DefaultView[expertAssignmentBindingSource.Position].Row;

                int idContract = Convert.ToInt32(currentRow["id"]);
                int idExpert = Convert.ToInt32(((DataRowView)expertsListBox.SelectedValue)["id"]);

                try
                {
                    //assign expert
                    this.expertAssignmentTAdapter.AssignExpert((int)Constants.ContractStatuses.ContractSigning, idExpert, idContract);

                    ///refresh data
                    this.edocbaseDataSet.AcceptChanges();
                    this.expertAssignmentTAdapter.Fill(this.edocbaseDataSet.ExpertAssignment);
                    this.assignedContractsTAdapter.Fill(this.edocbaseDataSet.AssignedContracts);

                    this.proposalsDataGridView.Refresh();
                    this.assignedContractsDataGridView.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Save Error");
                }

            }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            RefreshDatabase();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            RefreshDatabase();
        }
    }
}
