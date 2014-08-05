using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Edocsys.Helpers;

namespace Edocsys
{
    public partial class ExpertsForm : Form
    {
        public ExpertsForm()
        {
            InitializeComponent();
        }

        private FilterHelper filter;
        private DataGridViewColumnsSerializer dgvcs_e;

        private void ExpertsForm_Load(object sender, EventArgs e)
        {
            this.expertsTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;

            this.expertsTableAdapter.Fill(this.edocbaseDataSet.experts);

            filter = new FilterHelper(this.expertsDataGridView, FilterTextBox.TextBox);
            dgvcs_e = new DataGridViewColumnsSerializer(this, this.expertsDataGridView);

        }

        private void expertsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveExperts();
            RefreshDatabase();
        }

        private void SaveExperts()
        {
            try
            {
                this.Validate();
                this.expertsBindingSource.EndEdit();
                this.expertsTableAdapter.Update(this.edocbaseDataSet.experts);

                this.edocbaseDataSet.AcceptChanges();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {

                if (ex.Number == (int)MySql.Data.MySqlClient.MySqlErrorCode.RowIsReferenced2)
                {
                    string msg = "Невозможно удалить эксперта";

                    string title = "Ошибка удаления";
                    string type = "Delete constrain ERROR";
                    TraceHelper.LogError(type, ex, this);
                    MessageBox.Show(msg, title);
                }
                else
                {
                    throw;
                }

            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                string title = "Save ERROR";
                string type = "Save ERROR";
                TraceHelper.LogError(type, ex, this);
                MessageBox.Show(msg, title);
            }
        }

        private void RefreshDatabase()
        {
            try
            {
                int pos = expertsBindingSource.Position;
                this.expertsTableAdapter.Fill(this.edocbaseDataSet.experts);
                expertsBindingSource.Position = pos;
                this.expertsDataGridView.Refresh();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                string title = "Refresh ERROR";
                string type = "Refresh ERROR";
                TraceHelper.LogError(type, ex, this);
                MessageBox.Show(msg, title);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            DataRowView row = ((DataRowView)this.expertsBindingSource.Current);
            row["user_types_id"] = (int)Constants.UserTypes.Expert;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if ((expertsBindingSource.Position < 0) ||
                (expertsBindingSource.Position >= expertsBindingSource.Count))
            {
                return;
            }

            DataRowView currentRow = (DataRowView)expertsBindingSource.Current;

            //int id = Convert.ToInt32(currentRow["id"]);
            string fullname = Convert.ToString(currentRow["fullname"]);


            if (MessageBox.Show("Удалить эксперта " + fullname , "Подтвердить удаление эксперта", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                expertsBindingSource.RemoveCurrent();
                SaveExperts();
                RefreshDatabase();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            RefreshDatabase();
        }
    }
}
