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
            this.gOSTSelectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.edocbaseDataSet = new Edocsys.EdocbaseDataSet();
            this.tableAdapterManager = new Edocsys.EdocbaseDataSetTableAdapters.TableAdapterManager();
            this.gOSTSelectionDataGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxProductionDocuments = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.GOSTPresenceColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonGOST = new System.Windows.Forms.RadioButton();
            this.radioButtonTU = new System.Windows.Forms.RadioButton();
            this.buttonRefreshGostList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gOSTSelectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edocbaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gOSTSelectionDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gOSTSelectionTableAdapter
            // 
            this.gOSTSelectionTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.GOSTSelectionTableAdapter = this.gOSTSelectionTableAdapter;
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
            this.gOSTSelectionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gOSTSelectionDataGridView.Location = new System.Drawing.Point(0, 112);
            this.gOSTSelectionDataGridView.MultiSelect = false;
            this.gOSTSelectionDataGridView.Name = "gOSTSelectionDataGridView";
            this.gOSTSelectionDataGridView.Size = new System.Drawing.Size(471, 154);
            this.gOSTSelectionDataGridView.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.textBoxProductionDocuments);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(471, 112);
            this.panel2.TabIndex = 12;
            // 
            // textBoxProductionDocuments
            // 
            this.textBoxProductionDocuments.Location = new System.Drawing.Point(100, 79);
            this.textBoxProductionDocuments.Name = "textBoxProductionDocuments";
            this.textBoxProductionDocuments.Size = new System.Drawing.Size(350, 20);
            this.textBoxProductionDocuments.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выполнено по";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonAccept);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 266);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 51);
            this.panel1.TabIndex = 11;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(276, 14);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Закрыть";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(100, 14);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(75, 23);
            this.buttonAccept.TabIndex = 9;
            this.buttonAccept.Text = "Сохранить";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonRefreshGostList);
            this.groupBox1.Controls.Add(this.radioButtonTU);
            this.groupBox1.Controls.Add(this.radioButtonGOST);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 65);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Условия производства и соответствия";
            // 
            // radioButtonGOST
            // 
            this.radioButtonGOST.AutoSize = true;
            this.radioButtonGOST.Checked = true;
            this.radioButtonGOST.Location = new System.Drawing.Point(12, 19);
            this.radioButtonGOST.Name = "radioButtonGOST";
            this.radioButtonGOST.Size = new System.Drawing.Size(53, 17);
            this.radioButtonGOST.TabIndex = 0;
            this.radioButtonGOST.TabStop = true;
            this.radioButtonGOST.Text = "ГОСТ";
            this.radioButtonGOST.UseVisualStyleBackColor = true;
            this.radioButtonGOST.CheckedChanged += new System.EventHandler(this.radioButtonGOST_CheckedChanged);
            // 
            // radioButtonTU
            // 
            this.radioButtonTU.AutoSize = true;
            this.radioButtonTU.Location = new System.Drawing.Point(12, 42);
            this.radioButtonTU.Name = "radioButtonTU";
            this.radioButtonTU.Size = new System.Drawing.Size(40, 17);
            this.radioButtonTU.TabIndex = 1;
            this.radioButtonTU.Text = "ТУ";
            this.radioButtonTU.UseVisualStyleBackColor = true;
            this.radioButtonTU.CheckedChanged += new System.EventHandler(this.radioButtonTU_CheckedChanged);
            // 
            // buttonRefreshGostList
            // 
            this.buttonRefreshGostList.Location = new System.Drawing.Point(267, 25);
            this.buttonRefreshGostList.Name = "buttonRefreshGostList";
            this.buttonRefreshGostList.Size = new System.Drawing.Size(192, 23);
            this.buttonRefreshGostList.TabIndex = 2;
            this.buttonRefreshGostList.Text = "Перезаполнить список ГОСТов";
            this.buttonRefreshGostList.UseVisualStyleBackColor = true;
            this.buttonRefreshGostList.Click += new System.EventHandler(this.buttonRefreshGostList_Click);
            // 
            // GOSTSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(471, 317);
            this.Controls.Add(this.gOSTSelectionDataGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "GOSTSelectionTitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GOSTSelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = global::Edocsys.Properties.Settings.Default.GOSTSelectionTitle;
            this.Load += new System.EventHandler(this.gostselection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gOSTSelectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edocbaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gOSTSelectionDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private EdocbaseDataSet edocbaseDataSet;
        private EdocbaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource gOSTSelectionBindingSource;
        private EdocbaseDataSetTableAdapters.GOSTSelectionTableAdapter gOSTSelectionTableAdapter;
        private System.Windows.Forms.DataGridView gOSTSelectionDataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn GOSTPresenceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxProductionDocuments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonTU;
        private System.Windows.Forms.RadioButton radioButtonGOST;
        private System.Windows.Forms.Button buttonRefreshGostList;
    }
}