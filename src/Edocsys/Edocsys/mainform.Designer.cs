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
         this.admToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.AdmpanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.assignexpertЭкспертаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.AddingExpertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.DocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.proposalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.ClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.ProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.ContractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.menuStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // menuStrip1
         // 
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.admToolStripMenuItem,
            this.DocToolStripMenuItem,
            this.HelpToolStripMenuItem});
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.MdiWindowListItem = this.DocToolStripMenuItem;
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
         this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
         this.FileToolStripMenuItem.Text = "&Файл";
         // 
         // LoginToolStripMenuItem
         // 
         this.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem";
         this.LoginToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
         this.LoginToolStripMenuItem.Text = "Вход";
         this.LoginToolStripMenuItem.Click += new System.EventHandler(this.LoginToolStripMenuItem_Click_1);
         // 
         // ExitToolStripMenuItem
         // 
         this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
         this.ExitToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
         this.ExitToolStripMenuItem.Text = "Выход";
         this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
         // 
         // admToolStripMenuItem
         // 
         this.admToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdmpanelToolStripMenuItem,
            this.assignexpertЭкспертаToolStripMenuItem,
            this.AddingExpertToolStripMenuItem});
         this.admToolStripMenuItem.Name = "admToolStripMenuItem";
         this.admToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
         this.admToolStripMenuItem.Text = "&Администрирование";
         // 
         // AdmpanelToolStripMenuItem
         // 
         this.AdmpanelToolStripMenuItem.Name = "AdmpanelToolStripMenuItem";
         this.AdmpanelToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
         this.AdmpanelToolStripMenuItem.Text = "&Панель Администрирования";
         // 
         // assignexpertЭкспертаToolStripMenuItem
         // 
         this.assignexpertЭкспертаToolStripMenuItem.Name = "assignexpertЭкспертаToolStripMenuItem";
         this.assignexpertЭкспертаToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
         this.assignexpertЭкспертаToolStripMenuItem.Text = "Назначение эксперта";
         // 
         // AddingExpertToolStripMenuItem
         // 
         this.AddingExpertToolStripMenuItem.Name = "AddingExpertToolStripMenuItem";
         this.AddingExpertToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
         this.AddingExpertToolStripMenuItem.Text = "Добавление эксперта";
         // 
         // DocToolStripMenuItem
         // 
         this.DocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proposalToolStripMenuItem,
            this.ClientToolStripMenuItem,
            this.ProductToolStripMenuItem,
            this.ContractToolStripMenuItem});
         this.DocToolStripMenuItem.Name = "DocToolStripMenuItem";
         this.DocToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
         this.DocToolStripMenuItem.Text = "&Документы";
         // 
         // proposalToolStripMenuItem
         // 
         this.proposalToolStripMenuItem.Name = "proposalToolStripMenuItem";
         this.proposalToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
         this.proposalToolStripMenuItem.Text = "Добавить заявку";
         this.proposalToolStripMenuItem.Click += new System.EventHandler(this.proposalToolStripMenuItem_Click);
         // 
         // ClientToolStripMenuItem
         // 
         this.ClientToolStripMenuItem.Name = "ClientToolStripMenuItem";
         this.ClientToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
         this.ClientToolStripMenuItem.Text = "Добавить контрагента";
         // 
         // ProductToolStripMenuItem
         // 
         this.ProductToolStripMenuItem.Name = "ProductToolStripMenuItem";
         this.ProductToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
         this.ProductToolStripMenuItem.Text = "Добавить продукцию";
         // 
         // ContractToolStripMenuItem
         // 
         this.ContractToolStripMenuItem.Name = "ContractToolStripMenuItem";
         this.ContractToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
         this.ContractToolStripMenuItem.Text = "Добавить договор";
         // 
         // HelpToolStripMenuItem
         // 
         this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
         this.HelpToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
         this.HelpToolStripMenuItem.Text = "&Помощь";
         // 
         // MainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(559, 266);
         this.Controls.Add(this.menuStrip1);
         this.IsMdiContainer = true;
         this.MainMenuStrip = this.menuStrip1;
         this.Name = "MainForm";
         this.Text = "Едоксись";
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
        private System.Windows.Forms.ToolStripMenuItem admToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proposalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AdmpanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignexpertЭкспертаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddingExpertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ContractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
    }
}

