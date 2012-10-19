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
            

            //set server textbox to default address
            servtxbox.Text = global::Edocsys.Properties.Settings.Default.ConnHost + ":" +global::Edocsys.Properties.Settings.Default.ConnPort;
        }


        private void btnlogin_Click(object sender, EventArgs e)
        {
            int i = usersComboBox.SelectedIndex;
            string pass = Convert.ToString( usersDataGridView.Rows[i].Cells[1].Value);

            string login = Convert.ToString(usersDataGridView.Rows[i].Cells[3].Value);

            label1.Text = login;

            if (psmgr.VerifyHash(passtxbox.Text,pass))
            {
                MessageBox.Show("Вы успешно авторизованы");
                ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;


                //make connection string
                MySqlConnectionStringBuilder connString = new MySqlConnectionStringBuilder();

                connString["Data Source"] = "";

                connString["Server"] = global::Edocsys.Properties.Settings.Default.ConnHost;
                connString["Port"] = global::Edocsys.Properties.Settings.Default.ConnPort;

                connString["User ID"] = login;
                //?????????? connString["Password"] = passtxbox.Text;
                connString["Password"] = "wepo23nri_)(*";

                connString["Persist Security Info"] = true;
                connString["Character Set"] = "utf8";

                connString["Database"] = global::Edocsys.Properties.Settings.Default.ConnDatabase;

                Edocsys.Program.Data.constr = connString.ConnectionString;

                //close form after successful login
                this.Close();
            }
            else
                MessageBox.Show("Неверный пароль");
        }

        private void btnCheckserv_Click(object sender, EventArgs e)
        {
            // here we're trying connecting to database
            if (psmgr.OpenDbConn(servtxbox.Text))
            {
                MessageBox.Show("Connection ok");
                btnlogin.Enabled = true;
                this.usersTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
                try
                {
                    // TODO: This line of code loads data into the 'edocbaseDataSet.users' table. You can move, or remove it, as needed.
                    this.usersTableAdapter.Fill(this.edocbaseDataSet.users);
                }
                catch (Exception)
                {
                    MessageBox.Show("Нет подключения к базе данных");
                }
            }
            else MessageBox.Show("Не удалось выполнить подключение к базе данных");
            //DEBUG btnlogin.Enabled = true;
        }
    }
}
