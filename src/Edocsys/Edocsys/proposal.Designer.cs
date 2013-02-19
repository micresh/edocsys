namespace Edocsys
{
    partial class ProposalForm
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
            System.Windows.Forms.Label proposalProductLabel;
            System.Windows.Forms.Label proposalEmissionLabel;
            System.Windows.Forms.Label proposalSchemeTypeLabel;
            System.Windows.Forms.Label proposalAddDataLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label contract_typeLabel;
            System.Windows.Forms.Label date_proposalLabel;
            System.Windows.Forms.Label costLabel;
            System.Windows.Forms.Label total_costLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProposalForm));
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.proposalsDataGridView = new System.Windows.Forms.DataGridView();
            this.agentsnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agenttypesnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contracttypesnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schemetypeFIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emissiontypesnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactpersnameFIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentsfullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SendProposalColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractInfoDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.edocbaseDataSet = new Edocsys.EdocbaseDataSet();
            this.total_costTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.emission_types_idComboBox = new System.Windows.Forms.ComboBox();
            this.emission_typesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contract_typeComboBox = new System.Windows.Forms.ComboBox();
            this.contract_typesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.date_proposalDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.porposalGenerationGroupBox = new System.Windows.Forms.GroupBox();
            this.buttonLoadProposal = new System.Windows.Forms.Button();
            this.buttonSaveProposal = new System.Windows.Forms.Button();
            this.buttonEditProposal = new System.Windows.Forms.Button();
            this.buttonGenerateProposalDoc = new System.Windows.Forms.Button();
            this.proposalAgentsComboBox = new System.Windows.Forms.ComboBox();
            this.agentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addDataTextBox = new System.Windows.Forms.TextBox();
            this.schemeTypeTextBox = new System.Windows.Forms.TextBox();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.contractsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.contractsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.filterToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.agentsTableAdapter = new Edocsys.EdocbaseDataSetTableAdapters.agentsTableAdapter();
            this.tableAdapterManager = new Edocsys.EdocbaseDataSetTableAdapters.TableAdapterManager();
            this.contract_typesTableAdapter = new Edocsys.EdocbaseDataSetTableAdapters.contract_typesTableAdapter();
            this.contractInfoTableAdapter = new Edocsys.EdocbaseDataSetTableAdapters.ContractInfoTableAdapter();
            this.documentsTableAdapter = new Edocsys.EdocbaseDataSetTableAdapters.documentsTableAdapter();
            this.emission_typesTableAdapter = new Edocsys.EdocbaseDataSetTableAdapters.emission_typesTableAdapter();
            this.productsTableAdapter = new Edocsys.EdocbaseDataSetTableAdapters.productsTableAdapter();
            this.templatesDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.templatesDataTableTableAdapter = new Edocsys.EdocbaseDataSetTableAdapters.templatesDataTableTableAdapter();
            this.documentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonGOSTSelection = new System.Windows.Forms.Button();
            proposalProductLabel = new System.Windows.Forms.Label();
            proposalEmissionLabel = new System.Windows.Forms.Label();
            proposalSchemeTypeLabel = new System.Windows.Forms.Label();
            proposalAddDataLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            contract_typeLabel = new System.Windows.Forms.Label();
            date_proposalLabel = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            total_costLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proposalsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractInfoDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edocbaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emission_typesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contract_typesBindingSource)).BeginInit();
            this.porposalGenerationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsBindingNavigator)).BeginInit();
            this.contractsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.templatesDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // proposalProductLabel
            // 
            proposalProductLabel.AutoSize = true;
            proposalProductLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "product_nameLabelText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            proposalProductLabel.Location = new System.Drawing.Point(12, 29);
            proposalProductLabel.Name = "proposalProductLabel";
            proposalProductLabel.Size = new System.Drawing.Size(139, 13);
            proposalProductLabel.TabIndex = 4;
            proposalProductLabel.Text = global::Edocsys.Properties.Settings.Default.product_nameLabelText;
            // 
            // proposalEmissionLabel
            // 
            proposalEmissionLabel.AutoSize = true;
            proposalEmissionLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ProposalEmissionLabelText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            proposalEmissionLabel.Location = new System.Drawing.Point(12, 99);
            proposalEmissionLabel.Name = "proposalEmissionLabel";
            proposalEmissionLabel.Size = new System.Drawing.Size(128, 13);
            proposalEmissionLabel.TabIndex = 6;
            proposalEmissionLabel.Text = global::Edocsys.Properties.Settings.Default.ProposalEmissionLabelText;
            // 
            // proposalSchemeTypeLabel
            // 
            proposalSchemeTypeLabel.AutoSize = true;
            proposalSchemeTypeLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ProposalSchemeTypeLabelText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            proposalSchemeTypeLabel.Location = new System.Drawing.Point(12, 122);
            proposalSchemeTypeLabel.Name = "proposalSchemeTypeLabel";
            proposalSchemeTypeLabel.Size = new System.Drawing.Size(115, 13);
            proposalSchemeTypeLabel.TabIndex = 11;
            proposalSchemeTypeLabel.Text = global::Edocsys.Properties.Settings.Default.ProposalSchemeTypeLabelText;
            // 
            // proposalAddDataLabel
            // 
            proposalAddDataLabel.AutoSize = true;
            proposalAddDataLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ProposalAddDataLabelText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            proposalAddDataLabel.Location = new System.Drawing.Point(12, 146);
            proposalAddDataLabel.Name = "proposalAddDataLabel";
            proposalAddDataLabel.Size = new System.Drawing.Size(146, 13);
            proposalAddDataLabel.TabIndex = 13;
            proposalAddDataLabel.Text = global::Edocsys.Properties.Settings.Default.ProposalAddDataLabelText;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ProposalAgentNameText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            label1.Location = new System.Drawing.Point(12, 7);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(123, 13);
            label1.TabIndex = 14;
            label1.Text = global::Edocsys.Properties.Settings.Default.ProposalAgentNameText;
            // 
            // contract_typeLabel
            // 
            contract_typeLabel.AutoSize = true;
            contract_typeLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ContractTypeText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            contract_typeLabel.Location = new System.Drawing.Point(12, 75);
            contract_typeLabel.Name = "contract_typeLabel";
            contract_typeLabel.Size = new System.Drawing.Size(124, 13);
            contract_typeLabel.TabIndex = 21;
            contract_typeLabel.Text = global::Edocsys.Properties.Settings.Default.ContractTypeText;
            // 
            // date_proposalLabel
            // 
            date_proposalLabel.AutoSize = true;
            date_proposalLabel.Location = new System.Drawing.Point(12, 172);
            date_proposalLabel.Name = "date_proposalLabel";
            date_proposalLabel.Size = new System.Drawing.Size(110, 13);
            date_proposalLabel.TabIndex = 27;
            date_proposalLabel.Text = "Дата подачи заявки";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new System.Drawing.Point(321, 172);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(41, 13);
            costLabel.TabIndex = 28;
            costLabel.Text = "Сумма";
            // 
            // total_costLabel
            // 
            total_costLabel.AutoSize = true;
            total_costLabel.Location = new System.Drawing.Point(468, 172);
            total_costLabel.Name = "total_costLabel";
            total_costLabel.Size = new System.Drawing.Size(78, 13);
            total_costLabel.TabIndex = 29;
            total_costLabel.Text = "Общая сумма";
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 25);
            this.mainSplitContainer.Name = "mainSplitContainer";
            this.mainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.proposalsDataGridView);
            this.mainSplitContainer.Panel1MinSize = 240;
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.AutoScroll = true;
            this.mainSplitContainer.Panel2.Controls.Add(this.buttonGOSTSelection);
            this.mainSplitContainer.Panel2.Controls.Add(this.textBox1);
            this.mainSplitContainer.Panel2.Controls.Add(this.checkBox1);
            this.mainSplitContainer.Panel2.Controls.Add(this.label2);
            this.mainSplitContainer.Panel2.Controls.Add(total_costLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.total_costTextBox);
            this.mainSplitContainer.Panel2.Controls.Add(costLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.costTextBox);
            this.mainSplitContainer.Panel2.Controls.Add(date_proposalLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.emission_types_idComboBox);
            this.mainSplitContainer.Panel2.Controls.Add(this.contract_typeComboBox);
            this.mainSplitContainer.Panel2.Controls.Add(this.date_proposalDateTimePicker);
            this.mainSplitContainer.Panel2.Controls.Add(this.porposalGenerationGroupBox);
            this.mainSplitContainer.Panel2.Controls.Add(contract_typeLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.proposalAgentsComboBox);
            this.mainSplitContainer.Panel2.Controls.Add(label1);
            this.mainSplitContainer.Panel2.Controls.Add(proposalAddDataLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.addDataTextBox);
            this.mainSplitContainer.Panel2.Controls.Add(proposalSchemeTypeLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.schemeTypeTextBox);
            this.mainSplitContainer.Panel2.Controls.Add(this.productComboBox);
            this.mainSplitContainer.Panel2.Controls.Add(proposalEmissionLabel);
            this.mainSplitContainer.Panel2.Controls.Add(proposalProductLabel);
            this.mainSplitContainer.Panel2MinSize = 200;
            this.mainSplitContainer.Size = new System.Drawing.Size(950, 574);
            this.mainSplitContainer.SplitterDistance = 370;
            this.mainSplitContainer.TabIndex = 2;
            // 
            // proposalsDataGridView
            // 
            this.proposalsDataGridView.AllowUserToAddRows = false;
            this.proposalsDataGridView.AllowUserToDeleteRows = false;
            this.proposalsDataGridView.AutoGenerateColumns = false;
            this.proposalsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proposalsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.agentsnameDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.agenttypesnameDataGridViewTextBoxColumn,
            this.contracttypesnameDataGridViewTextBoxColumn,
            this.schemetypeFIODataGridViewTextBoxColumn,
            this.emissiontypesnameDataGridViewTextBoxColumn,
            this.contactpersnameFIODataGridViewTextBoxColumn,
            this.agentsfullnameDataGridViewTextBoxColumn,
            this.SendProposalColumn,
            this.cost,
            this.total_cost});
            this.proposalsDataGridView.DataSource = this.contractInfoDataTableBindingSource;
            this.proposalsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.proposalsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.proposalsDataGridView.MultiSelect = false;
            this.proposalsDataGridView.Name = "proposalsDataGridView";
            this.proposalsDataGridView.ReadOnly = true;
            this.proposalsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.proposalsDataGridView.Size = new System.Drawing.Size(950, 370);
            this.proposalsDataGridView.TabIndex = 2;
            this.proposalsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.contractsDataGridView_CellClick);
            // 
            // agentsnameDataGridViewTextBoxColumn
            // 
            this.agentsnameDataGridViewTextBoxColumn.DataPropertyName = "agents_name";
            this.agentsnameDataGridViewTextBoxColumn.HeaderText = "Контрагент";
            this.agentsnameDataGridViewTextBoxColumn.Name = "agentsnameDataGridViewTextBoxColumn";
            this.agentsnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "products_name";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Продукция";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // agenttypesnameDataGridViewTextBoxColumn
            // 
            this.agenttypesnameDataGridViewTextBoxColumn.DataPropertyName = "agent_types_name";
            this.agenttypesnameDataGridViewTextBoxColumn.HeaderText = "Форма";
            this.agenttypesnameDataGridViewTextBoxColumn.Name = "agenttypesnameDataGridViewTextBoxColumn";
            this.agenttypesnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contracttypesnameDataGridViewTextBoxColumn
            // 
            this.contracttypesnameDataGridViewTextBoxColumn.DataPropertyName = "contract_types_name";
            this.contracttypesnameDataGridViewTextBoxColumn.HeaderText = "Тип сертификации";
            this.contracttypesnameDataGridViewTextBoxColumn.Name = "contracttypesnameDataGridViewTextBoxColumn";
            this.contracttypesnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // schemetypeFIODataGridViewTextBoxColumn
            // 
            this.schemetypeFIODataGridViewTextBoxColumn.DataPropertyName = "scheme_type";
            this.schemetypeFIODataGridViewTextBoxColumn.HeaderText = "Схема сертификации";
            this.schemetypeFIODataGridViewTextBoxColumn.Name = "schemetypeFIODataGridViewTextBoxColumn";
            this.schemetypeFIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emissiontypesnameDataGridViewTextBoxColumn
            // 
            this.emissiontypesnameDataGridViewTextBoxColumn.DataPropertyName = "emission_types_name";
            this.emissiontypesnameDataGridViewTextBoxColumn.HeaderText = "Тип выпуска";
            this.emissiontypesnameDataGridViewTextBoxColumn.Name = "emissiontypesnameDataGridViewTextBoxColumn";
            this.emissiontypesnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactpersnameFIODataGridViewTextBoxColumn
            // 
            this.contactpersnameFIODataGridViewTextBoxColumn.DataPropertyName = "contact_pers_name_FIO";
            this.contactpersnameFIODataGridViewTextBoxColumn.HeaderText = "Контактное лицо";
            this.contactpersnameFIODataGridViewTextBoxColumn.Name = "contactpersnameFIODataGridViewTextBoxColumn";
            this.contactpersnameFIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // agentsfullnameDataGridViewTextBoxColumn
            // 
            this.agentsfullnameDataGridViewTextBoxColumn.DataPropertyName = "agents_fullname";
            this.agentsfullnameDataGridViewTextBoxColumn.HeaderText = "Контрагент";
            this.agentsfullnameDataGridViewTextBoxColumn.Name = "agentsfullnameDataGridViewTextBoxColumn";
            this.agentsfullnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SendProposalColumn
            // 
            this.SendProposalColumn.HeaderText = "Отправить заявку";
            this.SendProposalColumn.Name = "SendProposalColumn";
            this.SendProposalColumn.ReadOnly = true;
            // 
            // cost
            // 
            this.cost.DataPropertyName = "cost";
            this.cost.HeaderText = "Сумма";
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            // 
            // total_cost
            // 
            this.total_cost.DataPropertyName = "total_cost";
            this.total_cost.HeaderText = "Общая сумма";
            this.total_cost.Name = "total_cost";
            this.total_cost.ReadOnly = true;
            // 
            // contractInfoDataTableBindingSource
            // 
            this.contractInfoDataTableBindingSource.DataMember = "ContractInfoDataTable";
            this.contractInfoDataTableBindingSource.DataSource = this.edocbaseDataSet;
            // 
            // edocbaseDataSet
            // 
            this.edocbaseDataSet.CaseSensitive = true;
            this.edocbaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // total_costTextBox
            // 
            this.total_costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractInfoDataTableBindingSource, "total_cost", true));
            this.total_costTextBox.Location = new System.Drawing.Point(552, 167);
            this.total_costTextBox.Name = "total_costTextBox";
            this.total_costTextBox.Size = new System.Drawing.Size(100, 20);
            this.total_costTextBox.TabIndex = 30;
            // 
            // costTextBox
            // 
            this.costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractInfoDataTableBindingSource, "cost", true));
            this.costTextBox.Location = new System.Drawing.Point(368, 166);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(94, 20);
            this.costTextBox.TabIndex = 29;
            // 
            // emission_types_idComboBox
            // 
            this.emission_types_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contractInfoDataTableBindingSource, "emission_types_id", true));
            this.emission_types_idComboBox.DataSource = this.emission_typesBindingSource;
            this.emission_types_idComboBox.DisplayMember = "name";
            this.emission_types_idComboBox.FormattingEnabled = true;
            this.emission_types_idComboBox.Location = new System.Drawing.Point(167, 96);
            this.emission_types_idComboBox.Name = "emission_types_idComboBox";
            this.emission_types_idComboBox.Size = new System.Drawing.Size(485, 21);
            this.emission_types_idComboBox.TabIndex = 27;
            this.emission_types_idComboBox.ValueMember = "id";
            // 
            // emission_typesBindingSource
            // 
            this.emission_typesBindingSource.DataMember = "emission_types";
            this.emission_typesBindingSource.DataSource = this.edocbaseDataSet;
            // 
            // contract_typeComboBox
            // 
            this.contract_typeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contractInfoDataTableBindingSource, "contract_types_id", true));
            this.contract_typeComboBox.DataSource = this.contract_typesBindingSource;
            this.contract_typeComboBox.DisplayMember = "name";
            this.contract_typeComboBox.FormattingEnabled = true;
            this.contract_typeComboBox.Location = new System.Drawing.Point(167, 72);
            this.contract_typeComboBox.Name = "contract_typeComboBox";
            this.contract_typeComboBox.Size = new System.Drawing.Size(485, 21);
            this.contract_typeComboBox.TabIndex = 25;
            this.contract_typeComboBox.ValueMember = "id";
            // 
            // contract_typesBindingSource
            // 
            this.contract_typesBindingSource.DataMember = "contract_types";
            this.contract_typesBindingSource.DataSource = this.edocbaseDataSet;
            // 
            // date_proposalDateTimePicker
            // 
            this.date_proposalDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contractInfoDataTableBindingSource, "date_proposal", true));
            this.date_proposalDateTimePicker.Location = new System.Drawing.Point(167, 166);
            this.date_proposalDateTimePicker.Name = "date_proposalDateTimePicker";
            this.date_proposalDateTimePicker.Size = new System.Drawing.Size(148, 20);
            this.date_proposalDateTimePicker.TabIndex = 28;
            // 
            // porposalGenerationGroupBox
            // 
            this.porposalGenerationGroupBox.Controls.Add(this.buttonLoadProposal);
            this.porposalGenerationGroupBox.Controls.Add(this.buttonSaveProposal);
            this.porposalGenerationGroupBox.Controls.Add(this.buttonEditProposal);
            this.porposalGenerationGroupBox.Controls.Add(this.buttonGenerateProposalDoc);
            this.porposalGenerationGroupBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ProposalOperationsGroupBox", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.porposalGenerationGroupBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.porposalGenerationGroupBox.Location = new System.Drawing.Point(658, 0);
            this.porposalGenerationGroupBox.Name = "porposalGenerationGroupBox";
            this.porposalGenerationGroupBox.Size = new System.Drawing.Size(292, 200);
            this.porposalGenerationGroupBox.TabIndex = 24;
            this.porposalGenerationGroupBox.TabStop = false;
            this.porposalGenerationGroupBox.Text = global::Edocsys.Properties.Settings.Default.ProposalOperationsGroupBox;
            // 
            // buttonLoadProposal
            // 
            this.buttonLoadProposal.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "LoadProposalButton", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonLoadProposal.Location = new System.Drawing.Point(21, 116);
            this.buttonLoadProposal.Name = "buttonLoadProposal";
            this.buttonLoadProposal.Size = new System.Drawing.Size(246, 23);
            this.buttonLoadProposal.TabIndex = 20;
            this.buttonLoadProposal.Text = global::Edocsys.Properties.Settings.Default.LoadProposalButton;
            this.buttonLoadProposal.UseVisualStyleBackColor = true;
            this.buttonLoadProposal.Click += new System.EventHandler(this.buttonLoadProposal_Click);
            // 
            // buttonSaveProposal
            // 
            this.buttonSaveProposal.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "SaveProposalButton", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonSaveProposal.Location = new System.Drawing.Point(21, 86);
            this.buttonSaveProposal.Name = "buttonSaveProposal";
            this.buttonSaveProposal.Size = new System.Drawing.Size(246, 23);
            this.buttonSaveProposal.TabIndex = 19;
            this.buttonSaveProposal.Text = global::Edocsys.Properties.Settings.Default.SaveProposalButton;
            this.buttonSaveProposal.UseVisualStyleBackColor = true;
            this.buttonSaveProposal.Click += new System.EventHandler(this.buttonSaveProposal_Click);
            // 
            // buttonEditProposal
            // 
            this.buttonEditProposal.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "EditProposalButton", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonEditProposal.Location = new System.Drawing.Point(21, 57);
            this.buttonEditProposal.Name = "buttonEditProposal";
            this.buttonEditProposal.Size = new System.Drawing.Size(246, 23);
            this.buttonEditProposal.TabIndex = 18;
            this.buttonEditProposal.Text = global::Edocsys.Properties.Settings.Default.EditProposalButton;
            this.buttonEditProposal.UseVisualStyleBackColor = true;
            this.buttonEditProposal.Click += new System.EventHandler(this.buttonEditProposal_Click);
            // 
            // buttonGenerateProposalDoc
            // 
            this.buttonGenerateProposalDoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "GenerateProposalTitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonGenerateProposalDoc.Location = new System.Drawing.Point(21, 19);
            this.buttonGenerateProposalDoc.Name = "buttonGenerateProposalDoc";
            this.buttonGenerateProposalDoc.Size = new System.Drawing.Size(246, 23);
            this.buttonGenerateProposalDoc.TabIndex = 17;
            this.buttonGenerateProposalDoc.Text = global::Edocsys.Properties.Settings.Default.GenerateProposalTitle;
            this.buttonGenerateProposalDoc.UseVisualStyleBackColor = true;
            this.buttonGenerateProposalDoc.Click += new System.EventHandler(this.buttonGenerateProposalDoc_Click);
            // 
            // proposalAgentsComboBox
            // 
            this.proposalAgentsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contractInfoDataTableBindingSource, "agents_id", true));
            this.proposalAgentsComboBox.DataSource = this.agentsBindingSource;
            this.proposalAgentsComboBox.DisplayMember = "fullname";
            this.proposalAgentsComboBox.FormattingEnabled = true;
            this.proposalAgentsComboBox.Location = new System.Drawing.Point(167, 4);
            this.proposalAgentsComboBox.Name = "proposalAgentsComboBox";
            this.proposalAgentsComboBox.Size = new System.Drawing.Size(485, 21);
            this.proposalAgentsComboBox.TabIndex = 15;
            this.proposalAgentsComboBox.ValueMember = "id";
            // 
            // agentsBindingSource
            // 
            this.agentsBindingSource.DataMember = "agents";
            this.agentsBindingSource.DataSource = this.edocbaseDataSet;
            // 
            // addDataTextBox
            // 
            this.addDataTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractInfoDataTableBindingSource, "add_data_proposal", true));
            this.addDataTextBox.Location = new System.Drawing.Point(167, 143);
            this.addDataTextBox.Name = "addDataTextBox";
            this.addDataTextBox.Size = new System.Drawing.Size(485, 20);
            this.addDataTextBox.TabIndex = 12;
            // 
            // schemeTypeTextBox
            // 
            this.schemeTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractInfoDataTableBindingSource, "scheme_type", true));
            this.schemeTypeTextBox.Location = new System.Drawing.Point(167, 119);
            this.schemeTypeTextBox.Name = "schemeTypeTextBox";
            this.schemeTypeTextBox.Size = new System.Drawing.Size(485, 20);
            this.schemeTypeTextBox.TabIndex = 10;
            // 
            // productComboBox
            // 
            this.productComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contractInfoDataTableBindingSource, "products_id", true));
            this.productComboBox.DataSource = this.productsBindingSource;
            this.productComboBox.DisplayMember = "name";
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(167, 26);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(485, 21);
            this.productComboBox.TabIndex = 7;
            this.productComboBox.ValueMember = "id";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "products";
            this.productsBindingSource.DataSource = this.edocbaseDataSet;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Файлы Word 2007-2010| *.docx|Все файлы|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Файлы Word 2007-2010| *.docx|Все файлы|*.*";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            // contractsBindingNavigatorSaveItem
            // 
            this.contractsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.contractsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("contractsBindingNavigatorSaveItem.Image")));
            this.contractsBindingNavigatorSaveItem.Name = "contractsBindingNavigatorSaveItem";
            this.contractsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.contractsBindingNavigatorSaveItem.Text = "Save Data";
            this.contractsBindingNavigatorSaveItem.Click += new System.EventHandler(this.contractsBindingNavigatorSaveItem_Click);
            // 
            // contractsBindingNavigator
            // 
            this.contractsBindingNavigator.AddNewItem = null;
            this.contractsBindingNavigator.BindingSource = this.contractInfoDataTableBindingSource;
            this.contractsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.contractsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.contractsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.contractsBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.filterToolStripTextBox});
            this.contractsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.contractsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.contractsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.contractsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.contractsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.contractsBindingNavigator.Name = "contractsBindingNavigator";
            this.contractsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.contractsBindingNavigator.Size = new System.Drawing.Size(950, 25);
            this.contractsBindingNavigator.TabIndex = 0;
            this.contractsBindingNavigator.Text = "bindingNavigator1";
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
            // filterToolStripTextBox
            // 
            this.filterToolStripTextBox.Name = "filterToolStripTextBox";
            this.filterToolStripTextBox.Size = new System.Drawing.Size(200, 25);
            // 
            // agentsTableAdapter
            // 
            this.agentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.agent_typesTableAdapter = null;
            this.tableAdapterManager.agents_contactsTableAdapter = null;
            this.tableAdapterManager.agentsTableAdapter = this.agentsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.contract_statusTableAdapter = null;
            this.tableAdapterManager.contract_types_for_workTableAdapter = null;
            this.tableAdapterManager.contract_typesTableAdapter = this.contract_typesTableAdapter;
            this.tableAdapterManager.ContractInfoTableAdapter = this.contractInfoTableAdapter;
            this.tableAdapterManager.contractsTableAdapter = null;
            this.tableAdapterManager.doc_templatesTableAdapter = null;
            this.tableAdapterManager.documentsTableAdapter = this.documentsTableAdapter;
            this.tableAdapterManager.emission_typesTableAdapter = this.emission_typesTableAdapter;
            this.tableAdapterManager.expertsTableAdapter = null;
            this.tableAdapterManager.log_journalTableAdapter = null;
            this.tableAdapterManager.product_areasTableAdapter = null;
            this.tableAdapterManager.product_gostsTableAdapter = null;
            this.tableAdapterManager.productsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.selected_gostsTableAdapter = null;
            this.tableAdapterManager.source_typesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Edocsys.EdocbaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.user_typesTableAdapter = null;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // contract_typesTableAdapter
            // 
            this.contract_typesTableAdapter.ClearBeforeFill = true;
            // 
            // contractInfoTableAdapter
            // 
            this.contractInfoTableAdapter.ClearBeforeFill = true;
            // 
            // documentsTableAdapter
            // 
            this.documentsTableAdapter.ClearBeforeFill = true;
            // 
            // emission_typesTableAdapter
            // 
            this.emission_typesTableAdapter.ClearBeforeFill = true;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // templatesDataTableBindingSource
            // 
            this.templatesDataTableBindingSource.DataMember = "templatesDataTable";
            this.templatesDataTableBindingSource.DataSource = this.edocbaseDataSet;
            // 
            // templatesDataTableTableAdapter
            // 
            this.templatesDataTableTableAdapter.ClearBeforeFill = true;
            // 
            // documentsBindingSource
            // 
            this.documentsBindingSource.DataMember = "documents";
            this.documentsBindingSource.DataSource = this.edocbaseDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Выбраные ГОСТы";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(167, 50);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(44, 17);
            this.checkBox1.TabIndex = 32;
            this.checkBox1.Text = "все";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(217, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(404, 20);
            this.textBox1.TabIndex = 33;
            // 
            // buttonGOSTSelection
            // 
            this.buttonGOSTSelection.Location = new System.Drawing.Point(622, 49);
            this.buttonGOSTSelection.Name = "buttonGOSTSelection";
            this.buttonGOSTSelection.Size = new System.Drawing.Size(30, 23);
            this.buttonGOSTSelection.TabIndex = 34;
            this.buttonGOSTSelection.Text = "...";
            this.buttonGOSTSelection.UseVisualStyleBackColor = true;
            // 
            // ProposalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 599);
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.contractsBindingNavigator);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ProposalFormText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Name = "ProposalForm";
            this.Text = global::Edocsys.Properties.Settings.Default.ProposalFormText;
            this.Load += new System.EventHandler(this.ProposalForm_Load);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.proposalsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractInfoDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edocbaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emission_typesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contract_typesBindingSource)).EndInit();
            this.porposalGenerationGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.agentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsBindingNavigator)).EndInit();
            this.contractsBindingNavigator.ResumeLayout(false);
            this.contractsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.templatesDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView proposalsDataGridView;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.TextBox addDataTextBox;
        private System.Windows.Forms.TextBox schemeTypeTextBox;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.ComboBox proposalAgentsComboBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.GroupBox porposalGenerationGroupBox;
        private System.Windows.Forms.Button buttonLoadProposal;
        private System.Windows.Forms.Button buttonSaveProposal;
        private System.Windows.Forms.Button buttonEditProposal;
        private System.Windows.Forms.Button buttonGenerateProposalDoc;
        private System.Windows.Forms.ComboBox contract_typeComboBox;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton contractsBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator contractsBindingNavigator;
        private EdocbaseDataSet edocbaseDataSet;
        private System.Windows.Forms.BindingSource agentsBindingSource;
        private EdocbaseDataSetTableAdapters.agentsTableAdapter agentsTableAdapter;
        private EdocbaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private EdocbaseDataSetTableAdapters.productsTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private EdocbaseDataSetTableAdapters.contract_typesTableAdapter contract_typesTableAdapter;
        private System.Windows.Forms.BindingSource contract_typesBindingSource;
        private System.Windows.Forms.BindingSource templatesDataTableBindingSource;
        private EdocbaseDataSetTableAdapters.templatesDataTableTableAdapter templatesDataTableTableAdapter;
        private EdocbaseDataSetTableAdapters.documentsTableAdapter documentsTableAdapter;
        private System.Windows.Forms.BindingSource documentsBindingSource;
        private System.Windows.Forms.ComboBox emission_types_idComboBox;
        private EdocbaseDataSetTableAdapters.emission_typesTableAdapter emission_typesTableAdapter;
        private System.Windows.Forms.BindingSource emission_typesBindingSource;
        private System.Windows.Forms.BindingSource contractInfoDataTableBindingSource;
        private EdocbaseDataSetTableAdapters.ContractInfoTableAdapter contractInfoTableAdapter;
        private System.Windows.Forms.DateTimePicker date_proposalDateTimePicker;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox filterToolStripTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentsnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agenttypesnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contracttypesnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schemetypeFIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emissiontypesnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactpersnameFIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentsfullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn SendProposalColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_cost;
        private System.Windows.Forms.TextBox total_costTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonGOSTSelection;

        //private EdocbaseDataSetTableAdapters.TemplatesDataTableTableAdapter templatesDataTableTableAdapter;
        //private EdocbaseDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        //private EdocbaseDataSetTableAdapters.AgentsTableAdapter agentsTableAdapter;
        //private EdocbaseDataSetTableAdapters.Exec_contractsTableAdapter exec_contractsTableAdapter;
        //private EdocbaseDataSetTableAdapters.DocTemplatesTableAdapter docTemplatesTableAdapter;
        //private EdocbaseDataSetTableAdapters.DocumentsTableAdapter documentsTableAdapter;
        //private EdocbaseDataSetTableAdapters.ContractTypesForDocsTableAdapter contractTypesForDocsTableAdapter;

    }
}