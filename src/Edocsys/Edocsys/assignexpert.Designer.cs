namespace Edocsys
{
    partial class AssignExpertForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignExpertForm));
            this.tabControlAssignExpert = new System.Windows.Forms.TabControl();
            this.tabPageAssignExpert = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.expertAssignmentDataGridView = new System.Windows.Forms.DataGridView();
            this.products_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contracttypesnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateproposalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agents_fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agents_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agenttypesnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expertAssignmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.edocbaseDataSet = new Edocsys.EdocbaseDataSet();
            this.bindingNavigatorAssignedExperts = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.filterProposalsToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.expertsListBox = new System.Windows.Forms.ListBox();
            this.expertsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelExperts = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.assignButton = new System.Windows.Forms.Button();
            this.expertTextBox = new System.Windows.Forms.TextBox();
            this.contractTextBox = new System.Windows.Forms.TextBox();
            this.tabPageAssignedExperts = new System.Windows.Forms.TabPage();
            this.assignedContractsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contracttypesnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expert_FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contract_status_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prepayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cash_income = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.date_cash_income = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateproposalDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_contract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_end = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.days_to_deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_sample_income = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_protocol_income = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_planed_reatt_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.days_to_deadline_reatt_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_real_reatt_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_planed_reatt_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.days_to_deadline_reatt_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_real_reatt_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_planed_resert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.days_to_deadline_resert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_real_resert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentsnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agenttypesnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignedContractsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.contract_statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkBoxStatuses = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxExpertsFilter = new System.Windows.Forms.CheckBox();
            this.fullnameComboBox = new System.Windows.Forms.ComboBox();
            this.assignedContractsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.filterAssignedToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.proposalLabel = new System.Windows.Forms.Label();
            this.tableAdapterManager = new Edocsys.EdocbaseDataSetTableAdapters.TableAdapterManager();
            this.expertAssignmentTAdapter = new Edocsys.EdocbaseDataSetTableAdapters.ExpertAssignmentTAdapter();
            this.expertsTableAdapter = new Edocsys.EdocbaseDataSetTableAdapters.expertsTableAdapter();
            this.assignedContractsTAdapter = new Edocsys.EdocbaseDataSetTableAdapters.AssignedContractsTAdapter();
            this.contract_statusTableAdapter = new Edocsys.EdocbaseDataSetTableAdapters.contract_statusTableAdapter();
            this.tabControlAssignExpert.SuspendLayout();
            this.tabPageAssignExpert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expertAssignmentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expertAssignmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edocbaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorAssignedExperts)).BeginInit();
            this.bindingNavigatorAssignedExperts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expertsBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPageAssignedExperts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assignedContractsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignedContractsBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contract_statusBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assignedContractsBindingNavigator)).BeginInit();
            this.assignedContractsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAssignExpert
            // 
            this.tabControlAssignExpert.Controls.Add(this.tabPageAssignExpert);
            this.tabControlAssignExpert.Controls.Add(this.tabPageAssignedExperts);
            this.tabControlAssignExpert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAssignExpert.Location = new System.Drawing.Point(0, 0);
            this.tabControlAssignExpert.Name = "tabControlAssignExpert";
            this.tabControlAssignExpert.SelectedIndex = 0;
            this.tabControlAssignExpert.Size = new System.Drawing.Size(1276, 485);
            this.tabControlAssignExpert.TabIndex = 6;
            this.tabControlAssignExpert.Text = "Назначить эксперта";
            this.tabControlAssignExpert.SelectedIndexChanged += new System.EventHandler(this.tabControlAssignExpert_SelectedIndexChanged);
            // 
            // tabPageAssignExpert
            // 
            this.tabPageAssignExpert.Controls.Add(this.splitContainer1);
            this.tabPageAssignExpert.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "AssignExpertTabText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tabPageAssignExpert.Location = new System.Drawing.Point(4, 22);
            this.tabPageAssignExpert.Name = "tabPageAssignExpert";
            this.tabPageAssignExpert.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAssignExpert.Size = new System.Drawing.Size(1268, 459);
            this.tabPageAssignExpert.TabIndex = 0;
            this.tabPageAssignExpert.Text = global::Edocsys.Properties.Settings.Default.AssignExpertTabText;
            this.tabPageAssignExpert.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1262, 453);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.TabIndex = 7;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.expertAssignmentDataGridView);
            this.splitContainer2.Panel1.Controls.Add(this.bindingNavigatorAssignedExperts);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.expertsListBox);
            this.splitContainer2.Panel2.Controls.Add(this.panel2);
            this.splitContainer2.Size = new System.Drawing.Size(1262, 400);
            this.splitContainer2.SplitterDistance = 962;
            this.splitContainer2.TabIndex = 0;
            // 
            // expertAssignmentDataGridView
            // 
            this.expertAssignmentDataGridView.AllowUserToAddRows = false;
            this.expertAssignmentDataGridView.AllowUserToDeleteRows = false;
            this.expertAssignmentDataGridView.AutoGenerateColumns = false;
            this.expertAssignmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expertAssignmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.products_name,
            this.contracttypesnameDataGridViewTextBoxColumn,
            this.dateproposalDataGridViewTextBoxColumn,
            this.cost,
            this.total_cost,
            this.agents_fullname,
            this.agents_name,
            this.agenttypesnameDataGridViewTextBoxColumn});
            this.expertAssignmentDataGridView.DataSource = this.expertAssignmentBindingSource;
            this.expertAssignmentDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expertAssignmentDataGridView.Location = new System.Drawing.Point(0, 25);
            this.expertAssignmentDataGridView.MultiSelect = false;
            this.expertAssignmentDataGridView.Name = "expertAssignmentDataGridView";
            this.expertAssignmentDataGridView.ReadOnly = true;
            this.expertAssignmentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.expertAssignmentDataGridView.Size = new System.Drawing.Size(962, 375);
            this.expertAssignmentDataGridView.TabIndex = 10;
            // 
            // products_name
            // 
            this.products_name.DataPropertyName = "products_name";
            this.products_name.HeaderText = "Продукция";
            this.products_name.Name = "products_name";
            this.products_name.ReadOnly = true;
            this.products_name.Width = 200;
            // 
            // contracttypesnameDataGridViewTextBoxColumn
            // 
            this.contracttypesnameDataGridViewTextBoxColumn.DataPropertyName = "contract_types_name";
            this.contracttypesnameDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.contracttypesnameDataGridViewTextBoxColumn.Name = "contracttypesnameDataGridViewTextBoxColumn";
            this.contracttypesnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateproposalDataGridViewTextBoxColumn
            // 
            this.dateproposalDataGridViewTextBoxColumn.DataPropertyName = "date_proposal";
            this.dateproposalDataGridViewTextBoxColumn.HeaderText = "Дата подачи";
            this.dateproposalDataGridViewTextBoxColumn.Name = "dateproposalDataGridViewTextBoxColumn";
            this.dateproposalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cost
            // 
            this.cost.DataPropertyName = "cost";
            this.cost.HeaderText = "Сумма";
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            this.cost.Visible = false;
            // 
            // total_cost
            // 
            this.total_cost.DataPropertyName = "total_cost";
            this.total_cost.HeaderText = "Общая сумма";
            this.total_cost.Name = "total_cost";
            this.total_cost.ReadOnly = true;
            // 
            // agents_fullname
            // 
            this.agents_fullname.DataPropertyName = "agents_fullname";
            this.agents_fullname.HeaderText = "Контрагент";
            this.agents_fullname.Name = "agents_fullname";
            this.agents_fullname.ReadOnly = true;
            this.agents_fullname.Width = 200;
            // 
            // agents_name
            // 
            this.agents_name.DataPropertyName = "agents_name";
            this.agents_name.HeaderText = "Контрагент";
            this.agents_name.Name = "agents_name";
            this.agents_name.ReadOnly = true;
            this.agents_name.ToolTipText = "Контрагент";
            this.agents_name.Visible = false;
            this.agents_name.Width = 200;
            // 
            // agenttypesnameDataGridViewTextBoxColumn
            // 
            this.agenttypesnameDataGridViewTextBoxColumn.DataPropertyName = "agent_types_name";
            this.agenttypesnameDataGridViewTextBoxColumn.HeaderText = "Форма собственности";
            this.agenttypesnameDataGridViewTextBoxColumn.Name = "agenttypesnameDataGridViewTextBoxColumn";
            this.agenttypesnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.agenttypesnameDataGridViewTextBoxColumn.Visible = false;
            // 
            // expertAssignmentBindingSource
            // 
            this.expertAssignmentBindingSource.DataMember = "ExpertAssignment";
            this.expertAssignmentBindingSource.DataSource = this.edocbaseDataSet;
            // 
            // edocbaseDataSet
            // 
            this.edocbaseDataSet.CaseSensitive = true;
            this.edocbaseDataSet.DataSetName = "EdocbaseDataSet";
            this.edocbaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorAssignedExperts
            // 
            this.bindingNavigatorAssignedExperts.AddNewItem = null;
            this.bindingNavigatorAssignedExperts.BindingSource = this.expertAssignmentBindingSource;
            this.bindingNavigatorAssignedExperts.CountItem = this.toolStripLabel2;
            this.bindingNavigatorAssignedExperts.DeleteItem = null;
            this.bindingNavigatorAssignedExperts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton10,
            this.toolStripButton11,
            this.toolStripSeparator5,
            this.toolStripTextBox2,
            this.toolStripLabel2,
            this.toolStripSeparator6,
            this.toolStripButton12,
            this.toolStripButton13,
            this.toolStripSeparator7,
            this.toolStripButton8,
            this.toolStripSeparator8,
            this.filterProposalsToolStripTextBox});
            this.bindingNavigatorAssignedExperts.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorAssignedExperts.MoveFirstItem = this.toolStripButton10;
            this.bindingNavigatorAssignedExperts.MoveLastItem = this.toolStripButton13;
            this.bindingNavigatorAssignedExperts.MoveNextItem = this.toolStripButton12;
            this.bindingNavigatorAssignedExperts.MovePreviousItem = this.toolStripButton11;
            this.bindingNavigatorAssignedExperts.Name = "bindingNavigatorAssignedExperts";
            this.bindingNavigatorAssignedExperts.PositionItem = this.toolStripTextBox2;
            this.bindingNavigatorAssignedExperts.Size = new System.Drawing.Size(962, 25);
            this.bindingNavigatorAssignedExperts.TabIndex = 9;
            this.bindingNavigatorAssignedExperts.Text = "bindingNavigator1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel2.Text = "of {0}";
            this.toolStripLabel2.ToolTipText = "Total number of items";
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.RightToLeftAutoMirrorImage = true;
            this.toolStripButton10.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton10.Text = "Move first";
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.RightToLeftAutoMirrorImage = true;
            this.toolStripButton11.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton11.Text = "Move previous";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AccessibleName = "Position";
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(50, 21);
            this.toolStripTextBox2.Text = "0";
            this.toolStripTextBox2.ToolTipText = "Current position";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.RightToLeftAutoMirrorImage = true;
            this.toolStripButton12.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton12.Text = "Move next";
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.RightToLeftAutoMirrorImage = true;
            this.toolStripButton13.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton13.Text = "Move last";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "Обновить";
            this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // filterProposalsToolStripTextBox
            // 
            this.filterProposalsToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterProposalsToolStripTextBox.Name = "filterProposalsToolStripTextBox";
            this.filterProposalsToolStripTextBox.Size = new System.Drawing.Size(200, 25);
            // 
            // expertsListBox
            // 
            this.expertsListBox.DataSource = this.expertsBindingSource;
            this.expertsListBox.DisplayMember = "fullname";
            this.expertsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expertsListBox.FormattingEnabled = true;
            this.expertsListBox.Location = new System.Drawing.Point(0, 25);
            this.expertsListBox.Name = "expertsListBox";
            this.expertsListBox.Size = new System.Drawing.Size(296, 375);
            this.expertsListBox.TabIndex = 8;
            // 
            // expertsBindingSource
            // 
            this.expertsBindingSource.DataMember = "Experts";
            this.expertsBindingSource.DataSource = this.edocbaseDataSet;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelExperts);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 25);
            this.panel2.TabIndex = 7;
            // 
            // labelExperts
            // 
            this.labelExperts.AutoSize = true;
            this.labelExperts.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "AssignExpertExpertsText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.labelExperts.Location = new System.Drawing.Point(80, 6);
            this.labelExperts.Name = "labelExperts";
            this.labelExperts.Size = new System.Drawing.Size(57, 13);
            this.labelExperts.TabIndex = 0;
            this.labelExperts.Text = global::Edocsys.Properties.Settings.Default.AssignExpertExpertsText;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.assignButton);
            this.panel1.Controls.Add(this.expertTextBox);
            this.panel1.Controls.Add(this.contractTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 49);
            this.panel1.TabIndex = 5;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "AssignExpertProposalText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label.Location = new System.Drawing.Point(16, 18);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(44, 13);
            this.label.TabIndex = 4;
            this.label.Text = global::Edocsys.Properties.Settings.Default.AssignExpertProposalText;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "AssignExprtsExpertText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.Location = new System.Drawing.Point(860, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = global::Edocsys.Properties.Settings.Default.AssignExprtsExpertText;
            // 
            // assignButton
            // 
            this.assignButton.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "AssignExpertsAssignButtonText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.assignButton.Location = new System.Drawing.Point(758, 12);
            this.assignButton.Name = "assignButton";
            this.assignButton.Size = new System.Drawing.Size(75, 23);
            this.assignButton.TabIndex = 2;
            this.assignButton.Text = global::Edocsys.Properties.Settings.Default.AssignExpertsAssignButtonText;
            this.assignButton.UseVisualStyleBackColor = true;
            this.assignButton.Click += new System.EventHandler(this.assignButton_Click);
            // 
            // expertTextBox
            // 
            this.expertTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expertsBindingSource, "fullname", true));
            this.expertTextBox.Location = new System.Drawing.Point(924, 15);
            this.expertTextBox.Name = "expertTextBox";
            this.expertTextBox.ReadOnly = true;
            this.expertTextBox.Size = new System.Drawing.Size(320, 20);
            this.expertTextBox.TabIndex = 1;
            // 
            // contractTextBox
            // 
            this.contractTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expertAssignmentBindingSource, "contract_fullname", true));
            this.contractTextBox.Location = new System.Drawing.Point(87, 15);
            this.contractTextBox.Name = "contractTextBox";
            this.contractTextBox.ReadOnly = true;
            this.contractTextBox.Size = new System.Drawing.Size(631, 20);
            this.contractTextBox.TabIndex = 0;
            // 
            // tabPageAssignedExperts
            // 
            this.tabPageAssignedExperts.Controls.Add(this.assignedContractsDataGridView);
            this.tabPageAssignedExperts.Controls.Add(this.panel3);
            this.tabPageAssignedExperts.Controls.Add(this.assignedContractsBindingNavigator);
            this.tabPageAssignedExperts.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "AssignedExpertTabText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tabPageAssignedExperts.Location = new System.Drawing.Point(4, 22);
            this.tabPageAssignedExperts.Name = "tabPageAssignedExperts";
            this.tabPageAssignedExperts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAssignedExperts.Size = new System.Drawing.Size(1268, 459);
            this.tabPageAssignedExperts.TabIndex = 1;
            this.tabPageAssignedExperts.Text = global::Edocsys.Properties.Settings.Default.AssignedExpertTabText;
            this.tabPageAssignedExperts.UseVisualStyleBackColor = true;
            // 
            // assignedContractsDataGridView
            // 
            this.assignedContractsDataGridView.AllowUserToAddRows = false;
            this.assignedContractsDataGridView.AllowUserToDeleteRows = false;
            this.assignedContractsDataGridView.AutoGenerateColumns = false;
            this.assignedContractsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assignedContractsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.contracttypesnameDataGridViewTextBoxColumn1,
            this.expert_FIO,
            this.contract_status_name,
            this.number,
            this.prepayment,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.cash_income,
            this.date_cash_income,
            this.dateproposalDataGridViewTextBoxColumn1,
            this.date_contract,
            this.date_start,
            this.date_end,
            this.days_to_deadline,
            this.date_sample_income,
            this.date_protocol_income,
            this.date_planed_reatt_1,
            this.days_to_deadline_reatt_1,
            this.date_real_reatt_1,
            this.date_planed_reatt_2,
            this.days_to_deadline_reatt_2,
            this.date_real_reatt_2,
            this.date_planed_resert,
            this.days_to_deadline_resert,
            this.date_real_resert,
            this.agentsnameDataGridViewTextBoxColumn,
            this.agenttypesnameDataGridViewTextBoxColumn1});
            this.assignedContractsDataGridView.DataSource = this.assignedContractsBindingSource;
            this.assignedContractsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assignedContractsDataGridView.Location = new System.Drawing.Point(3, 146);
            this.assignedContractsDataGridView.MultiSelect = false;
            this.assignedContractsDataGridView.Name = "assignedContractsDataGridView";
            this.assignedContractsDataGridView.ReadOnly = true;
            this.assignedContractsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.assignedContractsDataGridView.Size = new System.Drawing.Size(1262, 310);
            this.assignedContractsDataGridView.TabIndex = 10;
            this.assignedContractsDataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.assignedContractsDataGridView_CellPainting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "products_name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Продукция";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // contracttypesnameDataGridViewTextBoxColumn1
            // 
            this.contracttypesnameDataGridViewTextBoxColumn1.DataPropertyName = "contract_types_name";
            this.contracttypesnameDataGridViewTextBoxColumn1.HeaderText = "Тип";
            this.contracttypesnameDataGridViewTextBoxColumn1.Name = "contracttypesnameDataGridViewTextBoxColumn1";
            this.contracttypesnameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // expert_FIO
            // 
            this.expert_FIO.DataPropertyName = "expert_FIO";
            this.expert_FIO.HeaderText = "Эксперт";
            this.expert_FIO.Name = "expert_FIO";
            this.expert_FIO.ReadOnly = true;
            this.expert_FIO.Width = 150;
            // 
            // contract_status_name
            // 
            this.contract_status_name.DataPropertyName = "contract_status_name";
            this.contract_status_name.HeaderText = "Состояние договора";
            this.contract_status_name.Name = "contract_status_name";
            this.contract_status_name.ReadOnly = true;
            this.contract_status_name.Width = 200;
            // 
            // number
            // 
            this.number.DataPropertyName = "number";
            this.number.HeaderText = "Номер договора";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            // 
            // prepayment
            // 
            this.prepayment.DataPropertyName = "prepayment";
            this.prepayment.HeaderText = "Оплачено";
            this.prepayment.Name = "prepayment";
            this.prepayment.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "cost";
            this.dataGridViewTextBoxColumn2.HeaderText = "Сумма";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "total_cost";
            this.dataGridViewTextBoxColumn3.HeaderText = "Общая сумма";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // cash_income
            // 
            this.cash_income.DataPropertyName = "cash_income";
            this.cash_income.HeaderText = "Опалта";
            this.cash_income.Name = "cash_income";
            this.cash_income.ReadOnly = true;
            // 
            // date_cash_income
            // 
            this.date_cash_income.DataPropertyName = "date_cash_income";
            this.date_cash_income.HeaderText = "Дата оплаты";
            this.date_cash_income.Name = "date_cash_income";
            this.date_cash_income.ReadOnly = true;
            // 
            // dateproposalDataGridViewTextBoxColumn1
            // 
            this.dateproposalDataGridViewTextBoxColumn1.DataPropertyName = "date_proposal";
            this.dateproposalDataGridViewTextBoxColumn1.HeaderText = "Дата подачи заявки";
            this.dateproposalDataGridViewTextBoxColumn1.Name = "dateproposalDataGridViewTextBoxColumn1";
            this.dateproposalDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // date_contract
            // 
            this.date_contract.DataPropertyName = "date_contract";
            this.date_contract.HeaderText = "Дата заключения договора";
            this.date_contract.Name = "date_contract";
            this.date_contract.ReadOnly = true;
            // 
            // date_start
            // 
            this.date_start.DataPropertyName = "date_start";
            this.date_start.HeaderText = "Дата начала работ";
            this.date_start.Name = "date_start";
            this.date_start.ReadOnly = true;
            // 
            // date_end
            // 
            this.date_end.DataPropertyName = "date_end";
            this.date_end.HeaderText = "Дата окончания работ";
            this.date_end.Name = "date_end";
            this.date_end.ReadOnly = true;
            // 
            // days_to_deadline
            // 
            this.days_to_deadline.DataPropertyName = "days_to_deadline";
            this.days_to_deadline.HeaderText = "Дней до окончания";
            this.days_to_deadline.Name = "days_to_deadline";
            this.days_to_deadline.ReadOnly = true;
            // 
            // date_sample_income
            // 
            this.date_sample_income.DataPropertyName = "date_sample_income";
            this.date_sample_income.HeaderText = "Дата предоставления образца";
            this.date_sample_income.Name = "date_sample_income";
            this.date_sample_income.ReadOnly = true;
            // 
            // date_protocol_income
            // 
            this.date_protocol_income.DataPropertyName = "date_protocol_income";
            this.date_protocol_income.HeaderText = "Дата получения протокола";
            this.date_protocol_income.Name = "date_protocol_income";
            this.date_protocol_income.ReadOnly = true;
            // 
            // date_planed_reatt_1
            // 
            this.date_planed_reatt_1.DataPropertyName = "date_planed_reatt_1";
            this.date_planed_reatt_1.HeaderText = "Планируемая дата 1-ой реаттестации";
            this.date_planed_reatt_1.Name = "date_planed_reatt_1";
            this.date_planed_reatt_1.ReadOnly = true;
            // 
            // days_to_deadline_reatt_1
            // 
            this.days_to_deadline_reatt_1.DataPropertyName = "days_to_deadline_reatt_1";
            this.days_to_deadline_reatt_1.HeaderText = "Дней до 1-ой реаттестации";
            this.days_to_deadline_reatt_1.Name = "days_to_deadline_reatt_1";
            this.days_to_deadline_reatt_1.ReadOnly = true;
            // 
            // date_real_reatt_1
            // 
            this.date_real_reatt_1.DataPropertyName = "date_real_reatt_1";
            this.date_real_reatt_1.HeaderText = "Реальная дата 1-ой реаттестации";
            this.date_real_reatt_1.Name = "date_real_reatt_1";
            this.date_real_reatt_1.ReadOnly = true;
            // 
            // date_planed_reatt_2
            // 
            this.date_planed_reatt_2.DataPropertyName = "date_planed_reatt_2";
            this.date_planed_reatt_2.HeaderText = "Планируемая дата 2-ой реаттестации";
            this.date_planed_reatt_2.Name = "date_planed_reatt_2";
            this.date_planed_reatt_2.ReadOnly = true;
            // 
            // days_to_deadline_reatt_2
            // 
            this.days_to_deadline_reatt_2.DataPropertyName = "days_to_deadline_reatt_2";
            this.days_to_deadline_reatt_2.HeaderText = "Дней до 2-ой реаттестации";
            this.days_to_deadline_reatt_2.Name = "days_to_deadline_reatt_2";
            this.days_to_deadline_reatt_2.ReadOnly = true;
            // 
            // date_real_reatt_2
            // 
            this.date_real_reatt_2.DataPropertyName = "date_real_reatt_2";
            this.date_real_reatt_2.HeaderText = "Реальная дата 2-ой реаттестации";
            this.date_real_reatt_2.Name = "date_real_reatt_2";
            this.date_real_reatt_2.ReadOnly = true;
            // 
            // date_planed_resert
            // 
            this.date_planed_resert.DataPropertyName = "date_planed_resert";
            this.date_planed_resert.HeaderText = "Планируемая дата ресертификации";
            this.date_planed_resert.Name = "date_planed_resert";
            this.date_planed_resert.ReadOnly = true;
            // 
            // days_to_deadline_resert
            // 
            this.days_to_deadline_resert.DataPropertyName = "days_to_deadline_resert";
            this.days_to_deadline_resert.HeaderText = "Дней до ресертификации";
            this.days_to_deadline_resert.Name = "days_to_deadline_resert";
            this.days_to_deadline_resert.ReadOnly = true;
            // 
            // date_real_resert
            // 
            this.date_real_resert.DataPropertyName = "date_real_resert";
            this.date_real_resert.HeaderText = "Реальная дата ресертификации";
            this.date_real_resert.Name = "date_real_resert";
            this.date_real_resert.ReadOnly = true;
            // 
            // agentsnameDataGridViewTextBoxColumn
            // 
            this.agentsnameDataGridViewTextBoxColumn.DataPropertyName = "agents_name";
            this.agentsnameDataGridViewTextBoxColumn.HeaderText = "Контрагент";
            this.agentsnameDataGridViewTextBoxColumn.Name = "agentsnameDataGridViewTextBoxColumn";
            this.agentsnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.agentsnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // agenttypesnameDataGridViewTextBoxColumn1
            // 
            this.agenttypesnameDataGridViewTextBoxColumn1.DataPropertyName = "agent_types_name";
            this.agenttypesnameDataGridViewTextBoxColumn1.HeaderText = "Форма собственности";
            this.agenttypesnameDataGridViewTextBoxColumn1.Name = "agenttypesnameDataGridViewTextBoxColumn1";
            this.agenttypesnameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // assignedContractsBindingSource
            // 
            this.assignedContractsBindingSource.DataMember = "AssignedContracts";
            this.assignedContractsBindingSource.DataSource = this.edocbaseDataSet;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1262, 118);
            this.panel3.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nameComboBox);
            this.groupBox2.Controls.Add(this.checkBoxStatuses);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1262, 63);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фильтр этапов выполнения работ";
            // 
            // nameComboBox
            // 
            this.nameComboBox.DataSource = this.contract_statusBindingSource;
            this.nameComboBox.DisplayMember = "name";
            this.nameComboBox.Enabled = false;
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(185, 26);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(712, 21);
            this.nameComboBox.TabIndex = 2;
            this.nameComboBox.ValueMember = "id";
            this.nameComboBox.SelectedIndexChanged += new System.EventHandler(this.nameComboBox_SelectedIndexChanged);
            // 
            // contract_statusBindingSource
            // 
            this.contract_statusBindingSource.DataMember = "contract_status";
            this.contract_statusBindingSource.DataSource = this.edocbaseDataSet;
            // 
            // checkBoxStatuses
            // 
            this.checkBoxStatuses.AutoSize = true;
            this.checkBoxStatuses.Location = new System.Drawing.Point(18, 28);
            this.checkBoxStatuses.Name = "checkBoxStatuses";
            this.checkBoxStatuses.Size = new System.Drawing.Size(147, 17);
            this.checkBoxStatuses.TabIndex = 0;
            this.checkBoxStatuses.Text = "Этап выполнения работ";
            this.checkBoxStatuses.UseVisualStyleBackColor = true;
            this.checkBoxStatuses.CheckedChanged += new System.EventHandler(this.checkBoxStatuses_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxExpertsFilter);
            this.groupBox1.Controls.Add(this.fullnameComboBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1262, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтр экспертов";
            // 
            // checkBoxExpertsFilter
            // 
            this.checkBoxExpertsFilter.AutoSize = true;
            this.checkBoxExpertsFilter.Location = new System.Drawing.Point(18, 24);
            this.checkBoxExpertsFilter.Name = "checkBoxExpertsFilter";
            this.checkBoxExpertsFilter.Size = new System.Drawing.Size(76, 17);
            this.checkBoxExpertsFilter.TabIndex = 2;
            this.checkBoxExpertsFilter.Text = "Эксперты";
            this.checkBoxExpertsFilter.UseVisualStyleBackColor = true;
            this.checkBoxExpertsFilter.CheckedChanged += new System.EventHandler(this.checkBoxExpertsFilter_CheckedChanged);
            // 
            // fullnameComboBox
            // 
            this.fullnameComboBox.DataSource = this.expertsBindingSource;
            this.fullnameComboBox.DisplayMember = "fullname";
            this.fullnameComboBox.Enabled = false;
            this.fullnameComboBox.FormattingEnabled = true;
            this.fullnameComboBox.Location = new System.Drawing.Point(100, 22);
            this.fullnameComboBox.Name = "fullnameComboBox";
            this.fullnameComboBox.Size = new System.Drawing.Size(797, 21);
            this.fullnameComboBox.TabIndex = 1;
            this.fullnameComboBox.ValueMember = "id";
            this.fullnameComboBox.SelectedIndexChanged += new System.EventHandler(this.fullnameComboBox_SelectedIndexChanged);
            // 
            // assignedContractsBindingNavigator
            // 
            this.assignedContractsBindingNavigator.AddNewItem = null;
            this.assignedContractsBindingNavigator.BindingSource = this.assignedContractsBindingSource;
            this.assignedContractsBindingNavigator.CountItem = this.toolStripLabel1;
            this.assignedContractsBindingNavigator.DeleteItem = null;
            this.assignedContractsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.toolStripButton9,
            this.toolStripSeparator4,
            this.filterAssignedToolStripTextBox});
            this.assignedContractsBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.assignedContractsBindingNavigator.MoveFirstItem = this.toolStripButton3;
            this.assignedContractsBindingNavigator.MoveLastItem = this.toolStripButton6;
            this.assignedContractsBindingNavigator.MoveNextItem = this.toolStripButton5;
            this.assignedContractsBindingNavigator.MovePreviousItem = this.toolStripButton4;
            this.assignedContractsBindingNavigator.Name = "assignedContractsBindingNavigator";
            this.assignedContractsBindingNavigator.PositionItem = this.toolStripTextBox1;
            this.assignedContractsBindingNavigator.Size = new System.Drawing.Size(1262, 25);
            this.assignedContractsBindingNavigator.TabIndex = 8;
            this.assignedContractsBindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Move first";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 21);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Move next";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton9.Text = "Обновить";
            this.toolStripButton9.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // filterAssignedToolStripTextBox
            // 
            this.filterAssignedToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterAssignedToolStripTextBox.Name = "filterAssignedToolStripTextBox";
            this.filterAssignedToolStripTextBox.Size = new System.Drawing.Size(200, 25);
            // 
            // proposalLabel
            // 
            this.proposalLabel.AutoSize = true;
            this.proposalLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "AssignExpertProposalText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.proposalLabel.Location = new System.Drawing.Point(16, 18);
            this.proposalLabel.Name = "proposalLabel";
            this.proposalLabel.Size = new System.Drawing.Size(44, 13);
            this.proposalLabel.TabIndex = 4;
            this.proposalLabel.Text = global::Edocsys.Properties.Settings.Default.AssignExpertProposalText;
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
            this.tableAdapterManager.ContractPaymentsTableAdapter = null;
            this.tableAdapterManager.ContractPrepareForWorkTAdapter = null;
            this.tableAdapterManager.ContractSigningTableAdapter = null;
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
            // expertAssignmentTAdapter
            // 
            this.expertAssignmentTAdapter.ClearBeforeFill = true;
            // 
            // expertsTableAdapter
            // 
            this.expertsTableAdapter.ClearBeforeFill = true;
            // 
            // assignedContractsTAdapter
            // 
            this.assignedContractsTAdapter.ClearBeforeFill = true;
            // 
            // contract_statusTableAdapter
            // 
            this.contract_statusTableAdapter.ClearBeforeFill = true;
            // 
            // AssignExpertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 485);
            this.Controls.Add(this.tabControlAssignExpert);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "AssighExpertFormText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Name = "AssignExpertForm";
            this.Text = global::Edocsys.Properties.Settings.Default.AssighExpertFormText;
            this.Activated += new System.EventHandler(this.AssignExpertForm_Activated);
            this.Load += new System.EventHandler(this.AssignExpertForm_Load);
            this.tabControlAssignExpert.ResumeLayout(false);
            this.tabPageAssignExpert.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.expertAssignmentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expertAssignmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edocbaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorAssignedExperts)).EndInit();
            this.bindingNavigatorAssignedExperts.ResumeLayout(false);
            this.bindingNavigatorAssignedExperts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expertsBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPageAssignedExperts.ResumeLayout(false);
            this.tabPageAssignedExperts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assignedContractsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignedContractsBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contract_statusBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assignedContractsBindingNavigator)).EndInit();
            this.assignedContractsBindingNavigator.ResumeLayout(false);
            this.assignedContractsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private EdocbaseDataSet edocbaseDataSet;
        private EdocbaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TabControl tabControlAssignExpert;
        private System.Windows.Forms.TabPage tabPageAssignExpert;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button assignButton;
        private System.Windows.Forms.TextBox expertTextBox;
        private System.Windows.Forms.TextBox contractTextBox;
        private System.Windows.Forms.TabPage tabPageAssignedExperts;
        private System.Windows.Forms.ListBox expertsListBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelExperts;
        private System.Windows.Forms.BindingSource expertsBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label proposalLabel;
        private System.Windows.Forms.BindingNavigator assignedContractsBindingNavigator;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.DataGridView assignedContractsDataGridView;
        private System.Windows.Forms.BindingSource expertAssignmentBindingSource;
        private EdocbaseDataSetTableAdapters.ExpertAssignmentTAdapter expertAssignmentTAdapter;
        private EdocbaseDataSetTableAdapters.expertsTableAdapter expertsTableAdapter;
        private System.Windows.Forms.BindingSource assignedContractsBindingSource;
        private EdocbaseDataSetTableAdapters.AssignedContractsTAdapter assignedContractsTAdapter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox filterAssignedToolStripTextBox;
        private System.Windows.Forms.DataGridView expertAssignmentDataGridView;
        private System.Windows.Forms.BindingNavigator bindingNavigatorAssignedExperts;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripTextBox filterProposalsToolStripTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox fullnameComboBox;
        private System.Windows.Forms.CheckBox checkBoxExpertsFilter;
        private System.Windows.Forms.BindingSource contract_statusBindingSource;
        private EdocbaseDataSetTableAdapters.contract_statusTableAdapter contract_statusTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox nameComboBox;
        private System.Windows.Forms.CheckBox checkBoxStatuses;
        private System.Windows.Forms.DataGridViewTextBoxColumn products_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn contracttypesnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateproposalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn agents_fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn agents_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn agenttypesnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn contracttypesnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn expert_FIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn contract_status_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn prepayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cash_income;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_cash_income;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateproposalDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_contract;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_start;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_end;
        private System.Windows.Forms.DataGridViewTextBoxColumn days_to_deadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_sample_income;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_protocol_income;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_planed_reatt_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn days_to_deadline_reatt_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_real_reatt_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_planed_reatt_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn days_to_deadline_reatt_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_real_reatt_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_planed_resert;
        private System.Windows.Forms.DataGridViewTextBoxColumn days_to_deadline_resert;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_real_resert;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentsnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agenttypesnameDataGridViewTextBoxColumn1;
    }
}