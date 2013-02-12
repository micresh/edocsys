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
            System.Windows.Forms.Label proposalClientDocsLabel;
            System.Windows.Forms.Label proposalSchemeTypeLabel;
            System.Windows.Forms.Label proposalAddDataLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label contract_typeLabel;
            System.Windows.Forms.Label contract_numberLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProposalForm));
            this.contractsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.contractsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.edocbaseDataSet = new Edocsys.EdocbaseDataSet();
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
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.contractsDataGridView = new System.Windows.Forms.DataGridView();
            this.idContract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contract_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agent_shortname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProducts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SendProposalColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Contract_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contract_numberTextBox = new System.Windows.Forms.TextBox();
            this.contract_typeComboBox = new System.Windows.Forms.ComboBox();
            this.contractTypesForDocsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.porposalGenerationGroupBox = new System.Windows.Forms.GroupBox();
            this.buttonLoadProposal = new System.Windows.Forms.Button();
            this.buttonSaveProposal = new System.Windows.Forms.Button();
            this.buttonEditProposal = new System.Windows.Forms.Button();
            this.buttonGenerateProposalDoc = new System.Windows.Forms.Button();
            this.proposalAgentsComboBox = new System.Windows.Forms.ComboBox();
            this.agentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addDataTextBox = new System.Windows.Forms.TextBox();
            this.schemeTypeTextBox = new System.Windows.Forms.TextBox();
            this.clientDocsTextBox = new System.Windows.Forms.TextBox();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proposalEmissionTypeTextBox = new System.Windows.Forms.TextBox();
            this.tableAdapterManager = new Edocsys.EdocbaseDataSetTableAdapters.TableAdapterManager();
            this.templatesDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractInfoDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractInfoDataTableTableAdapter = new Edocsys.EdocbaseDataSetTableAdapters.ContractInfoDataTableTableAdapter();
            this.docTemplatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentsidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expertsidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractstatusidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emissiontypesidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contracttypesidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateproposalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schemetypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adddataproposalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datecontractDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourcetypesidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daterealresertDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateplanedresertDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daterealreatt2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateplanedreatt2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daterealreatt1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateplanedreatt1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateprotocolincomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datesampleincomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datestartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datecashincomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashincomeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.totalcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adddatacontractDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            proposalProductLabel = new System.Windows.Forms.Label();
            proposalEmissionLabel = new System.Windows.Forms.Label();
            proposalClientDocsLabel = new System.Windows.Forms.Label();
            proposalSchemeTypeLabel = new System.Windows.Forms.Label();
            proposalAddDataLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            contract_typeLabel = new System.Windows.Forms.Label();
            contract_numberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.contractsBindingNavigator)).BeginInit();
            this.contractsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edocbaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractTypesForDocsBindingSource)).BeginInit();
            this.porposalGenerationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templatesDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractInfoDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docTemplatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // proposalProductLabel
            // 
            proposalProductLabel.AutoSize = true;
            proposalProductLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "product_nameLabelText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            proposalProductLabel.Location = new System.Drawing.Point(12, 57);
            proposalProductLabel.Name = "proposalProductLabel";
            proposalProductLabel.Size = new System.Drawing.Size(139, 13);
            proposalProductLabel.TabIndex = 4;
            proposalProductLabel.Text = global::Edocsys.Properties.Settings.Default.product_nameLabelText;
            // 
            // proposalEmissionLabel
            // 
            proposalEmissionLabel.AutoSize = true;
            proposalEmissionLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ProposalEmissionLabelText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            proposalEmissionLabel.Location = new System.Drawing.Point(12, 103);
            proposalEmissionLabel.Name = "proposalEmissionLabel";
            proposalEmissionLabel.Size = new System.Drawing.Size(128, 13);
            proposalEmissionLabel.TabIndex = 6;
            proposalEmissionLabel.Text = global::Edocsys.Properties.Settings.Default.ProposalEmissionLabelText;
            // 
            // proposalClientDocsLabel
            // 
            proposalClientDocsLabel.AutoSize = true;
            proposalClientDocsLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ProposalClientDocsLabelText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            proposalClientDocsLabel.Location = new System.Drawing.Point(12, 126);
            proposalClientDocsLabel.Name = "proposalClientDocsLabel";
            proposalClientDocsLabel.Size = new System.Drawing.Size(146, 13);
            proposalClientDocsLabel.TabIndex = 9;
            proposalClientDocsLabel.Text = global::Edocsys.Properties.Settings.Default.ProposalClientDocsLabelText;
            // 
            // proposalSchemeTypeLabel
            // 
            proposalSchemeTypeLabel.AutoSize = true;
            proposalSchemeTypeLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ProposalSchemeTypeLabelText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            proposalSchemeTypeLabel.Location = new System.Drawing.Point(12, 148);
            proposalSchemeTypeLabel.Name = "proposalSchemeTypeLabel";
            proposalSchemeTypeLabel.Size = new System.Drawing.Size(115, 13);
            proposalSchemeTypeLabel.TabIndex = 11;
            proposalSchemeTypeLabel.Text = global::Edocsys.Properties.Settings.Default.ProposalSchemeTypeLabelText;
            // 
            // proposalAddDataLabel
            // 
            proposalAddDataLabel.AutoSize = true;
            proposalAddDataLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ProposalAddDataLabelText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            proposalAddDataLabel.Location = new System.Drawing.Point(12, 171);
            proposalAddDataLabel.Name = "proposalAddDataLabel";
            proposalAddDataLabel.Size = new System.Drawing.Size(146, 13);
            proposalAddDataLabel.TabIndex = 13;
            proposalAddDataLabel.Text = global::Edocsys.Properties.Settings.Default.ProposalAddDataLabelText;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ProposalAgentNameText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            label1.Location = new System.Drawing.Point(12, 35);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(123, 13);
            label1.TabIndex = 14;
            label1.Text = global::Edocsys.Properties.Settings.Default.ProposalAgentNameText;
            // 
            // contract_typeLabel
            // 
            contract_typeLabel.AutoSize = true;
            contract_typeLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ContractTypeText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            contract_typeLabel.Location = new System.Drawing.Point(12, 79);
            contract_typeLabel.Name = "contract_typeLabel";
            contract_typeLabel.Size = new System.Drawing.Size(124, 13);
            contract_typeLabel.TabIndex = 21;
            contract_typeLabel.Text = global::Edocsys.Properties.Settings.Default.ContractTypeText;
            // 
            // contract_numberLabel
            // 
            contract_numberLabel.AutoSize = true;
            contract_numberLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ContractNumberTitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            contract_numberLabel.Location = new System.Drawing.Point(12, 13);
            contract_numberLabel.Name = "contract_numberLabel";
            contract_numberLabel.Size = new System.Drawing.Size(91, 13);
            contract_numberLabel.TabIndex = 25;
            contract_numberLabel.Text = global::Edocsys.Properties.Settings.Default.ContractNumberTitle;
            // 
            // contractsBindingNavigator
            // 
            this.contractsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.contractsBindingNavigator.BindingSource = this.contractsBindingSource;
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
            this.contractsBindingNavigatorSaveItem});
            this.contractsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.contractsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.contractsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.contractsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.contractsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.contractsBindingNavigator.Name = "contractsBindingNavigator";
            this.contractsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.contractsBindingNavigator.Size = new System.Drawing.Size(1267, 25);
            this.contractsBindingNavigator.TabIndex = 0;
            this.contractsBindingNavigator.Text = "bindingNavigator1";
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
            // contractsBindingSource
            // 
            this.contractsBindingSource.DataMember = "Contracts";
            this.contractsBindingSource.DataSource = this.edocbaseDataSet;
            // 
            // edocbaseDataSet
            // 
            this.edocbaseDataSet.CaseSensitive = true;
            this.edocbaseDataSet.DataSetName = "EdocbaseDataSet";
            this.edocbaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.contractsBindingNavigatorSaveItem.Click += new System.EventHandler(this.contractsBindingNavigatorSaveItem_Click);
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
            this.mainSplitContainer.Panel1.Controls.Add(this.contractsDataGridView);
            this.mainSplitContainer.Panel1MinSize = 240;
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.AutoScroll = true;
            this.mainSplitContainer.Panel2.Controls.Add(contract_numberLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.contract_numberTextBox);
            this.mainSplitContainer.Panel2.Controls.Add(this.contract_typeComboBox);
            this.mainSplitContainer.Panel2.Controls.Add(this.porposalGenerationGroupBox);
            this.mainSplitContainer.Panel2.Controls.Add(contract_typeLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.proposalAgentsComboBox);
            this.mainSplitContainer.Panel2.Controls.Add(label1);
            this.mainSplitContainer.Panel2.Controls.Add(proposalAddDataLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.addDataTextBox);
            this.mainSplitContainer.Panel2.Controls.Add(proposalSchemeTypeLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.schemeTypeTextBox);
            this.mainSplitContainer.Panel2.Controls.Add(proposalClientDocsLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.clientDocsTextBox);
            this.mainSplitContainer.Panel2.Controls.Add(this.productComboBox);
            this.mainSplitContainer.Panel2.Controls.Add(proposalEmissionLabel);
            this.mainSplitContainer.Panel2.Controls.Add(proposalProductLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.proposalEmissionTypeTextBox);
            this.mainSplitContainer.Panel2MinSize = 160;
            this.mainSplitContainer.Size = new System.Drawing.Size(1267, 522);
            this.mainSplitContainer.SplitterDistance = 320;
            this.mainSplitContainer.TabIndex = 2;
            // 
            // contractsDataGridView
            // 
            this.contractsDataGridView.AllowUserToAddRows = false;
            this.contractsDataGridView.AutoGenerateColumns = false;
            this.contractsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contractsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idContract,
            this.Contract_number,
            this.agent_shortname,
            this.idProducts,
            this.SendProposalColumn,
            this.Contract_status,
            this.idDataGridViewTextBoxColumn,
            this.productsidDataGridViewTextBoxColumn,
            this.agentsidDataGridViewTextBoxColumn,
            this.expertsidDataGridViewTextBoxColumn,
            this.contractstatusidDataGridViewTextBoxColumn,
            this.emissiontypesidDataGridViewTextBoxColumn,
            this.contracttypesidDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.dateproposalDataGridViewTextBoxColumn,
            this.schemetypeDataGridViewTextBoxColumn,
            this.adddataproposalDataGridViewTextBoxColumn,
            this.datecontractDataGridViewTextBoxColumn,
            this.sourcetypesidDataGridViewTextBoxColumn,
            this.daterealresertDataGridViewTextBoxColumn,
            this.dateplanedresertDataGridViewTextBoxColumn,
            this.daterealreatt2DataGridViewTextBoxColumn,
            this.dateplanedreatt2DataGridViewTextBoxColumn,
            this.daterealreatt1DataGridViewTextBoxColumn,
            this.dateplanedreatt1DataGridViewTextBoxColumn,
            this.dateprotocolincomeDataGridViewTextBoxColumn,
            this.datesampleincomeDataGridViewTextBoxColumn,
            this.datestartDataGridViewTextBoxColumn,
            this.datecashincomeDataGridViewTextBoxColumn,
            this.cashincomeDataGridViewCheckBoxColumn,
            this.totalcostDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.adddatacontractDataGridViewTextBoxColumn});
            this.contractsDataGridView.DataSource = this.contractsBindingSource;
            this.contractsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contractsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.contractsDataGridView.Name = "contractsDataGridView";
            this.contractsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.contractsDataGridView.Size = new System.Drawing.Size(1267, 320);
            this.contractsDataGridView.TabIndex = 2;
            this.contractsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.contractsDataGridView_CellClick);
            // 
            // idContract
            // 
            this.idContract.DataPropertyName = "idContract";
            this.idContract.HeaderText = "#";
            this.idContract.Name = "idContract";
            this.idContract.ReadOnly = true;
            this.idContract.ToolTipText = "#";
            this.idContract.Width = 30;
            // 
            // Contract_number
            // 
            this.Contract_number.DataPropertyName = "Contract_number";
            this.Contract_number.HeaderText = "№ договора";
            this.Contract_number.Name = "Contract_number";
            this.Contract_number.Width = 70;
            // 
            // agent_shortname
            // 
            this.agent_shortname.DataPropertyName = "Ag_fullname";
            this.agent_shortname.HeaderText = "Название контрагента";
            this.agent_shortname.Name = "agent_shortname";
            this.agent_shortname.ReadOnly = true;
            this.agent_shortname.ToolTipText = "Название контрагента";
            this.agent_shortname.Width = 200;
            // 
            // idProducts
            // 
            this.idProducts.DataPropertyName = "Product_name";
            this.idProducts.HeaderText = "Наименование продукции";
            this.idProducts.Name = "idProducts";
            this.idProducts.ReadOnly = true;
            this.idProducts.ToolTipText = "Наименование продукции";
            this.idProducts.Width = 250;
            // 
            // SendProposalColumn
            // 
            this.SendProposalColumn.HeaderText = "Отправить заявку";
            this.SendProposalColumn.Name = "SendProposalColumn";
            this.SendProposalColumn.Text = "Отправить";
            this.SendProposalColumn.ToolTipText = "Отправить";
            this.SendProposalColumn.UseColumnTextForButtonValue = true;
            // 
            // Contract_status
            // 
            this.Contract_status.HeaderText = "T";
            this.Contract_status.Name = "Contract_status";
            this.Contract_status.Visible = false;
            // 
            // contract_numberTextBox
            // 
            this.contract_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractsBindingSource, "Contract_number", true));
            this.contract_numberTextBox.Location = new System.Drawing.Point(167, 10);
            this.contract_numberTextBox.Name = "contract_numberTextBox";
            this.contract_numberTextBox.Size = new System.Drawing.Size(485, 20);
            this.contract_numberTextBox.TabIndex = 26;
            // 
            // contract_typeComboBox
            // 
            this.contract_typeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contractsBindingSource, "Contract_type", true));
            this.contract_typeComboBox.DataSource = this.contractTypesForDocsBindingSource;
            this.contract_typeComboBox.DisplayMember = "name";
            this.contract_typeComboBox.FormattingEnabled = true;
            this.contract_typeComboBox.Location = new System.Drawing.Point(167, 76);
            this.contract_typeComboBox.Name = "contract_typeComboBox";
            this.contract_typeComboBox.Size = new System.Drawing.Size(485, 21);
            this.contract_typeComboBox.TabIndex = 25;
            this.contract_typeComboBox.ValueMember = "id";
            // 
            // contractTypesForDocsBindingSource
            // 
            this.contractTypesForDocsBindingSource.DataMember = "ContractTypesForDocs";
            this.contractTypesForDocsBindingSource.DataSource = this.edocbaseDataSet;
            // 
            // porposalGenerationGroupBox
            // 
            this.porposalGenerationGroupBox.Controls.Add(this.buttonLoadProposal);
            this.porposalGenerationGroupBox.Controls.Add(this.buttonSaveProposal);
            this.porposalGenerationGroupBox.Controls.Add(this.buttonEditProposal);
            this.porposalGenerationGroupBox.Controls.Add(this.buttonGenerateProposalDoc);
            this.porposalGenerationGroupBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ProposalOperationsGroupBox", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.porposalGenerationGroupBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.porposalGenerationGroupBox.Location = new System.Drawing.Point(980, 0);
            this.porposalGenerationGroupBox.Name = "porposalGenerationGroupBox";
            this.porposalGenerationGroupBox.Size = new System.Drawing.Size(287, 198);
            this.porposalGenerationGroupBox.TabIndex = 24;
            this.porposalGenerationGroupBox.TabStop = false;
            this.porposalGenerationGroupBox.Text = global::Edocsys.Properties.Settings.Default.ProposalOperationsGroupBox;
            // 
            // buttonLoadProposal
            // 
            this.buttonLoadProposal.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "LoadProposalButton", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonLoadProposal.Location = new System.Drawing.Point(21, 166);
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
            this.buttonSaveProposal.Location = new System.Drawing.Point(21, 142);
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
            this.buttonEditProposal.Location = new System.Drawing.Point(21, 116);
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
            this.buttonGenerateProposalDoc.Location = new System.Drawing.Point(21, 74);
            this.buttonGenerateProposalDoc.Name = "buttonGenerateProposalDoc";
            this.buttonGenerateProposalDoc.Size = new System.Drawing.Size(246, 23);
            this.buttonGenerateProposalDoc.TabIndex = 17;
            this.buttonGenerateProposalDoc.Text = global::Edocsys.Properties.Settings.Default.GenerateProposalTitle;
            this.buttonGenerateProposalDoc.UseVisualStyleBackColor = true;
            this.buttonGenerateProposalDoc.Click += new System.EventHandler(this.buttonGenerateProposalDoc_Click);
            // 
            // proposalAgentsComboBox
            // 
            this.proposalAgentsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contractsBindingSource, "agent_id", true));
            this.proposalAgentsComboBox.DataSource = this.agentsBindingSource;
            this.proposalAgentsComboBox.DisplayMember = "Ag_fullname";
            this.proposalAgentsComboBox.FormattingEnabled = true;
            this.proposalAgentsComboBox.Location = new System.Drawing.Point(167, 32);
            this.proposalAgentsComboBox.Name = "proposalAgentsComboBox";
            this.proposalAgentsComboBox.Size = new System.Drawing.Size(485, 21);
            this.proposalAgentsComboBox.TabIndex = 15;
            this.proposalAgentsComboBox.ValueMember = "idAgents";
            // 
            // agentsBindingSource
            // 
            this.agentsBindingSource.DataMember = "Agents";
            this.agentsBindingSource.DataSource = this.edocbaseDataSet;
            // 
            // addDataTextBox
            // 
            this.addDataTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractsBindingSource, "Add_data", true));
            this.addDataTextBox.Location = new System.Drawing.Point(167, 168);
            this.addDataTextBox.Name = "addDataTextBox";
            this.addDataTextBox.Size = new System.Drawing.Size(485, 20);
            this.addDataTextBox.TabIndex = 12;
            // 
            // schemeTypeTextBox
            // 
            this.schemeTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractsBindingSource, "Schem_type", true));
            this.schemeTypeTextBox.Location = new System.Drawing.Point(167, 145);
            this.schemeTypeTextBox.Name = "schemeTypeTextBox";
            this.schemeTypeTextBox.Size = new System.Drawing.Size(485, 20);
            this.schemeTypeTextBox.TabIndex = 10;
            // 
            // clientDocsTextBox
            // 
            this.clientDocsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractsBindingSource, "Client_docs", true));
            this.clientDocsTextBox.Location = new System.Drawing.Point(167, 123);
            this.clientDocsTextBox.Name = "clientDocsTextBox";
            this.clientDocsTextBox.Size = new System.Drawing.Size(485, 20);
            this.clientDocsTextBox.TabIndex = 8;
            // 
            // productComboBox
            // 
            this.productComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contractsBindingSource, "idProducts", true));
            this.productComboBox.DataSource = this.productsBindingSource;
            this.productComboBox.DisplayMember = "Product_name";
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(167, 54);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(485, 21);
            this.productComboBox.TabIndex = 7;
            this.productComboBox.ValueMember = "idProducts";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.edocbaseDataSet;
            // 
            // proposalEmissionTypeTextBox
            // 
            this.proposalEmissionTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractsBindingSource, "emission_type", true));
            this.proposalEmissionTypeTextBox.Location = new System.Drawing.Point(167, 100);
            this.proposalEmissionTypeTextBox.Name = "proposalEmissionTypeTextBox";
            this.proposalEmissionTypeTextBox.Size = new System.Drawing.Size(485, 20);
            this.proposalEmissionTypeTextBox.TabIndex = 5;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.agent_typesTableAdapter = null;
            this.tableAdapterManager.agents_contactsTableAdapter = null;
            this.tableAdapterManager.agentsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.contract_statusTableAdapter = null;
            this.tableAdapterManager.contract_types_for_workDataTablesTableAdapter = null;
            this.tableAdapterManager.contract_typesTableAdapter = null;
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
            // templatesDataTableBindingSource
            // 
            this.templatesDataTableBindingSource.DataMember = "TemplatesDataTable";
            this.templatesDataTableBindingSource.DataSource = this.edocbaseDataSet;
            // 
            // contractInfoDataTableBindingSource
            // 
            this.contractInfoDataTableBindingSource.DataMember = "ContractInfoDataTable";
            this.contractInfoDataTableBindingSource.DataSource = this.edocbaseDataSet;
            // 
            // contractInfoDataTableTableAdapter
            // 
            this.contractInfoDataTableTableAdapter.ClearBeforeFill = true;
            // 
            // docTemplatesBindingSource
            // 
            this.docTemplatesBindingSource.DataMember = "DocTemplates";
            this.docTemplatesBindingSource.DataSource = this.edocbaseDataSet;
            // 
            // documentsBindingSource
            // 
            this.documentsBindingSource.DataMember = "documents";
            this.documentsBindingSource.DataSource = this.edocbaseDataSet;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Файлы Word 2007-2010| *.docx|Все файлы|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Файлы Word 2007-2010| *.docx|Все файлы|*.*";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // productsidDataGridViewTextBoxColumn
            // 
            this.productsidDataGridViewTextBoxColumn.DataPropertyName = "products_id";
            this.productsidDataGridViewTextBoxColumn.HeaderText = "products_id";
            this.productsidDataGridViewTextBoxColumn.Name = "productsidDataGridViewTextBoxColumn";
            // 
            // agentsidDataGridViewTextBoxColumn
            // 
            this.agentsidDataGridViewTextBoxColumn.DataPropertyName = "agents_id";
            this.agentsidDataGridViewTextBoxColumn.HeaderText = "agents_id";
            this.agentsidDataGridViewTextBoxColumn.Name = "agentsidDataGridViewTextBoxColumn";
            // 
            // expertsidDataGridViewTextBoxColumn
            // 
            this.expertsidDataGridViewTextBoxColumn.DataPropertyName = "experts_id";
            this.expertsidDataGridViewTextBoxColumn.HeaderText = "experts_id";
            this.expertsidDataGridViewTextBoxColumn.Name = "expertsidDataGridViewTextBoxColumn";
            // 
            // contractstatusidDataGridViewTextBoxColumn
            // 
            this.contractstatusidDataGridViewTextBoxColumn.DataPropertyName = "contract_status_id";
            this.contractstatusidDataGridViewTextBoxColumn.HeaderText = "contract_status_id";
            this.contractstatusidDataGridViewTextBoxColumn.Name = "contractstatusidDataGridViewTextBoxColumn";
            // 
            // emissiontypesidDataGridViewTextBoxColumn
            // 
            this.emissiontypesidDataGridViewTextBoxColumn.DataPropertyName = "emission_types_id";
            this.emissiontypesidDataGridViewTextBoxColumn.HeaderText = "emission_types_id";
            this.emissiontypesidDataGridViewTextBoxColumn.Name = "emissiontypesidDataGridViewTextBoxColumn";
            // 
            // contracttypesidDataGridViewTextBoxColumn
            // 
            this.contracttypesidDataGridViewTextBoxColumn.DataPropertyName = "contract_types_id";
            this.contracttypesidDataGridViewTextBoxColumn.HeaderText = "contract_types_id";
            this.contracttypesidDataGridViewTextBoxColumn.Name = "contracttypesidDataGridViewTextBoxColumn";
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // dateproposalDataGridViewTextBoxColumn
            // 
            this.dateproposalDataGridViewTextBoxColumn.DataPropertyName = "date_proposal";
            this.dateproposalDataGridViewTextBoxColumn.HeaderText = "date_proposal";
            this.dateproposalDataGridViewTextBoxColumn.Name = "dateproposalDataGridViewTextBoxColumn";
            // 
            // schemetypeDataGridViewTextBoxColumn
            // 
            this.schemetypeDataGridViewTextBoxColumn.DataPropertyName = "scheme_type";
            this.schemetypeDataGridViewTextBoxColumn.HeaderText = "scheme_type";
            this.schemetypeDataGridViewTextBoxColumn.Name = "schemetypeDataGridViewTextBoxColumn";
            // 
            // adddataproposalDataGridViewTextBoxColumn
            // 
            this.adddataproposalDataGridViewTextBoxColumn.DataPropertyName = "add_data_proposal";
            this.adddataproposalDataGridViewTextBoxColumn.HeaderText = "add_data_proposal";
            this.adddataproposalDataGridViewTextBoxColumn.Name = "adddataproposalDataGridViewTextBoxColumn";
            // 
            // datecontractDataGridViewTextBoxColumn
            // 
            this.datecontractDataGridViewTextBoxColumn.DataPropertyName = "date_contract";
            this.datecontractDataGridViewTextBoxColumn.HeaderText = "date_contract";
            this.datecontractDataGridViewTextBoxColumn.Name = "datecontractDataGridViewTextBoxColumn";
            // 
            // sourcetypesidDataGridViewTextBoxColumn
            // 
            this.sourcetypesidDataGridViewTextBoxColumn.DataPropertyName = "source_types_id";
            this.sourcetypesidDataGridViewTextBoxColumn.HeaderText = "source_types_id";
            this.sourcetypesidDataGridViewTextBoxColumn.Name = "sourcetypesidDataGridViewTextBoxColumn";
            // 
            // daterealresertDataGridViewTextBoxColumn
            // 
            this.daterealresertDataGridViewTextBoxColumn.DataPropertyName = "date_real_resert";
            this.daterealresertDataGridViewTextBoxColumn.HeaderText = "date_real_resert";
            this.daterealresertDataGridViewTextBoxColumn.Name = "daterealresertDataGridViewTextBoxColumn";
            // 
            // dateplanedresertDataGridViewTextBoxColumn
            // 
            this.dateplanedresertDataGridViewTextBoxColumn.DataPropertyName = "date_planed_resert";
            this.dateplanedresertDataGridViewTextBoxColumn.HeaderText = "date_planed_resert";
            this.dateplanedresertDataGridViewTextBoxColumn.Name = "dateplanedresertDataGridViewTextBoxColumn";
            // 
            // daterealreatt2DataGridViewTextBoxColumn
            // 
            this.daterealreatt2DataGridViewTextBoxColumn.DataPropertyName = "date_real_reatt_2";
            this.daterealreatt2DataGridViewTextBoxColumn.HeaderText = "date_real_reatt_2";
            this.daterealreatt2DataGridViewTextBoxColumn.Name = "daterealreatt2DataGridViewTextBoxColumn";
            // 
            // dateplanedreatt2DataGridViewTextBoxColumn
            // 
            this.dateplanedreatt2DataGridViewTextBoxColumn.DataPropertyName = "date_planed_reatt_2";
            this.dateplanedreatt2DataGridViewTextBoxColumn.HeaderText = "date_planed_reatt_2";
            this.dateplanedreatt2DataGridViewTextBoxColumn.Name = "dateplanedreatt2DataGridViewTextBoxColumn";
            // 
            // daterealreatt1DataGridViewTextBoxColumn
            // 
            this.daterealreatt1DataGridViewTextBoxColumn.DataPropertyName = "date_real_reatt_1";
            this.daterealreatt1DataGridViewTextBoxColumn.HeaderText = "date_real_reatt_1";
            this.daterealreatt1DataGridViewTextBoxColumn.Name = "daterealreatt1DataGridViewTextBoxColumn";
            // 
            // dateplanedreatt1DataGridViewTextBoxColumn
            // 
            this.dateplanedreatt1DataGridViewTextBoxColumn.DataPropertyName = "date_planed_reatt_1";
            this.dateplanedreatt1DataGridViewTextBoxColumn.HeaderText = "date_planed_reatt_1";
            this.dateplanedreatt1DataGridViewTextBoxColumn.Name = "dateplanedreatt1DataGridViewTextBoxColumn";
            // 
            // dateprotocolincomeDataGridViewTextBoxColumn
            // 
            this.dateprotocolincomeDataGridViewTextBoxColumn.DataPropertyName = "date_protocol_income";
            this.dateprotocolincomeDataGridViewTextBoxColumn.HeaderText = "date_protocol_income";
            this.dateprotocolincomeDataGridViewTextBoxColumn.Name = "dateprotocolincomeDataGridViewTextBoxColumn";
            // 
            // datesampleincomeDataGridViewTextBoxColumn
            // 
            this.datesampleincomeDataGridViewTextBoxColumn.DataPropertyName = "date_sample_income";
            this.datesampleincomeDataGridViewTextBoxColumn.HeaderText = "date_sample_income";
            this.datesampleincomeDataGridViewTextBoxColumn.Name = "datesampleincomeDataGridViewTextBoxColumn";
            // 
            // datestartDataGridViewTextBoxColumn
            // 
            this.datestartDataGridViewTextBoxColumn.DataPropertyName = "date_start";
            this.datestartDataGridViewTextBoxColumn.HeaderText = "date_start";
            this.datestartDataGridViewTextBoxColumn.Name = "datestartDataGridViewTextBoxColumn";
            // 
            // datecashincomeDataGridViewTextBoxColumn
            // 
            this.datecashincomeDataGridViewTextBoxColumn.DataPropertyName = "date_cash_income";
            this.datecashincomeDataGridViewTextBoxColumn.HeaderText = "date_cash_income";
            this.datecashincomeDataGridViewTextBoxColumn.Name = "datecashincomeDataGridViewTextBoxColumn";
            // 
            // cashincomeDataGridViewCheckBoxColumn
            // 
            this.cashincomeDataGridViewCheckBoxColumn.DataPropertyName = "cash_income";
            this.cashincomeDataGridViewCheckBoxColumn.HeaderText = "cash_income";
            this.cashincomeDataGridViewCheckBoxColumn.Name = "cashincomeDataGridViewCheckBoxColumn";
            // 
            // totalcostDataGridViewTextBoxColumn
            // 
            this.totalcostDataGridViewTextBoxColumn.DataPropertyName = "total_cost";
            this.totalcostDataGridViewTextBoxColumn.HeaderText = "total_cost";
            this.totalcostDataGridViewTextBoxColumn.Name = "totalcostDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // adddatacontractDataGridViewTextBoxColumn
            // 
            this.adddatacontractDataGridViewTextBoxColumn.DataPropertyName = "add_data_contract";
            this.adddatacontractDataGridViewTextBoxColumn.HeaderText = "add_data_contract";
            this.adddatacontractDataGridViewTextBoxColumn.Name = "adddatacontractDataGridViewTextBoxColumn";
            // 
            // ProposalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 547);
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.contractsBindingNavigator);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ProposalFormText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Name = "ProposalForm";
            this.Text = global::Edocsys.Properties.Settings.Default.ProposalFormText;
            this.Load += new System.EventHandler(this.ProposalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contractsBindingNavigator)).EndInit();
            this.contractsBindingNavigator.ResumeLayout(false);
            this.contractsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edocbaseDataSet)).EndInit();
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contractsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractTypesForDocsBindingSource)).EndInit();
            this.porposalGenerationGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.agentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templatesDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractInfoDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docTemplatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EdocbaseDataSet edocbaseDataSet;
        private System.Windows.Forms.BindingSource contractsBindingSource;
        private EdocbaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator contractsBindingNavigator;
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
        private System.Windows.Forms.DataGridView contractsDataGridView;
        private System.Windows.Forms.TextBox proposalEmissionTypeTextBox;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.TextBox clientDocsTextBox;
        private System.Windows.Forms.TextBox addDataTextBox;
        private System.Windows.Forms.TextBox schemeTypeTextBox;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.ComboBox proposalAgentsComboBox;
        private System.Windows.Forms.BindingSource agentsBindingSource;
        private System.Windows.Forms.BindingSource templatesDataTableBindingSource;
        private System.Windows.Forms.BindingSource contractInfoDataTableBindingSource;
        private EdocbaseDataSetTableAdapters.ContractInfoDataTableTableAdapter contractInfoDataTableTableAdapter;
        private System.Windows.Forms.BindingSource docTemplatesBindingSource;
        private System.Windows.Forms.BindingSource documentsBindingSource;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.BindingSource contractTypesForDocsBindingSource;
        private System.Windows.Forms.GroupBox porposalGenerationGroupBox;
        private System.Windows.Forms.Button buttonLoadProposal;
        private System.Windows.Forms.Button buttonSaveProposal;
        private System.Windows.Forms.Button buttonEditProposal;
        private System.Windows.Forms.Button buttonGenerateProposalDoc;
        private System.Windows.Forms.ComboBox contract_typeComboBox;
        private System.Windows.Forms.TextBox contract_numberTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idContract;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contract_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn agent_shortname;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducts;
        private System.Windows.Forms.DataGridViewButtonColumn SendProposalColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contract_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productsidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentsidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expertsidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractstatusidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emissiontypesidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contracttypesidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateproposalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schemetypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adddataproposalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datecontractDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourcetypesidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daterealresertDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateplanedresertDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daterealreatt2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateplanedreatt2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daterealreatt1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateplanedreatt1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateprotocolincomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datesampleincomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datestartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datecashincomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cashincomeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adddatacontractDataGridViewTextBoxColumn;

        //private EdocbaseDataSetTableAdapters.TemplatesDataTableTableAdapter templatesDataTableTableAdapter;
        //private EdocbaseDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        //private EdocbaseDataSetTableAdapters.AgentsTableAdapter agentsTableAdapter;
        //private EdocbaseDataSetTableAdapters.Exec_contractsTableAdapter exec_contractsTableAdapter;
        //private EdocbaseDataSetTableAdapters.DocTemplatesTableAdapter docTemplatesTableAdapter;
        //private EdocbaseDataSetTableAdapters.DocumentsTableAdapter documentsTableAdapter;
        //private EdocbaseDataSetTableAdapters.ContractTypesForDocsTableAdapter contractTypesForDocsTableAdapter;

    }
}