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

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Connection.ConnectionString = ConnectionManager.TestConnectionString;

            try
            {
                this.usersTableAdapter.Fill(this.edocbaseDataSet.users);

                //select active user
                for (int i = 0; i < this.edocbaseDataSet.Tables["users"].DefaultView.Count; i++)
                {
                    string login = this.edocbaseDataSet.Tables["users"].DefaultView[i].Row["login"].ToString();
                    if (login == ConnectionManager.CurrentUser)
                    {
                        usersComboBox.SelectedIndex = i;
                        break;
                    }
                }

                ConnectionManager.CurrentUser = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка подключения к базе данных");
            }
        }


        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (usersBindingSource.Position < 0)
            {
                MessageBox.Show("Не выбран пользователь?", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            DataRow currentRow = edocbaseDataSet.Tables["Users"].DefaultView[usersBindingSource.Position].Row;

            string login = Convert.ToString(currentRow["login"]);

            string pass = Convert.ToString(currentRow["password"]);

            if (psmgr.VerifyHash(passtxbox.Text, pass))
            {
                ConnectionManager.Login = login;
                ConnectionManager.Password = pass;

                //verify database connection with new users
                try
                {
                    ConnectionManager.TestConnection();
                }
                catch
                {
                    MessageBox.Show("Не удалось выполнить подключение к базе данных");
                }

#if DEBUG
                MessageBox.Show("Вы успешно авторизованы");
#endif


                ConnectionManager.CurrentUser = login;
                //close form after successful login
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный пароль");
                ConnectionManager.CurrentUser = "";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ConnectionManager.CurrentUser = "";
            this.Close();
        }
    }
}
