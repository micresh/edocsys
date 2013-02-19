namespace Edocsys
{
    partial class ContractsForm
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
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContractsForm));
            this.edocbaseDataSet = new Edocsys.EdocbaseDataSet();
            this.tableAdapterManager = new Edocsys.EdocbaseDataSetTableAdapters.TableAdapterManager();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageExpertAssigned = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxContract = new System.Windows.Forms.GroupBox();
            this.contract_typeLabel2 = new System.Windows.Forms.Label();
            this.buttonLoadContract = new System.Windows.Forms.Button();
            this.buttonSaveContract = new System.Windows.Forms.Button();
            this.buttonEditContract = new System.Windows.Forms.Button();
            this.buttonGenerateContract = new System.Windows.Forms.Button();
            this.contractsToStartDataTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessTaskColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.contractsToStartDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractConfirmBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.contractsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tabPageTaskProcessed = new System.Windows.Forms.TabPage();
            this.taskProcessedDataTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskReadyColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.taskProcessedDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageTaskReady = new System.Windows.Forms.TabPage();
            this.taskReadyDataTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConfirmTaskFinishedColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.taskReadyDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageTaskFinished = new System.Windows.Forms.TabPage();
            this.taskFinishedDataTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskFinishedDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageBadJob = new System.Windows.Forms.TabPage();
            this.badJobsDataTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.badJobsDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractConfirmTAdapter = new Edocsys.EdocbaseDataSetTableAdapters.ContractConfirmTAdapter();
            this.taskProcessedDataTableTableAdapter = new Edocsys.EdocbaseDataSetTableAdapters.TaskProcessedDataTableTableAdapter();
            this.taskReadyDataTableTableAdapter = new Edocsys.EdocbaseDataSetTableAdapters.TaskReadyDataTableTableAdapter();
            this.taskFinishedDataTableTableAdapter = new Edocsys.EdocbaseDataSetTableAdapters.TaskFinishedDataTableTableAdapter();
            this.badJobsDataTableTableAdapter = new Edocsys.EdocbaseDataSetTableAdapters.BadJobsDataTableTableAdapter();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.edocbaseDataSet)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPageExpertAssigned.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxContract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractsToStartDataTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsToStartDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractConfirmBindingNavigator)).BeginInit();
            this.contractConfirmBindingNavigator.SuspendLayout();
            this.tabPageTaskProcessed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskProcessedDataTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskProcessedDataTableBindingSource)).BeginInit();
            this.tabPageTaskReady.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskReadyDataTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskReadyDataTableBindingSource)).BeginInit();
            this.tabPageTaskFinished.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskFinishedDataTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskFinishedDataTableBindingSource)).BeginInit();
            this.tabPageBadJob.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.badJobsDataTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.badJobsDataTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ContractTypeText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            label2.Location = new System.Drawing.Point(87, 21);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(124, 13);
            label2.TabIndex = 22;
            label2.Text = global::Edocsys.Properties.Settings.Default.ContractTypeText;
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
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.contract_statusTableAdapter = null;
            this.tableAdapterManager.contract_types_for_workTableAdapter = null;
            this.tableAdapterManager.contract_typesTableAdapter = null;
            this.tableAdapterManager.ContractInfoTableAdapter = null;
            this.tableAdapterManager.contractsTableAdapter = null;
            this.tableAdapterManager.doc_templatesTableAdapter = null;
            this.tableAdapterManager.documentsTableAdapter = null;
            this.tableAdapterManager.emission_typesTableAdapter = null;
            this.tableAdapterManager.expertsTableAdapter = null;
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
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageExpertAssigned);
            this.tabControl.Controls.Add(this.tabPageTaskProcessed);
            this.tabControl.Controls.Add(this.tabPageTaskReady);
            this.tabControl.Controls.Add(this.tabPageTaskFinished);
            this.tabControl.Controls.Add(this.tabPageBadJob);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(931, 418);
            this.tabControl.TabIndex = 2;
            // 
            // tabPageExpertAssigned
            // 
            this.tabPageExpertAssigned.AutoScroll = true;
            this.tabPageExpertAssigned.Controls.Add(this.panel1);
            this.tabPageExpertAssigned.Controls.Add(this.contractsToStartDataTableDataGridView);
            this.tabPageExpertAssigned.Controls.Add(this.contractConfirmBindingNavigator);
            this.tabPageExpertAssigned.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "TabExpertAssigned", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tabPageExpertAssigned.Location = new System.Drawing.Point(4, 22);
            this.tabPageExpertAssigned.Name = "tabPageExpertAssigned";
            this.tabPageExpertAssigned.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExpertAssigned.Size = new System.Drawing.Size(923, 392);
            this.tabPageExpertAssigned.TabIndex = 0;
            this.tabPageExpertAssigned.Text = global::Edocsys.Properties.Settings.Default.TabExpertAssigned;
            this.tabPageExpertAssigned.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxContract);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 204);
            this.panel1.TabIndex = 25;
            // 
            // groupBoxContract
            // 
            this.groupBoxContract.Controls.Add(label2);
            this.groupBoxContract.Controls.Add(this.contract_typeLabel2);
            this.groupBoxContract.Controls.Add(this.buttonLoadContract);
            this.groupBoxContract.Controls.Add(this.buttonSaveContract);
            this.groupBoxContract.Controls.Add(this.buttonEditContract);
            this.groupBoxContract.Controls.Add(this.buttonGenerateContract);
            this.groupBoxContract.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ContractOperationGroupBox", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBoxContract.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxContract.Location = new System.Drawing.Point(630, 0);
            this.groupBoxContract.Name = "groupBoxContract";
            this.groupBoxContract.Size = new System.Drawing.Size(287, 204);
            this.groupBoxContract.TabIndex = 25;
            this.groupBoxContract.TabStop = false;
            this.groupBoxContract.Text = global::Edocsys.Properties.Settings.Default.ContractOperationGroupBox;
            // 
            // contract_typeLabel2
            // 
            this.contract_typeLabel2.Location = new System.Drawing.Point(18, 35);
            this.contract_typeLabel2.Name = "contract_typeLabel2";
            this.contract_typeLabel2.Size = new System.Drawing.Size(249, 23);
            this.contract_typeLabel2.TabIndex = 21;
            this.contract_typeLabel2.Text = "TYPE";
            this.contract_typeLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonLoadContract
            // 
            this.buttonLoadContract.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "LoadContractTitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonLoadContract.Location = new System.Drawing.Point(21, 166);
            this.buttonLoadContract.Name = "buttonLoadContract";
            this.buttonLoadContract.Size = new System.Drawing.Size(246, 23);
            this.buttonLoadContract.TabIndex = 20;
            this.buttonLoadContract.Text = global::Edocsys.Properties.Settings.Default.LoadContractTitle;
            this.buttonLoadContract.UseVisualStyleBackColor = true;
            // 
            // buttonSaveContract
            // 
            this.buttonSaveContract.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "SaveContractTitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonSaveContract.Location = new System.Drawing.Point(21, 142);
            this.buttonSaveContract.Name = "buttonSaveContract";
            this.buttonSaveContract.Size = new System.Drawing.Size(246, 23);
            this.buttonSaveContract.TabIndex = 19;
            this.buttonSaveContract.Text = global::Edocsys.Properties.Settings.Default.SaveContractTitle;
            this.buttonSaveContract.UseVisualStyleBackColor = true;
            // 
            // buttonEditContract
            // 
            this.buttonEditContract.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "EditContractTitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonEditContract.Location = new System.Drawing.Point(21, 116);
            this.buttonEditContract.Name = "buttonEditContract";
            this.buttonEditContract.Size = new System.Drawing.Size(246, 23);
            this.buttonEditContract.TabIndex = 18;
            this.buttonEditContract.Text = global::Edocsys.Properties.Settings.Default.EditContractTitle;
            this.buttonEditContract.UseVisualStyleBackColor = true;
            // 
            // buttonGenerateContract
            // 
            this.buttonGenerateContract.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "GenerateContractTitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonGenerateContract.Location = new System.Drawing.Point(21, 74);
            this.buttonGenerateContract.Name = "buttonGenerateContract";
            this.buttonGenerateContract.Size = new System.Drawing.Size(246, 23);
            this.buttonGenerateContract.TabIndex = 17;
            this.buttonGenerateContract.Text = global::Edocsys.Properties.Settings.Default.GenerateContractTitle;
            this.buttonGenerateContract.UseVisualStyleBackColor = true;
            this.buttonGenerateContract.Click += new System.EventHandler(this.buttonGenerateContract_Click);
            // 
            // contractsToStartDataTableDataGridView
            // 
            this.contractsToStartDataTableDataGridView.AutoGenerateColumns = false;
            this.contractsToStartDataTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contractsToStartDataTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.ProcessTaskColumn});
            this.contractsToStartDataTableDataGridView.DataSource = this.contractsToStartDataTableBindingSource;
            this.contractsToStartDataTableDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contractsToStartDataTableDataGridView.Location = new System.Drawing.Point(3, 28);
            this.contractsToStartDataTableDataGridView.Name = "contractsToStartDataTableDataGridView";
            this.contractsToStartDataTableDataGridView.Size = new System.Drawing.Size(917, 361);
            this.contractsToStartDataTableDataGridView.TabIndex = 3;
            this.contractsToStartDataTableDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.contractsToStartDataTableDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Contract_number";
            this.dataGridViewTextBoxColumn2.HeaderText = "Номер договора";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ToolTipText = "Номер договора";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Ag_fullname";
            this.dataGridViewTextBoxColumn6.HeaderText = "Контрагнет";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ToolTipText = "Контрагент";
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Product_name";
            this.dataGridViewTextBoxColumn7.HeaderText = "Продукция";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ToolTipText = "Продукция";
            this.dataGridViewTextBoxColumn7.Width = 250;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "expert_fullname";
            this.dataGridViewTextBoxColumn8.HeaderText = "Эксперт";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ToolTipText = "Эксперт";
            this.dataGridViewTextBoxColumn8.Width = 200;
            // 
            // ProcessTaskColumn
            // 
            this.ProcessTaskColumn.HeaderText = "Начать работы";
            this.ProcessTaskColumn.Name = "ProcessTaskColumn";
            // 
            // contractsToStartDataTableBindingSource
            // 
            this.contractsToStartDataTableBindingSource.DataMember = "ContractConfirmed";
            this.contractsToStartDataTableBindingSource.DataSource = this.edocbaseDataSet;
            // 
            // contractConfirmBindingNavigator
            // 
            this.contractConfirmBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.contractConfirmBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.contractConfirmBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.contractConfirmBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.contractsBindingNavigatorSaveItem});
            this.contractConfirmBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.contractConfirmBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.contractConfirmBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.contractConfirmBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.contractConfirmBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.contractConfirmBindingNavigator.Name = "contractConfirmBindingNavigator";
            this.contractConfirmBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.contractConfirmBindingNavigator.Size = new System.Drawing.Size(917, 25);
            this.contractConfirmBindingNavigator.TabIndex = 3;
            this.contractConfirmBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // contractsBindingNavigatorSaveItem
            // 
            this.contractsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.contractsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("contractsBindingNavigatorSaveItem.Image")));
            this.contractsBindingNavigatorSaveItem.Name = "contractsBindingNavigatorSaveItem";
            this.contractsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.contractsBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // tabPageTaskProcessed
            // 
            this.tabPageTaskProcessed.AutoScroll = true;
            this.tabPageTaskProcessed.Controls.Add(this.taskProcessedDataTableDataGridView);
            this.tabPageTaskProcessed.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "TabTaskProcessed", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tabPageTaskProcessed.Location = new System.Drawing.Point(4, 22);
            this.tabPageTaskProcessed.Name = "tabPageTaskProcessed";
            this.tabPageTaskProcessed.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTaskProcessed.Size = new System.Drawing.Size(923, 392);
            this.tabPageTaskProcessed.TabIndex = 1;
            this.tabPageTaskProcessed.Text = global::Edocsys.Properties.Settings.Default.TabTaskProcessed;
            this.tabPageTaskProcessed.UseVisualStyleBackColor = true;
            // 
            // taskProcessedDataTableDataGridView
            // 
            this.taskProcessedDataTableDataGridView.AutoGenerateColumns = false;
            this.taskProcessedDataTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taskProcessedDataTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.TaskReadyColumn});
            this.taskProcessedDataTableDataGridView.DataSource = this.taskProcessedDataTableBindingSource;
            this.taskProcessedDataTableDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskProcessedDataTableDataGridView.Location = new System.Drawing.Point(3, 3);
            this.taskProcessedDataTableDataGridView.Name = "taskProcessedDataTableDataGridView";
            this.taskProcessedDataTableDataGridView.Size = new System.Drawing.Size(917, 386);
            this.taskProcessedDataTableDataGridView.TabIndex = 0;
            this.taskProcessedDataTableDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.taskProcessedDataTableDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Contract_number";
            this.dataGridViewTextBoxColumn3.HeaderText = "Номер договора";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ToolTipText = "Номер договора";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Ag_fullname";
            this.dataGridViewTextBoxColumn10.HeaderText = "Контрагент";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ToolTipText = "Контрагент";
            this.dataGridViewTextBoxColumn10.Width = 200;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Product_name";
            this.dataGridViewTextBoxColumn11.HeaderText = "Продукция";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ToolTipText = "Продукция";
            this.dataGridViewTextBoxColumn11.Width = 250;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "expert_fullname";
            this.dataGridViewTextBoxColumn12.HeaderText = "Эксперт";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ToolTipText = "Эксперт";
            this.dataGridViewTextBoxColumn12.Width = 200;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Contract_start";
            this.dataGridViewTextBoxColumn13.HeaderText = "Начало работ";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ToolTipText = "Начало работ";
            // 
            // TaskReadyColumn
            // 
            this.TaskReadyColumn.HeaderText = "Оформить акт";
            this.TaskReadyColumn.Name = "TaskReadyColumn";
            // 
            // taskProcessedDataTableBindingSource
            // 
            this.taskProcessedDataTableBindingSource.DataMember = "TaskProcessedDataTable";
            this.taskProcessedDataTableBindingSource.DataSource = this.edocbaseDataSet;
            // 
            // tabPageTaskReady
            // 
            this.tabPageTaskReady.AutoScroll = true;
            this.tabPageTaskReady.Controls.Add(this.taskReadyDataTableDataGridView);
            this.tabPageTaskReady.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "TabTaskReady", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tabPageTaskReady.Location = new System.Drawing.Point(4, 22);
            this.tabPageTaskReady.Name = "tabPageTaskReady";
            this.tabPageTaskReady.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTaskReady.Size = new System.Drawing.Size(923, 392);
            this.tabPageTaskReady.TabIndex = 2;
            this.tabPageTaskReady.Text = global::Edocsys.Properties.Settings.Default.TabTaskReady;
            this.tabPageTaskReady.UseVisualStyleBackColor = true;
            // 
            // taskReadyDataTableDataGridView
            // 
            this.taskReadyDataTableDataGridView.AutoGenerateColumns = false;
            this.taskReadyDataTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taskReadyDataTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.ConfirmTaskFinishedColumn});
            this.taskReadyDataTableDataGridView.DataSource = this.taskReadyDataTableBindingSource;
            this.taskReadyDataTableDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskReadyDataTableDataGridView.Location = new System.Drawing.Point(3, 3);
            this.taskReadyDataTableDataGridView.Name = "taskReadyDataTableDataGridView";
            this.taskReadyDataTableDataGridView.Size = new System.Drawing.Size(917, 386);
            this.taskReadyDataTableDataGridView.TabIndex = 0;
            this.taskReadyDataTableDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.taskReadyDataTableDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Contract_number";
            this.dataGridViewTextBoxColumn4.HeaderText = "Номер договара";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ToolTipText = "Номер договара";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Ag_fullname";
            this.dataGridViewTextBoxColumn15.HeaderText = "Контаргент";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ToolTipText = "Контрагент";
            this.dataGridViewTextBoxColumn15.Width = 200;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Product_name";
            this.dataGridViewTextBoxColumn16.HeaderText = "Продукция";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ToolTipText = "Продукция";
            this.dataGridViewTextBoxColumn16.Width = 250;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "expert_fullname";
            this.dataGridViewTextBoxColumn17.HeaderText = "Эксперт";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ToolTipText = "Эксперт";
            this.dataGridViewTextBoxColumn17.Width = 200;
            // 
            // ConfirmTaskFinishedColumn
            // 
            this.ConfirmTaskFinishedColumn.HeaderText = "Подтвердить выполнение";
            this.ConfirmTaskFinishedColumn.Name = "ConfirmTaskFinishedColumn";
            this.ConfirmTaskFinishedColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ConfirmTaskFinishedColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // taskReadyDataTableBindingSource
            // 
            this.taskReadyDataTableBindingSource.DataMember = "TaskReadyDataTable";
            this.taskReadyDataTableBindingSource.DataSource = this.edocbaseDataSet;
            // 
            // tabPageTaskFinished
            // 
            this.tabPageTaskFinished.AutoScroll = true;
            this.tabPageTaskFinished.Controls.Add(this.taskFinishedDataTableDataGridView);
            this.tabPageTaskFinished.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "TabTaskFinished", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tabPageTaskFinished.Location = new System.Drawing.Point(4, 22);
            this.tabPageTaskFinished.Name = "tabPageTaskFinished";
            this.tabPageTaskFinished.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTaskFinished.Size = new System.Drawing.Size(923, 392);
            this.tabPageTaskFinished.TabIndex = 3;
            this.tabPageTaskFinished.Text = global::Edocsys.Properties.Settings.Default.TabTaskFinished;
            this.tabPageTaskFinished.UseVisualStyleBackColor = true;
            // 
            // taskFinishedDataTableDataGridView
            // 
            this.taskFinishedDataTableDataGridView.AutoGenerateColumns = false;
            this.taskFinishedDataTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taskFinishedDataTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21});
            this.taskFinishedDataTableDataGridView.DataSource = this.taskFinishedDataTableBindingSource;
            this.taskFinishedDataTableDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskFinishedDataTableDataGridView.Location = new System.Drawing.Point(3, 3);
            this.taskFinishedDataTableDataGridView.Name = "taskFinishedDataTableDataGridView";
            this.taskFinishedDataTableDataGridView.Size = new System.Drawing.Size(917, 386);
            this.taskFinishedDataTableDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Contract_number";
            this.dataGridViewTextBoxColumn5.HeaderText = "Номер договара";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ToolTipText = "Номер договора";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Ag_fullname";
            this.dataGridViewTextBoxColumn19.HeaderText = "Контрагент";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ToolTipText = "Контрагент";
            this.dataGridViewTextBoxColumn19.Width = 200;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Product_name";
            this.dataGridViewTextBoxColumn20.HeaderText = "Продукция";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ToolTipText = "Продукция";
            this.dataGridViewTextBoxColumn20.Width = 250;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "expert_fullname";
            this.dataGridViewTextBoxColumn21.HeaderText = "Эксперт";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ToolTipText = "Эксперт";
            this.dataGridViewTextBoxColumn21.Width = 200;
            // 
            // taskFinishedDataTableBindingSource
            // 
            this.taskFinishedDataTableBindingSource.DataMember = "TaskFinishedDataTable";
            this.taskFinishedDataTableBindingSource.DataSource = this.edocbaseDataSet;
            // 
            // tabPageBadJob
            // 
            this.tabPageBadJob.Controls.Add(this.badJobsDataTableDataGridView);
            this.tabPageBadJob.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "TabBadJob", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tabPageBadJob.Location = new System.Drawing.Point(4, 22);
            this.tabPageBadJob.Name = "tabPageBadJob";
            this.tabPageBadJob.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBadJob.Size = new System.Drawing.Size(923, 392);
            this.tabPageBadJob.TabIndex = 4;
            this.tabPageBadJob.Text = global::Edocsys.Properties.Settings.Default.TabBadJob;
            this.tabPageBadJob.UseVisualStyleBackColor = true;
            // 
            // badJobsDataTableDataGridView
            // 
            this.badJobsDataTableDataGridView.AutoGenerateColumns = false;
            this.badJobsDataTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.badJobsDataTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25});
            this.badJobsDataTableDataGridView.DataSource = this.badJobsDataTableBindingSource;
            this.badJobsDataTableDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.badJobsDataTableDataGridView.Location = new System.Drawing.Point(3, 3);
            this.badJobsDataTableDataGridView.Name = "badJobsDataTableDataGridView";
            this.badJobsDataTableDataGridView.Size = new System.Drawing.Size(917, 386);
            this.badJobsDataTableDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Contract_number";
            this.dataGridViewTextBoxColumn9.HeaderText = "Номер договора";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ToolTipText = "Номер договора";
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "Ag_fullname";
            this.dataGridViewTextBoxColumn23.HeaderText = "Контрагент";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ToolTipText = "Контрагент";
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Product_name";
            this.dataGridViewTextBoxColumn24.HeaderText = "Продукция";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ToolTipText = "Продукция";
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "expert_fullname";
            this.dataGridViewTextBoxColumn25.HeaderText = "Эксперт";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ToolTipText = "Эксперт";
            // 
            // badJobsDataTableBindingSource
            // 
            this.badJobsDataTableBindingSource.DataMember = "BadJobsDataTable";
            this.badJobsDataTableBindingSource.DataSource = this.edocbaseDataSet;
            // 
            // contractConfirmTAdapter
            // 
            this.contractConfirmTAdapter.ClearBeforeFill = true;
            // 
            // taskProcessedDataTableTableAdapter
            // 
            this.taskProcessedDataTableTableAdapter.ClearBeforeFill = true;
            // 
            // taskReadyDataTableTableAdapter
            // 
            this.taskReadyDataTableTableAdapter.ClearBeforeFill = true;
            // 
            // taskFinishedDataTableTableAdapter
            // 
            this.taskFinishedDataTableTableAdapter.ClearBeforeFill = true;
            // 
            // badJobsDataTableTableAdapter
            // 
            this.badJobsDataTableTableAdapter.ClearBeforeFill = true;
            // 
            // ContractsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 418);
            this.Controls.Add(this.tabControl);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ContractsFormTitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Name = "ContractsForm";
            this.Text = global::Edocsys.Properties.Settings.Default.ContractsFormTitle;
            this.Load += new System.EventHandler(this.ContractsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.edocbaseDataSet)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPageExpertAssigned.ResumeLayout(false);
            this.tabPageExpertAssigned.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBoxContract.ResumeLayout(false);
            this.groupBoxContract.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractsToStartDataTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsToStartDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractConfirmBindingNavigator)).EndInit();
            this.contractConfirmBindingNavigator.ResumeLayout(false);
            this.contractConfirmBindingNavigator.PerformLayout();
            this.tabPageTaskProcessed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.taskProcessedDataTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskProcessedDataTableBindingSource)).EndInit();
            this.tabPageTaskReady.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.taskReadyDataTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskReadyDataTableBindingSource)).EndInit();
            this.tabPageTaskFinished.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.taskFinishedDataTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskFinishedDataTableBindingSource)).EndInit();
            this.tabPageBadJob.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.badJobsDataTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.badJobsDataTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EdocbaseDataSet edocbaseDataSet;
        private EdocbaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageExpertAssigned;
        private System.Windows.Forms.BindingNavigator contractConfirmBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton contractsBindingNavigatorSaveItem;
        private System.Windows.Forms.TabPage tabPageTaskProcessed;
        private System.Windows.Forms.TabPage tabPageTaskReady;
        private System.Windows.Forms.TabPage tabPageTaskFinished;
        private System.Windows.Forms.TabPage tabPageBadJob;
        private System.Windows.Forms.BindingSource contractsToStartDataTableBindingSource;
        private EdocbaseDataSetTableAdapters.ContractConfirmTAdapter contractConfirmTAdapter;
        private System.Windows.Forms.DataGridView contractsToStartDataTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewButtonColumn ProcessTaskColumn;
        private System.Windows.Forms.BindingSource taskProcessedDataTableBindingSource;
        private EdocbaseDataSetTableAdapters.TaskProcessedDataTableTableAdapter taskProcessedDataTableTableAdapter;
        private System.Windows.Forms.DataGridView taskProcessedDataTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewButtonColumn TaskReadyColumn;
        private System.Windows.Forms.BindingSource taskReadyDataTableBindingSource;
        private EdocbaseDataSetTableAdapters.TaskReadyDataTableTableAdapter taskReadyDataTableTableAdapter;
        private System.Windows.Forms.DataGridView taskReadyDataTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewButtonColumn ConfirmTaskFinishedColumn;
        private System.Windows.Forms.BindingSource taskFinishedDataTableBindingSource;
        private EdocbaseDataSetTableAdapters.TaskFinishedDataTableTableAdapter taskFinishedDataTableTableAdapter;
        private System.Windows.Forms.DataGridView taskFinishedDataTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.BindingSource badJobsDataTableBindingSource;
        private EdocbaseDataSetTableAdapters.BadJobsDataTableTableAdapter badJobsDataTableTableAdapter;
        private System.Windows.Forms.DataGridView badJobsDataTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxContract;
        private System.Windows.Forms.Label contract_typeLabel2;
        private System.Windows.Forms.Button buttonLoadContract;
        private System.Windows.Forms.Button buttonSaveContract;
        private System.Windows.Forms.Button buttonEditContract;
        private System.Windows.Forms.Button buttonGenerateContract;

        //private EdocbaseDataSetTableAdapters.Exec_contractsTableAdapter exec_contractsTableAdapter;
    }
}