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
            
        }

        private void ProductionForm_Load(object sender, EventArgs e)
        {
            this.product_areasTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.product_gostsTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.productsTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            // TODO: This line of code loads data into the 'edocbaseDataSet.product_areas' table. You can move, or remove it, as needed.
            this.product_areasTableAdapter.Fill(this.edocbaseDataSet.product_areas);
            // TODO: This line of code loads data into the 'edocbaseDataSet.product_gosts' table. You can move, or remove it, as needed.
           // this.product_gostsTableAdapter.Fill(this.edocbaseDataSet.product_gosts);
            // TODO: This line of code loads data into the 'edocbaseDataSet.products' table. You can move, or remove it, as needed.
         //   this.productsTableAdapter.Fill(this.edocbaseDataSet.products);
            //this.prodGostTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            //// TODO: This line of code loads data into the 'edocbaseDataSet.ProdGost' table. You can move, or remove it, as needed.
            //this.prodGostTableAdapter.Fill(this.edocbaseDataSet.ProdGost);
            //// TODO: This line of code loads data into the 'edocbaseDataSet.Products' table. You can move, or remove it, as needed.
            //this.productsTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
                        
            //this.productsTableAdapter.Fill(this.edocbaseDataSet.Products);
        }

        private void productsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
                            
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {

        }

        private void productsBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            
        }

        private void productsBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.edocbaseDataSet);

        }

        private void productsBindingNavigatorSaveItem_Click_4(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.edocbaseDataSet);

        }

        private void nameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (nameComboBox.SelectedIndex)
            {
                case 0:
                    this.productsDataGridView.ClearSelection();
                    this.productsTableAdapter.FillBySertification(this.edocbaseDataSet.products);
                    this.product_gostsTableAdapter.Fill(this.edocbaseDataSet.product_gosts);
                    break;
                case 1:
                    this.productsDataGridView.ClearSelection();
                    this.productsTableAdapter.FillByLabIssl(this.edocbaseDataSet.products);
                    this.product_gostsTableAdapter.Fill(this.edocbaseDataSet.product_gosts);
                    break;
            }

        }
    }
}
