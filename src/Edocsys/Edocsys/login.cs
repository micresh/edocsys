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




namespace Edocsys
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

 
        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
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

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string pass;
            int i;
            i = comboBox1.SelectedIndex;
            pass = Convert.ToString( usersDataGridView.Rows[i].Cells[1].Value);
            label1.Text = Convert.ToString(usersDataGridView.Rows[i].Cells[3].Value);
            if (psmgr.VerifyHash(passtxbox.Text,pass))
            {
                MessageBox.Show("Вы успешно авторизованы");
                ConnectionStringSettingsCollection settings = 
            ConfigurationManager.ConnectionStrings;
                Edocsys.Program.Data.constr = "server=10.0.2.2;UserID=" + Convert.ToString(usersDataGridView.Rows[i].Cells[3].Value) + ";password=wepo23nri_)(*;database=Edocbase";
                
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
                
                
                //this.usersTableAdapter.Connection.ConnectionString = Edocsys.Program.Data.constr;

            }
            else MessageBox.Show("Неверный пароль");
            
        }

        private void btnCheckserv_Click(object sender, EventArgs e)
        {
            int i;
            i = comboBox1.SelectedIndex;
            // here we're trying to connect to database

            if (psmgr.OpenDbConn(Convert.ToString(usersDataGridView.Rows[i].Cells[3].Value),servtxbox.Text))
            {
                MessageBox.Show("dhsgf");
                btnlogin.Enabled = true;
            }
        }

        private void passtxbox_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
