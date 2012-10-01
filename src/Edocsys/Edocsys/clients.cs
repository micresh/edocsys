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
    public partial class ClientsForm : Form
    {
        public ClientsForm()
        {
            InitializeComponent();
        }

        private void agentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.agentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.edocbaseDataSet);

        }

        private void clients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'edocbaseDataSet.Agents' table. You can move, or remove it, as needed.
            this.agentsTableAdapter.Fill(this.edocbaseDataSet.Agents);

        }
    }
}
