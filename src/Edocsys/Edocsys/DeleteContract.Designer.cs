namespace Edocsys
{
    partial class DeleteContractForm
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
            this.buttonBadJobByAgent = new System.Windows.Forms.Button();
            this.buttonBadJobByExpert = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBadJobByAgent
            // 
            this.buttonBadJobByAgent.Location = new System.Drawing.Point(27, 25);
            this.buttonBadJobByAgent.Name = "buttonBadJobByAgent";
            this.buttonBadJobByAgent.Size = new System.Drawing.Size(196, 23);
            this.buttonBadJobByAgent.TabIndex = 0;
            this.buttonBadJobByAgent.Text = "Невыполнение по вине заказчика";
            this.buttonBadJobByAgent.UseVisualStyleBackColor = true;
            this.buttonBadJobByAgent.Click += new System.EventHandler(this.buttonBadJobByAgent_Click);
            // 
            // buttonBadJobByExpert
            // 
            this.buttonBadJobByExpert.Location = new System.Drawing.Point(27, 72);
            this.buttonBadJobByExpert.Name = "buttonBadJobByExpert";
            this.buttonBadJobByExpert.Size = new System.Drawing.Size(196, 23);
            this.buttonBadJobByExpert.TabIndex = 1;
            this.buttonBadJobByExpert.Text = "Невыполнение по вине эксперта";
            this.buttonBadJobByExpert.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(82, 127);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // DeleteContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 173);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonBadJobByExpert);
            this.Controls.Add(this.buttonBadJobByAgent);
            this.Name = "DeleteContractForm";
            this.Text = "Расторгнуть договор";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBadJobByAgent;
        private System.Windows.Forms.Button buttonBadJobByExpert;
        private System.Windows.Forms.Button buttonCancel;
    }
}