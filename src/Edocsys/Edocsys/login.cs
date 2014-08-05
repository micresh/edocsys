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

        public string selectedLogin;

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Connection.ConnectionString = ConnectionManager.TestConnectionString;

            if (selectedLogin == null)
                selectedLogin = "";

            try
            {
                this.usersTableAdapter.Fill(this.edocbaseDataSet.users);

                //select active user
                int idx = usersComboBox.FindString(selectedLogin);
                usersComboBox.SelectedIndex = idx;

                selectedLogin = "";
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

            DataRowView currentRow = (DataRowView)usersBindingSource.Current;

            string login = Convert.ToString(currentRow["login"]);

            string pass = Convert.ToString(currentRow["password"]);
            int id = Convert.ToInt32(currentRow["id"]);
            string name = Convert.ToString(currentRow["lastname"]) + " " + Convert.ToString(currentRow["firstname"])[0] + ". " + 
                            Convert.ToString(currentRow["middlename"])[0] + ".";
            int type = Convert.ToInt32(currentRow["user_types_id"]);

            if (User.VerifyHash(passtxbox.Text, pass))
            {
                //verify database connection with new users
                try
                {
                    ConnectionManager.TestConnection();
                }
                catch
                {
                    MessageBox.Show("Не удалось выполнить подключение к базе данных");
                }

                ConnectionManager.CurrentUser.UserID = id;
                ConnectionManager.CurrentUser.Name = name;
                ConnectionManager.CurrentUser.UserType = type;

//#if DEBUG
//                MessageBox.Show("Вы успешно авторизованы");
//#endif


                //close form after successful login
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный пароль");
                ConnectionManager.CurrentUser.Name = "";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            selectedLogin = "";
            this.Close();
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            passtxbox.Focus();
        }
    }
}
