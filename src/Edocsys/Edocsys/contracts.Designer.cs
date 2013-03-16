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
            System.Windows.Forms.Label date_contractLabel;
            System.Windows.Forms.Label numberLabel;
            System.Windows.Forms.Label costLabel;
            System.Windows.Forms.Label total_costLabel;
            System.Windows.Forms.Label prepaymentLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContractsForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabContractSigning = new System.Windows.Forms.TabPage();
            this.contractsSigningDataGridView = new System.Windows.Forms.DataGridView();
            this.contractSigningBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.edocbaseDataSet = new Edocsys.EdocbaseDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.prepaymentTextBox = new System.Windows.Forms.TextBox();
            this.total_costTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.date_contractDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.groupBoxContract = new System.Windows.Forms.GroupBox();
            this.buttonLoadContract = new System.Windows.Forms.Button();
            this.buttonSaveContract = new System.Windows.Forms.Button();
            this.buttonEditContract = new System.Windows.Forms.Button();
            this.buttonGenerateContract = new System.Windows.Forms.Button();
            this.bindingNavigatorContractSigning = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.usersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.filterContractSigningText = new System.Windows.Forms.ToolStripTextBox();
            this.tabComplitionManagerConfrim = new System.Windows.Forms.TabPage();
            this.contractComplitionManagerConfrimDataGridView = new System.Windows.Forms.DataGridView();
            this.contractComplitionMgrCfmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorComplitionMgrCnf = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton15 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton16 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.filterComplitionTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.tabComplitionAgentConfrim = new System.Windows.Forms.TabPage();
            this.contractDoneDataTableDataGridView = new System.Windows.Forms.DataGridView();
            this.contractDoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.filterContractDoneTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonLoadAct = new System.Windows.Forms.Button();
            this.buttonSaveAct = new System.Windows.Forms.Button();
            this.buttonEditAct = new System.Windows.Forms.Button();
            this.buttonGenerateAct = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tableAdapterManager = new Edocsys.EdocbaseDataSetTableAdapters.TableAdapterManager();
            this.contractSigningTableAdapter = new Edocsys.EdocbaseDataSetTableAdapters.ContractSigningTableAdapter();
            this.contractDocDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractDocDataTableAdapter = new Edocsys.EdocbaseDataSetTableAdapters.ContractDocDataTableAdapter();
            this.contractComplitionMgrCfmTableAdapter = new Edocsys.EdocbaseDataSetTableAdapters.ContractComplitionMgrCfmTableAdapter();
            this.contractDoneTableAdapter = new Edocsys.EdocbaseDataSetTableAdapters.ContractDoneTableAdapter();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contracttypesnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentsnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agenttypesnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prepayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateproposalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentsfullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expertFIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.has_contract_document = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SignContractColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.numberDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentsnameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agenttypesnameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cash_income = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.productsnameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contracttypesnameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalcostDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConfirmTaskFinishedColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.datecontractDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datestartDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateendDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expertFIODataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentsfullnameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentsnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agenttypesnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contracttypesnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cash_income_finish = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FinishContractColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.has_act_document = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ReattSignColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.datecontractDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datestartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalcostDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentsfullnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expertFIODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            date_contractLabel = new System.Windows.Forms.Label();
            numberLabel = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            total_costLabel = new System.Windows.Forms.Label();
            prepaymentLabel = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabContractSigning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractsSigningDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractSigningBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edocbaseDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBoxContract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorContractSigning)).BeginInit();
            this.bindingNavigatorContractSigning.SuspendLayout();
            this.tabComplitionManagerConfrim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractComplitionManagerConfrimDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractComplitionMgrCfmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorComplitionMgrCnf)).BeginInit();
            this.bindingNavigatorComplitionMgrCnf.SuspendLayout();
            this.tabComplitionAgentConfrim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractDoneDataTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractDoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
            this.bindingNavigator.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractDocDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // date_contractLabel
            // 
            date_contractLabel.AutoSize = true;
            date_contractLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ContractDateCTitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            date_contractLabel.Location = new System.Drawing.Point(14, 44);
            date_contractLabel.Name = "date_contractLabel";
            date_contractLabel.Size = new System.Drawing.Size(147, 13);
            date_contractLabel.TabIndex = 25;
            date_contractLabel.Text = global::Edocsys.Properties.Settings.Default.ContractDateCTitle;
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ContractsNumberTitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            numberLabel.Location = new System.Drawing.Point(14, 15);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new System.Drawing.Size(91, 13);
            numberLabel.TabIndex = 29;
            numberLabel.Text = global::Edocsys.Properties.Settings.Default.ContractsNumberTitle;
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new System.Drawing.Point(14, 100);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(41, 13);
            costLabel.TabIndex = 31;
            costLabel.Text = "Сумма";
            // 
            // total_costLabel
            // 
            total_costLabel.AutoSize = true;
            total_costLabel.Location = new System.Drawing.Point(14, 125);
            total_costLabel.Name = "total_costLabel";
            total_costLabel.Size = new System.Drawing.Size(78, 13);
            total_costLabel.TabIndex = 32;
            total_costLabel.Text = "Общая сумма";
            // 
            // prepaymentLabel
            // 
            prepaymentLabel.AutoSize = true;
            prepaymentLabel.Location = new System.Drawing.Point(14, 73);
            prepaymentLabel.Name = "prepaymentLabel";
            prepaymentLabel.Size = new System.Drawing.Size(38, 13);
            prepaymentLabel.TabIndex = 33;
            prepaymentLabel.Text = "Аванс";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabContractSigning);
            this.tabControl.Controls.Add(this.tabComplitionManagerConfrim);
            this.tabControl.Controls.Add(this.tabComplitionAgentConfrim);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1057, 546);
            this.tabControl.TabIndex = 2;
            // 
            // tabContractSigning
            // 
            this.tabContractSigning.AutoScroll = true;
            this.tabContractSigning.Controls.Add(this.contractsSigningDataGridView);
            this.tabContractSigning.Controls.Add(this.panel1);
            this.tabContractSigning.Controls.Add(this.bindingNavigatorContractSigning);
            this.tabContractSigning.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "TabExpertAssigned", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tabContractSigning.Location = new System.Drawing.Point(4, 22);
            this.tabContractSigning.Name = "tabContractSigning";
            this.tabContractSigning.Padding = new System.Windows.Forms.Padding(3);
            this.tabContractSigning.Size = new System.Drawing.Size(740, 444);
            this.tabContractSigning.TabIndex = 0;
            this.tabContractSigning.Text = global::Edocsys.Properties.Settings.Default.TabExpertAssigned;
            this.tabContractSigning.UseVisualStyleBackColor = true;
            // 
            // contractsSigningDataGridView
            // 
            this.contractsSigningDataGridView.AllowUserToAddRows = false;
            this.contractsSigningDataGridView.AllowUserToDeleteRows = false;
            this.contractsSigningDataGridView.AutoGenerateColumns = false;
            this.contractsSigningDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contractsSigningDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.productsnameDataGridViewTextBoxColumn,
            this.contracttypesnameDataGridViewTextBoxColumn,
            this.agentsnameDataGridViewTextBoxColumn,
            this.agenttypesnameDataGridViewTextBoxColumn,
            this.prepayment,
            this.costDataGridViewTextBoxColumn,
            this.totalcostDataGridViewTextBoxColumn,
            this.dateproposalDataGridViewTextBoxColumn,
            this.agentsfullnameDataGridViewTextBoxColumn,
            this.expertFIODataGridViewTextBoxColumn,
            this.has_contract_document,
            this.SignContractColumn});
            this.contractsSigningDataGridView.DataSource = this.contractSigningBindingSource;
            this.contractsSigningDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contractsSigningDataGridView.Location = new System.Drawing.Point(3, 28);
            this.contractsSigningDataGridView.Name = "contractsSigningDataGridView";
            this.contractsSigningDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.contractsSigningDataGridView.Size = new System.Drawing.Size(734, 260);
            this.contractsSigningDataGridView.TabIndex = 27;
            this.contractsSigningDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.contractsSigningDataTableDataGridView_CellContentClick);
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
            // panel1
            // 
            this.panel1.Controls.Add(prepaymentLabel);
            this.panel1.Controls.Add(this.prepaymentTextBox);
            this.panel1.Controls.Add(total_costLabel);
            this.panel1.Controls.Add(this.total_costTextBox);
            this.panel1.Controls.Add(costLabel);
            this.panel1.Controls.Add(this.costTextBox);
            this.panel1.Controls.Add(this.date_contractDateTimePicker);
            this.panel1.Controls.Add(this.numberTextBox);
            this.panel1.Controls.Add(numberLabel);
            this.panel1.Controls.Add(date_contractLabel);
            this.panel1.Controls.Add(this.groupBoxContract);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 288);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 153);
            this.panel1.TabIndex = 25;
            // 
            // prepaymentTextBox
            // 
            this.prepaymentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractSigningBindingSource, "prepayment", true));
            this.prepaymentTextBox.Location = new System.Drawing.Point(184, 70);
            this.prepaymentTextBox.Name = "prepaymentTextBox";
            this.prepaymentTextBox.Size = new System.Drawing.Size(100, 20);
            this.prepaymentTextBox.TabIndex = 34;
            // 
            // total_costTextBox
            // 
            this.total_costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractSigningBindingSource, "total_cost", true));
            this.total_costTextBox.Location = new System.Drawing.Point(184, 122);
            this.total_costTextBox.Name = "total_costTextBox";
            this.total_costTextBox.Size = new System.Drawing.Size(100, 20);
            this.total_costTextBox.TabIndex = 33;
            // 
            // costTextBox
            // 
            this.costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractSigningBindingSource, "cost", true));
            this.costTextBox.Location = new System.Drawing.Point(184, 96);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(100, 20);
            this.costTextBox.TabIndex = 32;
            // 
            // date_contractDateTimePicker
            // 
            this.date_contractDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contractSigningBindingSource, "date_contract", true));
            this.date_contractDateTimePicker.Location = new System.Drawing.Point(184, 38);
            this.date_contractDateTimePicker.Name = "date_contractDateTimePicker";
            this.date_contractDateTimePicker.Size = new System.Drawing.Size(142, 20);
            this.date_contractDateTimePicker.TabIndex = 31;
            // 
            // numberTextBox
            // 
            this.numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractSigningBindingSource, "number", true));
            this.numberTextBox.Location = new System.Drawing.Point(184, 12);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberTextBox.TabIndex = 30;
            // 
            // groupBoxContract
            // 
            this.groupBoxContract.Controls.Add(this.buttonLoadContract);
            this.groupBoxContract.Controls.Add(this.buttonSaveContract);
            this.groupBoxContract.Controls.Add(this.buttonEditContract);
            this.groupBoxContract.Controls.Add(this.buttonGenerateContract);
            this.groupBoxContract.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ContractOperationGroupBox", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBoxContract.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxContract.Location = new System.Drawing.Point(447, 0);
            this.groupBoxContract.Name = "groupBoxContract";
            this.groupBoxContract.Size = new System.Drawing.Size(287, 153);
            this.groupBoxContract.TabIndex = 25;
            this.groupBoxContract.TabStop = false;
            this.groupBoxContract.Text = global::Edocsys.Properties.Settings.Default.ContractOperationGroupBox;
            // 
            // buttonLoadContract
            // 
            this.buttonLoadContract.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "LoadContractTitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonLoadContract.Location = new System.Drawing.Point(21, 119);
            this.buttonLoadContract.Name = "buttonLoadContract";
            this.buttonLoadContract.Size = new System.Drawing.Size(246, 23);
            this.buttonLoadContract.TabIndex = 20;
            this.buttonLoadContract.Text = global::Edocsys.Properties.Settings.Default.LoadContractTitle;
            this.buttonLoadContract.UseVisualStyleBackColor = true;
            this.buttonLoadContract.Click += new System.EventHandler(this.buttonLoadContract_Click);
            // 
            // buttonSaveContract
            // 
            this.buttonSaveContract.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "SaveContractTitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonSaveContract.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.contractSigningBindingSource, "has_contract_document", true));
            this.buttonSaveContract.Location = new System.Drawing.Point(21, 90);
            this.buttonSaveContract.Name = "buttonSaveContract";
            this.buttonSaveContract.Size = new System.Drawing.Size(246, 23);
            this.buttonSaveContract.TabIndex = 19;
            this.buttonSaveContract.Text = global::Edocsys.Properties.Settings.Default.SaveContractTitle;
            this.buttonSaveContract.UseVisualStyleBackColor = true;
            this.buttonSaveContract.Click += new System.EventHandler(this.buttonSaveContract_Click);
            // 
            // buttonEditContract
            // 
            this.buttonEditContract.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "EditContractTitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonEditContract.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.contractSigningBindingSource, "has_contract_document", true));
            this.buttonEditContract.Location = new System.Drawing.Point(21, 61);
            this.buttonEditContract.Name = "buttonEditContract";
            this.buttonEditContract.Size = new System.Drawing.Size(246, 23);
            this.buttonEditContract.TabIndex = 18;
            this.buttonEditContract.Text = global::Edocsys.Properties.Settings.Default.EditContractTitle;
            this.buttonEditContract.UseVisualStyleBackColor = true;
            this.buttonEditContract.Click += new System.EventHandler(this.buttonEditContract_Click);
            // 
            // buttonGenerateContract
            // 
            this.buttonGenerateContract.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "GenerateContractTitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonGenerateContract.Location = new System.Drawing.Point(21, 32);
            this.buttonGenerateContract.Name = "buttonGenerateContract";
            this.buttonGenerateContract.Size = new System.Drawing.Size(246, 23);
            this.buttonGenerateContract.TabIndex = 17;
            this.buttonGenerateContract.Text = global::Edocsys.Properties.Settings.Default.GenerateContractTitle;
            this.buttonGenerateContract.UseVisualStyleBackColor = true;
            this.buttonGenerateContract.Click += new System.EventHandler(this.buttonGenerateContract_Click);
            // 
            // bindingNavigatorContractSigning
            // 
            this.bindingNavigatorContractSigning.AddNewItem = null;
            this.bindingNavigatorContractSigning.BindingSource = this.contractSigningBindingSource;
            this.bindingNavigatorContractSigning.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorContractSigning.DeleteItem = null;
            this.bindingNavigatorContractSigning.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripButton5,
            this.toolStripSeparator6,
            this.bindingNavigatorDeleteItem,
            this.usersBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.filterContractSigningText});
            this.bindingNavigatorContractSigning.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigatorContractSigning.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorContractSigning.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorContractSigning.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorContractSigning.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorContractSigning.Name = "bindingNavigatorContractSigning";
            this.bindingNavigatorContractSigning.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorContractSigning.Size = new System.Drawing.Size(734, 25);
            this.bindingNavigatorContractSigning.TabIndex = 26;
            this.bindingNavigatorContractSigning.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
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
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "toolStripButton1";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // usersBindingNavigatorSaveItem
            // 
            this.usersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.usersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("usersBindingNavigatorSaveItem.Image")));
            this.usersBindingNavigatorSaveItem.Name = "usersBindingNavigatorSaveItem";
            this.usersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.usersBindingNavigatorSaveItem.Text = "Save Data";
            this.usersBindingNavigatorSaveItem.Click += new System.EventHandler(this.usersBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(42, 22);
            this.toolStripLabel1.Text = "Поиск";
            // 
            // filterContractSigningText
            // 
            this.filterContractSigningText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterContractSigningText.Name = "filterContractSigningText";
            this.filterContractSigningText.Size = new System.Drawing.Size(200, 25);
            // 
            // tabComplitionManagerConfrim
            // 
            this.tabComplitionManagerConfrim.AutoScroll = true;
            this.tabComplitionManagerConfrim.Controls.Add(this.contractComplitionManagerConfrimDataGridView);
            this.tabComplitionManagerConfrim.Controls.Add(this.bindingNavigatorComplitionMgrCnf);
            this.tabComplitionManagerConfrim.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "TabTaskReady", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tabComplitionManagerConfrim.Location = new System.Drawing.Point(4, 22);
            this.tabComplitionManagerConfrim.Name = "tabComplitionManagerConfrim";
            this.tabComplitionManagerConfrim.Padding = new System.Windows.Forms.Padding(3);
            this.tabComplitionManagerConfrim.Size = new System.Drawing.Size(740, 444);
            this.tabComplitionManagerConfrim.TabIndex = 2;
            this.tabComplitionManagerConfrim.Text = global::Edocsys.Properties.Settings.Default.TabTaskReady;
            this.tabComplitionManagerConfrim.UseVisualStyleBackColor = true;
            // 
            // contractComplitionManagerConfrimDataGridView
            // 
            this.contractComplitionManagerConfrimDataGridView.AllowUserToAddRows = false;
            this.contractComplitionManagerConfrimDataGridView.AllowUserToDeleteRows = false;
            this.contractComplitionManagerConfrimDataGridView.AutoGenerateColumns = false;
            this.contractComplitionManagerConfrimDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contractComplitionManagerConfrimDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn2,
            this.agentsnameDataGridViewTextBoxColumn3,
            this.agenttypesnameDataGridViewTextBoxColumn3,
            this.cash_income,
            this.productsnameDataGridViewTextBoxColumn3,
            this.contracttypesnameDataGridViewTextBoxColumn3,
            this.costDataGridViewTextBoxColumn3,
            this.totalcostDataGridViewTextBoxColumn3,
            this.ConfirmTaskFinishedColumn,
            this.datecontractDataGridViewTextBoxColumn1,
            this.datestartDataGridViewTextBoxColumn2,
            this.dateendDataGridViewTextBoxColumn2,
            this.expertFIODataGridViewTextBoxColumn3,
            this.agentsfullnameDataGridViewTextBoxColumn3});
            this.contractComplitionManagerConfrimDataGridView.DataSource = this.contractComplitionMgrCfmBindingSource;
            this.contractComplitionManagerConfrimDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contractComplitionManagerConfrimDataGridView.Location = new System.Drawing.Point(3, 28);
            this.contractComplitionManagerConfrimDataGridView.Name = "contractComplitionManagerConfrimDataGridView";
            this.contractComplitionManagerConfrimDataGridView.Size = new System.Drawing.Size(734, 413);
            this.contractComplitionManagerConfrimDataGridView.TabIndex = 30;
            this.contractComplitionManagerConfrimDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.contractComplitionManagerConfrimDataGridView_CellContentClick);
            // 
            // contractComplitionMgrCfmBindingSource
            // 
            this.contractComplitionMgrCfmBindingSource.DataMember = "ContractComplitionMgrCfm";
            this.contractComplitionMgrCfmBindingSource.DataSource = this.edocbaseDataSet;
            // 
            // bindingNavigatorComplitionMgrCnf
            // 
            this.bindingNavigatorComplitionMgrCnf.AddNewItem = null;
            this.bindingNavigatorComplitionMgrCnf.BindingSource = this.contractComplitionMgrCfmBindingSource;
            this.bindingNavigatorComplitionMgrCnf.CountItem = this.toolStripLabel6;
            this.bindingNavigatorComplitionMgrCnf.DeleteItem = null;
            this.bindingNavigatorComplitionMgrCnf.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton13,
            this.toolStripButton14,
            this.toolStripSeparator10,
            this.toolStripTextBox2,
            this.toolStripLabel6,
            this.toolStripSeparator11,
            this.toolStripButton15,
            this.toolStripButton16,
            this.toolStripSeparator12,
            this.toolStripButton6,
            this.toolStripSeparator13,
            this.toolStripLabel7,
            this.filterComplitionTextBox});
            this.bindingNavigatorComplitionMgrCnf.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigatorComplitionMgrCnf.MoveFirstItem = this.toolStripButton13;
            this.bindingNavigatorComplitionMgrCnf.MoveLastItem = this.toolStripButton16;
            this.bindingNavigatorComplitionMgrCnf.MoveNextItem = this.toolStripButton15;
            this.bindingNavigatorComplitionMgrCnf.MovePreviousItem = this.toolStripButton14;
            this.bindingNavigatorComplitionMgrCnf.Name = "bindingNavigatorComplitionMgrCnf";
            this.bindingNavigatorComplitionMgrCnf.PositionItem = this.toolStripTextBox2;
            this.bindingNavigatorComplitionMgrCnf.Size = new System.Drawing.Size(734, 25);
            this.bindingNavigatorComplitionMgrCnf.TabIndex = 29;
            this.bindingNavigatorComplitionMgrCnf.Text = "bindingNavigator2";
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel6.Text = "of {0}";
            this.toolStripLabel6.ToolTipText = "Total number of items";
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.RightToLeftAutoMirrorImage = true;
            this.toolStripButton13.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton13.Text = "Move first";
            // 
            // toolStripButton14
            // 
            this.toolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton14.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton14.Image")));
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.RightToLeftAutoMirrorImage = true;
            this.toolStripButton14.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton14.Text = "Move previous";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AccessibleName = "Position";
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox2.Text = "0";
            this.toolStripTextBox2.ToolTipText = "Current position";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton15
            // 
            this.toolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton15.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton15.Image")));
            this.toolStripButton15.Name = "toolStripButton15";
            this.toolStripButton15.RightToLeftAutoMirrorImage = true;
            this.toolStripButton15.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton15.Text = "Move next";
            // 
            // toolStripButton16
            // 
            this.toolStripButton16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton16.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton16.Image")));
            this.toolStripButton16.Name = "toolStripButton16";
            this.toolStripButton16.RightToLeftAutoMirrorImage = true;
            this.toolStripButton16.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton16.Text = "Move last";
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "toolStripButton1";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(42, 22);
            this.toolStripLabel7.Text = "Поиск";
            // 
            // filterComplitionTextBox
            // 
            this.filterComplitionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterComplitionTextBox.Name = "filterComplitionTextBox";
            this.filterComplitionTextBox.Size = new System.Drawing.Size(200, 25);
            // 
            // tabComplitionAgentConfrim
            // 
            this.tabComplitionAgentConfrim.AutoScroll = true;
            this.tabComplitionAgentConfrim.Controls.Add(this.contractDoneDataTableDataGridView);
            this.tabComplitionAgentConfrim.Controls.Add(this.bindingNavigator);
            this.tabComplitionAgentConfrim.Controls.Add(this.panel2);
            this.tabComplitionAgentConfrim.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "TabTaskFinished", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tabComplitionAgentConfrim.Location = new System.Drawing.Point(4, 22);
            this.tabComplitionAgentConfrim.Name = "tabComplitionAgentConfrim";
            this.tabComplitionAgentConfrim.Padding = new System.Windows.Forms.Padding(3);
            this.tabComplitionAgentConfrim.Size = new System.Drawing.Size(1049, 520);
            this.tabComplitionAgentConfrim.TabIndex = 3;
            this.tabComplitionAgentConfrim.Text = global::Edocsys.Properties.Settings.Default.TabTaskFinished;
            this.tabComplitionAgentConfrim.UseVisualStyleBackColor = true;
            // 
            // contractDoneDataTableDataGridView
            // 
            this.contractDoneDataTableDataGridView.AllowUserToAddRows = false;
            this.contractDoneDataTableDataGridView.AllowUserToDeleteRows = false;
            this.contractDoneDataTableDataGridView.AutoGenerateColumns = false;
            this.contractDoneDataTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contractDoneDataTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn,
            this.productsnameDataGridViewTextBoxColumn1,
            this.agentsnameDataGridViewTextBoxColumn1,
            this.agenttypesnameDataGridViewTextBoxColumn1,
            this.contracttypesnameDataGridViewTextBoxColumn1,
            this.cash_income_finish,
            this.FinishContractColumn,
            this.has_act_document,
            this.ReattSignColumn,
            this.datecontractDataGridViewTextBoxColumn,
            this.datestartDataGridViewTextBoxColumn,
            this.dateendDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn1,
            this.totalcostDataGridViewTextBoxColumn1,
            this.agentsfullnameDataGridViewTextBoxColumn1,
            this.expertFIODataGridViewTextBoxColumn1});
            this.contractDoneDataTableDataGridView.DataSource = this.contractDoneBindingSource;
            this.contractDoneDataTableDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contractDoneDataTableDataGridView.Location = new System.Drawing.Point(3, 28);
            this.contractDoneDataTableDataGridView.Name = "contractDoneDataTableDataGridView";
            this.contractDoneDataTableDataGridView.Size = new System.Drawing.Size(1043, 319);
            this.contractDoneDataTableDataGridView.TabIndex = 31;
            this.contractDoneDataTableDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.contractDoneDataTableDataGridView_CellContentClick);
            // 
            // contractDoneBindingSource
            // 
            this.contractDoneBindingSource.DataMember = "ContractDone";
            this.contractDoneBindingSource.DataSource = this.edocbaseDataSet;
            // 
            // bindingNavigator
            // 
            this.bindingNavigator.AddNewItem = null;
            this.bindingNavigator.BindingSource = this.contractDoneBindingSource;
            this.bindingNavigator.CountItem = this.toolStripLabel2;
            this.bindingNavigator.DeleteItem = null;
            this.bindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.toolStripTextBox1,
            this.toolStripLabel2,
            this.toolStripSeparator3,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator4,
            this.toolStripButton7,
            this.toolStripSeparator5,
            this.toolStripLabel3,
            this.filterContractDoneTextBox});
            this.bindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator.MoveFirstItem = this.toolStripButton1;
            this.bindingNavigator.MoveLastItem = this.toolStripButton4;
            this.bindingNavigator.MoveNextItem = this.toolStripButton3;
            this.bindingNavigator.MovePreviousItem = this.toolStripButton2;
            this.bindingNavigator.Name = "bindingNavigator";
            this.bindingNavigator.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator.Size = new System.Drawing.Size(1043, 25);
            this.bindingNavigator.TabIndex = 30;
            this.bindingNavigator.Text = "bindingNavigator2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel2.Text = "of {0}";
            this.toolStripLabel2.ToolTipText = "Total number of items";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Move first";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Move previous";
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
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Move next";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Move last";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "toolStripButton1";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
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
            // filterContractDoneTextBox
            // 
            this.filterContractDoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterContractDoneTextBox.Name = "filterContractDoneTextBox";
            this.filterContractDoneTextBox.Size = new System.Drawing.Size(200, 25);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 347);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1043, 170);
            this.panel2.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonLoadAct);
            this.groupBox1.Controls.Add(this.buttonSaveAct);
            this.groupBox1.Controls.Add(this.buttonEditAct);
            this.groupBox1.Controls.Add(this.buttonGenerateAct);
            this.groupBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ContractActTitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(756, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 170);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = global::Edocsys.Properties.Settings.Default.ContractActTitle;
            // 
            // buttonLoadAct
            // 
            this.buttonLoadAct.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ActLoadTitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonLoadAct.Location = new System.Drawing.Point(21, 139);
            this.buttonLoadAct.Name = "buttonLoadAct";
            this.buttonLoadAct.Size = new System.Drawing.Size(246, 23);
            this.buttonLoadAct.TabIndex = 20;
            this.buttonLoadAct.Text = global::Edocsys.Properties.Settings.Default.ActLoadTitle;
            this.buttonLoadAct.UseVisualStyleBackColor = true;
            this.buttonLoadAct.Click += new System.EventHandler(this.buttonLoadAct_Click);
            // 
            // buttonSaveAct
            // 
            this.buttonSaveAct.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ActSaveTitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonSaveAct.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.contractDoneBindingSource, "has_act_document", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonSaveAct.Location = new System.Drawing.Point(21, 110);
            this.buttonSaveAct.Name = "buttonSaveAct";
            this.buttonSaveAct.Size = new System.Drawing.Size(246, 23);
            this.buttonSaveAct.TabIndex = 19;
            this.buttonSaveAct.Text = global::Edocsys.Properties.Settings.Default.ActSaveTitle;
            this.buttonSaveAct.UseVisualStyleBackColor = true;
            this.buttonSaveAct.Click += new System.EventHandler(this.buttonSaveAct_Click);
            // 
            // buttonEditAct
            // 
            this.buttonEditAct.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ActEditTitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonEditAct.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.contractDoneBindingSource, "has_act_document", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonEditAct.Location = new System.Drawing.Point(21, 81);
            this.buttonEditAct.Name = "buttonEditAct";
            this.buttonEditAct.Size = new System.Drawing.Size(246, 23);
            this.buttonEditAct.TabIndex = 18;
            this.buttonEditAct.Text = global::Edocsys.Properties.Settings.Default.ActEditTitle;
            this.buttonEditAct.UseVisualStyleBackColor = true;
            this.buttonEditAct.Click += new System.EventHandler(this.buttonEditAct_Click);
            // 
            // buttonGenerateAct
            // 
            this.buttonGenerateAct.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "GenerateActTitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonGenerateAct.Location = new System.Drawing.Point(21, 32);
            this.buttonGenerateAct.Name = "buttonGenerateAct";
            this.buttonGenerateAct.Size = new System.Drawing.Size(246, 23);
            this.buttonGenerateAct.TabIndex = 17;
            this.buttonGenerateAct.Text = global::Edocsys.Properties.Settings.Default.GenerateActTitle;
            this.buttonGenerateAct.UseVisualStyleBackColor = true;
            this.buttonGenerateAct.Click += new System.EventHandler(this.buttonGenerateAct_Click);
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
            this.tableAdapterManager.contract_statusTableAdapter = null;
            this.tableAdapterManager.contract_types_for_workTableAdapter = null;
            this.tableAdapterManager.contract_typesTableAdapter = null;
            this.tableAdapterManager.ContractInfoTableAdapter = null;
            this.tableAdapterManager.ContractPrepareForWorkTAdapter = null;
            this.tableAdapterManager.ContractSigningTableAdapter = this.contractSigningTableAdapter;
            this.tableAdapterManager.ContractsOnInspectionTableAdapter = null;
            this.tableAdapterManager.contractsTableAdapter = null;
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
            // contractComplitionMgrCfmTableAdapter
            // 
            this.contractComplitionMgrCfmTableAdapter.ClearBeforeFill = true;
            // 
            // contractDoneTableAdapter
            // 
            this.contractDoneTableAdapter.ClearBeforeFill = true;
            // 
            // number
            // 
            this.number.DataPropertyName = "number";
            this.number.HeaderText = "Номер договора";
            this.number.Name = "number";
            // 
            // productsnameDataGridViewTextBoxColumn
            // 
            this.productsnameDataGridViewTextBoxColumn.DataPropertyName = "products_name";
            this.productsnameDataGridViewTextBoxColumn.HeaderText = "Продукция";
            this.productsnameDataGridViewTextBoxColumn.Name = "productsnameDataGridViewTextBoxColumn";
            // 
            // contracttypesnameDataGridViewTextBoxColumn
            // 
            this.contracttypesnameDataGridViewTextBoxColumn.DataPropertyName = "contract_types_name";
            this.contracttypesnameDataGridViewTextBoxColumn.HeaderText = "Тип работ";
            this.contracttypesnameDataGridViewTextBoxColumn.Name = "contracttypesnameDataGridViewTextBoxColumn";
            // 
            // agentsnameDataGridViewTextBoxColumn
            // 
            this.agentsnameDataGridViewTextBoxColumn.DataPropertyName = "agents_name";
            this.agentsnameDataGridViewTextBoxColumn.HeaderText = "Контрагент";
            this.agentsnameDataGridViewTextBoxColumn.Name = "agentsnameDataGridViewTextBoxColumn";
            // 
            // agenttypesnameDataGridViewTextBoxColumn
            // 
            this.agenttypesnameDataGridViewTextBoxColumn.DataPropertyName = "agent_types_name";
            this.agenttypesnameDataGridViewTextBoxColumn.HeaderText = "Форма собственности";
            this.agenttypesnameDataGridViewTextBoxColumn.Name = "agenttypesnameDataGridViewTextBoxColumn";
            // 
            // prepayment
            // 
            this.prepayment.DataPropertyName = "prepayment";
            this.prepayment.HeaderText = "Аванс";
            this.prepayment.Name = "prepayment";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // totalcostDataGridViewTextBoxColumn
            // 
            this.totalcostDataGridViewTextBoxColumn.DataPropertyName = "total_cost";
            this.totalcostDataGridViewTextBoxColumn.HeaderText = "Общая сумма";
            this.totalcostDataGridViewTextBoxColumn.Name = "totalcostDataGridViewTextBoxColumn";
            // 
            // dateproposalDataGridViewTextBoxColumn
            // 
            this.dateproposalDataGridViewTextBoxColumn.DataPropertyName = "date_proposal";
            this.dateproposalDataGridViewTextBoxColumn.HeaderText = "Дата поступления заявки";
            this.dateproposalDataGridViewTextBoxColumn.Name = "dateproposalDataGridViewTextBoxColumn";
            // 
            // agentsfullnameDataGridViewTextBoxColumn
            // 
            this.agentsfullnameDataGridViewTextBoxColumn.DataPropertyName = "agents_fullname";
            this.agentsfullnameDataGridViewTextBoxColumn.HeaderText = "Контрагент";
            this.agentsfullnameDataGridViewTextBoxColumn.Name = "agentsfullnameDataGridViewTextBoxColumn";
            // 
            // expertFIODataGridViewTextBoxColumn
            // 
            this.expertFIODataGridViewTextBoxColumn.DataPropertyName = "expert_FIO";
            this.expertFIODataGridViewTextBoxColumn.HeaderText = "Эксперт";
            this.expertFIODataGridViewTextBoxColumn.Name = "expertFIODataGridViewTextBoxColumn";
            // 
            // has_contract_document
            // 
            this.has_contract_document.DataPropertyName = "has_contract_document";
            this.has_contract_document.HeaderText = "Документ";
            this.has_contract_document.Name = "has_contract_document";
            this.has_contract_document.ReadOnly = true;
            this.has_contract_document.Width = 70;
            // 
            // SignContractColumn
            // 
            this.SignContractColumn.HeaderText = "Контракт подписан";
            this.SignContractColumn.Name = "SignContractColumn";
            // 
            // numberDataGridViewTextBoxColumn2
            // 
            this.numberDataGridViewTextBoxColumn2.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn2.HeaderText = "Номер";
            this.numberDataGridViewTextBoxColumn2.Name = "numberDataGridViewTextBoxColumn2";
            // 
            // agentsnameDataGridViewTextBoxColumn3
            // 
            this.agentsnameDataGridViewTextBoxColumn3.DataPropertyName = "agents_name";
            this.agentsnameDataGridViewTextBoxColumn3.HeaderText = "Контрагент";
            this.agentsnameDataGridViewTextBoxColumn3.Name = "agentsnameDataGridViewTextBoxColumn3";
            // 
            // agenttypesnameDataGridViewTextBoxColumn3
            // 
            this.agenttypesnameDataGridViewTextBoxColumn3.DataPropertyName = "agent_types_name";
            this.agenttypesnameDataGridViewTextBoxColumn3.HeaderText = "Форма собственности";
            this.agenttypesnameDataGridViewTextBoxColumn3.Name = "agenttypesnameDataGridViewTextBoxColumn3";
            this.agenttypesnameDataGridViewTextBoxColumn3.Width = 50;
            // 
            // cash_income
            // 
            this.cash_income.DataPropertyName = "cash_income";
            this.cash_income.HeaderText = "Оплата";
            this.cash_income.Name = "cash_income";
            // 
            // productsnameDataGridViewTextBoxColumn3
            // 
            this.productsnameDataGridViewTextBoxColumn3.DataPropertyName = "products_name";
            this.productsnameDataGridViewTextBoxColumn3.HeaderText = "Продукция";
            this.productsnameDataGridViewTextBoxColumn3.Name = "productsnameDataGridViewTextBoxColumn3";
            // 
            // contracttypesnameDataGridViewTextBoxColumn3
            // 
            this.contracttypesnameDataGridViewTextBoxColumn3.DataPropertyName = "contract_types_name";
            this.contracttypesnameDataGridViewTextBoxColumn3.HeaderText = "Тип работ";
            this.contracttypesnameDataGridViewTextBoxColumn3.Name = "contracttypesnameDataGridViewTextBoxColumn3";
            // 
            // costDataGridViewTextBoxColumn3
            // 
            this.costDataGridViewTextBoxColumn3.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn3.HeaderText = "Сумма";
            this.costDataGridViewTextBoxColumn3.Name = "costDataGridViewTextBoxColumn3";
            // 
            // totalcostDataGridViewTextBoxColumn3
            // 
            this.totalcostDataGridViewTextBoxColumn3.DataPropertyName = "total_cost";
            this.totalcostDataGridViewTextBoxColumn3.HeaderText = "Общая сумма";
            this.totalcostDataGridViewTextBoxColumn3.Name = "totalcostDataGridViewTextBoxColumn3";
            // 
            // ConfirmTaskFinishedColumn
            // 
            this.ConfirmTaskFinishedColumn.HeaderText = "Подтвердить выполнение";
            this.ConfirmTaskFinishedColumn.Name = "ConfirmTaskFinishedColumn";
            this.ConfirmTaskFinishedColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ConfirmTaskFinishedColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // datecontractDataGridViewTextBoxColumn1
            // 
            this.datecontractDataGridViewTextBoxColumn1.DataPropertyName = "date_contract";
            this.datecontractDataGridViewTextBoxColumn1.HeaderText = "Дата заключения договора";
            this.datecontractDataGridViewTextBoxColumn1.Name = "datecontractDataGridViewTextBoxColumn1";
            // 
            // datestartDataGridViewTextBoxColumn2
            // 
            this.datestartDataGridViewTextBoxColumn2.DataPropertyName = "date_start";
            this.datestartDataGridViewTextBoxColumn2.HeaderText = "Дата начала работ";
            this.datestartDataGridViewTextBoxColumn2.Name = "datestartDataGridViewTextBoxColumn2";
            // 
            // dateendDataGridViewTextBoxColumn2
            // 
            this.dateendDataGridViewTextBoxColumn2.DataPropertyName = "date_end";
            this.dateendDataGridViewTextBoxColumn2.HeaderText = "Дата окончания работ";
            this.dateendDataGridViewTextBoxColumn2.Name = "dateendDataGridViewTextBoxColumn2";
            // 
            // expertFIODataGridViewTextBoxColumn3
            // 
            this.expertFIODataGridViewTextBoxColumn3.DataPropertyName = "expert_FIO";
            this.expertFIODataGridViewTextBoxColumn3.HeaderText = "Эксперт";
            this.expertFIODataGridViewTextBoxColumn3.Name = "expertFIODataGridViewTextBoxColumn3";
            // 
            // agentsfullnameDataGridViewTextBoxColumn3
            // 
            this.agentsfullnameDataGridViewTextBoxColumn3.DataPropertyName = "agents_fullname";
            this.agentsfullnameDataGridViewTextBoxColumn3.HeaderText = "Контрагент";
            this.agentsfullnameDataGridViewTextBoxColumn3.Name = "agentsfullnameDataGridViewTextBoxColumn3";
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // productsnameDataGridViewTextBoxColumn1
            // 
            this.productsnameDataGridViewTextBoxColumn1.DataPropertyName = "products_name";
            this.productsnameDataGridViewTextBoxColumn1.HeaderText = "Продукция";
            this.productsnameDataGridViewTextBoxColumn1.Name = "productsnameDataGridViewTextBoxColumn1";
            // 
            // agentsnameDataGridViewTextBoxColumn1
            // 
            this.agentsnameDataGridViewTextBoxColumn1.DataPropertyName = "agents_name";
            this.agentsnameDataGridViewTextBoxColumn1.HeaderText = "Контрагент";
            this.agentsnameDataGridViewTextBoxColumn1.Name = "agentsnameDataGridViewTextBoxColumn1";
            // 
            // agenttypesnameDataGridViewTextBoxColumn1
            // 
            this.agenttypesnameDataGridViewTextBoxColumn1.DataPropertyName = "agent_types_name";
            this.agenttypesnameDataGridViewTextBoxColumn1.HeaderText = "Форма собственности";
            this.agenttypesnameDataGridViewTextBoxColumn1.Name = "agenttypesnameDataGridViewTextBoxColumn1";
            // 
            // contracttypesnameDataGridViewTextBoxColumn1
            // 
            this.contracttypesnameDataGridViewTextBoxColumn1.DataPropertyName = "contract_types_name";
            this.contracttypesnameDataGridViewTextBoxColumn1.HeaderText = "Тип работ";
            this.contracttypesnameDataGridViewTextBoxColumn1.Name = "contracttypesnameDataGridViewTextBoxColumn1";
            // 
            // cash_income_finish
            // 
            this.cash_income_finish.DataPropertyName = "cash_income";
            this.cash_income_finish.HeaderText = "Оплата";
            this.cash_income_finish.Name = "cash_income_finish";
            // 
            // FinishContractColumn
            // 
            this.FinishContractColumn.HeaderText = "Завершить договор";
            this.FinishContractColumn.Name = "FinishContractColumn";
            // 
            // has_act_document
            // 
            this.has_act_document.DataPropertyName = "has_act_document";
            this.has_act_document.HeaderText = "Акт";
            this.has_act_document.Name = "has_act_document";
            this.has_act_document.ReadOnly = true;
            this.has_act_document.Width = 35;
            // 
            // ReattSignColumn
            // 
            this.ReattSignColumn.HeaderText = "Заключить договор инспекционного контроля";
            this.ReattSignColumn.Name = "ReattSignColumn";
            // 
            // datecontractDataGridViewTextBoxColumn
            // 
            this.datecontractDataGridViewTextBoxColumn.DataPropertyName = "date_contract";
            this.datecontractDataGridViewTextBoxColumn.HeaderText = "Дата заключения договора";
            this.datecontractDataGridViewTextBoxColumn.Name = "datecontractDataGridViewTextBoxColumn";
            // 
            // datestartDataGridViewTextBoxColumn
            // 
            this.datestartDataGridViewTextBoxColumn.DataPropertyName = "date_start";
            this.datestartDataGridViewTextBoxColumn.HeaderText = "Дата начала работ";
            this.datestartDataGridViewTextBoxColumn.Name = "datestartDataGridViewTextBoxColumn";
            // 
            // dateendDataGridViewTextBoxColumn
            // 
            this.dateendDataGridViewTextBoxColumn.DataPropertyName = "date_end";
            this.dateendDataGridViewTextBoxColumn.HeaderText = "Дата окончания работ";
            this.dateendDataGridViewTextBoxColumn.Name = "dateendDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn1
            // 
            this.costDataGridViewTextBoxColumn1.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn1.HeaderText = "Сумма";
            this.costDataGridViewTextBoxColumn1.Name = "costDataGridViewTextBoxColumn1";
            // 
            // totalcostDataGridViewTextBoxColumn1
            // 
            this.totalcostDataGridViewTextBoxColumn1.DataPropertyName = "total_cost";
            this.totalcostDataGridViewTextBoxColumn1.HeaderText = "Общая сумма";
            this.totalcostDataGridViewTextBoxColumn1.Name = "totalcostDataGridViewTextBoxColumn1";
            // 
            // agentsfullnameDataGridViewTextBoxColumn1
            // 
            this.agentsfullnameDataGridViewTextBoxColumn1.DataPropertyName = "agents_fullname";
            this.agentsfullnameDataGridViewTextBoxColumn1.HeaderText = "Контрагент";
            this.agentsfullnameDataGridViewTextBoxColumn1.Name = "agentsfullnameDataGridViewTextBoxColumn1";
            // 
            // expertFIODataGridViewTextBoxColumn1
            // 
            this.expertFIODataGridViewTextBoxColumn1.DataPropertyName = "expert_FIO";
            this.expertFIODataGridViewTextBoxColumn1.HeaderText = "Эксперт";
            this.expertFIODataGridViewTextBoxColumn1.Name = "expertFIODataGridViewTextBoxColumn1";
            // 
            // ContractsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 546);
            this.Controls.Add(this.tabControl);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ContractsFormTitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Name = "ContractsForm";
            this.Text = global::Edocsys.Properties.Settings.Default.ContractsFormTitle;
            this.Load += new System.EventHandler(this.ContractsForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabContractSigning.ResumeLayout(false);
            this.tabContractSigning.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractsSigningDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractSigningBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edocbaseDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxContract.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorContractSigning)).EndInit();
            this.bindingNavigatorContractSigning.ResumeLayout(false);
            this.bindingNavigatorContractSigning.PerformLayout();
            this.tabComplitionManagerConfrim.ResumeLayout(false);
            this.tabComplitionManagerConfrim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractComplitionManagerConfrimDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractComplitionMgrCfmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorComplitionMgrCnf)).EndInit();
            this.bindingNavigatorComplitionMgrCnf.ResumeLayout(false);
            this.bindingNavigatorComplitionMgrCnf.PerformLayout();
            this.tabComplitionAgentConfrim.ResumeLayout(false);
            this.tabComplitionAgentConfrim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractDoneDataTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractDoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
            this.bindingNavigator.ResumeLayout(false);
            this.bindingNavigator.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contractDocDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EdocbaseDataSet edocbaseDataSet;
        private EdocbaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabContractSigning;
        private System.Windows.Forms.TabPage tabComplitionManagerConfrim;
        private System.Windows.Forms.TabPage tabComplitionAgentConfrim;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxContract;
        private System.Windows.Forms.Button buttonLoadContract;
        private System.Windows.Forms.Button buttonSaveContract;
        private System.Windows.Forms.Button buttonEditContract;
        private System.Windows.Forms.Button buttonGenerateContract;
        private System.Windows.Forms.DataGridView contractsSigningDataGridView;
        private System.Windows.Forms.BindingNavigator bindingNavigatorContractSigning;
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
        private System.Windows.Forms.ToolStripButton usersBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox filterContractSigningText;
        private System.Windows.Forms.BindingSource contractSigningBindingSource;
        private EdocbaseDataSetTableAdapters.ContractSigningTableAdapter contractSigningTableAdapter;
        private System.Windows.Forms.DateTimePicker date_contractDateTimePicker;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.BindingSource contractDocDataBindingSource;
        private EdocbaseDataSetTableAdapters.ContractDocDataTableAdapter contractDocDataTableAdapter;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.DataGridView contractComplitionManagerConfrimDataGridView;
        private System.Windows.Forms.BindingNavigator bindingNavigatorComplitionMgrCnf;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.ToolStripButton toolStripButton14;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton toolStripButton15;
        private System.Windows.Forms.ToolStripButton toolStripButton16;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.ToolStripTextBox filterComplitionTextBox;
        private System.Windows.Forms.BindingSource contractComplitionMgrCfmBindingSource;
        private EdocbaseDataSetTableAdapters.ContractComplitionMgrCfmTableAdapter contractComplitionMgrCfmTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonLoadAct;
        private System.Windows.Forms.Button buttonSaveAct;
        private System.Windows.Forms.Button buttonEditAct;
        private System.Windows.Forms.Button buttonGenerateAct;
        private System.Windows.Forms.DataGridView contractDoneDataTableDataGridView;
        private System.Windows.Forms.BindingNavigator bindingNavigator;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox filterContractDoneTextBox;
        private System.Windows.Forms.BindingSource contractDoneBindingSource;
        private EdocbaseDataSetTableAdapters.ContractDoneTableAdapter contractDoneTableAdapter;
        private System.Windows.Forms.TextBox total_costTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.TextBox prepaymentTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn productsnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contracttypesnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentsnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agenttypesnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prepayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateproposalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentsfullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expertFIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn has_contract_document;
        private System.Windows.Forms.DataGridViewButtonColumn SignContractColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentsnameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn agenttypesnameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cash_income;
        private System.Windows.Forms.DataGridViewTextBoxColumn productsnameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn contracttypesnameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalcostDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn ConfirmTaskFinishedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datecontractDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datestartDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateendDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn expertFIODataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentsfullnameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productsnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentsnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn agenttypesnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn contracttypesnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cash_income_finish;
        private System.Windows.Forms.DataGridViewButtonColumn FinishContractColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn has_act_document;
        private System.Windows.Forms.DataGridViewButtonColumn ReattSignColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datecontractDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datestartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalcostDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentsfullnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn expertFIODataGridViewTextBoxColumn1;

        //private EdocbaseDataSetTableAdapters.Exec_contractsTableAdapter exec_contractsTableAdapter;
    }
}