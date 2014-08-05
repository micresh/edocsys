using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Edocsys.Helpers;

namespace Edocsys
{
    public partial class AssignExpertForm : Form
    {
        public AssignExpertForm()
        {
            InitializeComponent();
        }

        private FilterHelper assignedFilter, proposalsFilter;
        private DataGridViewFooterDecorator fdAssignedContractsDataGridView;

        private DataGridViewColumnsSerializer dgvcs_ea;
        private DataGridViewColumnsSerializer dgvcs_ac;

        private void AssignExpertForm_Load(object sender, EventArgs e)
        {
            this.contract_statusTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.expertsTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;

            this.expertAssignmentTAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.assignedContractsTAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;

            this.contract_statusTableAdapter.Fill(this.edocbaseDataSet.contract_status);

            RefreshDatabase();

            //Add column serializers
            dgvcs_ea = new DataGridViewColumnsSerializer(this, this.expertAssignmentDataGridView);
            dgvcs_ac = new DataGridViewColumnsSerializer(this, this.assignedContractsDataGridView);

            //add filters
            proposalsFilter = new FilterHelper(expertAssignmentDataGridView, filterProposalsToolStripTextBox.TextBox);
            assignedFilter = new FilterHelper(assignedContractsDataGridView, filterAssignedToolStripTextBox.TextBox);
            

            //performance tuning
            DataGridViewHelper.DoubleBuffered(assignedContractsDataGridView, true);
            
            //Add decorators
            fdAssignedContractsDataGridView = new DataGridViewFooterDecorator(assignedContractsDataGridView, new List<ColumnHandler>()
                        {
                            new ColumnHandler (DataGridViewFooterDecorator.StaticText, "products_name", "ИТОГО", null),
                            new ColumnHandler (DataGridViewFooterDecorator.Sum, "prepayment", null, assignedContractsDataGridView),
                            new ColumnHandler (DataGridViewFooterDecorator.Sum, "total_cost", null, assignedContractsDataGridView),
                        }
                );
        }

        private void RefreshDatabase()
        {
            RefreshContractsToAssign();
            RefreshAssignedContracts();
        }

        private void RefreshAssignedContracts()
        {
            int pos = assignedContractsBindingSource.Position;

            AssignedExpertsFill();

            assignedContractsBindingSource.Position = pos;

            this.assignedContractsDataGridView.Refresh();
        }

        private void RefreshContractsToAssign()
        {
            int pos = expertAssignmentBindingSource.Position;

            this.expertAssignmentTAdapter.Fill(this.edocbaseDataSet.ExpertAssignment);
            this.expertsTableAdapter.Fill(this.edocbaseDataSet.experts);

            expertAssignmentBindingSource.Position = pos;

            this.expertAssignmentDataGridView.Refresh();
        }

        private void AssignedExpertsFill()
        {
            bool dont_filter_experts = true;
            int expert_id = 0;
            if (checkBoxExpertsFilter.Checked)
            {
                dont_filter_experts = false;
                expert_id = Convert.ToInt32(fullnameComboBox.SelectedValue);
            }

            bool dont_filter_status = true;
            int status_id = 0;
            if (checkBoxStatuses.Checked)
            {
                dont_filter_status = false;
                status_id = Convert.ToInt32(nameComboBox.SelectedValue);
            }

            this.assignedContractsTAdapter.Fill(this.edocbaseDataSet.AssignedContracts, dont_filter_experts, expert_id, dont_filter_status, status_id);
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

                    //refresh data

                    SaveDatabase();

                    RefreshDatabase();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Save Error");
                }
            }
        }

        private void SaveDatabase()
        {
            this.edocbaseDataSet.AcceptChanges();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            RefreshContractsToAssign();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            RefreshAssignedContracts();
        }

        private void checkBoxExpertsFilter_CheckedChanged(object sender, EventArgs e)
        {
            fullnameComboBox.Enabled = ((CheckBox)sender).Checked;
            RefreshAssignedContracts();
        }

        private void checkBoxStatuses_CheckedChanged(object sender, EventArgs e)
        {
            nameComboBox.Enabled = ((CheckBox)sender).Checked;
            RefreshAssignedContracts();
        }

        private void fullnameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshAssignedContracts();
        }

        private void nameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshAssignedContracts();
        }

        private void assignedContractsDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {
                DataGridView s = sender as DataGridView;

                DataGridViewHelper.HighlightStandartStats(s, e.RowIndex);
            }
        }

        private void AssignExpertForm_Activated(object sender, EventArgs e)
        {
            RefreshDatabase();
        }

        private void tabControlAssignExpert_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDatabase();
        }

        private void AssignExpertForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // TODO: (Workaround) Fix bug with Exception while destroying grids:
            // FooterGrid try to access to MainGrid but some of it's columns are
            // already empty and causes Exception generation
            //
            // See more:
            // http://www.sql.ru/forum/511919/magiya
            // http://stackoverflow.com/questions/4494147/windows-form-application-exception
            // http://stackoverflow.com/questions/1435526/datagridview-object-databinding-issue-index-1-does-not-have-a-value

            assignedContractsDataGridView.DataSource = null;
        }
    }
}
