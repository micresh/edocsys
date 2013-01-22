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
            this.ProposalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CatalogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContractorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdmpanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExpertsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.AssignexpertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docTemplatesFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.fillUsersToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.cueerntUserToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.CatalogToolStripMenuItem,
            this.AdmToolStripMenuItem,
            this.WindowToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.WindowToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(559, 24);
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
            this.ProposalToolStripMenuItem,
            this.ContractToolStripMenuItem});
            this.DocToolStripMenuItem.Name = "DocToolStripMenuItem";
            this.DocToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.DocToolStripMenuItem.Text = global::Edocsys.Properties.Settings.Default.DocToolStripMenuItemText;
            // 
            // ProposalToolStripMenuItem
            // 
            this.ProposalToolStripMenuItem.Name = "ProposalToolStripMenuItem";
            this.ProposalToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.ProposalToolStripMenuItem.Text = global::Edocsys.Properties.Settings.Default.ProposalToolStripMenuItemText;
            this.ProposalToolStripMenuItem.Click += new System.EventHandler(this.proposalToolStripMenuItem_Click);
            // 
            // ContractToolStripMenuItem
            // 
            this.ContractToolStripMenuItem.Name = "ContractToolStripMenuItem";
            this.ContractToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.ContractToolStripMenuItem.Text = global::Edocsys.Properties.Settings.Default.ContractToolStripMenuItemText;
            this.ContractToolStripMenuItem.Click += new System.EventHandler(this.ContractToolStripMenuItem_Click);
            // 
            // CatalogToolStripMenuItem
            // 
            this.CatalogToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContractorToolStripMenuItem,
            this.ProductionToolStripMenuItem});
            this.CatalogToolStripMenuItem.Name = "CatalogToolStripMenuItem";
            this.CatalogToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.CatalogToolStripMenuItem.Text = global::Edocsys.Properties.Settings.Default.CatalogToolStripMenuText;
            // 
            // ContractorToolStripMenuItem
            // 
            this.ContractorToolStripMenuItem.Name = "ContractorToolStripMenuItem";
            this.ContractorToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.ContractorToolStripMenuItem.Text = global::Edocsys.Properties.Settings.Default.ContractorToolStripMenuItemText;
            this.ContractorToolStripMenuItem.Click += new System.EventHandler(this.ContractorToolStripMenuItem_Click);
            // 
            // ProductionToolStripMenuItem
            // 
            this.ProductionToolStripMenuItem.Name = "ProductionToolStripMenuItem";
            this.ProductionToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.ProductionToolStripMenuItem.Text = global::Edocsys.Properties.Settings.Default.ProductionToolStripMenuItemText;
            this.ProductionToolStripMenuItem.Click += new System.EventHandler(this.ProductionToolStripMenuItem_Click);
            // 
            // AdmToolStripMenuItem
            // 
            this.AdmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdmpanelToolStripMenuItem,
            this.ExpertsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.AssignexpertToolStripMenuItem,
            this.docTemplatesFormToolStripMenuItem});
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
            // AssignexpertToolStripMenuItem
            // 
            this.AssignexpertToolStripMenuItem.Name = "AssignexpertToolStripMenuItem";
            this.AssignexpertToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.AssignexpertToolStripMenuItem.Text = global::Edocsys.Properties.Settings.Default.AssighExpertFormText;
            this.AssignexpertToolStripMenuItem.Click += new System.EventHandler(this.AssignexpertToolStripMenuItem_Click);
            // 
            // docTemplatesFormToolStripMenuItem
            // 
            this.docTemplatesFormToolStripMenuItem.Name = "docTemplatesFormToolStripMenuItem";
            this.docTemplatesFormToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.docTemplatesFormToolStripMenuItem.Text = global::Edocsys.Properties.Settings.Default.DocTemplatesTitle;
            this.docTemplatesFormToolStripMenuItem.Click += new System.EventHandler(this.docTemplatesFormToolStripMenuItem_Click);
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
            this.toolStripSeparator3,
            this.fillUsersToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(559, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "toolStripButton5";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "toolStripButton6";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "toolStripButton8";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // loginToolStripButton
            // 
            this.loginToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.loginToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.loginToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("loginToolStripButton.Image")));
            this.loginToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loginToolStripButton.Name = "loginToolStripButton";
            this.loginToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.loginToolStripButton.Text = "toolStripButton7";
            this.loginToolStripButton.Click += new System.EventHandler(this.loginToolStripButton_Click);
            // 
            // usersToolStripComboBox
            // 
            this.usersToolStripComboBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.usersToolStripComboBox.Name = "usersToolStripComboBox";
            this.usersToolStripComboBox.Size = new System.Drawing.Size(200, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // fillUsersToolStripButton
            // 
            this.fillUsersToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.fillUsersToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fillUsersToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("fillUsersToolStripButton.Image")));
            this.fillUsersToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fillUsersToolStripButton.Name = "fillUsersToolStripButton";
            this.fillUsersToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.fillUsersToolStripButton.Text = "toolStripButton9";
            this.fillUsersToolStripButton.Click += new System.EventHandler(this.fillUsersToolStripButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cueerntUserToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 362);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(559, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // cueerntUserToolStripStatusLabel
            // 
            this.cueerntUserToolStripStatusLabel.Name = "cueerntUserToolStripStatusLabel";
            this.cueerntUserToolStripStatusLabel.Size = new System.Drawing.Size(112, 17);
            this.cueerntUserToolStripStatusLabel.Text = "Пользователь: НЕТ";
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // edocbaseDataSet
            // 
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
            this.tableAdapterManager.Agents_contactsTableAdapter = null;
            this.tableAdapterManager.Agents_typesTableAdapter = null;
            this.tableAdapterManager.AgentsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ContractsTableAdapter = null;
            this.tableAdapterManager.ContractStatusTableAdapter = null;
            this.tableAdapterManager.ContractTypesTableAdapter = null;
            this.tableAdapterManager.DocTemplatesTableAdapter = null;
            this.tableAdapterManager.DocumentsTableAdapter = null;
            this.tableAdapterManager.Exec_contractsTableAdapter = null;
            this.tableAdapterManager.ExpertsTableAdapter = null;
            this.tableAdapterManager.log_journalTableAdapter = null;
            this.tableAdapterManager.ProdGostTableAdapter = null;
            this.tableAdapterManager.ProductAreasTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Edocsys.EdocbaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = this.usersTableAdapter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 384);
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
        private System.Windows.Forms.ToolStripMenuItem AssignexpertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExpertsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ContractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CatalogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ContractorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductionToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripStatusLabel cueerntUserToolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem docTemplatesFormToolStripMenuItem;
    }
}

