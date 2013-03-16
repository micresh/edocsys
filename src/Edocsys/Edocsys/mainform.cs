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

namespace Edocsys
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            wmgr.SetMDIParent(this);
        }

        private void LoginToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            wmgr.ShowLoginForm("");
            UpdateLoginControls();
        }

        private void UpdateLoginControls()
        {
            if (ConnectionManager.CurrentUser.UserID > 0)
            {
                HideLoginButtons();

                EnableActionButtons(true);
            }
            else
            {
                ShowLoginButtons();
                EnableActionButtons(false);
            }
        }

        private void EnableActionButtons(bool isEnabled)
        {
            //menus
            this.DocToolStripMenuItem.Enabled = isEnabled;
            this.AdmToolStripMenuItem.Enabled = isEnabled;

            //toolstrip
            for (int i = 0; i < mainToolStrip.Items.Count; ++i)
            {
                if ((mainToolStrip.Items[i].Name != "fillUsersToolStripButton")
                    &&
                    (mainToolStrip.Items[i].Name != "usersToolStripComboBox")
                    &&
                    (mainToolStrip.Items[i].Name != "loginToolStripButton"))
                {
                    mainToolStrip.Items[i].Enabled = isEnabled;
                }
                else
                {
                    mainToolStrip.Items[i].Enabled = !isEnabled;
                }
            }
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
            TraceHelper.LogInfo("------------------------- STRAT PROGRAM");

            this.usersTableAdapter.Connection.ConnectionString = ConnectionManager.TestConnectionString;

            try
            {
                FillUsersToolStrip();
            }
            catch (MySqlException ex)
            {
                TraceHelper.LogWarning("MAINFORM: Ошибка подключения к базе данных" , ex);

                //error to get users
                fillUsersToolStripButton.Visible = true;
                HideLoginButtons();
                return;
            }

            //success users get
            fillUsersToolStripButton.Visible = false;
            ShowLoginButtons();
            EnableActionButtons(false);
        }

        /// <summary>
        /// Throws MySqlException!!!!!
        /// </summary>
        private void FillUsersToolStrip()
        {
            this.usersTableAdapter.Fill(this.edocbaseDataSet.users);

            //select active user
            foreach (DataRowView x in this.usersBindingSource)
            {
                string login = (x["login"]).ToString();
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
            TraceHelper.LogInfo("------------------------- END PROGRAM");
            //save debug information
            TraceHelper.Flush();
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
            wmgr.ShowLoginForm(usersToolStripComboBox.Text);
            UpdateLoginControls();
            this.Activate();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            curentUserToolStripStatusLabel.Text = "Пользователь: " + ConnectionManager.CurrentUser.Name;
        }

        private void ContractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wmgr.ShowContractsForm();
        }

        private void docTemplatesFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wmgr.ShowDocTemplatesForm();
        }

        private void ExpertAssignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wmgr.ShowAssignexpertForm();
        }

        private void AgentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wmgr.ShowClientsForm();
        }

        private void WorksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wmgr.ShowWorksForContractForm();
        }

        private void ContractPaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wmgr.ShowContractPaymentsForm();
        }

        private void InspectionControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wmgr.ShowInspectionControlForm();
        }

        private void ContractStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wmgr.ShowContractStatsForm();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectionManager.ResetToDefaults();

            EnableActionButtons(false);
            ShowLoginButtons();
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wmgr.ShowHelpForm();
        }
    }
}
