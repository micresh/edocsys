namespace Edocsys
{
    partial class AboutForm
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelAppVersion = new System.Windows.Forms.Label();
            this.labelPath = new System.Windows.Forms.Label();
            this.labelDeployVersion = new System.Windows.Forms.Label();
            this.labelDatabaseVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 20);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(309, 65);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "EdocSys.\r\n\r\nСистема регистрации, ведения и учета заявок и договоров\r\nсертификацио" +
    "нных работ.\r\n\r\n";
            // 
            // labelAppVersion
            // 
            this.labelAppVersion.AutoSize = true;
            this.labelAppVersion.Location = new System.Drawing.Point(12, 83);
            this.labelAppVersion.Name = "labelAppVersion";
            this.labelAppVersion.Size = new System.Drawing.Size(79, 13);
            this.labelAppVersion.TabIndex = 1;
            this.labelAppVersion.Text = "VERSION APP";
            // 
            // labelPath
            // 
            this.labelPath.Location = new System.Drawing.Point(12, 144);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(309, 41);
            this.labelPath.TabIndex = 2;
            this.labelPath.Text = "PATH";
            // 
            // labelDeployVersion
            // 
            this.labelDeployVersion.AutoSize = true;
            this.labelDeployVersion.Location = new System.Drawing.Point(12, 103);
            this.labelDeployVersion.Name = "labelDeployVersion";
            this.labelDeployVersion.Size = new System.Drawing.Size(101, 13);
            this.labelDeployVersion.TabIndex = 3;
            this.labelDeployVersion.Text = "VERSION DEPLOY";
            // 
            // labelDatabaseVersion
            // 
            this.labelDatabaseVersion.AutoSize = true;
            this.labelDatabaseVersion.Location = new System.Drawing.Point(12, 125);
            this.labelDatabaseVersion.Name = "labelDatabaseVersion";
            this.labelDatabaseVersion.Size = new System.Drawing.Size(73, 13);
            this.labelDatabaseVersion.TabIndex = 4;
            this.labelDatabaseVersion.Text = "VERSION DB";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 193);
            this.Controls.Add(this.labelDatabaseVersion);
            this.Controls.Add(this.labelDeployVersion);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.labelAppVersion);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "О программе";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AboutForm_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAppVersion;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Label labelDeployVersion;
        private System.Windows.Forms.Label labelDatabaseVersion;

    }
}