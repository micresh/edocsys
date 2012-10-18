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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProposalForm));
            this.edocbaseDataSet = new Edocsys.EdocbaseDataSet();
            this.contractsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractsTableAdapter = new Edocsys.EdocbaseDataSetTableAdapters.ContractsTableAdapter();
            this.tableAdapterManager = new Edocsys.EdocbaseDataSetTableAdapters.TableAdapterManager();
            this.productsTableAdapter = new Edocsys.EdocbaseDataSetTableAdapters.ProductsTableAdapter();
            this.contractsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.contractsDataGridView = new System.Windows.Forms.DataGridView();
            this.idContract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProducts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SendProposalColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Contract_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ClientDocsTextBox = new System.Windows.Forms.TextBox();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proposalEmissionTypeTextBox = new System.Windows.Forms.TextBox();
            this.contractTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractTypesTableAdapter = new Edocsys.EdocbaseDataSetTableAdapters.ContractTypesTableAdapter();
            proposalProductLabel = new System.Windows.Forms.Label();
            proposalEmissionLabel = new System.Windows.Forms.Label();
            proposalClientDocsLabel = new System.Windows.Forms.Label();
            proposalSchemeTypeLabel = new System.Windows.Forms.Label();
            proposalAddDataLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.edocbaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsBindingNavigator)).BeginInit();
            this.contractsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // proposalProductLabel
            // 
            proposalProductLabel.AutoSize = true;
            proposalProductLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "product_nameLabelText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            proposalProductLabel.Location = new System.Drawing.Point(12, 25);
            proposalProductLabel.Name = "proposalProductLabel";
            proposalProductLabel.Size = new System.Drawing.Size(139, 13);
            proposalProductLabel.TabIndex = 4;
            proposalProductLabel.Text = global::Edocsys.Properties.Settings.Default.product_nameLabelText;
            // 
            // proposalEmissionLabel
            // 
            proposalEmissionLabel.AutoSize = true;
            proposalEmissionLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ProposalEmissionLabelText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            proposalEmissionLabel.Location = new System.Drawing.Point(12, 51);
            proposalEmissionLabel.Name = "proposalEmissionLabel";
            proposalEmissionLabel.Size = new System.Drawing.Size(128, 13);
            proposalEmissionLabel.TabIndex = 6;
            proposalEmissionLabel.Text = global::Edocsys.Properties.Settings.Default.ProposalEmissionLabelText;
            // 
            // proposalClientDocsLabel
            // 
            proposalClientDocsLabel.AutoSize = true;
            proposalClientDocsLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ProposalClientDocsLabelText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            proposalClientDocsLabel.Location = new System.Drawing.Point(12, 77);
            proposalClientDocsLabel.Name = "proposalClientDocsLabel";
            proposalClientDocsLabel.Size = new System.Drawing.Size(146, 13);
            proposalClientDocsLabel.TabIndex = 9;
            proposalClientDocsLabel.Text = global::Edocsys.Properties.Settings.Default.ProposalClientDocsLabelText;
            // 
            // proposalSchemeTypeLabel
            // 
            proposalSchemeTypeLabel.AutoSize = true;
            proposalSchemeTypeLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ProposalSchemeTypeLabelText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            proposalSchemeTypeLabel.Location = new System.Drawing.Point(12, 103);
            proposalSchemeTypeLabel.Name = "proposalSchemeTypeLabel";
            proposalSchemeTypeLabel.Size = new System.Drawing.Size(115, 13);
            proposalSchemeTypeLabel.TabIndex = 11;
            proposalSchemeTypeLabel.Text = global::Edocsys.Properties.Settings.Default.ProposalSchemeTypeLabelText;
            // 
            // proposalAddDataLabel
            // 
            proposalAddDataLabel.AutoSize = true;
            proposalAddDataLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ProposalAddDataLabelText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            proposalAddDataLabel.Location = new System.Drawing.Point(12, 129);
            proposalAddDataLabel.Name = "proposalAddDataLabel";
            proposalAddDataLabel.Size = new System.Drawing.Size(146, 13);
            proposalAddDataLabel.TabIndex = 13;
            proposalAddDataLabel.Text = global::Edocsys.Properties.Settings.Default.ProposalAddDataLabelText;
            // 
            // edocbaseDataSet
            // 
            this.edocbaseDataSet.DataSetName = "EdocbaseDataSet";
            this.edocbaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contractsBindingSource
            // 
            this.contractsBindingSource.DataMember = "Contracts";
            this.contractsBindingSource.DataSource = this.edocbaseDataSet;
            // 
            // contractsTableAdapter
            // 
            this.contractsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AgentsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ContractsTableAdapter = this.contractsTableAdapter;
            this.tableAdapterManager.ContractTypesTableAdapter = null;
            this.tableAdapterManager.Exec_contractsTableAdapter = null;
            this.tableAdapterManager.ExpertsTableAdapter = null;
            this.tableAdapterManager.log_journalTableAdapter = null;
            this.tableAdapterManager.PaymentTypesTableAdapter = null;
            this.tableAdapterManager.ProdGostTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Edocsys.EdocbaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
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
            this.contractsBindingNavigator.Size = new System.Drawing.Size(1010, 25);
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
            this.mainSplitContainer.Panel2.Controls.Add(proposalAddDataLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.textBox2);
            this.mainSplitContainer.Panel2.Controls.Add(proposalSchemeTypeLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.textBox1);
            this.mainSplitContainer.Panel2.Controls.Add(proposalClientDocsLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.ClientDocsTextBox);
            this.mainSplitContainer.Panel2.Controls.Add(this.productComboBox);
            this.mainSplitContainer.Panel2.Controls.Add(proposalEmissionLabel);
            this.mainSplitContainer.Panel2.Controls.Add(proposalProductLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.proposalEmissionTypeTextBox);
            this.mainSplitContainer.Panel2MinSize = 160;
            this.mainSplitContainer.Size = new System.Drawing.Size(1010, 464);
            this.mainSplitContainer.SplitterDistance = 300;
            this.mainSplitContainer.TabIndex = 2;
            // 
            // contractsDataGridView
            // 
            this.contractsDataGridView.AllowUserToAddRows = false;
            this.contractsDataGridView.AutoGenerateColumns = false;
            this.contractsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contractsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idContract,
            this.idProducts,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.SendProposalColumn,
            this.Contract_type});
            this.contractsDataGridView.DataSource = this.contractsBindingSource;
            this.contractsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contractsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.contractsDataGridView.Name = "contractsDataGridView";
            this.contractsDataGridView.Size = new System.Drawing.Size(1010, 300);
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
            // idProducts
            // 
            this.idProducts.DataPropertyName = "Product_name";
            this.idProducts.HeaderText = "Наименование продукции";
            this.idProducts.Name = "idProducts";
            this.idProducts.ReadOnly = true;
            this.idProducts.ToolTipText = "Наименование продукции";
            this.idProducts.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "emission_type";
            this.dataGridViewTextBoxColumn3.HeaderText = "Тип выпуска продукции";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ToolTipText = "Тип выпуска продукции";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Client_docs";
            this.dataGridViewTextBoxColumn4.HeaderText = "Учредительные документы";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ToolTipText = "Учредительные документы";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Schem_type";
            this.dataGridViewTextBoxColumn5.HeaderText = "Схема сертификации";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 15;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Add_data";
            this.dataGridViewTextBoxColumn6.HeaderText = "Дополнительные сведения";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 15;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ToolTipText = "Дополнительные сведения";
            // 
            // SendProposalColumn
            // 
            this.SendProposalColumn.HeaderText = "Отправить заявку";
            this.SendProposalColumn.Name = "SendProposalColumn";
            this.SendProposalColumn.Text = "Отправить";
            this.SendProposalColumn.ToolTipText = "Отправить";
            this.SendProposalColumn.UseColumnTextForButtonValue = true;
            // 
            // Contract_type
            // 
            this.Contract_type.DataPropertyName = "Contract_type";
            this.Contract_type.HeaderText = "T";
            this.Contract_type.Name = "Contract_type";
            this.Contract_type.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractsBindingSource, "Add_data", true));
            this.textBox2.Location = new System.Drawing.Point(201, 122);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(456, 20);
            this.textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractsBindingSource, "Schem_type", true));
            this.textBox1.Location = new System.Drawing.Point(201, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(456, 20);
            this.textBox1.TabIndex = 10;
            // 
            // ClientDocsTextBox
            // 
            this.ClientDocsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractsBindingSource, "Client_docs", true));
            this.ClientDocsTextBox.Location = new System.Drawing.Point(201, 70);
            this.ClientDocsTextBox.Name = "ClientDocsTextBox";
            this.ClientDocsTextBox.Size = new System.Drawing.Size(456, 20);
            this.ClientDocsTextBox.TabIndex = 8;
            // 
            // productComboBox
            // 
            this.productComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contractsBindingSource, "idProducts", true));
            this.productComboBox.DataSource = this.productsBindingSource;
            this.productComboBox.DisplayMember = "Product_name";
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(201, 17);
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
            this.proposalEmissionTypeTextBox.Location = new System.Drawing.Point(201, 44);
            this.proposalEmissionTypeTextBox.Name = "proposalEmissionTypeTextBox";
            this.proposalEmissionTypeTextBox.Size = new System.Drawing.Size(456, 20);
            this.proposalEmissionTypeTextBox.TabIndex = 5;
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
            // ProposalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 489);
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.contractsBindingNavigator);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ProposalFormText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Name = "ProposalForm";
            this.Text = global::Edocsys.Properties.Settings.Default.ProposalFormText;
            this.Load += new System.EventHandler(this.ProposalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.edocbaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsBindingNavigator)).EndInit();
            this.contractsBindingNavigator.ResumeLayout(false);
            this.contractsBindingNavigator.PerformLayout();
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contractsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractTypesBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox ClientDocsTextBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource contractTypesBindingSource;
        private EdocbaseDataSetTableAdapters.ContractTypesTableAdapter contractTypesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idContract;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewButtonColumn SendProposalColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contract_type;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
    }
}