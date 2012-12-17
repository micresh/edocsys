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

        private void AssignExpertForm_Load(object sender, EventArgs e)
        {
            this.expertsTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.expertAssignmentDataTableTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.assignedContractsDataTableTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.contractsTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;


            this.expertsTableAdapter.Fill(this.edocbaseDataSet.Experts);
            this.expertAssignmentDataTableTableAdapter.Fill(this.edocbaseDataSet.ExpertAssignmentDataTable);
            this.assignedContractsDataTableTableAdapter.Fill(this.edocbaseDataSet.AssignedContractsDataTable);
            this.contractsTableAdapter.Fill(this.edocbaseDataSet.Contracts);
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

                DataRow currentRow = edocbaseDataSet.Tables["ExpertAssignmentDataTable"].DefaultView[expertAssignmentBindingSource.Position].Row;

                int idContract = Convert.ToInt32(currentRow["idContract"]);
                int idExpert = Convert.ToInt32(expertsListBox.SelectedValue);

                try
                {
                    //assign expert
                    this.contractsTableAdapter.AssignExpert(Constants.ContractStatuses.ExpertAssigned, idExpert, idContract);

                    //refresh data
                    this.edocbaseDataSet.AcceptChanges();
                    this.expertAssignmentDataTableTableAdapter.Fill(this.edocbaseDataSet.ExpertAssignmentDataTable);
                    this.assignedContractsDataTableTableAdapter.Fill(this.edocbaseDataSet.AssignedContractsDataTable);

                    this.contractsDataGridView.Refresh();
                    this.assignedContractsDataGridView.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Save Error");
                }

            }
        }
    }
}
