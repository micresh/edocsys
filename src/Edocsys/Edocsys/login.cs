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
            try
            {
                // TODO: This line of code loads data into the 'edocbaseDataSet.users' table. You can move, or remove it, as needed.
                this.usersTableAdapter.Fill(this.edocbaseDataSet.users);
            }
            catch (Exception)
            {

                MessageBox.Show("Нет подключения к базе данных");
            }

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

                connString["Host"] = global::Edocsys.Properties.Settings.Default.ConnHost;
                connString["Port"] = global::Edocsys.Properties.Settings.Default.ConnPort;

                connString["UserID"] = login;
                //?????????? connString["Password"] = passtxbox.Text;
                connString["Password"] = "wepo23nri_)(*";

                connString["Persist Security Info"] = true;
                connString["Character Set"] = "utf8";

                connString["Database"] = global::Edocsys.Properties.Settings.Default.ConnDatabase;



                Edocsys.Program.Data.constr = connString.ConnectionString;

                //save new connection string
                if (settings != null)
                {
                    foreach (ConnectionStringSettings cs in settings)
                    {
                        if (cs.Name == "Edocsys.Properties.Settings.EdocbaseConnectionString")
                        {
                            ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap();
                            fileMap.ExeConfigFilename = @"edocsys.exe.config";

                            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);

                            config.ConnectionStrings.ConnectionStrings[1].ConnectionString = Edocsys.Program.Data.constr;
                            config.SectionGroups.Clear();
                            config.Save(ConfigurationSaveMode.Modified);
                        }
                    }
                }

                //close form after successful login
                this.Close();
            }
            else
                MessageBox.Show("Неверный пароль");
        }

        private void btnCheckserv_Click(object sender, EventArgs e)
        {
            int i = usersComboBox.SelectedIndex;

            string login = Convert.ToString(usersDataGridView.Rows[i].Cells[3].Value);

            // here we're trying to connect to database
            if (psmgr.OpenDbConn(login, servtxbox.Text))
            {
                MessageBox.Show("Connection ok");
                btnlogin.Enabled = true;
            }
            //DEBUG btnlogin.Enabled = true;
        }
    }
}
