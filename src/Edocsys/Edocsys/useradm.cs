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
    public partial class UseradmForm : Form
    {
        public UseradmForm()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.edocbaseDataSet);

        }

        private void UseradmForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'edocbaseDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.edocbaseDataSet.users);
            // TODO: This line of code loads data into the 'edocbaseDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.edocbaseDataSet.users);

        }

        private void btnUseradd_Click(object sender, EventArgs e)
        {
            //usersTableAdapter.Useradd(loginTextBox.Text, psmgr.GetHashString(passwordTextBox.Text), Convert.ToInt32(typeTextBox.Text), log_databaseTextBox.Text);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //bool chkdatabaselog;
            //chkdatabaselog = (log_databaseTextBox.Text == "admin") || (log_databaseTextBox.Text == "direktor") || (log_databaseTextBox.Text == "expert");
            //if (chkdatabaselog)
            //{
            //    btnUseradd.Enabled = true;
            //}
            //else MessageBox.Show("Неверное имя пользователя в базе данных");
        }

        private void usersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.edocbaseDataSet);

        }
    }
}
