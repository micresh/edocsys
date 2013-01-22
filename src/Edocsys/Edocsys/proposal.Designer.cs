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
            this.emission_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client_docs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheme_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agent_shortname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProducts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SendProposalColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Contract_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.contractsTableAdapter = new Edocsys.EdocbaseDataSetTableAdapters.ContractsTableAdapter();
            this.tableAdapterManager = new Edocsys.EdocbaseDataSetTableAdapters.TableAdapterManager();
            this.agentsTableAdapter = new Edocsys.EdocbaseDataSetTableAdapters.AgentsTableAdapter();
            this.productsTableAdapter = new Edocsys.EdocbaseDataSetTableAdapters.ProductsTableAdapter();
            this.contractTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractTypesTableAdapter = new Edocsys.EdocbaseDataSetTableAdapters.ContractTypesTableAdapter();
            this.exec_contractsTableAdapter = new Edocsys.EdocbaseDataSetTableAdapters.Exec_contractsTableAdapter();
            this.templatesDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.templatesDataTableTableAdapter = new Edocsys.EdocbaseDataSetTableAdapters.TemplatesDataTableTableAdapter();
            this.contractInfoDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractInfoDataTableTableAdapter = new Edocsys.EdocbaseDataSetTableAdapters.ContractInfoDataTableTableAdapter();
            this.docTemplatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.docTemplatesTableAdapter = new Edocsys.EdocbaseDataSetTableAdapters.DocTemplatesTableAdapter();
            this.documentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentsTableAdapter = new Edocsys.EdocbaseDataSetTableAdapters.DocumentsTableAdapter();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            proposalProductLabel = new System.Windows.Forms.Label();
            proposalEmissionLabel = new System.Windows.Forms.Label();
            proposalClientDocsLabel = new System.Windows.Forms.Label();
            proposalSchemeTypeLabel = new System.Windows.Forms.Label();
            proposalAddDataLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.contractsBindingNavigator)).BeginInit();
            this.contractsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edocbaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractsDataGridView)).BeginInit();
            this.porposalGenerationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractTypesBindingSource)).BeginInit();
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
            proposalProductLabel.Location = new System.Drawing.Point(11, 51);
            proposalProductLabel.Name = "proposalProductLabel";
            proposalProductLabel.Size = new System.Drawing.Size(139, 13);
            proposalProductLabel.TabIndex = 4;
            proposalProductLabel.Text = global::Edocsys.Properties.Settings.Default.product_nameLabelText;
            // 
            // proposalEmissionLabel
            // 
            proposalEmissionLabel.AutoSize = true;
            proposalEmissionLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ProposalEmissionLabelText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            proposalEmissionLabel.Location = new System.Drawing.Point(11, 77);
            proposalEmissionLabel.Name = "proposalEmissionLabel";
            proposalEmissionLabel.Size = new System.Drawing.Size(128, 13);
            proposalEmissionLabel.TabIndex = 6;
            proposalEmissionLabel.Text = global::Edocsys.Properties.Settings.Default.ProposalEmissionLabelText;
            // 
            // proposalClientDocsLabel
            // 
            proposalClientDocsLabel.AutoSize = true;
            proposalClientDocsLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ProposalClientDocsLabelText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            proposalClientDocsLabel.Location = new System.Drawing.Point(11, 103);
            proposalClientDocsLabel.Name = "proposalClientDocsLabel";
            proposalClientDocsLabel.Size = new System.Drawing.Size(146, 13);
            proposalClientDocsLabel.TabIndex = 9;
            proposalClientDocsLabel.Text = global::Edocsys.Properties.Settings.Default.ProposalClientDocsLabelText;
            // 
            // proposalSchemeTypeLabel
            // 
            proposalSchemeTypeLabel.AutoSize = true;
            proposalSchemeTypeLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ProposalSchemeTypeLabelText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            proposalSchemeTypeLabel.Location = new System.Drawing.Point(11, 129);
            proposalSchemeTypeLabel.Name = "proposalSchemeTypeLabel";
            proposalSchemeTypeLabel.Size = new System.Drawing.Size(115, 13);
            proposalSchemeTypeLabel.TabIndex = 11;
            proposalSchemeTypeLabel.Text = global::Edocsys.Properties.Settings.Default.ProposalSchemeTypeLabelText;
            // 
            // proposalAddDataLabel
            // 
            proposalAddDataLabel.AutoSize = true;
            proposalAddDataLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ProposalAddDataLabelText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            proposalAddDataLabel.Location = new System.Drawing.Point(11, 155);
            proposalAddDataLabel.Name = "proposalAddDataLabel";
            proposalAddDataLabel.Size = new System.Drawing.Size(146, 13);
            proposalAddDataLabel.TabIndex = 13;
            proposalAddDataLabel.Text = global::Edocsys.Properties.Settings.Default.ProposalAddDataLabelText;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ProposalAgentNameText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            label1.Location = new System.Drawing.Point(11, 24);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(123, 13);
            label1.TabIndex = 14;
            label1.Text = global::Edocsys.Properties.Settings.Default.ProposalAgentNameText;
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
            this.contractsBindingNavigator.Size = new System.Drawing.Size(1198, 25);
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
            this.mainSplitContainer.Panel2.Controls.Add(this.porposalGenerationGroupBox);
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
            this.mainSplitContainer.Size = new System.Drawing.Size(1198, 425);
            this.mainSplitContainer.SplitterDistance = 240;
            this.mainSplitContainer.TabIndex = 2;
            // 
            // contractsDataGridView
            // 
            this.contractsDataGridView.AllowUserToAddRows = false;
            this.contractsDataGridView.AutoGenerateColumns = false;
            this.contractsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contractsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idContract,
            this.emission_type,
            this.client_docs,
            this.scheme_type,
            this.add_data,
            this.agent_shortname,
            this.idProducts,
            this.SendProposalColumn,
            this.Contract_status});
            this.contractsDataGridView.DataSource = this.contractsBindingSource;
            this.contractsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contractsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.contractsDataGridView.Name = "contractsDataGridView";
            this.contractsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.contractsDataGridView.Size = new System.Drawing.Size(1198, 240);
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
            // emission_type
            // 
            this.emission_type.DataPropertyName = "emission_type";
            this.emission_type.HeaderText = "Тип выпуска продукции";
            this.emission_type.Name = "emission_type";
            this.emission_type.ReadOnly = true;
            this.emission_type.ToolTipText = "Тип выпуска продукции";
            this.emission_type.Width = 150;
            // 
            // client_docs
            // 
            this.client_docs.DataPropertyName = "Client_docs";
            this.client_docs.HeaderText = "Учредительные документы";
            this.client_docs.Name = "client_docs";
            this.client_docs.ReadOnly = true;
            this.client_docs.ToolTipText = "Учредительные документы";
            this.client_docs.Width = 150;
            // 
            // scheme_type
            // 
            this.scheme_type.DataPropertyName = "Schem_type";
            this.scheme_type.HeaderText = "Схема сертификации";
            this.scheme_type.MinimumWidth = 15;
            this.scheme_type.Name = "scheme_type";
            this.scheme_type.ReadOnly = true;
            this.scheme_type.Width = 150;
            // 
            // add_data
            // 
            this.add_data.DataPropertyName = "Add_data";
            this.add_data.HeaderText = "Дополнительные сведения";
            this.add_data.MinimumWidth = 15;
            this.add_data.Name = "add_data";
            this.add_data.ReadOnly = true;
            this.add_data.ToolTipText = "Дополнительные сведения";
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
            // porposalGenerationGroupBox
            // 
            this.porposalGenerationGroupBox.Controls.Add(this.buttonLoadProposal);
            this.porposalGenerationGroupBox.Controls.Add(this.buttonSaveProposal);
            this.porposalGenerationGroupBox.Controls.Add(this.buttonEditProposal);
            this.porposalGenerationGroupBox.Controls.Add(this.buttonGenerateProposalDoc);
            this.porposalGenerationGroupBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ProposalOperationsGroupBox", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.porposalGenerationGroupBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.porposalGenerationGroupBox.Location = new System.Drawing.Point(919, 0);
            this.porposalGenerationGroupBox.Name = "porposalGenerationGroupBox";
            this.porposalGenerationGroupBox.Size = new System.Drawing.Size(279, 181);
            this.porposalGenerationGroupBox.TabIndex = 19;
            this.porposalGenerationGroupBox.TabStop = false;
            this.porposalGenerationGroupBox.Text = global::Edocsys.Properties.Settings.Default.ProposalOperationsGroupBox;
            // 
            // buttonLoadProposal
            // 
            this.buttonLoadProposal.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "LoadProposalButton", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonLoadProposal.Location = new System.Drawing.Point(21, 145);
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
            this.buttonSaveProposal.Location = new System.Drawing.Point(21, 103);
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
            this.buttonEditProposal.Location = new System.Drawing.Point(21, 51);
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
            this.buttonGenerateProposalDoc.Location = new System.Drawing.Point(21, 16);
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
            this.proposalAgentsComboBox.Location = new System.Drawing.Point(200, 16);
            this.proposalAgentsComboBox.Name = "proposalAgentsComboBox";
            this.proposalAgentsComboBox.Size = new System.Drawing.Size(456, 21);
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
            this.addDataTextBox.Location = new System.Drawing.Point(200, 148);
            this.addDataTextBox.Name = "addDataTextBox";
            this.addDataTextBox.Size = new System.Drawing.Size(456, 20);
            this.addDataTextBox.TabIndex = 12;
            // 
            // schemeTypeTextBox
            // 
            this.schemeTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractsBindingSource, "Schem_type", true));
            this.schemeTypeTextBox.Location = new System.Drawing.Point(200, 122);
            this.schemeTypeTextBox.Name = "schemeTypeTextBox";
            this.schemeTypeTextBox.Size = new System.Drawing.Size(456, 20);
            this.schemeTypeTextBox.TabIndex = 10;
            // 
            // clientDocsTextBox
            // 
            this.clientDocsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractsBindingSource, "Client_docs", true));
            this.clientDocsTextBox.Location = new System.Drawing.Point(200, 96);
            this.clientDocsTextBox.Name = "clientDocsTextBox";
            this.clientDocsTextBox.Size = new System.Drawing.Size(456, 20);
            this.clientDocsTextBox.TabIndex = 8;
            // 
            // productComboBox
            // 
            this.productComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contractsBindingSource, "idProducts", true));
            this.productComboBox.DataSource = this.productsBindingSource;
            this.productComboBox.DisplayMember = "Product_name";
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(200, 43);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(456, 21);
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
            this.proposalEmissionTypeTextBox.Location = new System.Drawing.Point(200, 70);
            this.proposalEmissionTypeTextBox.Name = "proposalEmissionTypeTextBox";
            this.proposalEmissionTypeTextBox.Size = new System.Drawing.Size(456, 20);
            this.proposalEmissionTypeTextBox.TabIndex = 5;
            // 
            // contractsTableAdapter
            // 
            this.contractsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Agents_contactsTableAdapter = null;
            this.tableAdapterManager.Agents_typesTableAdapter = null;
            this.tableAdapterManager.AgentsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ContractsTableAdapter = this.contractsTableAdapter;
            this.tableAdapterManager.ContractStatusTableAdapter = null;
            this.tableAdapterManager.ContractTypesTableAdapter = null;
            this.tableAdapterManager.DocTemplatesTableAdapter = null;
            this.tableAdapterManager.DocumentsTableAdapter = null;
            this.tableAdapterManager.Exec_contractsTableAdapter = null;
            this.tableAdapterManager.ExpertsTableAdapter = null;
            this.tableAdapterManager.log_journalTableAdapter = null;
            this.tableAdapterManager.ProdGostTableAdapter = null;
            this.tableAdapterManager.ProductAreasTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Edocsys.EdocbaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // agentsTableAdapter
            // 
            this.agentsTableAdapter.ClearBeforeFill = true;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // contractTypesBindingSource
            // 
            this.contractTypesBindingSource.DataMember = "ContractTypes";
            this.contractTypesBindingSource.DataSource = this.edocbaseDataSet;
            // 
            // contractTypesTableAdapter
            // 
            this.contractTypesTableAdapter.ClearBeforeFill = true;
            // 
            // exec_contractsTableAdapter
            // 
            this.exec_contractsTableAdapter.ClearBeforeFill = true;
            // 
            // templatesDataTableBindingSource
            // 
            this.templatesDataTableBindingSource.DataMember = "TemplatesDataTable";
            this.templatesDataTableBindingSource.DataSource = this.edocbaseDataSet;
            // 
            // templatesDataTableTableAdapter
            // 
            this.templatesDataTableTableAdapter.ClearBeforeFill = true;
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
            // docTemplatesTableAdapter
            // 
            this.docTemplatesTableAdapter.ClearBeforeFill = true;
            // 
            // documentsBindingSource
            // 
            this.documentsBindingSource.DataMember = "documents";
            this.documentsBindingSource.DataSource = this.edocbaseDataSet;
            // 
            // documentsTableAdapter
            // 
            this.documentsTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Файлы Word 2007-2010| *.docx|Все файлы|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Файлы Word 2007-2010| *.docx|Все файлы|*.*";
            // 
            // ProposalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 450);
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
            this.porposalGenerationGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.agentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractTypesBindingSource)).EndInit();
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
        private EdocbaseDataSetTableAdapters.ContractsTableAdapter contractsTableAdapter;
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
        private EdocbaseDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.TextBox clientDocsTextBox;
        private System.Windows.Forms.TextBox addDataTextBox;
        private System.Windows.Forms.TextBox schemeTypeTextBox;
        private System.Windows.Forms.BindingSource contractTypesBindingSource;
        private EdocbaseDataSetTableAdapters.ContractTypesTableAdapter contractTypesTableAdapter;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.ComboBox proposalAgentsComboBox;
        private System.Windows.Forms.BindingSource agentsBindingSource;
        private EdocbaseDataSetTableAdapters.AgentsTableAdapter agentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idContract;
        private System.Windows.Forms.DataGridViewTextBoxColumn agent_shortname;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducts;
        private System.Windows.Forms.DataGridViewButtonColumn SendProposalColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contract_status;
        private EdocbaseDataSetTableAdapters.Exec_contractsTableAdapter exec_contractsTableAdapter;
        private System.Windows.Forms.BindingSource templatesDataTableBindingSource;
        private EdocbaseDataSetTableAdapters.TemplatesDataTableTableAdapter templatesDataTableTableAdapter;
        private System.Windows.Forms.BindingSource contractInfoDataTableBindingSource;
        private EdocbaseDataSetTableAdapters.ContractInfoDataTableTableAdapter contractInfoDataTableTableAdapter;
        private System.Windows.Forms.BindingSource docTemplatesBindingSource;
        private EdocbaseDataSetTableAdapters.DocTemplatesTableAdapter docTemplatesTableAdapter;
        private System.Windows.Forms.BindingSource documentsBindingSource;
        private EdocbaseDataSetTableAdapters.DocumentsTableAdapter documentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn emission_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn client_docs;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheme_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn add_data;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.GroupBox porposalGenerationGroupBox;
        private System.Windows.Forms.Button buttonLoadProposal;
        private System.Windows.Forms.Button buttonSaveProposal;
        private System.Windows.Forms.Button buttonEditProposal;
        private System.Windows.Forms.Button buttonGenerateProposalDoc;
    }
}