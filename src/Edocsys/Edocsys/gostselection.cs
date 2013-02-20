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

        private ProposalForm mainForm = null;

        public GOSTSelectionForm(Form callingForm)
        {
            mainForm = callingForm as ProposalForm;
            InitializeComponent();
        }

        private void gostselection_Load(object sender, EventArgs e)
        {
            this.gOSTSelectionTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;

            this.gOSTSelectionTableAdapter.Fill(this.edocbaseDataSet.GOSTSelection, mainForm.currentProductID, mainForm.currentContractID);
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.gOSTSelectionBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.edocbaseDataSet);

                this.edocbaseDataSet.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save Error");
            }

            this.gOSTSelectionTableAdapter.Fill(this.edocbaseDataSet.GOSTSelection, mainForm.currentProductID, mainForm.currentContractID);
            this.gOSTSelectionDataGridView.Refresh();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            //this.DialogResult = DialogResult.Cancel;
        }
    }
}
