namespace Edocsys
{
    partial class InspectionControlForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabReattestationSign = new System.Windows.Forms.TabPage();
            this.tabInspectionControl = new System.Windows.Forms.TabPage();
            this.contractSigningBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.edocbaseDataSet = new Edocsys.EdocbaseDataSet();
            this.contractPrepareForWorkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractInWorkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractComplitionMgrCfmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tableAdapterManager = new Edocsys.EdocbaseDataSetTableAdapters.TableAdapterManager();
            this.contractSigningTableAdapter = new Edocsys.EdocbaseDataSetTableAdapters.ContractSigningTableAdapter();
            this.contractDocDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractDocDataTableAdapter = new Edocsys.EdocbaseDataSetTableAdapters.ContractDocDataTableAdapter();
            this.contractPrepareForWorkTAdapter = new Edocsys.EdocbaseDataSetTableAdapters.ContractPrepareForWorkTAdapter();
            this.contractInWorkTableAdapter = new Edocsys.EdocbaseDataSetTableAdapters.ContractInWorkTableAdapter();
            this.contractComplitionMgrCfmTableAdapter = new Edocsys.EdocbaseDataSetTableAdapters.ContractComplitionMgrCfmTableAdapter();
            this.tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractSigningBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edocbaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractPrepareForWorkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractInWorkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractComplitionMgrCfmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractDocDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabReattestationSign);
            this.tabControl.Controls.Add(this.tabInspectionControl);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1114, 470);
            this.tabControl.TabIndex = 2;
            // 
            // tabReattestationSign
            // 
            this.tabReattestationSign.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ReattestationSignTitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tabReattestationSign.Location = new System.Drawing.Point(4, 22);
            this.tabReattestationSign.Name = "tabReattestationSign";
            this.tabReattestationSign.Padding = new System.Windows.Forms.Padding(3);
            this.tabReattestationSign.Size = new System.Drawing.Size(1106, 444);
            this.tabReattestationSign.TabIndex = 6;
            this.tabReattestationSign.Text = global::Edocsys.Properties.Settings.Default.ReattestationSignTitle;
            this.tabReattestationSign.UseVisualStyleBackColor = true;
            // 
            // tabInspectionControl
            // 
            this.tabInspectionControl.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "InspectionControlTitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tabInspectionControl.Location = new System.Drawing.Point(4, 22);
            this.tabInspectionControl.Name = "tabInspectionControl";
            this.tabInspectionControl.Padding = new System.Windows.Forms.Padding(3);
            this.tabInspectionControl.Size = new System.Drawing.Size(1106, 444);
            this.tabInspectionControl.TabIndex = 7;
            this.tabInspectionControl.Text = global::Edocsys.Properties.Settings.Default.InspectionControlTitle;
            this.tabInspectionControl.UseVisualStyleBackColor = true;
            // 
            // contractSigningBindingSource
            // 
            this.contractSigningBindingSource.DataMember = "ContractSigning";
            this.contractSigningBindingSource.DataSource = this.edocbaseDataSet;
            // 
            // edocbaseDataSet
            // 
            this.edocbaseDataSet.CaseSensitive = true;
            this.edocbaseDataSet.DataSetName = "EdocbaseDataSet";
            this.edocbaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contractPrepareForWorkBindingSource
            // 
            this.contractPrepareForWorkBindingSource.DataMember = "ContractPrepareForWork";
            this.contractPrepareForWorkBindingSource.DataSource = this.edocbaseDataSet;
            // 
            // contractInWorkBindingSource
            // 
            this.contractInWorkBindingSource.DataMember = "ContractInWork";
            this.contractInWorkBindingSource.DataSource = this.edocbaseDataSet;
            // 
            // contractComplitionMgrCfmBindingSource
            // 
            this.contractComplitionMgrCfmBindingSource.DataMember = "ContractComplitionMgrCfm";
            this.contractComplitionMgrCfmBindingSource.DataSource = this.edocbaseDataSet;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Файлы Word 2007-2010| *.docx|Все файлы|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Файлы Word 2007-2010| *.docx|Все файлы|*.*";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.agent_typesTableAdapter = null;
            this.tableAdapterManager.agents_contactsTableAdapter = null;
            this.tableAdapterManager.agentsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.contract_statusTableAdapter = null;
            this.tableAdapterManager.contract_types_for_workTableAdapter = null;
            this.tableAdapterManager.contract_typesTableAdapter = null;
            this.tableAdapterManager.ContractInfoTableAdapter = null;
            this.tableAdapterManager.ContractPrepareForWorkTAdapter = null;
            this.tableAdapterManager.ContractSigningTableAdapter = null;
            this.tableAdapterManager.contractsTableAdapter = null;
            this.tableAdapterManager.doc_templatesTableAdapter = null;
            this.tableAdapterManager.documentsTableAdapter = null;
            this.tableAdapterManager.emission_typesTableAdapter = null;
            this.tableAdapterManager.expertsTableAdapter = null;
            this.tableAdapterManager.GOSTSelectionTableAdapter = null;
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
            // contractSigningTableAdapter
            // 
            this.contractSigningTableAdapter.ClearBeforeFill = true;
            // 
            // contractDocDataBindingSource
            // 
            this.contractDocDataBindingSource.DataMember = "ContractDocData";
            this.contractDocDataBindingSource.DataSource = this.edocbaseDataSet;
            // 
            // contractDocDataTableAdapter
            // 
            this.contractDocDataTableAdapter.ClearBeforeFill = true;
            // 
            // contractPrepareForWorkTAdapter
            // 
            this.contractPrepareForWorkTAdapter.ClearBeforeFill = true;
            // 
            // contractInWorkTableAdapter
            // 
            this.contractInWorkTableAdapter.ClearBeforeFill = true;
            // 
            // contractComplitionMgrCfmTableAdapter
            // 
            this.contractComplitionMgrCfmTableAdapter.ClearBeforeFill = true;
            // 
            // InspectionControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 470);
            this.Controls.Add(this.tabControl);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "InspectionControlMenuTitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Name = "InspectionControlForm";
            this.Text = global::Edocsys.Properties.Settings.Default.InspectionControlMenuTitle;
            this.Load += new System.EventHandler(this.ContractsForm_Load);
            this.tabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contractSigningBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edocbaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractPrepareForWorkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractInWorkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractComplitionMgrCfmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractDocDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EdocbaseDataSet edocbaseDataSet;
        private EdocbaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.BindingSource contractSigningBindingSource;
        private EdocbaseDataSetTableAdapters.ContractSigningTableAdapter contractSigningTableAdapter;
        private System.Windows.Forms.BindingSource contractDocDataBindingSource;
        private EdocbaseDataSetTableAdapters.ContractDocDataTableAdapter contractDocDataTableAdapter;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.BindingSource contractPrepareForWorkBindingSource;
        private EdocbaseDataSetTableAdapters.ContractPrepareForWorkTAdapter contractPrepareForWorkTAdapter;
        private System.Windows.Forms.BindingSource contractInWorkBindingSource;
        private EdocbaseDataSetTableAdapters.ContractInWorkTableAdapter contractInWorkTableAdapter;
        private System.Windows.Forms.TabPage tabReattestationSign;
        private System.Windows.Forms.TabPage tabInspectionControl;
        private System.Windows.Forms.BindingSource contractComplitionMgrCfmBindingSource;
        private EdocbaseDataSetTableAdapters.ContractComplitionMgrCfmTableAdapter contractComplitionMgrCfmTableAdapter;

        //private EdocbaseDataSetTableAdapters.Exec_contractsTableAdapter exec_contractsTableAdapter;
    }
}