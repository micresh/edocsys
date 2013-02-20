namespace Edocsys
{
    partial class GOSTSelectionForm
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
            this.gOSTSelectionTableAdapter = new Edocsys.EdocbaseDataSetTableAdapters.GOSTSelectionTableAdapter();
            this.gOSTSelectionDataGridView = new System.Windows.Forms.DataGridView();
            this.gOSTSelectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.edocbaseDataSet = new Edocsys.EdocbaseDataSet();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tableAdapterManager = new Edocsys.EdocbaseDataSetTableAdapters.TableAdapterManager();
            this.GOSTPresenceColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gOSTSelectionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gOSTSelectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edocbaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gOSTSelectionTableAdapter
            // 
            this.gOSTSelectionTableAdapter.ClearBeforeFill = true;
            // 
            // gOSTSelectionDataGridView
            // 
            this.gOSTSelectionDataGridView.AllowUserToAddRows = false;
            this.gOSTSelectionDataGridView.AllowUserToDeleteRows = false;
            this.gOSTSelectionDataGridView.AutoGenerateColumns = false;
            this.gOSTSelectionDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gOSTSelectionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gOSTSelectionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GOSTPresenceColumn,
            this.number,
            this.type});
            this.gOSTSelectionDataGridView.DataSource = this.gOSTSelectionBindingSource;
            this.gOSTSelectionDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.gOSTSelectionDataGridView.Location = new System.Drawing.Point(0, 0);
            this.gOSTSelectionDataGridView.MultiSelect = false;
            this.gOSTSelectionDataGridView.Name = "gOSTSelectionDataGridView";
            this.gOSTSelectionDataGridView.Size = new System.Drawing.Size(470, 220);
            this.gOSTSelectionDataGridView.TabIndex = 1;
            // 
            // gOSTSelectionBindingSource
            // 
            this.gOSTSelectionBindingSource.DataMember = "GOSTSelection";
            this.gOSTSelectionBindingSource.DataSource = this.edocbaseDataSet;
            // 
            // edocbaseDataSet
            // 
            this.edocbaseDataSet.CaseSensitive = true;
            this.edocbaseDataSet.DataSetName = "EdocbaseDataSet";
            this.edocbaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(97, 237);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(75, 23);
            this.buttonAccept.TabIndex = 8;
            this.buttonAccept.Text = "Сохранить";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(283, 237);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Закрыть";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
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
            this.tableAdapterManager.contractsTableAdapter = null;
            this.tableAdapterManager.doc_templatesTableAdapter = null;
            this.tableAdapterManager.documentsTableAdapter = null;
            this.tableAdapterManager.emission_typesTableAdapter = null;
            this.tableAdapterManager.expertsTableAdapter = null;
            this.tableAdapterManager.GOSTSelectionTableAdapter = this.gOSTSelectionTableAdapter;
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
            // GOSTPresenceColumn
            // 
            this.GOSTPresenceColumn.DataPropertyName = "using_gost";
            this.GOSTPresenceColumn.HeaderText = "Использовать ГОСТ";
            this.GOSTPresenceColumn.Name = "GOSTPresenceColumn";
            this.GOSTPresenceColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GOSTPresenceColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // number
            // 
            this.number.DataPropertyName = "number";
            this.number.HeaderText = "Номер";
            this.number.Name = "number";
            // 
            // type
            // 
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "Тип";
            this.type.Name = "type";
            this.type.Width = 200;
            // 
            // GOSTSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 279);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.gOSTSelectionDataGridView);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "GOSTSelectionTitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Name = "GOSTSelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = global::Edocsys.Properties.Settings.Default.GOSTSelectionTitle;
            this.Load += new System.EventHandler(this.gostselection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gOSTSelectionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gOSTSelectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edocbaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EdocbaseDataSet edocbaseDataSet;
        private EdocbaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource gOSTSelectionBindingSource;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonCancel;
        private EdocbaseDataSetTableAdapters.GOSTSelectionTableAdapter gOSTSelectionTableAdapter;
        private System.Windows.Forms.DataGridView gOSTSelectionDataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn GOSTPresenceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
    }
}