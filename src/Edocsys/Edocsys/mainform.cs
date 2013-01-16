using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


using MySql.Data.MySqlClient;

using System.Diagnostics;

namespace Edocsys
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            wmgr.SetMDIParent(this);

            //set trace information logger 
            Debug.Listeners.Add(new TextWriterTraceListener(global::Edocsys.Properties.Settings.Default.LogFilename));
            Trace.Listeners.Add(new TextWriterTraceListener(global::Edocsys.Properties.Settings.Default.LogFilename));
        }

        private void LoginToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           wmgr.ShowLoginForm();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void proposalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wmgr.ShowProporsalForm();
        }

        private void AdmpanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wmgr.ShowUseradmForm();
        }

        private void ProductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wmgr.ShowProductionForm();
        }

        private void ContractorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wmgr.ShowClientsForm();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Connection.ConnectionString = ConnectionManager.TestConnectionString;

            try
            {
                FillUsersToolStrip();
            }
            catch (MySqlException ex)
            {
                Trace.TraceWarning("MAINFORM: Ошибка подключения к базе данных. " + ex.Message);

                //error to get users
                fillUsersToolStripButton.Visible = true;
                HideLoginButtons();
                return;
            }

            //success users get
            fillUsersToolStripButton.Visible = false;
            ShowLoginButtons();
        }

        /// <summary>
        /// Throws MySqlException!!!!!
        /// </summary>
        private void FillUsersToolStrip()
        {
            this.usersTableAdapter.Fill(this.edocbaseDataSet.users);

            for (int i = 0; i < this.edocbaseDataSet.Tables["users"].DefaultView.Count; i++)
            {
                string login = this.edocbaseDataSet.Tables["users"].DefaultView[i].Row["login"].ToString();
                usersToolStripComboBox.Items.Add(login);
            }

            if (usersToolStripComboBox.Items.Count > 0)
                usersToolStripComboBox.SelectedIndex = 0;
        }

        private void ShowLoginButtons()
        {
            //set visible login buttons
            loginToolStripButton.Visible = true;
            usersToolStripComboBox.Visible = true;
        }

        private void HideLoginButtons()
        {
            //set invisible login buttons
            loginToolStripButton.Visible = false;
            usersToolStripComboBox.Visible = false;
        }

        private void AssignexpertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wmgr.ShowAssignexpertForm();
        }

        private void ExpertsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wmgr.ShowExpertsForm();
        }

        private void configFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wmgr.ShowConfigForm();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //save debug information
            Trace.Flush();
            Debug.Flush();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.edocbaseDataSet);

        }

        private void fillUsersToolStripButton_Click(object sender, EventArgs e)
        {
            this.usersTableAdapter.Connection.ConnectionString = ConnectionManager.TestConnectionString;

            try
            {
                FillUsersToolStrip();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Ошибка подключения к базе данных");

                //error to get users
                fillUsersToolStripButton.Visible = true;
                HideLoginButtons();
                return;
            }

            //success users get
            fillUsersToolStripButton.Visible = false;
            ShowLoginButtons();
        }

        private void loginToolStripButton_Click(object sender, EventArgs e)
        {
            ConnectionManager.CurrentUser = usersToolStripComboBox.SelectedItem.ToString();
            wmgr.ShowLoginForm();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            cueerntUserToolStripStatusLabel.Text = "Пользователь: " + ConnectionManager.CurrentUser;
        }

        private void ContractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wmgr.ShowContractsForm();
        }
    }
}
