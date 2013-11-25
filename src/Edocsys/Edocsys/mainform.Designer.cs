namespace Edocsys
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.TSMFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMExit = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMWorkMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAgents = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMProposals = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAssignExpert = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMContracts = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMWorkForContracts = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMContractPayments = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMInspectionControl = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMContractStats = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAdminMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMUserAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMExperts = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMDocTemplates = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMProduction = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAgentTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMScheme = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.TSBAgents = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBProposals = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBAssignExpert = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBContracts = new System.Windows.Forms.ToolStripButton();
            this.TSBWorkForContracts = new System.Windows.Forms.ToolStripButton();
            this.TSBInspectionControl = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBContractPayments = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBContractStats = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBLogout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBLogin = new System.Windows.Forms.ToolStripButton();
            this.TMCUsersCBox = new System.Windows.Forms.ToolStripComboBox();
            this.TSBFillUsers = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.curentUserToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.usersTableAdapter = new Edocsys.EdocbaseDataSetTableAdapters.usersTableAdapter();
            this.edocbaseDataSet = new Edocsys.EdocbaseDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Edocsys.EdocbaseDataSetTableAdapters.TableAdapterManager();
            this.mainMenuStrip.SuspendLayout();
            this.mainToolStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edocbaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMFileMenu,
            this.TSMWorkMenu,
            this.TSMAdminMenu,
            this.WindowToolStripMenuItem,
            this.TSMHelp});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.MdiWindowListItem = this.WindowToolStripMenuItem;
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(825, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // TSMFileMenu
            // 
            this.TSMFileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMConfig,
            this.toolStripMenuItem1,
            this.TSMLogin,
            this.TSMLogout,
            this.toolStripMenuItem3,
            this.TSMExit});
            this.TSMFileMenu.Name = "TSMFileMenu";
            this.TSMFileMenu.Size = new System.Drawing.Size(48, 20);
            this.TSMFileMenu.Text = global::Edocsys.Properties.Settings.Default.FileToolStripMenuItemText;
            // 
            // TSMConfig
            // 
            this.TSMConfig.Name = "TSMConfig";
            this.TSMConfig.Size = new System.Drawing.Size(169, 22);
            this.TSMConfig.Text = global::Edocsys.Properties.Settings.Default.ConfigFormText;
            this.TSMConfig.Click += new System.EventHandler(this.configFormToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(166, 6);
            // 
            // TSMLogin
            // 
            this.TSMLogin.Name = "TSMLogin";
            this.TSMLogin.Size = new System.Drawing.Size(169, 22);
            this.TSMLogin.Text = global::Edocsys.Properties.Settings.Default.LoginToolStripMenuItemText;
            this.TSMLogin.Click += new System.EventHandler(this.LoginToolStripMenuItem_Click_1);
            // 
            // TSMLogout
            // 
            this.TSMLogout.Name = "TSMLogout";
            this.TSMLogout.Size = new System.Drawing.Size(169, 22);
            this.TSMLogout.Text = "Завершить сеанс";
            this.TSMLogout.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(166, 6);
            // 
            // TSMExit
            // 
            this.TSMExit.Name = "TSMExit";
            this.TSMExit.Size = new System.Drawing.Size(169, 22);
            this.TSMExit.Text = global::Edocsys.Properties.Settings.Default.ExitToolStripMenuItemText;
            this.TSMExit.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // TSMWorkMenu
            // 
            this.TSMWorkMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMAgents,
            this.TSMProposals,
            this.TSMAssignExpert,
            this.TSMContracts,
            this.TSMWorkForContracts,
            this.TSMContractPayments,
            this.TSMInspectionControl,
            this.TSMContractStats});
            this.TSMWorkMenu.Name = "TSMWorkMenu";
            this.TSMWorkMenu.Size = new System.Drawing.Size(97, 20);
            this.TSMWorkMenu.Text = global::Edocsys.Properties.Settings.Default.DocToolStripMenuItemText;
            // 
            // TSMAgents
            // 
            this.TSMAgents.Name = "TSMAgents";
            this.TSMAgents.Size = new System.Drawing.Size(221, 22);
            this.TSMAgents.Text = global::Edocsys.Properties.Settings.Default.ClientsFormText;
            this.TSMAgents.Click += new System.EventHandler(this.AgentsToolStripMenuItem_Click);
            // 
            // TSMProposals
            // 
            this.TSMProposals.Name = "TSMProposals";
            this.TSMProposals.Size = new System.Drawing.Size(221, 22);
            this.TSMProposals.Text = global::Edocsys.Properties.Settings.Default.ProposalToolStripMenuItemText;
            this.TSMProposals.Click += new System.EventHandler(this.proposalToolStripMenuItem_Click);
            // 
            // TSMAssignExpert
            // 
            this.TSMAssignExpert.Name = "TSMAssignExpert";
            this.TSMAssignExpert.Size = new System.Drawing.Size(221, 22);
            this.TSMAssignExpert.Text = global::Edocsys.Properties.Settings.Default.AssignexpertToolStripMenuItemText;
            this.TSMAssignExpert.Click += new System.EventHandler(this.ExpertAssignToolStripMenuItem_Click);
            // 
            // TSMContracts
            // 
            this.TSMContracts.Name = "TSMContracts";
            this.TSMContracts.Size = new System.Drawing.Size(221, 22);
            this.TSMContracts.Text = global::Edocsys.Properties.Settings.Default.ContractToolStripMenuItemText;
            this.TSMContracts.Click += new System.EventHandler(this.ContractToolStripMenuItem_Click);
            // 
            // TSMWorkForContracts
            // 
            this.TSMWorkForContracts.Name = "TSMWorkForContracts";
            this.TSMWorkForContracts.Size = new System.Drawing.Size(221, 22);
            this.TSMWorkForContracts.Text = global::Edocsys.Properties.Settings.Default.WorksForContractTitle;
            this.TSMWorkForContracts.Click += new System.EventHandler(this.WorksToolStripMenuItem_Click);
            // 
            // TSMContractPayments
            // 
            this.TSMContractPayments.Name = "TSMContractPayments";
            this.TSMContractPayments.Size = new System.Drawing.Size(221, 22);
            this.TSMContractPayments.Text = global::Edocsys.Properties.Settings.Default.ContractPaymentsTitle;
            this.TSMContractPayments.Click += new System.EventHandler(this.ContractPaymentsToolStripMenuItem_Click);
            // 
            // TSMInspectionControl
            // 
            this.TSMInspectionControl.Name = "TSMInspectionControl";
            this.TSMInspectionControl.Size = new System.Drawing.Size(221, 22);
            this.TSMInspectionControl.Text = global::Edocsys.Properties.Settings.Default.InspectionControlMenuTitle;
            this.TSMInspectionControl.Click += new System.EventHandler(this.InspectionControlToolStripMenuItem_Click);
            // 
            // TSMContractStats
            // 
            this.TSMContractStats.Name = "TSMContractStats";
            this.TSMContractStats.Size = new System.Drawing.Size(221, 22);
            this.TSMContractStats.Text = global::Edocsys.Properties.Settings.Default.ContractStatsTitle;
            this.TSMContractStats.Click += new System.EventHandler(this.ContractStatsToolStripMenuItem_Click);
            // 
            // TSMAdminMenu
            // 
            this.TSMAdminMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMUserAdmin,
            this.TSMExperts,
            this.toolStripMenuItem2,
            this.TSMDocTemplates,
            this.TSMProduction,
            this.TSMAgentTypes});
            this.TSMAdminMenu.Name = "TSMAdminMenu";
            this.TSMAdminMenu.Size = new System.Drawing.Size(134, 20);
            this.TSMAdminMenu.Text = global::Edocsys.Properties.Settings.Default.AdmToolStripMenuItemText;
            // 
            // TSMUserAdmin
            // 
            this.TSMUserAdmin.Name = "TSMUserAdmin";
            this.TSMUserAdmin.Size = new System.Drawing.Size(233, 22);
            this.TSMUserAdmin.Text = global::Edocsys.Properties.Settings.Default.AdmpanelToolStripMenuItemText;
            this.TSMUserAdmin.Click += new System.EventHandler(this.AdmpanelToolStripMenuItem_Click);
            // 
            // TSMExperts
            // 
            this.TSMExperts.Name = "TSMExperts";
            this.TSMExperts.Size = new System.Drawing.Size(233, 22);
            this.TSMExperts.Text = global::Edocsys.Properties.Settings.Default.AddingExpertToolStripMenuItemText;
            this.TSMExperts.Click += new System.EventHandler(this.ExpertsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(230, 6);
            // 
            // TSMDocTemplates
            // 
            this.TSMDocTemplates.Name = "TSMDocTemplates";
            this.TSMDocTemplates.Size = new System.Drawing.Size(233, 22);
            this.TSMDocTemplates.Text = global::Edocsys.Properties.Settings.Default.DocTemplatesTitle;
            this.TSMDocTemplates.Click += new System.EventHandler(this.docTemplatesFormToolStripMenuItem_Click);
            // 
            // TSMProduction
            // 
            this.TSMProduction.Name = "TSMProduction";
            this.TSMProduction.Size = new System.Drawing.Size(233, 22);
            this.TSMProduction.Text = "Область аккредитации";
            this.TSMProduction.Click += new System.EventHandler(this.ProductionToolStripMenuItem_Click);
            // 
            // TSMAgentTypes
            // 
            this.TSMAgentTypes.Name = "TSMAgentTypes";
            this.TSMAgentTypes.Size = new System.Drawing.Size(233, 22);
            this.TSMAgentTypes.Text = global::Edocsys.Properties.Settings.Default.AgentTypesTitle;
            this.TSMAgentTypes.Click += new System.EventHandler(this.TSMAgentTypes_Click);
            // 
            // WindowToolStripMenuItem
            // 
            this.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem";
            this.WindowToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.WindowToolStripMenuItem.Text = global::Edocsys.Properties.Settings.Default.WindowToolStripMenuItemText;
            // 
            // TSMHelp
            // 
            this.TSMHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMAbout,
            this.TSMScheme});
            this.TSMHelp.Name = "TSMHelp";
            this.TSMHelp.Size = new System.Drawing.Size(68, 20);
            this.TSMHelp.Text = global::Edocsys.Properties.Settings.Default.HelpToolStripMenuItemText;
            // 
            // TSMAbout
            // 
            this.TSMAbout.Name = "TSMAbout";
            this.TSMAbout.Size = new System.Drawing.Size(152, 22);
            this.TSMAbout.Text = "О программе";
            this.TSMAbout.Click += new System.EventHandler(this.TSMIAbout_Click);
            // 
            // TSMScheme
            // 
            this.TSMScheme.Name = "TSMScheme";
            this.TSMScheme.Size = new System.Drawing.Size(152, 22);
            this.TSMScheme.Text = "Схема работы";
            this.TSMScheme.Click += new System.EventHandler(this.TSMIScheme_Click);
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBAgents,
            this.toolStripSeparator5,
            this.TSBProposals,
            this.toolStripSeparator6,
            this.TSBAssignExpert,
            this.toolStripSeparator3,
            this.TSBContracts,
            this.TSBWorkForContracts,
            this.TSBInspectionControl,
            this.toolStripSeparator7,
            this.TSBContractPayments,
            this.toolStripSeparator2,
            this.TSBContractStats,
            this.toolStripSeparator1,
            this.TSBLogout,
            this.toolStripSeparator4,
            this.TSBLogin,
            this.TMCUsersCBox,
            this.TSBFillUsers});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 24);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(825, 57);
            this.mainToolStrip.TabIndex = 2;
            this.mainToolStrip.Text = "toolStrip1";
            // 
            // TSBAgents
            // 
            this.TSBAgents.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBAgents.Image = ((System.Drawing.Image)(resources.GetObject("TSBAgents.Image")));
            this.TSBAgents.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBAgents.Name = "TSBAgents";
            this.TSBAgents.Size = new System.Drawing.Size(54, 54);
            this.TSBAgents.Text = "Контрагенты";
            this.TSBAgents.Click += new System.EventHandler(this.AgentsToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 57);
            // 
            // TSBProposals
            // 
            this.TSBProposals.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBProposals.Image = ((System.Drawing.Image)(resources.GetObject("TSBProposals.Image")));
            this.TSBProposals.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBProposals.Name = "TSBProposals";
            this.TSBProposals.Size = new System.Drawing.Size(54, 54);
            this.TSBProposals.Text = "Заявки";
            this.TSBProposals.Click += new System.EventHandler(this.proposalToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 57);
            // 
            // TSBAssignExpert
            // 
            this.TSBAssignExpert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBAssignExpert.Image = ((System.Drawing.Image)(resources.GetObject("TSBAssignExpert.Image")));
            this.TSBAssignExpert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBAssignExpert.Name = "TSBAssignExpert";
            this.TSBAssignExpert.Size = new System.Drawing.Size(54, 54);
            this.TSBAssignExpert.Text = "Назначение эксперта";
            this.TSBAssignExpert.Click += new System.EventHandler(this.AssignexpertToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 57);
            // 
            // TSBContracts
            // 
            this.TSBContracts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBContracts.Image = ((System.Drawing.Image)(resources.GetObject("TSBContracts.Image")));
            this.TSBContracts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBContracts.Name = "TSBContracts";
            this.TSBContracts.Size = new System.Drawing.Size(54, 54);
            this.TSBContracts.Text = "Ведение договоров";
            this.TSBContracts.Click += new System.EventHandler(this.ContractToolStripMenuItem_Click);
            // 
            // TSBWorkForContracts
            // 
            this.TSBWorkForContracts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBWorkForContracts.Image = ((System.Drawing.Image)(resources.GetObject("TSBWorkForContracts.Image")));
            this.TSBWorkForContracts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBWorkForContracts.Name = "TSBWorkForContracts";
            this.TSBWorkForContracts.Size = new System.Drawing.Size(54, 54);
            this.TSBWorkForContracts.Text = "Работы по договору";
            this.TSBWorkForContracts.Click += new System.EventHandler(this.WorksToolStripMenuItem_Click);
            // 
            // TSBInspectionControl
            // 
            this.TSBInspectionControl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBInspectionControl.Image = ((System.Drawing.Image)(resources.GetObject("TSBInspectionControl.Image")));
            this.TSBInspectionControl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBInspectionControl.Name = "TSBInspectionControl";
            this.TSBInspectionControl.Size = new System.Drawing.Size(54, 54);
            this.TSBInspectionControl.Text = "Инспекционный контроль";
            this.TSBInspectionControl.Click += new System.EventHandler(this.InspectionControlToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 57);
            // 
            // TSBContractPayments
            // 
            this.TSBContractPayments.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBContractPayments.Image = ((System.Drawing.Image)(resources.GetObject("TSBContractPayments.Image")));
            this.TSBContractPayments.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBContractPayments.Name = "TSBContractPayments";
            this.TSBContractPayments.Size = new System.Drawing.Size(54, 54);
            this.TSBContractPayments.Text = global::Edocsys.Properties.Settings.Default.ContractPaymentsTitle;
            this.TSBContractPayments.Click += new System.EventHandler(this.ContractPaymentsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 57);
            // 
            // TSBContractStats
            // 
            this.TSBContractStats.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBContractStats.Image = ((System.Drawing.Image)(resources.GetObject("TSBContractStats.Image")));
            this.TSBContractStats.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBContractStats.Name = "TSBContractStats";
            this.TSBContractStats.Size = new System.Drawing.Size(54, 54);
            this.TSBContractStats.Text = "Статистика договоров";
            this.TSBContractStats.Click += new System.EventHandler(this.ContractStatsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 57);
            // 
            // TSBLogout
            // 
            this.TSBLogout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSBLogout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBLogout.Image = ((System.Drawing.Image)(resources.GetObject("TSBLogout.Image")));
            this.TSBLogout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBLogout.Name = "TSBLogout";
            this.TSBLogout.Size = new System.Drawing.Size(54, 54);
            this.TSBLogout.Text = "Завершить сеанс";
            this.TSBLogout.ToolTipText = "Завершить сеанс";
            this.TSBLogout.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 57);
            // 
            // TSBLogin
            // 
            this.TSBLogin.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSBLogin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBLogin.Image = ((System.Drawing.Image)(resources.GetObject("TSBLogin.Image")));
            this.TSBLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBLogin.Name = "TSBLogin";
            this.TSBLogin.Size = new System.Drawing.Size(54, 54);
            this.TSBLogin.Text = "Вход";
            this.TSBLogin.Click += new System.EventHandler(this.loginToolStripButton_Click);
            // 
            // TMCUsersCBox
            // 
            this.TMCUsersCBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TMCUsersCBox.Name = "TMCUsersCBox";
            this.TMCUsersCBox.Size = new System.Drawing.Size(200, 57);
            // 
            // TSBFillUsers
            // 
            this.TSBFillUsers.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSBFillUsers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBFillUsers.Image = ((System.Drawing.Image)(resources.GetObject("TSBFillUsers.Image")));
            this.TSBFillUsers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBFillUsers.Name = "TSBFillUsers";
            this.TSBFillUsers.Size = new System.Drawing.Size(54, 54);
            this.TSBFillUsers.Text = "Обновить список пользователей";
            this.TSBFillUsers.Click += new System.EventHandler(this.fillUsersToolStripButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.curentUserToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 475);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(825, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // curentUserToolStripStatusLabel
            // 
            this.curentUserToolStripStatusLabel.Name = "curentUserToolStripStatusLabel";
            this.curentUserToolStripStatusLabel.Size = new System.Drawing.Size(112, 17);
            this.curentUserToolStripStatusLabel.Text = "Пользователь: НЕТ";
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // edocbaseDataSet
            // 
            this.edocbaseDataSet.CaseSensitive = true;
            this.edocbaseDataSet.DataSetName = "EdocbaseDataSet";
            this.edocbaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.edocbaseDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.agent_typesTableAdapter = null;
            this.tableAdapterManager.agents_contactsTableAdapter = null;
            this.tableAdapterManager.agentsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.contract_statusTableAdapter = null;
            this.tableAdapterManager.contract_types_for_workTableAdapter = null;
            this.tableAdapterManager.contract_typesTableAdapter = null;
            this.tableAdapterManager.ContractInfoTableAdapter = null;
            this.tableAdapterManager.ContractPrepareForWorkTAdapter = null;
            this.tableAdapterManager.ContractSigningTableAdapter = null;
            this.tableAdapterManager.ContractsOnInspectionTableAdapter = null;
            this.tableAdapterManager.contractsTableAdapter = null;
            this.tableAdapterManager.doc_templatesTableAdapter = null;
            this.tableAdapterManager.documentsTableAdapter = null;
            this.tableAdapterManager.emission_typesTableAdapter = null;
            this.tableAdapterManager.expertsTableAdapter = null;
            this.tableAdapterManager.GOSTSelectionTableAdapter = null;
            this.tableAdapterManager.InspectionContractsTableAdapter = null;
            this.tableAdapterManager.log_journalTableAdapter = null;
            this.tableAdapterManager.product_areasTableAdapter = null;
            this.tableAdapterManager.product_gostsTableAdapter = null;
            this.tableAdapterManager.productsTableAdapter = null;
            this.tableAdapterManager.selected_gostsTableAdapter = null;
            this.tableAdapterManager.source_typesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Edocsys.EdocbaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.user_typesTableAdapter = null;
            this.tableAdapterManager.usersTableAdapter = this.usersTableAdapter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 497);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mainToolStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "MainFormText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.Text = global::Edocsys.Properties.Settings.Default.MainFormText;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edocbaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem TSMFileMenu;
        private System.Windows.Forms.ToolStripMenuItem TSMLogin;
        private System.Windows.Forms.ToolStripMenuItem TSMExit;
        private System.Windows.Forms.ToolStripMenuItem TSMAdminMenu;
        private System.Windows.Forms.ToolStripMenuItem TSMWorkMenu;
        private System.Windows.Forms.ToolStripMenuItem TSMProposals;
        private System.Windows.Forms.ToolStripMenuItem TSMUserAdmin;
        private System.Windows.Forms.ToolStripMenuItem TSMExperts;
        private System.Windows.Forms.ToolStripMenuItem TSMContracts;
        private System.Windows.Forms.ToolStripMenuItem TSMHelp;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem WindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMConfig;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripButton TSBAgents;
        private System.Windows.Forms.ToolStripButton TSBProposals;
        private System.Windows.Forms.ToolStripButton TSBContracts;
        private System.Windows.Forms.ToolStripButton TSBWorkForContracts;
        private System.Windows.Forms.ToolStripButton TSBInspectionControl;
        private System.Windows.Forms.ToolStripButton TSBContractStats;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton TSBContractPayments;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TSBLogin;
        private System.Windows.Forms.ToolStripComboBox TMCUsersCBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private EdocbaseDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private EdocbaseDataSet edocbaseDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private EdocbaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripButton TSBFillUsers;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripStatusLabel curentUserToolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem TSMDocTemplates;
        private System.Windows.Forms.ToolStripMenuItem TSMAssignExpert;
        private System.Windows.Forms.ToolStripMenuItem TSMAgents;
        private System.Windows.Forms.ToolStripMenuItem TSMProduction;
        private System.Windows.Forms.ToolStripMenuItem TSMWorkForContracts;
        private System.Windows.Forms.ToolStripMenuItem TSMInspectionControl;
        private System.Windows.Forms.ToolStripMenuItem TSMContractPayments;
        private System.Windows.Forms.ToolStripMenuItem TSMContractStats;
        private System.Windows.Forms.ToolStripMenuItem TSMLogout;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton TSBAssignExpert;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton TSBLogout;
        private System.Windows.Forms.ToolStripMenuItem TSMAbout;
        private System.Windows.Forms.ToolStripMenuItem TSMScheme;
        private System.Windows.Forms.ToolStripMenuItem TSMAgentTypes;
    }
}

