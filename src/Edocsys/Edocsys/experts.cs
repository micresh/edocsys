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

        private FilterHelper filter;

        private void expertsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {

                this.Validate();
                this.expertsBindingSource.EndEdit();
                this.expertsTableAdapter.Update(this.edocbaseDataSet.experts);

                this.edocbaseDataSet.AcceptChanges();
                this.expertsTableAdapter.Fill(this.edocbaseDataSet.experts);
                this.expertsDataGridView.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save Error");
            }
        }

        private void ExpertsForm_Load(object sender, EventArgs e)
        {
            filter = new FilterHelper(this.expertsDataGridView, FilterTextBox.TextBox);
            this.expertsTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;

            
            this.expertsTableAdapter.Fill(this.edocbaseDataSet.experts);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            DataRowView row = ((DataRowView)this.expertsBindingSource.Current);
            row["user_types_id"] = (int)Constants.UserTypes.Expert;
        }
    }
}
