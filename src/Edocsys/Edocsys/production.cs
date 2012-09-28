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
    public partial class ProductionForm : Form
    {
        public ProductionForm()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.edocbaseDataSet);

        }

        private void ProductionForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'edocbaseDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.edocbaseDataSet.Products);
            // TODO: This line of code loads data into the 'edocbaseDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.edocbaseDataSet.Products);

        }

        private void productsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.edocbaseDataSet);

        }
    }
}
