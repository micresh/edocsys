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

using Edocsys.Helpers;

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
                ActionButtonsSetPermission();
                HideLoginButtons();
            }
            else
            {
                ActionButtonsSetPermission();
                ShowLoginButtons();
            }
        }

        private void ActionButtonsSetPermission()
        {
            foreach (ToolStripItem item in mainToolStrip.Items)
            {
                if (item.Name.Length >= 3)
                    item.Enabled = ConnectionManager.CurrentUser.HasAccess(item.Name.Substring(3));
            }

            foreach (ToolStripMenuItem mainmenu in mainMenuStrip.Items)
            {
                if (mainmenu.Name.Length >= 3)
                    mainmenu.Enabled = ConnectionManager.CurrentUser.HasAccess(mainmenu.Name.Substring(3));

                foreach (ToolStripItem item in mainmenu.DropDownItems)
                {
                    if (item.Name.Length >= 3)
                       item.Enabled = ConnectionManager.CurrentUser.HasAccess(item.Name.Substring(3));
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
            TraceHelper.LogInfo("Current HOST is: " + TraceHelper.GetCurrentHost());
            TraceHelper.LogInfo("Current IP is: " + TraceHelper.GetCurrentIpAddress());

            int result = DBMigrationHelper.MigrateDB();
            TraceHelper.LogInfo("Migrating Database: " + result.ToString());

            //wmgr.CloseAllOpendWindows();
            ActionButtonsSetPermission();

            this.usersTableAdapter.Connection.ConnectionString = ConnectionManager.TestConnectionString;

            try
            {
                FillUsersToolStrip();
            }
            catch (MySqlException ex)
            {
                TraceHelper.LogWarning("MAINFORM: Ошибка подключения к базе данных" , ex, sender);

                //error to get users
                TSBFillUsers.Visible = true;
                HideLoginButtons();
                return;
            }

            //success users get
            TSBFillUsers.Visible = false;
            ActionButtonsSetPermission();

            ShowLoginButtons();
        }

        /// <summary>
        /// Throws MySqlException!!!!!
        /// </summary>
        private void FillUsersToolStrip()
        {
            this.usersTableAdapter.Fill(this.edocbaseDataSet.users);

            TMCUsersCBox.Items.Clear();

            //select active user
            foreach (DataRowView x in this.usersBindingSource)
            {
                string login = (x["login"]).ToString();
                if (login != "")
                    TMCUsersCBox.Items.Add(login);
            }

            if (TMCUsersCBox.Items.Count > 0)
                TMCUsersCBox.SelectedIndex = 0;
        }

        private void ShowLoginButtons()
        {
            //set visible login buttons
            TSBLogin.Visible = true;
            TMCUsersCBox.Visible = true;
            TSBLogout.Visible = false;
        }

        private void HideLoginButtons()
        {
            //set invisible login buttons
            TSBLogin.Visible = false;
            TMCUsersCBox.Visible = false;
            TSBLogout.Visible = true;
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

        private void fillUsersToolStripButton_Click(object sender, EventArgs e)
        {
            this.usersTableAdapter.Connection.ConnectionString = ConnectionManager.TestConnectionString;

            try
            {
                FillUsersToolStrip();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка подключения к базе данных");

                string type = "MAINFORM DB Connection Error";
                TraceHelper.LogError(type, ex, sender);

                //error to get users
                TSBFillUsers.Visible = true;
                HideLoginButtons();
                return;
            }

            //success users get
            TSBFillUsers.Visible = false;
            ShowLoginButtons();
        }

        private void loginToolStripButton_Click(object sender, EventArgs e)
        {
            wmgr.ShowLoginForm(TMCUsersCBox.Text);
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

            wmgr.CloseAllOpendWindows();

            ActionButtonsSetPermission();
            ShowLoginButtons();
        }

        private void TSMIScheme_Click(object sender, EventArgs e)
        {
            wmgr.ShowHelpForm();
        }

        private void TSMIAbout_Click(object sender, EventArgs e)
        {
            wmgr.ShowAboutForm();
        }

        private void TSMAgentTypes_Click(object sender, EventArgs e)
        {
            wmgr.ShowAgentTypesForm();
        }

        private void TMSSaveColumns_Click(object sender, EventArgs e)
        {
            DataGridViewColumnsSerializer.InitDataGridViewColumnsSerializer();
            DataGridViewColumnsSerializer.SerializeItems();
        }
    }
}
