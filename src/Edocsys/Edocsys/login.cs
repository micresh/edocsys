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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            formcount = true;
        }
        public static bool formcount = false;

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            formcount = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.edocbaseDataSet);

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'edocbaseDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.edocbaseDataSet.users);

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string pass;
            int i;
            i = comboBox1.SelectedIndex;
            pass = Convert.ToString( usersDataGridView.Rows[i].Cells[1].Value);
            if (psmgr.VerifyHash(textBox1.Text,pass))
            {
                MessageBox.Show("Вы успешно авторизованы");
            }
            else MessageBox.Show("Неверный пароль");
        }

    }
}
