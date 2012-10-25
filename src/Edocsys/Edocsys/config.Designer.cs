namespace Edocsys
{
    partial class ConfigForm
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
            this.buttonSaveConfig = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxHost = new System.Windows.Forms.TextBox();
            this.labelHost = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.textBoxDatabase = new System.Windows.Forms.TextBox();
            this.labelDatabase = new System.Windows.Forms.Label();
            this.buttonResetToDefaults = new System.Windows.Forms.Button();
            this.buttonTestConnection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSaveConfig
            // 
            this.buttonSaveConfig.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ConfigSaveText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonSaveConfig.Location = new System.Drawing.Point(159, 208);
            this.buttonSaveConfig.Name = "buttonSaveConfig";
            this.buttonSaveConfig.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveConfig.TabIndex = 0;
            this.buttonSaveConfig.Text = global::Edocsys.Properties.Settings.Default.ConfigSaveText;
            this.buttonSaveConfig.UseVisualStyleBackColor = true;
            this.buttonSaveConfig.Click += new System.EventHandler(this.buttonSaveConfig_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ConfigCancelText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonCancel.Location = new System.Drawing.Point(280, 208);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = global::Edocsys.Properties.Settings.Default.ConfigCancelText;
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxHost
            // 
            this.textBoxHost.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ConnHost", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxHost.Location = new System.Drawing.Point(49, 6);
            this.textBoxHost.Name = "textBoxHost";
            this.textBoxHost.Size = new System.Drawing.Size(222, 20);
            this.textBoxHost.TabIndex = 2;
            this.textBoxHost.Text = global::Edocsys.Properties.Settings.Default.ConnHost;
            // 
            // labelHost
            // 
            this.labelHost.AutoSize = true;
            this.labelHost.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ConfigHostText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.labelHost.Location = new System.Drawing.Point(12, 9);
            this.labelHost.Name = "labelHost";
            this.labelHost.Size = new System.Drawing.Size(31, 13);
            this.labelHost.TabIndex = 3;
            this.labelHost.Text = global::Edocsys.Properties.Settings.Default.ConfigHostText;
            // 
            // textBoxPort
            // 
            this.textBoxPort.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ConnPort", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxPort.Location = new System.Drawing.Point(315, 6);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(52, 20);
            this.textBoxPort.TabIndex = 4;
            this.textBoxPort.Text = global::Edocsys.Properties.Settings.Default.ConnPort;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ConfigPortText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.labelPort.Location = new System.Drawing.Point(277, 9);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(32, 13);
            this.labelPort.TabIndex = 5;
            this.labelPort.Text = global::Edocsys.Properties.Settings.Default.ConfigPortText;
            // 
            // textBoxDatabase
            // 
            this.textBoxDatabase.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ConnDatabase", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxDatabase.Location = new System.Drawing.Point(116, 79);
            this.textBoxDatabase.Name = "textBoxDatabase";
            this.textBoxDatabase.Size = new System.Drawing.Size(251, 20);
            this.textBoxDatabase.TabIndex = 6;
            this.textBoxDatabase.Text = global::Edocsys.Properties.Settings.Default.ConnDatabase;
            // 
            // labelDatabase
            // 
            this.labelDatabase.AutoSize = true;
            this.labelDatabase.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ConfigDatabaseText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.labelDatabase.Location = new System.Drawing.Point(12, 82);
            this.labelDatabase.Name = "labelDatabase";
            this.labelDatabase.Size = new System.Drawing.Size(98, 13);
            this.labelDatabase.TabIndex = 7;
            this.labelDatabase.Text = global::Edocsys.Properties.Settings.Default.ConfigDatabaseText;
            // 
            // buttonResetToDefaults
            // 
            this.buttonResetToDefaults.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ConfigResetToDefaults", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonResetToDefaults.Location = new System.Drawing.Point(15, 208);
            this.buttonResetToDefaults.Name = "buttonResetToDefaults";
            this.buttonResetToDefaults.Size = new System.Drawing.Size(95, 23);
            this.buttonResetToDefaults.TabIndex = 8;
            this.buttonResetToDefaults.Text = global::Edocsys.Properties.Settings.Default.ConfigResetToDefaults;
            this.buttonResetToDefaults.UseVisualStyleBackColor = true;
            this.buttonResetToDefaults.Click += new System.EventHandler(this.buttonResetToDefaults_Click);
            // 
            // buttonTestConnection
            // 
            this.buttonTestConnection.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ConfigTestConnectionText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonTestConnection.Location = new System.Drawing.Point(12, 41);
            this.buttonTestConnection.Name = "buttonTestConnection";
            this.buttonTestConnection.Size = new System.Drawing.Size(183, 23);
            this.buttonTestConnection.TabIndex = 9;
            this.buttonTestConnection.Text = global::Edocsys.Properties.Settings.Default.ConfigTestConnectionText;
            this.buttonTestConnection.UseVisualStyleBackColor = true;
            this.buttonTestConnection.Click += new System.EventHandler(this.buttonTestConnection_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 243);
            this.Controls.Add(this.buttonTestConnection);
            this.Controls.Add(this.buttonResetToDefaults);
            this.Controls.Add(this.labelDatabase);
            this.Controls.Add(this.textBoxDatabase);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.labelHost);
            this.Controls.Add(this.textBoxHost);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSaveConfig);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ConfigFormText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Name = "ConfigForm";
            this.Text = global::Edocsys.Properties.Settings.Default.ConfigFormText;
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveConfig;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxHost;
        private System.Windows.Forms.Label labelHost;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.TextBox textBoxDatabase;
        private System.Windows.Forms.Label labelDatabase;
        private System.Windows.Forms.Button buttonResetToDefaults;
        private System.Windows.Forms.Button buttonTestConnection;
    }
}