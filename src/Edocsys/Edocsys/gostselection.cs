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
    public partial class GOSTSelectionForm : Form
    {
        public GOSTSelectionForm()
        {
            InitializeComponent();
        }

        private ProposalForm callingForm = null;

        public GOSTSelectionForm(Form callingForm)
        {
            this.callingForm = callingForm as ProposalForm;
            InitializeComponent();
        }

        private void gostselection_Load(object sender, EventArgs e)
        {
            this.gOSTSelectionTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;

            textBoxProductionDocuments.Text = callingForm.ProductionDocuments;

            radioButtonGOST.Checked = !callingForm.UseTUIsteadGosts;
            radioButtonTU.Checked = callingForm.UseTUIsteadGosts;

            if (!HasGOSTsList(callingForm.currentContractID))
            {
                gOSTSelectionTableAdapter.ClearAll(callingForm.currentContractID);
                gOSTSelectionTableAdapter.FillAll(callingForm.currentContractID, callingForm.currentProductID);
            }

            this.gOSTSelectionTableAdapter.Fill(this.edocbaseDataSet.GOSTSelection, callingForm.currentProductID, callingForm.currentContractID);
        }

        private string GetGOSTsList(int contractID)
        {

            this.gOSTSelectionTableAdapter.FillByContract(this.edocbaseDataSet.GOSTSelection, contractID);

            string list = "ГОСТ ";
            foreach (DataRowView x in this.gOSTSelectionBindingSource)
            {
                if (x["using_gost"] != DBNull.Value)
                    if ((bool)x["using_gost"])
                        list += x["number"] + "; ";
            }

            list = list.TrimEnd("; ".ToCharArray());

            return list;
        }

        private bool HasGOSTsList(int contractID)
        {

            this.gOSTSelectionTableAdapter.FillByContract(this.edocbaseDataSet.GOSTSelection, contractID);

            return (this.gOSTSelectionBindingSource.Count > 0);
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.gOSTSelectionBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.edocbaseDataSet);

                this.edocbaseDataSet.AcceptChanges();

                callingForm.UseTUIsteadGosts = radioButtonTU.Checked;
                callingForm.ProductionDocuments = textBoxProductionDocuments.Text;

                if (radioButtonGOST.Checked)
                {
                    callingForm.GOSTsList = GetGOSTsList(callingForm.currentContractID);
                }
                else
                {
                    callingForm.GOSTsList = textBoxProductionDocuments.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save Error");
            }

            this.DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void radioButtonGOST_CheckedChanged(object sender, EventArgs e)
        {
            gOSTSelectionDataGridView.Enabled = ((RadioButton)sender).Checked;
            gOSTSelectionDataGridView.Visible = ((RadioButton)sender).Checked;
        }

        private void radioButtonTU_CheckedChanged(object sender, EventArgs e)
        {
            gOSTSelectionDataGridView.Enabled = !((RadioButton)sender).Checked;
            gOSTSelectionDataGridView.Visible = !((RadioButton)sender).Checked;
        }

        private void buttonRefreshGostList_Click(object sender, EventArgs e)
        {
            gOSTSelectionTableAdapter.ClearAll(callingForm.currentContractID);
            gOSTSelectionTableAdapter.FillAll(callingForm.currentContractID, callingForm.currentProductID);

            this.gOSTSelectionTableAdapter.Fill(this.edocbaseDataSet.GOSTSelection, callingForm.currentProductID, callingForm.currentContractID);
            this.gOSTSelectionDataGridView.Refresh();
        }
    }
}
