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
    public partial class ExpertsForm : Form
    {
        public ExpertsForm()
        {
            InitializeComponent();
        }

        private void expertsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {

                //this.Validate();
                //this.expertsBindingSource.EndEdit();
                //this.tableAdapterManager.UpdateAll(this.edocbaseDataSet);

                //this.edocbaseDataSet.AcceptChanges();
                //this.expertsTableAdapter.Fill(this.edocbaseDataSet.Experts);
                //this.expertsDataGridView.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save Error");
            }
        }

        private void ExpertsForm_Load(object sender, EventArgs e)
        {

            //this.expertsTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;

            //// TODO: This line of code loads data into the 'edocbaseDataSet.Experts' table. You can move, or remove it, as needed.
            //this.expertsTableAdapter.Fill(this.edocbaseDataSet.Experts);

        }
    }
}
