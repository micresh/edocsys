﻿namespace Edocsys
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.LoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AgentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProposalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExpertAssignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WorksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContractPaymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InspectionControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContractStatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdmpanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExpertsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.docTemplatesFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.loginToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.usersToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.fillUsersToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.curentUserToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.usersTableAdapter = new Edocsys.EdocbaseDataSetTableAdapters.usersTableAdapter();
            this.edocbaseDataSet = new Edocsys.EdocbaseDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Edocsys.EdocbaseDataSetTableAdapters.TableAdapterManager();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edocbaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.DocToolStripMenuItem,
            this.AdmToolStripMenuItem,
            this.WindowToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.WindowToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(825, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configFormToolStripMenuItem,
            this.toolStripMenuItem1,
            this.LoginToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = global::Edocsys.Properties.Settings.Default.FileToolStripMenuItemText;
            // 
            // configFormToolStripMenuItem
            // 
            this.configFormToolStripMenuItem.Name = "configFormToolStripMenuItem";
            this.configFormToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.configFormToolStripMenuItem.Text = global::Edocsys.Properties.Settings.Default.ConfigFormText;
            this.configFormToolStripMenuItem.Click += new System.EventHandler(this.configFormToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(131, 6);
            // 
            // LoginToolStripMenuItem
            // 
            this.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem";
            this.LoginToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.LoginToolStripMenuItem.Text = global::Edocsys.Properties.Settings.Default.LoginToolStripMenuItemText;
            this.LoginToolStripMenuItem.Click += new System.EventHandler(this.LoginToolStripMenuItem_Click_1);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.ExitToolStripMenuItem.Text = global::Edocsys.Properties.Settings.Default.ExitToolStripMenuItemText;
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // DocToolStripMenuItem
            // 
            this.DocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AgentsToolStripMenuItem,
            this.ProposalToolStripMenuItem,
            this.ExpertAssignToolStripMenuItem,
            this.ContractToolStripMenuItem,
            this.WorksToolStripMenuItem,
            this.ContractPaymentsToolStripMenuItem,
            this.InspectionControlToolStripMenuItem,
            this.ContractStatsToolStripMenuItem});
            this.DocToolStripMenuItem.Name = "DocToolStripMenuItem";
            this.DocToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.DocToolStripMenuItem.Text = global::Edocsys.Properties.Settings.Default.DocToolStripMenuItemText;
            // 
            // AgentsToolStripMenuItem
            // 
            this.AgentsToolStripMenuItem.Name = "AgentsToolStripMenuItem";
            this.AgentsToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.AgentsToolStripMenuItem.Text = global::Edocsys.Properties.Settings.Default.ClientsFormText;
            this.AgentsToolStripMenuItem.Click += new System.EventHandler(this.AgentsToolStripMenuItem_Click);
            // 
            // ProposalToolStripMenuItem
            // 
            this.ProposalToolStripMenuItem.Name = "ProposalToolStripMenuItem";
            this.ProposalToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.ProposalToolStripMenuItem.Text = global::Edocsys.Properties.Settings.Default.ProposalToolStripMenuItemText;
            this.ProposalToolStripMenuItem.Click += new System.EventHandler(this.proposalToolStripMenuItem_Click);
            // 
            // ExpertAssignToolStripMenuItem
            // 
            this.ExpertAssignToolStripMenuItem.Name = "ExpertAssignToolStripMenuItem";
            this.ExpertAssignToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.ExpertAssignToolStripMenuItem.Text = global::Edocsys.Properties.Settings.Default.AssignexpertToolStripMenuItemText;
            this.ExpertAssignToolStripMenuItem.Click += new System.EventHandler(this.ExpertAssignToolStripMenuItem_Click);
            // 
            // ContractToolStripMenuItem
            // 
            this.ContractToolStripMenuItem.Name = "ContractToolStripMenuItem";
            this.ContractToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.ContractToolStripMenuItem.Text = global::Edocsys.Properties.Settings.Default.ContractToolStripMenuItemText;
            this.ContractToolStripMenuItem.Click += new System.EventHandler(this.ContractToolStripMenuItem_Click);
            // 
            // WorksToolStripMenuItem
            // 
            this.WorksToolStripMenuItem.Name = "WorksToolStripMenuItem";
            this.WorksToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.WorksToolStripMenuItem.Text = global::Edocsys.Properties.Settings.Default.WorksForContractTitle;
            this.WorksToolStripMenuItem.Click += new System.EventHandler(this.WorksToolStripMenuItem_Click);
            // 
            // ContractPaymentsToolStripMenuItem
            // 
            this.ContractPaymentsToolStripMenuItem.Name = "ContractPaymentsToolStripMenuItem";
            this.ContractPaymentsToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.ContractPaymentsToolStripMenuItem.Text = global::Edocsys.Properties.Settings.Default.ContractPaymentsTitle;
            this.ContractPaymentsToolStripMenuItem.Click += new System.EventHandler(this.ContractPaymentsToolStripMenuItem_Click);
            // 
            // InspectionControlToolStripMenuItem
            // 
            this.InspectionControlToolStripMenuItem.Name = "InspectionControlToolStripMenuItem";
            this.InspectionControlToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.InspectionControlToolStripMenuItem.Text = global::Edocsys.Properties.Settings.Default.InspectionControlMenuTitle;
            this.InspectionControlToolStripMenuItem.Click += new System.EventHandler(this.InspectionControlToolStripMenuItem_Click);
            // 
            // ContractStatsToolStripMenuItem
            // 
            this.ContractStatsToolStripMenuItem.Name = "ContractStatsToolStripMenuItem";
            this.ContractStatsToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.ContractStatsToolStripMenuItem.Text = global::Edocsys.Properties.Settings.Default.ContractStatsTitle;
            this.ContractStatsToolStripMenuItem.Click += new System.EventHandler(this.ContractStatsToolStripMenuItem_Click);
            // 
            // AdmToolStripMenuItem
            // 
            this.AdmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdmpanelToolStripMenuItem,
            this.ExpertsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.docTemplatesFormToolStripMenuItem,
            this.ProductionToolStripMenuItem});
            this.AdmToolStripMenuItem.Name = "AdmToolStripMenuItem";
            this.AdmToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.AdmToolStripMenuItem.Text = global::Edocsys.Properties.Settings.Default.AdmToolStripMenuItemText;
            // 
            // AdmpanelToolStripMenuItem
            // 
            this.AdmpanelToolStripMenuItem.Name = "AdmpanelToolStripMenuItem";
            this.AdmpanelToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.AdmpanelToolStripMenuItem.Text = global::Edocsys.Properties.Settings.Default.AdmpanelToolStripMenuItemText;
            this.AdmpanelToolStripMenuItem.Click += new System.EventHandler(this.AdmpanelToolStripMenuItem_Click);
            // 
            // ExpertsToolStripMenuItem
            // 
            this.ExpertsToolStripMenuItem.Name = "ExpertsToolStripMenuItem";
            this.ExpertsToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.ExpertsToolStripMenuItem.Text = global::Edocsys.Properties.Settings.Default.AddingExpertToolStripMenuItemText;
            this.ExpertsToolStripMenuItem.Click += new System.EventHandler(this.ExpertsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(230, 6);
            // 
            // docTemplatesFormToolStripMenuItem
            // 
            this.docTemplatesFormToolStripMenuItem.Name = "docTemplatesFormToolStripMenuItem";
            this.docTemplatesFormToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.docTemplatesFormToolStripMenuItem.Text = global::Edocsys.Properties.Settings.Default.DocTemplatesTitle;
            this.docTemplatesFormToolStripMenuItem.Click += new System.EventHandler(this.docTemplatesFormToolStripMenuItem_Click);
            // 
            // ProductionToolStripMenuItem
            // 
            this.ProductionToolStripMenuItem.Name = "ProductionToolStripMenuItem";
            this.ProductionToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.ProductionToolStripMenuItem.Text = "Область аккредитации";
            this.ProductionToolStripMenuItem.Click += new System.EventHandler(this.ProductionToolStripMenuItem_Click);
            // 
            // WindowToolStripMenuItem
            // 
            this.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem";
            this.WindowToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.WindowToolStripMenuItem.Text = global::Edocsys.Properties.Settings.Default.WindowToolStripMenuItemText;
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.HelpToolStripMenuItem.Text = global::Edocsys.Properties.Settings.Default.HelpToolStripMenuItemText;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator2,
            this.toolStripButton8,
            this.toolStripSeparator1,
            this.toolStripSeparator4,
            this.loginToolStripButton,
            this.usersToolStripComboBox,
            this.fillUsersToolStripButton,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(825, 57);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(54, 54);
            this.toolStripButton1.Text = "Контрагенты";
            this.toolStripButton1.Click += new System.EventHandler(this.ContractToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(54, 54);
            this.toolStripButton2.Text = "Заявки";
            this.toolStripButton2.Click += new System.EventHandler(this.proposalToolStripMenuItem_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(54, 54);
            this.toolStripButton3.Text = "Ведение договоров";
            this.toolStripButton3.Click += new System.EventHandler(this.ContractToolStripMenuItem_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(54, 54);
            this.toolStripButton4.Text = "Работы по договору";
            this.toolStripButton4.Click += new System.EventHandler(this.WorksToolStripMenuItem_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(54, 54);
            this.toolStripButton5.Text = "Инспекционный контроль";
            this.toolStripButton5.Click += new System.EventHandler(this.InspectionControlToolStripMenuItem_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(54, 54);
            this.toolStripButton6.Text = "Статистика договоров";
            this.toolStripButton6.Click += new System.EventHandler(this.ContractStatsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 57);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(54, 54);
            this.toolStripButton8.Text = "Оплата догворов";
            this.toolStripButton8.Click += new System.EventHandler(this.ContractPaymentsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 57);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 57);
            // 
            // loginToolStripButton
            // 
            this.loginToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.loginToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.loginToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("loginToolStripButton.Image")));
            this.loginToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loginToolStripButton.Name = "loginToolStripButton";
            this.loginToolStripButton.Size = new System.Drawing.Size(54, 54);
            this.loginToolStripButton.Text = "Вход";
            this.loginToolStripButton.Click += new System.EventHandler(this.loginToolStripButton_Click);
            // 
            // usersToolStripComboBox
            // 
            this.usersToolStripComboBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.usersToolStripComboBox.Name = "usersToolStripComboBox";
            this.usersToolStripComboBox.Size = new System.Drawing.Size(200, 57);
            // 
            // fillUsersToolStripButton
            // 
            this.fillUsersToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.fillUsersToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fillUsersToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("fillUsersToolStripButton.Image")));
            this.fillUsersToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fillUsersToolStripButton.Name = "fillUsersToolStripButton";
            this.fillUsersToolStripButton.Size = new System.Drawing.Size(54, 54);
            this.fillUsersToolStripButton.Text = "Обновить список пользователей";
            this.fillUsersToolStripButton.Click += new System.EventHandler(this.fillUsersToolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 57);
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
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "MainFormText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = global::Edocsys.Properties.Settings.Default.MainFormText;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edocbaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AdmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProposalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AdmpanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExpertsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ContractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem WindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton loginToolStripButton;
        private System.Windows.Forms.ToolStripComboBox usersToolStripComboBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private EdocbaseDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private EdocbaseDataSet edocbaseDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private EdocbaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripButton fillUsersToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripStatusLabel curentUserToolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem docTemplatesFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExpertAssignToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AgentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WorksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InspectionControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ContractPaymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ContractStatsToolStripMenuItem;
    }
}

