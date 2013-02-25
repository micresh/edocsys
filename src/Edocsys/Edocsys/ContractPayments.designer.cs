namespace Edocsys
{
    partial class ContractPaymentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContractPaymentsForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabInWork = new System.Windows.Forms.TabPage();
            this.contractInWorkDataGridView = new System.Windows.Forms.DataGridView();
            this.numberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsnameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentsnameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agenttypesnameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contracttypesnameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datestartDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateendDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daystodeadlineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalcostDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentsfullnameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datesampleincomeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateprotocolincomeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expertFIODataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkDoneColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.contractInWorkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.edocbaseDataSet = new Edocsys.EdocbaseDataSet();
            this.bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.filterInWorkTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.contractSigningBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractPrepareForWorkBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.tabInWork.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractInWorkDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractInWorkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edocbaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
            this.bindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractSigningBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractPrepareForWorkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractComplitionMgrCfmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractDocDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabInWork);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1114, 470);
            this.tabControl.TabIndex = 2;
            // 
            // tabInWork
            // 
            this.tabInWork.AutoScroll = true;
            this.tabInWork.Controls.Add(this.contractInWorkDataGridView);
            this.tabInWork.Controls.Add(this.bindingNavigator);
            this.tabInWork.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ContractPaymentsTitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tabInWork.Location = new System.Drawing.Point(4, 22);
            this.tabInWork.Name = "tabInWork";
            this.tabInWork.Padding = new System.Windows.Forms.Padding(3);
            this.tabInWork.Size = new System.Drawing.Size(1106, 444);
            this.tabInWork.TabIndex = 1;
            this.tabInWork.Text = global::Edocsys.Properties.Settings.Default.ContractPaymentsTitle;
            this.tabInWork.UseVisualStyleBackColor = true;
            // 
            // contractInWorkDataGridView
            // 
            this.contractInWorkDataGridView.AutoGenerateColumns = false;
            this.contractInWorkDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contractInWorkDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn1,
            this.productsnameDataGridViewTextBoxColumn2,
            this.agentsnameDataGridViewTextBoxColumn2,
            this.agenttypesnameDataGridViewTextBoxColumn2,
            this.contracttypesnameDataGridViewTextBoxColumn2,
            this.datestartDataGridViewTextBoxColumn1,
            this.dateendDataGridViewTextBoxColumn1,
            this.daystodeadlineDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn2,
            this.totalcostDataGridViewTextBoxColumn2,
            this.agentsfullnameDataGridViewTextBoxColumn2,
            this.datesampleincomeDataGridViewTextBoxColumn1,
            this.dateprotocolincomeDataGridViewTextBoxColumn1,
            this.expertFIODataGridViewTextBoxColumn2,
            this.WorkDoneColumn});
            this.contractInWorkDataGridView.DataSource = this.contractInWorkBindingSource;
            this.contractInWorkDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contractInWorkDataGridView.Location = new System.Drawing.Point(3, 28);
            this.contractInWorkDataGridView.Name = "contractInWorkDataGridView";
            this.contractInWorkDataGridView.Size = new System.Drawing.Size(1100, 413);
            this.contractInWorkDataGridView.TabIndex = 29;
            this.contractInWorkDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.contractInWorkDataGridView_CellContentClick);
            // 
            // numberDataGridViewTextBoxColumn1
            // 
            this.numberDataGridViewTextBoxColumn1.HeaderText = "Номер договора";
            this.numberDataGridViewTextBoxColumn1.Name = "numberDataGridViewTextBoxColumn1";
            // 
            // productsnameDataGridViewTextBoxColumn2
            // 
            this.productsnameDataGridViewTextBoxColumn2.HeaderText = "Продукция";
            this.productsnameDataGridViewTextBoxColumn2.Name = "productsnameDataGridViewTextBoxColumn2";
            // 
            // agentsnameDataGridViewTextBoxColumn2
            // 
            this.agentsnameDataGridViewTextBoxColumn2.HeaderText = "Контрагент";
            this.agentsnameDataGridViewTextBoxColumn2.Name = "agentsnameDataGridViewTextBoxColumn2";
            // 
            // agenttypesnameDataGridViewTextBoxColumn2
            // 
            this.agenttypesnameDataGridViewTextBoxColumn2.HeaderText = "Форма";
            this.agenttypesnameDataGridViewTextBoxColumn2.Name = "agenttypesnameDataGridViewTextBoxColumn2";
            this.agenttypesnameDataGridViewTextBoxColumn2.Width = 50;
            // 
            // contracttypesnameDataGridViewTextBoxColumn2
            // 
            this.contracttypesnameDataGridViewTextBoxColumn2.HeaderText = "Тип работ";
            this.contracttypesnameDataGridViewTextBoxColumn2.Name = "contracttypesnameDataGridViewTextBoxColumn2";
            // 
            // datestartDataGridViewTextBoxColumn1
            // 
            this.datestartDataGridViewTextBoxColumn1.HeaderText = "Дата начала работ";
            this.datestartDataGridViewTextBoxColumn1.Name = "datestartDataGridViewTextBoxColumn1";
            // 
            // dateendDataGridViewTextBoxColumn1
            // 
            this.dateendDataGridViewTextBoxColumn1.HeaderText = "Дата окончания работ";
            this.dateendDataGridViewTextBoxColumn1.Name = "dateendDataGridViewTextBoxColumn1";
            // 
            // daystodeadlineDataGridViewTextBoxColumn
            // 
            this.daystodeadlineDataGridViewTextBoxColumn.DataPropertyName = "days_to_deadline";
            this.daystodeadlineDataGridViewTextBoxColumn.HeaderText = "Дней до окончания";
            this.daystodeadlineDataGridViewTextBoxColumn.Name = "daystodeadlineDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn2
            // 
            this.costDataGridViewTextBoxColumn2.HeaderText = "Сумма";
            this.costDataGridViewTextBoxColumn2.Name = "costDataGridViewTextBoxColumn2";
            // 
            // totalcostDataGridViewTextBoxColumn2
            // 
            this.totalcostDataGridViewTextBoxColumn2.HeaderText = "Общая сумма";
            this.totalcostDataGridViewTextBoxColumn2.Name = "totalcostDataGridViewTextBoxColumn2";
            // 
            // agentsfullnameDataGridViewTextBoxColumn2
            // 
            this.agentsfullnameDataGridViewTextBoxColumn2.HeaderText = "Контрагент";
            this.agentsfullnameDataGridViewTextBoxColumn2.Name = "agentsfullnameDataGridViewTextBoxColumn2";
            // 
            // datesampleincomeDataGridViewTextBoxColumn1
            // 
            this.datesampleincomeDataGridViewTextBoxColumn1.HeaderText = "Дата предоставления образцов";
            this.datesampleincomeDataGridViewTextBoxColumn1.Name = "datesampleincomeDataGridViewTextBoxColumn1";
            // 
            // dateprotocolincomeDataGridViewTextBoxColumn1
            // 
            this.dateprotocolincomeDataGridViewTextBoxColumn1.HeaderText = "Дата предоставления протокола";
            this.dateprotocolincomeDataGridViewTextBoxColumn1.Name = "dateprotocolincomeDataGridViewTextBoxColumn1";
            // 
            // expertFIODataGridViewTextBoxColumn2
            // 
            this.expertFIODataGridViewTextBoxColumn2.HeaderText = "Эксперт";
            this.expertFIODataGridViewTextBoxColumn2.Name = "expertFIODataGridViewTextBoxColumn2";
            // 
            // WorkDoneColumn
            // 
            this.WorkDoneColumn.HeaderText = "Работа завершена";
            this.WorkDoneColumn.Name = "WorkDoneColumn";
            // 
            // contractInWorkBindingSource
            // 
            this.contractInWorkBindingSource.DataMember = "ContractInWork";
            this.contractInWorkBindingSource.DataSource = this.edocbaseDataSet;
            // 
            // edocbaseDataSet
            // 
            this.edocbaseDataSet.CaseSensitive = true;
            this.edocbaseDataSet.DataSetName = "EdocbaseDataSet";
            this.edocbaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigator
            // 
            this.bindingNavigator.AddNewItem = null;
            this.bindingNavigator.BindingSource = this.contractInWorkBindingSource;
            this.bindingNavigator.CountItem = this.toolStripLabel2;
            this.bindingNavigator.DeleteItem = null;
            this.bindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator2,
            this.toolStripTextBox1,
            this.toolStripLabel2,
            this.toolStripSeparator3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripSeparator4,
            this.toolStripButton1,
            this.toolStripButton6,
            this.toolStripSeparator5,
            this.toolStripLabel3,
            this.filterInWorkTextBox});
            this.bindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator.MoveFirstItem = this.toolStripButton2;
            this.bindingNavigator.MoveLastItem = this.toolStripButton5;
            this.bindingNavigator.MoveNextItem = this.toolStripButton4;
            this.bindingNavigator.MovePreviousItem = this.toolStripButton3;
            this.bindingNavigator.Name = "bindingNavigator";
            this.bindingNavigator.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator.Size = new System.Drawing.Size(1100, 25);
            this.bindingNavigator.TabIndex = 28;
            this.bindingNavigator.Text = "bindingNavigator2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel2.Text = "of {0}";
            this.toolStripLabel2.ToolTipText = "Total number of items";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Move first";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Move previous";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Move next";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Move last";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Delete";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Save Data";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(42, 22);
            this.toolStripLabel3.Text = "Поиск";
            // 
            // filterInWorkTextBox
            // 
            this.filterInWorkTextBox.Name = "filterInWorkTextBox";
            this.filterInWorkTextBox.Size = new System.Drawing.Size(200, 25);
            // 
            // contractSigningBindingSource
            // 
            this.contractSigningBindingSource.DataMember = "ContractSigning";
            this.contractSigningBindingSource.DataSource = this.edocbaseDataSet;
            // 
            // contractPrepareForWorkBindingSource
            // 
            this.contractPrepareForWorkBindingSource.DataMember = "ContractPrepareForWork";
            this.contractPrepareForWorkBindingSource.DataSource = this.edocbaseDataSet;
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
            // ContractPaymentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 470);
            this.Controls.Add(this.tabControl);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ContractPaymentsTitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Name = "ContractPaymentsForm";
            this.Text = global::Edocsys.Properties.Settings.Default.ContractPaymentsTitle;
            this.Load += new System.EventHandler(this.ContractsForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabInWork.ResumeLayout(false);
            this.tabInWork.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractInWorkDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractInWorkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edocbaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
            this.bindingNavigator.ResumeLayout(false);
            this.bindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractSigningBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractPrepareForWorkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractComplitionMgrCfmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractDocDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EdocbaseDataSet edocbaseDataSet;
        private EdocbaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabInWork;
        private System.Windows.Forms.DataGridView contractInWorkDataGridView;
        private System.Windows.Forms.BindingNavigator bindingNavigator;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox filterInWorkTextBox;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productsnameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentsnameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn agenttypesnameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn contracttypesnameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn datestartDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateendDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn daystodeadlineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalcostDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentsfullnameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn datesampleincomeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateprotocolincomeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn expertFIODataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn WorkDoneColumn;
        private System.Windows.Forms.BindingSource contractComplitionMgrCfmBindingSource;
        private EdocbaseDataSetTableAdapters.ContractComplitionMgrCfmTableAdapter contractComplitionMgrCfmTableAdapter;

        //private EdocbaseDataSetTableAdapters.Exec_contractsTableAdapter exec_contractsTableAdapter;
    }
}