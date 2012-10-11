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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdmpanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AssignexpertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddingExpertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProposalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CatalogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContractorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.AdmToolStripMenuItem,
            this.DocToolStripMenuItem,
            this.CatalogToolStripMenuItem,
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
            this.LoginToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.FileToolStripMenuItem.Text = global::Edocsys.Properties.Settings.Default.FileToolStripMenuItemText;
            // 
            // LoginToolStripMenuItem
            // 
            this.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem";
            this.LoginToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.LoginToolStripMenuItem.Text = global::Edocsys.Properties.Settings.Default.LoginToolStripMenuItemText;
            this.LoginToolStripMenuItem.Click += new System.EventHandler(this.LoginToolStripMenuItem_Click_1);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.ExitToolStripMenuItem.Text = global::Edocsys.Properties.Settings.Default.ExitToolStripMenuItemText;
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // AdmToolStripMenuItem
            // 
            this.AdmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdmpanelToolStripMenuItem,
            this.AssignexpertToolStripMenuItem,
            this.AddingExpertToolStripMenuItem});
            this.AdmToolStripMenuItem.Name = "AdmToolStripMenuItem";
            this.AdmToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.AdmToolStripMenuItem.Text = global::Edocsys.Properties.Settings.Default.AdmToolStripMenuItemText;
            // 
            // AdmpanelToolStripMenuItem
            // 
            this.AdmpanelToolStripMenuItem.Name = "AdmpanelToolStripMenuItem";
            this.AdmpanelToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.AdmpanelToolStripMenuItem.Text = global::Edocsys.Properties.Settings.Default.AdmpanelToolStripMenuItemText;
            this.AdmpanelToolStripMenuItem.Click += new System.EventHandler(this.AdmpanelToolStripMenuItem_Click);
            // 
            // AssignexpertToolStripMenuItem
            // 
            this.AssignexpertToolStripMenuItem.Name = "AssignexpertToolStripMenuItem";
            this.AssignexpertToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.AssignexpertToolStripMenuItem.Text = global::Edocsys.Properties.Settings.Default.AssignexpertToolStripMenuItemText;
            // 
            // AddingExpertToolStripMenuItem
            // 
            this.AddingExpertToolStripMenuItem.Name = "AddingExpertToolStripMenuItem";
            this.AddingExpertToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.AddingExpertToolStripMenuItem.Text = global::Edocsys.Properties.Settings.Default.AddingExpertToolStripMenuItemText;
            // 
            // DocToolStripMenuItem
            // 
            this.DocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProposalToolStripMenuItem,
            this.ContractToolStripMenuItem});
            this.DocToolStripMenuItem.Name = "DocToolStripMenuItem";
            this.DocToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.DocToolStripMenuItem.Text = global::Edocsys.Properties.Settings.Default.DocToolStripMenuItemText;
            // 
            // ProposalToolStripMenuItem
            // 
            this.ProposalToolStripMenuItem.Name = "ProposalToolStripMenuItem";
            this.ProposalToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.ProposalToolStripMenuItem.Text = global::Edocsys.Properties.Settings.Default.ProposalToolStripMenuItemText;
            this.ProposalToolStripMenuItem.Click += new System.EventHandler(this.proposalToolStripMenuItem_Click);
            // 
            // ContractToolStripMenuItem
            // 
            this.ContractToolStripMenuItem.Name = "ContractToolStripMenuItem";
            this.ContractToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.ContractToolStripMenuItem.Text = global::Edocsys.Properties.Settings.Default.ContractToolStripMenuItemText;
            // 
            // CatalogToolStripMenuItem
            // 
            this.CatalogToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContractorToolStripMenuItem,
            this.ProductionToolStripMenuItem});
            this.CatalogToolStripMenuItem.Name = "CatalogToolStripMenuItem";
            this.CatalogToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.CatalogToolStripMenuItem.Text = global::Edocsys.Properties.Settings.Default.CatalogToolStripMenuText;
            // 
            // ContractorToolStripMenuItem
            // 
            this.ContractorToolStripMenuItem.Name = "ContractorToolStripMenuItem";
            this.ContractorToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.ContractorToolStripMenuItem.Text = global::Edocsys.Properties.Settings.Default.ContractorToolStripMenuItemText;
            this.ContractorToolStripMenuItem.Click += new System.EventHandler(this.ContractorToolStripMenuItem_Click);
            // 
            // ProductionToolStripMenuItem
            // 
            this.ProductionToolStripMenuItem.Name = "ProductionToolStripMenuItem";
            this.ProductionToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.ProductionToolStripMenuItem.Text = global::Edocsys.Properties.Settings.Default.ProductionToolStripMenuItemText;
            this.ProductionToolStripMenuItem.Click += new System.EventHandler(this.ProductionToolStripMenuItem_Click);
            // 
            // WindowToolStripMenuItem
            // 
            this.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem";
            this.WindowToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.WindowToolStripMenuItem.Text = global::Edocsys.Properties.Settings.Default.WindowToolStripMenuItemText;
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.HelpToolStripMenuItem.Text = global::Edocsys.Properties.Settings.Default.HelpToolStripMenuItemText;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(559, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 244);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(559, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 266);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "MainFormText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = global::Edocsys.Properties.Settings.Default.MainFormText;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem AddingExpertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ContractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CatalogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ContractorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductionToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem WindowToolStripMenuItem;
    }
}

