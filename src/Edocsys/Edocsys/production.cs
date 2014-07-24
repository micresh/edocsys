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

        private FilterHelper filterProduct;

        private void ProductionForm_Load(object sender, EventArgs e)
        {
            this.product_areasTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.product_gostsTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.productsTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;


            RefreshDatabase();


            filterProduct = new FilterHelper(productsDataGridView, filterProductsTextBox.TextBox);
        }

        private void RefreshDatabase()
        {
            this.product_areasTableAdapter.Fill(this.edocbaseDataSet.product_areas);
            this.product_gostsTableAdapter.Fill(this.edocbaseDataSet.product_gosts);
            this.productsTableAdapter.Fill(this.edocbaseDataSet.products);
        }


        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveProducts();

            RefreshDatabase();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.productsBindingSource.AddNew();

            DataRowView currentProduct = (DataRowView)this.productsBindingSource.Current;

            DataRow currentRow = edocbaseDataSet.product_areas.DefaultView[product_areasBindingSource.Position].Row;

            int idArea = Convert.ToInt32(currentRow["id"]);

            currentProduct["product_areas_id"] = idArea;
        }

        private void productsBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if ((productsBindingSource.Position >= 0)
                && (edocbaseDataSet.products.DefaultView.Count > productsBindingSource.Position))
            {

                DataRowView currentRow = (DataRowView)productsBindingSource.Current;

                string agent = String.Format("Продукция: {0}", Convert.ToString(currentRow["name"]));

                toolStripLabelProduct.Text = agent;
            }
        }

        private void bindingNavigatorAddNewItem1_Click(object sender, EventArgs e)
        {
            int pos = productsBindingSource.Position;
            SaveProducts();
            productsBindingSource.Position = pos;

            this.product_gostsBindingSource.AddNew();

            DataRowView currentGOST = (DataRowView)this.product_gostsBindingSource.Current;

            DataRowView currentRow = (DataRowView)productsBindingSource.Current;

            int idProduct = Convert.ToInt32(currentRow["id"]);

            currentGOST["products_id"] = idProduct;

            product_gostsDataGridView.Focus();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SaveProducts();

            RefreshDatabase();
        }

        private void SaveProducts()
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.product_gostsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.edocbaseDataSet);
            this.edocbaseDataSet.AcceptChanges();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            RefreshDatabase();
        }

        private void ProductionForm_Activated(object sender, EventArgs e)
        {
            RefreshDatabase();
        }
    }
}
