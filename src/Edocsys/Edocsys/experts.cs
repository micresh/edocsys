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
            this.Validate();
            this.expertsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.edocbaseDataSet);

        }

        private void ExpertsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'edocbaseDataSet.Experts' table. You can move, or remove it, as needed.
            this.expertsTableAdapter.Fill(this.edocbaseDataSet.Experts);

        }

        private void expertsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         }

        private void edocbaseDataSet_Initialized(object sender, EventArgs e)
        {

        }
    }
}
