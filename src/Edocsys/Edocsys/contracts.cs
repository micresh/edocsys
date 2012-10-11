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
    public partial class ContractsForm : Form
    {
        public ContractsForm()
        {
            InitializeComponent();
        }

        private void contractsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contractsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.edocbaseDataSet);

        }

        private void ContractsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'edocbaseDataSet.Contracts' table. You can move, or remove it, as needed.
            this.contractsTableAdapter.Fill(this.edocbaseDataSet.Contracts);

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void contractsBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
