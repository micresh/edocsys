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
    public partial class gostselection : Form
    {
        public gostselection()
        {
            InitializeComponent();
        }

        private void selected_gostsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.selected_gostsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.edocbaseDataSet);

        }

        private void gostselection_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'edocbaseDataSet.selected_gosts' table. You can move, or remove it, as needed.
            this.selected_gostsTableAdapter.Fill(this.edocbaseDataSet.selected_gosts);

        }
    }
}
