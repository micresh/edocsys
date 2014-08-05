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
    public partial class UseradmForm : Form
    {
        public UseradmForm()
        {
            InitializeComponent();
        }

        private DataGridViewColumnsSerializer dgvcs_u;

        private void UseradmForm_Load(object sender, EventArgs e)
        {
            this.user_typesTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.usersTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;

            this.user_typesTableAdapter.Fill(this.edocbaseDataSet.user_types);
            this.usersTableAdapter.Fill(this.edocbaseDataSet.users);

            //Add column serializers
            dgvcs_u = new DataGridViewColumnsSerializer(this, this.usersDataGridView);
        }


        public string password;


        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveUser();
        }

        private void SaveUser()
        {
            try
            {
                this.Validate();
                this.usersBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.edocbaseDataSet);
                this.edocbaseDataSet.AcceptChanges();
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

        private void RefreshData()
        {
            try
            {
                int pos = usersBindingSource.Position;

                this.usersTableAdapter.Fill(this.edocbaseDataSet.users);

                usersBindingSource.Position = pos;

                this.usersDataGridView.Refresh();
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

        private void usersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView s = (DataGridView)sender;
            BindingSource bs = (BindingSource)s.DataSource;

            if (e.ColumnIndex == (s.Columns["SetPasswordButton"].Index))
            {
                if (bs.Position >= 0)
                {
                    DataRowView currentRow = (DataRowView)bs.Current;
                    int id = Convert.ToInt32(currentRow["id"]);

                    int pos = bs.Position;

                    if ((int)(currentRow["id"]) < 0)
                    {
                        //not saved => save
                        SaveUser();
                        RefreshData();
                    }

                    this.password = "";

                    SetPasswordForm pwdf = new SetPasswordForm(this);

                    if (pwdf.ShowDialog() == DialogResult.OK)
                    {
                        if (this.password != "")
                        {
                            currentRow["password"] = User.GetHash(this.password);
                            SaveUser();
                            RefreshData();
                        }
                        else
                        {
                            MessageBox.Show("Пароль не может быть пустым", "Ошибка");
                        }
                    }
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
