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
            this.components = new System.ComponentModel.Container();
            this.buttonBadJobByAgent = new System.Windows.Forms.Button();
            this.buttonBadJobByExpert = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.edocbaseDataSet = new Edocsys.EdocbaseDataSet();
            this.contractsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractsTableAdapter = new Edocsys.EdocbaseDataSetTableAdapters.contractsTableAdapter();
            this.tableAdapterManager = new Edocsys.EdocbaseDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.edocbaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsBindingSource)).BeginInit();
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
            this.buttonBadJobByExpert.Click += new System.EventHandler(this.buttonBadJobByExpert_Click);
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
            // edocbaseDataSet
            // 
            this.edocbaseDataSet.CaseSensitive = true;
            this.edocbaseDataSet.DataSetName = "EdocbaseDataSet";
            this.edocbaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contractsBindingSource
            // 
            this.contractsBindingSource.DataMember = "contracts";
            this.contractsBindingSource.DataSource = this.edocbaseDataSet;
            // 
            // contractsTableAdapter
            // 
            this.contractsTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ContractPaymentsTableAdapter = null;
            this.tableAdapterManager.ContractPrepareForWorkTAdapter = null;
            this.tableAdapterManager.ContractSigningTableAdapter = null;
            this.tableAdapterManager.ContractsOnInspectionTableAdapter = null;
            this.tableAdapterManager.contractsTableAdapter = this.contractsTableAdapter;
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
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // DeleteContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 175);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonBadJobByExpert);
            this.Controls.Add(this.buttonBadJobByAgent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DeleteContractForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Расторгнуть договор";
            this.Load += new System.EventHandler(this.DeleteContractForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.edocbaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBadJobByAgent;
        private System.Windows.Forms.Button buttonBadJobByExpert;
        private System.Windows.Forms.Button buttonCancel;
        private EdocbaseDataSet edocbaseDataSet;
        private System.Windows.Forms.BindingSource contractsBindingSource;
        private EdocbaseDataSetTableAdapters.contractsTableAdapter contractsTableAdapter;
        private EdocbaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}