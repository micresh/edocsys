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

            try
            {

                this.Validate();
                this.agentsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.edocbaseDataSet);

                this.edocbaseDataSet.AcceptChanges();
                this.agentsTableAdapter.FillWithShortName(this.edocbaseDataSet.Agents);
                this.agentsDataGridView.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save Error");
            }
        }

        private void clients_Load(object sender, EventArgs e)
        {
            this.agentsTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;

            // TODO: This line of code loads data into the 'edocbaseDataSet.Agents' table. You can move, or remove it, as needed.
            this.agentsTableAdapter.FillWithShortName(this.edocbaseDataSet.Agents);
        }

    }
}
