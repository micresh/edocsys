using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

using MySql.Data.MySqlClient;


namespace Edocsys
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }



        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.edocbaseDataSet);

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Connection.ConnectionString = ConnectionManager.TestConnectionString;
            try
            {
                // TODO: This line of code loads data into the 'edocbaseDataSet.users' table. You can move, or remove it, as needed.
                this.usersTableAdapter.Fill(this.edocbaseDataSet.users);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка подключения к базе данных");
            }
        }


        private void btnlogin_Click(object sender, EventArgs e)
        {
            int i = usersComboBox.SelectedIndex;
            string pass = Convert.ToString( usersDataGridView.Rows[i].Cells[1].Value);

            string login = Convert.ToString(usersDataGridView.Rows[i].Cells[3].Value);

            label1.Text = login;

            if (psmgr.VerifyHash(passtxbox.Text,pass))
            {
                

                ConnectionManager.Login = login;
                ConnectionManager.Password = pass;

                try
                {
                    ConnectionManager.TestConnection();
                }
                catch
                {
                    MessageBox.Show("Не удалось выполнить подключение к базе данных");
                }

                MessageBox.Show("Вы успешно авторизованы");
                //close form after successful login
                this.Close();
            }
            else
                MessageBox.Show("Неверный пароль");
        }
    }
}
