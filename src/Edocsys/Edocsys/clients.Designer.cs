namespace Edocsys
{
    partial class ClientsForm
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
            System.Windows.Forms.Label ag_type_idLabel;
            System.Windows.Forms.Label ag_INNLabel;
            System.Windows.Forms.Label ag_fullnameLabel;
            System.Windows.Forms.Label ag_addrLabel;
            System.Windows.Forms.Label ag_telLabel;
            System.Windows.Forms.Label ag_faxLabel;
            System.Windows.Forms.Label ag_mailLabel;
            System.Windows.Forms.Label ag_bankLabel;
            System.Windows.Forms.Label ag_RcouLabel;
            System.Windows.Forms.Label ag_KcouLabel;
            System.Windows.Forms.Label ag_BIKLabel;
            System.Windows.Forms.Label ag_OGRNLabel;
            System.Windows.Forms.Label ag_KPPLabel;
            System.Windows.Forms.Label ag_OKPOLabel;
            System.Windows.Forms.Label ag_docLabel;
            System.Windows.Forms.Label ag_pers_statusLabel;
            System.Windows.Forms.Label ag_pers_firstnameLabel;
            System.Windows.Forms.Label ag_pers_lastnameLabel;
            System.Windows.Forms.Label ag_pers_middlenameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsForm));
            this.agentsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.agentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.agentsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.agentstypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agentsTableAdapter = new Edocsys.EdocbaseDataSetTableAdapters.AgentsTableAdapter();
            this.tableAdapterManager = new Edocsys.EdocbaseDataSetTableAdapters.TableAdapterManager();
            this.agents_contactsTableAdapter = new Edocsys.EdocbaseDataSetTableAdapters.Agents_contactsTableAdapter();
            this.agents_typesTableAdapter = new Edocsys.EdocbaseDataSetTableAdapters.Agents_typesTableAdapter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.agents_contactsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ac_agent_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAgents_contacts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agents_contactsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorContacts = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.agentsDataGridView = new System.Windows.Forms.DataGridView();
            this.Ag_fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agINNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.person_shortname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ag_pers_statusTextBox = new System.Windows.Forms.TextBox();
            this.ag_docTextBox = new System.Windows.Forms.TextBox();
            this.ag_pers_firstnameTextBox = new System.Windows.Forms.TextBox();
            this.ag_pers_lastnameTextBox = new System.Windows.Forms.TextBox();
            this.ag_pers_middlenameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ag_bankTextBox = new System.Windows.Forms.TextBox();
            this.ag_RcouTextBox = new System.Windows.Forms.TextBox();
            this.ag_KcouTextBox = new System.Windows.Forms.TextBox();
            this.ag_BIKTextBox = new System.Windows.Forms.TextBox();
            this.ag_OGRNTextBox = new System.Windows.Forms.TextBox();
            this.ag_KPPTextBox = new System.Windows.Forms.TextBox();
            this.ag_OKPOTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ag_type_idComboBox = new System.Windows.Forms.ComboBox();
            this.ag_INNTextBox = new System.Windows.Forms.TextBox();
            this.ag_fullnameTextBox = new System.Windows.Forms.TextBox();
            this.ag_addrTextBox = new System.Windows.Forms.TextBox();
            this.ag_telTextBox = new System.Windows.Forms.TextBox();
            this.ag_faxTextBox = new System.Windows.Forms.TextBox();
            this.ag_mailTextBox = new System.Windows.Forms.TextBox();
            this.toolStripLabelAgent = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonSaveContact = new System.Windows.Forms.ToolStripButton();
            ag_type_idLabel = new System.Windows.Forms.Label();
            ag_INNLabel = new System.Windows.Forms.Label();
            ag_fullnameLabel = new System.Windows.Forms.Label();
            ag_addrLabel = new System.Windows.Forms.Label();
            ag_telLabel = new System.Windows.Forms.Label();
            ag_faxLabel = new System.Windows.Forms.Label();
            ag_mailLabel = new System.Windows.Forms.Label();
            ag_bankLabel = new System.Windows.Forms.Label();
            ag_RcouLabel = new System.Windows.Forms.Label();
            ag_KcouLabel = new System.Windows.Forms.Label();
            ag_BIKLabel = new System.Windows.Forms.Label();
            ag_OGRNLabel = new System.Windows.Forms.Label();
            ag_KPPLabel = new System.Windows.Forms.Label();
            ag_OKPOLabel = new System.Windows.Forms.Label();
            ag_docLabel = new System.Windows.Forms.Label();
            ag_pers_statusLabel = new System.Windows.Forms.Label();
            ag_pers_firstnameLabel = new System.Windows.Forms.Label();
            ag_pers_lastnameLabel = new System.Windows.Forms.Label();
            ag_pers_middlenameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.agentsBindingNavigator)).BeginInit();
            this.agentsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edocbaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentstypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agents_contactsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agents_contactsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorContacts)).BeginInit();
            this.bindingNavigatorContacts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agentsDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ag_type_idLabel
            // 
            ag_type_idLabel.AutoSize = true;
            ag_type_idLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "AgentsTypeName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            ag_type_idLabel.Location = new System.Drawing.Point(7, 48);
            ag_type_idLabel.Name = "ag_type_idLabel";
            ag_type_idLabel.Size = new System.Drawing.Size(123, 13);
            ag_type_idLabel.TabIndex = 27;
            ag_type_idLabel.Text = global::Edocsys.Properties.Settings.Default.AgentsTypeName;
            // 
            // ag_INNLabel
            // 
            ag_INNLabel.AutoSize = true;
            ag_INNLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "AgentsINNText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            ag_INNLabel.Location = new System.Drawing.Point(263, 48);
            ag_INNLabel.Name = "ag_INNLabel";
            ag_INNLabel.Size = new System.Drawing.Size(31, 13);
            ag_INNLabel.TabIndex = 26;
            ag_INNLabel.Text = global::Edocsys.Properties.Settings.Default.AgentsINNText;
            // 
            // ag_fullnameLabel
            // 
            ag_fullnameLabel.AutoSize = true;
            ag_fullnameLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "AgentsFullNameText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            ag_fullnameLabel.Location = new System.Drawing.Point(7, 22);
            ag_fullnameLabel.Name = "ag_fullnameLabel";
            ag_fullnameLabel.Size = new System.Drawing.Size(96, 13);
            ag_fullnameLabel.TabIndex = 24;
            ag_fullnameLabel.Text = global::Edocsys.Properties.Settings.Default.AgentsFullNameText;
            // 
            // ag_addrLabel
            // 
            ag_addrLabel.AutoSize = true;
            ag_addrLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "AgentsAddressText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            ag_addrLabel.Location = new System.Drawing.Point(7, 71);
            ag_addrLabel.Name = "ag_addrLabel";
            ag_addrLabel.Size = new System.Drawing.Size(38, 13);
            ag_addrLabel.TabIndex = 16;
            ag_addrLabel.Text = global::Edocsys.Properties.Settings.Default.AgentsAddressText;
            // 
            // ag_telLabel
            // 
            ag_telLabel.AutoSize = true;
            ag_telLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "AgentsPhoneText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            ag_telLabel.Location = new System.Drawing.Point(7, 126);
            ag_telLabel.Name = "ag_telLabel";
            ag_telLabel.Size = new System.Drawing.Size(52, 13);
            ag_telLabel.TabIndex = 18;
            ag_telLabel.Text = global::Edocsys.Properties.Settings.Default.AgentsPhoneText;
            // 
            // ag_faxLabel
            // 
            ag_faxLabel.AutoSize = true;
            ag_faxLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "AgentsFaxText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            ag_faxLabel.Location = new System.Drawing.Point(263, 129);
            ag_faxLabel.Name = "ag_faxLabel";
            ag_faxLabel.Size = new System.Drawing.Size(36, 13);
            ag_faxLabel.TabIndex = 20;
            ag_faxLabel.Text = global::Edocsys.Properties.Settings.Default.AgentsFaxText;
            // 
            // ag_mailLabel
            // 
            ag_mailLabel.AutoSize = true;
            ag_mailLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "AgentsEMailText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            ag_mailLabel.Location = new System.Drawing.Point(7, 152);
            ag_mailLabel.Name = "ag_mailLabel";
            ag_mailLabel.Size = new System.Drawing.Size(35, 13);
            ag_mailLabel.TabIndex = 22;
            ag_mailLabel.Text = global::Edocsys.Properties.Settings.Default.AgentsEMailText;
            // 
            // ag_bankLabel
            // 
            ag_bankLabel.AutoSize = true;
            ag_bankLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "AgentsBankText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            ag_bankLabel.Location = new System.Drawing.Point(8, 95);
            ag_bankLabel.Name = "ag_bankLabel";
            ag_bankLabel.Size = new System.Drawing.Size(116, 13);
            ag_bankLabel.TabIndex = 36;
            ag_bankLabel.Text = global::Edocsys.Properties.Settings.Default.AgentsBankText;
            // 
            // ag_RcouLabel
            // 
            ag_RcouLabel.AutoSize = true;
            ag_RcouLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "AgentsRSText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            ag_RcouLabel.Location = new System.Drawing.Point(8, 43);
            ag_RcouLabel.Name = "ag_RcouLabel";
            ag_RcouLabel.Size = new System.Drawing.Size(41, 13);
            ag_RcouLabel.TabIndex = 30;
            ag_RcouLabel.Text = global::Edocsys.Properties.Settings.Default.AgentsRSText;
            // 
            // ag_KcouLabel
            // 
            ag_KcouLabel.AutoSize = true;
            ag_KcouLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "AgentsKSText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            ag_KcouLabel.Location = new System.Drawing.Point(8, 69);
            ag_KcouLabel.Name = "ag_KcouLabel";
            ag_KcouLabel.Size = new System.Drawing.Size(53, 13);
            ag_KcouLabel.TabIndex = 32;
            ag_KcouLabel.Text = global::Edocsys.Properties.Settings.Default.AgentsKSText;
            // 
            // ag_BIKLabel
            // 
            ag_BIKLabel.AutoSize = true;
            ag_BIKLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "AgentsBIKText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            ag_BIKLabel.Location = new System.Drawing.Point(8, 18);
            ag_BIKLabel.Name = "ag_BIKLabel";
            ag_BIKLabel.Size = new System.Drawing.Size(29, 13);
            ag_BIKLabel.TabIndex = 34;
            ag_BIKLabel.Text = global::Edocsys.Properties.Settings.Default.AgentsBIKText;
            // 
            // ag_OGRNLabel
            // 
            ag_OGRNLabel.AutoSize = true;
            ag_OGRNLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "AgentsOGRNText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            ag_OGRNLabel.Location = new System.Drawing.Point(7, 121);
            ag_OGRNLabel.Name = "ag_OGRNLabel";
            ag_OGRNLabel.Size = new System.Drawing.Size(36, 13);
            ag_OGRNLabel.TabIndex = 24;
            ag_OGRNLabel.Text = global::Edocsys.Properties.Settings.Default.AgentsOGRNText;
            // 
            // ag_KPPLabel
            // 
            ag_KPPLabel.AutoSize = true;
            ag_KPPLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "AgentsKPPText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            ag_KPPLabel.Location = new System.Drawing.Point(263, 18);
            ag_KPPLabel.Name = "ag_KPPLabel";
            ag_KPPLabel.Size = new System.Drawing.Size(30, 13);
            ag_KPPLabel.TabIndex = 26;
            ag_KPPLabel.Text = global::Edocsys.Properties.Settings.Default.AgentsKPPText;
            // 
            // ag_OKPOLabel
            // 
            ag_OKPOLabel.AutoSize = true;
            ag_OKPOLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "AgentsOKPOText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            ag_OKPOLabel.Location = new System.Drawing.Point(263, 121);
            ag_OKPOLabel.Name = "ag_OKPOLabel";
            ag_OKPOLabel.Size = new System.Drawing.Size(38, 13);
            ag_OKPOLabel.TabIndex = 28;
            ag_OKPOLabel.Text = global::Edocsys.Properties.Settings.Default.AgentsOKPOText;
            // 
            // ag_docLabel
            // 
            ag_docLabel.AutoSize = true;
            ag_docLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "AgentsDocText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            ag_docLabel.Location = new System.Drawing.Point(7, 22);
            ag_docLabel.Name = "ag_docLabel";
            ag_docLabel.Size = new System.Drawing.Size(66, 13);
            ag_docLabel.TabIndex = 40;
            ag_docLabel.Text = global::Edocsys.Properties.Settings.Default.AgentsDocText;
            // 
            // ag_pers_statusLabel
            // 
            ag_pers_statusLabel.AutoSize = true;
            ag_pers_statusLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "AgentsPersonStatusText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            ag_pers_statusLabel.Location = new System.Drawing.Point(7, 75);
            ag_pers_statusLabel.Name = "ag_pers_statusLabel";
            ag_pers_statusLabel.Size = new System.Drawing.Size(65, 13);
            ag_pers_statusLabel.TabIndex = 42;
            ag_pers_statusLabel.Text = global::Edocsys.Properties.Settings.Default.AgentsPersonStatusText;
            // 
            // ag_pers_firstnameLabel
            // 
            ag_pers_firstnameLabel.AutoSize = true;
            ag_pers_firstnameLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "AgentsPersonFirstNameText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            ag_pers_firstnameLabel.Location = new System.Drawing.Point(8, 124);
            ag_pers_firstnameLabel.Name = "ag_pers_firstnameLabel";
            ag_pers_firstnameLabel.Size = new System.Drawing.Size(29, 13);
            ag_pers_firstnameLabel.TabIndex = 44;
            ag_pers_firstnameLabel.Text = global::Edocsys.Properties.Settings.Default.AgentsPersonFirstNameText;
            // 
            // ag_pers_lastnameLabel
            // 
            ag_pers_lastnameLabel.AutoSize = true;
            ag_pers_lastnameLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "AgentsPersonLastNameText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            ag_pers_lastnameLabel.Location = new System.Drawing.Point(7, 99);
            ag_pers_lastnameLabel.Name = "ag_pers_lastnameLabel";
            ag_pers_lastnameLabel.Size = new System.Drawing.Size(56, 13);
            ag_pers_lastnameLabel.TabIndex = 46;
            ag_pers_lastnameLabel.Text = global::Edocsys.Properties.Settings.Default.AgentsPersonLastNameText;
            // 
            // ag_pers_middlenameLabel
            // 
            ag_pers_middlenameLabel.AutoSize = true;
            ag_pers_middlenameLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "AgentsPersonMiddleNameText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            ag_pers_middlenameLabel.Location = new System.Drawing.Point(8, 150);
            ag_pers_middlenameLabel.Name = "ag_pers_middlenameLabel";
            ag_pers_middlenameLabel.Size = new System.Drawing.Size(54, 13);
            ag_pers_middlenameLabel.TabIndex = 48;
            ag_pers_middlenameLabel.Text = global::Edocsys.Properties.Settings.Default.AgentsPersonMiddleNameText;
            // 
            // agentsBindingNavigator
            // 
            this.agentsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.agentsBindingNavigator.BindingSource = this.agentsBindingSource;
            this.agentsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.agentsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.agentsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.agentsBindingNavigatorSaveItem});
            this.agentsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.agentsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.agentsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.agentsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.agentsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.agentsBindingNavigator.Name = "agentsBindingNavigator";
            this.agentsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.agentsBindingNavigator.Size = new System.Drawing.Size(1112, 25);
            this.agentsBindingNavigator.TabIndex = 0;
            this.agentsBindingNavigator.Text = "bindingNavigator1";
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
            // agentsBindingSource
            // 
            this.agentsBindingSource.AllowNew = true;
            this.agentsBindingSource.DataMember = "Agents";
            this.agentsBindingSource.DataSource = this.edocbaseDataSet;
            this.agentsBindingSource.CurrentChanged += new System.EventHandler(this.agentsBindingSource_CurrentChanged);
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
            // agentsBindingNavigatorSaveItem
            // 
            this.agentsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.agentsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("agentsBindingNavigatorSaveItem.Image")));
            this.agentsBindingNavigatorSaveItem.Name = "agentsBindingNavigatorSaveItem";
            this.agentsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.agentsBindingNavigatorSaveItem.Text = "Save Data";
            this.agentsBindingNavigatorSaveItem.Click += new System.EventHandler(this.agentsBindingNavigatorSaveItem_Click);
            // 
            // agentstypesBindingSource
            // 
            this.agentstypesBindingSource.DataMember = "Agents_types";
            this.agentstypesBindingSource.DataSource = this.edocbaseDataSet;
            // 
            // agentsTableAdapter
            // 
            this.agentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Agents_contactsTableAdapter = this.agents_contactsTableAdapter;
            this.tableAdapterManager.Agents_typesTableAdapter = null;
            this.tableAdapterManager.AgentsTableAdapter = this.agentsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ContractsTableAdapter = null;
            this.tableAdapterManager.ContractTypesTableAdapter = null;
            this.tableAdapterManager.Exec_contractsTableAdapter = null;
            this.tableAdapterManager.ExpertsTableAdapter = null;
            this.tableAdapterManager.log_journalTableAdapter = null;
            this.tableAdapterManager.ProdGostTableAdapter = null;
            this.tableAdapterManager.ProductAreasTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Edocsys.EdocbaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // agents_contactsTableAdapter
            // 
            this.agents_contactsTableAdapter.ClearBeforeFill = true;
            // 
            // agents_typesTableAdapter
            // 
            this.agents_typesTableAdapter.ClearBeforeFill = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel1.Controls.Add(this.agentsDataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2MinSize = 490;
            this.splitContainer1.Size = new System.Drawing.Size(1112, 522);
            this.splitContainer1.SplitterDistance = 618;
            this.splitContainer1.TabIndex = 8;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.agents_contactsDataGridView);
            this.groupBox4.Controls.Add(this.bindingNavigatorContacts);
            this.groupBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "AgentsContactsText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(0, 334);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(618, 188);
            this.groupBox4.TabIndex = 49;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = global::Edocsys.Properties.Settings.Default.AgentsContactsText;
            // 
            // agents_contactsDataGridView
            // 
            this.agents_contactsDataGridView.AutoGenerateColumns = false;
            this.agents_contactsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.agents_contactsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.ac_agent_id,
            this.idAgents_contacts});
            this.agents_contactsDataGridView.DataSource = this.agents_contactsBindingSource;
            this.agents_contactsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.agents_contactsDataGridView.Location = new System.Drawing.Point(3, 41);
            this.agents_contactsDataGridView.Name = "agents_contactsDataGridView";
            this.agents_contactsDataGridView.Size = new System.Drawing.Size(612, 144);
            this.agents_contactsDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ac_person";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ф.И.О.";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ToolTipText = "Ф.И.О.";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ac_status";
            this.dataGridViewTextBoxColumn4.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ToolTipText = "Должность";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ac_phone";
            this.dataGridViewTextBoxColumn5.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ToolTipText = "Телефон";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ac_fax";
            this.dataGridViewTextBoxColumn6.HeaderText = "Факс";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ToolTipText = "Факс";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ac_email";
            this.dataGridViewTextBoxColumn7.HeaderText = "E-mail";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ToolTipText = "E-mail";
            // 
            // ac_agent_id
            // 
            this.ac_agent_id.DataPropertyName = "ac_agent_id";
            this.ac_agent_id.HeaderText = "ac_agent_id";
            this.ac_agent_id.Name = "ac_agent_id";
            this.ac_agent_id.Visible = false;
            // 
            // idAgents_contacts
            // 
            this.idAgents_contacts.DataPropertyName = "idAgents_contacts";
            this.idAgents_contacts.HeaderText = "idAgents_contacts";
            this.idAgents_contacts.Name = "idAgents_contacts";
            this.idAgents_contacts.Visible = false;
            // 
            // agents_contactsBindingSource
            // 
            this.agents_contactsBindingSource.DataMember = "Agents_Agents_contacts";
            this.agents_contactsBindingSource.DataSource = this.agentsBindingSource;
            // 
            // bindingNavigatorContacts
            // 
            this.bindingNavigatorContacts.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.bindingNavigatorContacts.BindingSource = this.agents_contactsBindingSource;
            this.bindingNavigatorContacts.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigatorContacts.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.bindingNavigatorContacts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1,
            this.toolStripLabelAgent,
            this.toolStripButtonSaveContact});
            this.bindingNavigatorContacts.Location = new System.Drawing.Point(3, 16);
            this.bindingNavigatorContacts.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigatorContacts.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigatorContacts.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigatorContacts.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigatorContacts.Name = "bindingNavigatorContacts";
            this.bindingNavigatorContacts.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigatorContacts.Size = new System.Drawing.Size(612, 25);
            this.bindingNavigatorContacts.TabIndex = 2;
            this.bindingNavigatorContacts.Text = "bindingNavigatorContacts";
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem1.Text = "Add new";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem1.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // agentsDataGridView
            // 
            this.agentsDataGridView.AllowUserToAddRows = false;
            this.agentsDataGridView.AutoGenerateColumns = false;
            this.agentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.agentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ag_fullname,
            this.agINNDataGridViewTextBoxColumn,
            this.person_shortname});
            this.agentsDataGridView.DataSource = this.agentsBindingSource;
            this.agentsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.agentsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.agentsDataGridView.Name = "agentsDataGridView";
            this.agentsDataGridView.Size = new System.Drawing.Size(618, 522);
            this.agentsDataGridView.TabIndex = 7;
            // 
            // Ag_fullname
            // 
            this.Ag_fullname.DataPropertyName = "Ag_name";
            this.Ag_fullname.HeaderText = "Название";
            this.Ag_fullname.MinimumWidth = 250;
            this.Ag_fullname.Name = "Ag_fullname";
            this.Ag_fullname.ToolTipText = "Название";
            this.Ag_fullname.Width = 250;
            // 
            // agINNDataGridViewTextBoxColumn
            // 
            this.agINNDataGridViewTextBoxColumn.DataPropertyName = "Ag_INN";
            this.agINNDataGridViewTextBoxColumn.HeaderText = "ИНН";
            this.agINNDataGridViewTextBoxColumn.Name = "agINNDataGridViewTextBoxColumn";
            this.agINNDataGridViewTextBoxColumn.ToolTipText = "ИНН";
            // 
            // person_shortname
            // 
            this.person_shortname.DataPropertyName = "Contact_FullName";
            this.person_shortname.HeaderText = "Ф.И.О. ответственного";
            this.person_shortname.MinimumWidth = 200;
            this.person_shortname.Name = "person_shortname";
            this.person_shortname.ToolTipText = "Ф.И.О. ответственного";
            this.person_shortname.Width = 200;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ag_pers_statusTextBox);
            this.groupBox3.Controls.Add(this.ag_docTextBox);
            this.groupBox3.Controls.Add(ag_docLabel);
            this.groupBox3.Controls.Add(ag_pers_statusLabel);
            this.groupBox3.Controls.Add(ag_pers_firstnameLabel);
            this.groupBox3.Controls.Add(this.ag_pers_firstnameTextBox);
            this.groupBox3.Controls.Add(ag_pers_lastnameLabel);
            this.groupBox3.Controls.Add(this.ag_pers_lastnameTextBox);
            this.groupBox3.Controls.Add(ag_pers_middlenameLabel);
            this.groupBox3.Controls.Add(this.ag_pers_middlenameTextBox);
            this.groupBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "AgentsContactPersonText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 334);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(490, 188);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = global::Edocsys.Properties.Settings.Default.AgentsContactPersonText;
            // 
            // ag_pers_statusTextBox
            // 
            this.ag_pers_statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "Ag_pers_status", true));
            this.ag_pers_statusTextBox.Location = new System.Drawing.Point(79, 72);
            this.ag_pers_statusTextBox.Name = "ag_pers_statusTextBox";
            this.ag_pers_statusTextBox.Size = new System.Drawing.Size(398, 20);
            this.ag_pers_statusTextBox.TabIndex = 51;
            // 
            // ag_docTextBox
            // 
            this.ag_docTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "Ag_doc", true));
            this.ag_docTextBox.Location = new System.Drawing.Point(79, 22);
            this.ag_docTextBox.Multiline = true;
            this.ag_docTextBox.Name = "ag_docTextBox";
            this.ag_docTextBox.Size = new System.Drawing.Size(398, 47);
            this.ag_docTextBox.TabIndex = 50;
            // 
            // ag_pers_firstnameTextBox
            // 
            this.ag_pers_firstnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "Ag_pers_firstname", true));
            this.ag_pers_firstnameTextBox.Location = new System.Drawing.Point(79, 121);
            this.ag_pers_firstnameTextBox.Name = "ag_pers_firstnameTextBox";
            this.ag_pers_firstnameTextBox.Size = new System.Drawing.Size(398, 20);
            this.ag_pers_firstnameTextBox.TabIndex = 45;
            // 
            // ag_pers_lastnameTextBox
            // 
            this.ag_pers_lastnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "Ag_pers_lastname", true));
            this.ag_pers_lastnameTextBox.Location = new System.Drawing.Point(79, 96);
            this.ag_pers_lastnameTextBox.Name = "ag_pers_lastnameTextBox";
            this.ag_pers_lastnameTextBox.Size = new System.Drawing.Size(399, 20);
            this.ag_pers_lastnameTextBox.TabIndex = 47;
            // 
            // ag_pers_middlenameTextBox
            // 
            this.ag_pers_middlenameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "Ag_pers_middlename", true));
            this.ag_pers_middlenameTextBox.Location = new System.Drawing.Point(79, 147);
            this.ag_pers_middlenameTextBox.Name = "ag_pers_middlenameTextBox";
            this.ag_pers_middlenameTextBox.Size = new System.Drawing.Size(399, 20);
            this.ag_pers_middlenameTextBox.TabIndex = 49;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(ag_bankLabel);
            this.groupBox2.Controls.Add(this.ag_bankTextBox);
            this.groupBox2.Controls.Add(ag_RcouLabel);
            this.groupBox2.Controls.Add(this.ag_RcouTextBox);
            this.groupBox2.Controls.Add(ag_KcouLabel);
            this.groupBox2.Controls.Add(this.ag_KcouTextBox);
            this.groupBox2.Controls.Add(ag_BIKLabel);
            this.groupBox2.Controls.Add(this.ag_BIKTextBox);
            this.groupBox2.Controls.Add(ag_OGRNLabel);
            this.groupBox2.Controls.Add(this.ag_OGRNTextBox);
            this.groupBox2.Controls.Add(ag_KPPLabel);
            this.groupBox2.Controls.Add(this.ag_KPPTextBox);
            this.groupBox2.Controls.Add(ag_OKPOLabel);
            this.groupBox2.Controls.Add(this.ag_OKPOTextBox);
            this.groupBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "AgentsBankInformationText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 148);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = global::Edocsys.Properties.Settings.Default.AgentsBankInformationText;
            // 
            // ag_bankTextBox
            // 
            this.ag_bankTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "Ag_bank", true));
            this.ag_bankTextBox.Location = new System.Drawing.Point(129, 92);
            this.ag_bankTextBox.Name = "ag_bankTextBox";
            this.ag_bankTextBox.Size = new System.Drawing.Size(348, 20);
            this.ag_bankTextBox.TabIndex = 37;
            // 
            // ag_RcouTextBox
            // 
            this.ag_RcouTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "Ag_Rcou", true));
            this.ag_RcouTextBox.Location = new System.Drawing.Point(70, 40);
            this.ag_RcouTextBox.Name = "ag_RcouTextBox";
            this.ag_RcouTextBox.Size = new System.Drawing.Size(408, 20);
            this.ag_RcouTextBox.TabIndex = 31;
            // 
            // ag_KcouTextBox
            // 
            this.ag_KcouTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "Ag_Kcou", true));
            this.ag_KcouTextBox.Location = new System.Drawing.Point(70, 66);
            this.ag_KcouTextBox.Name = "ag_KcouTextBox";
            this.ag_KcouTextBox.Size = new System.Drawing.Size(408, 20);
            this.ag_KcouTextBox.TabIndex = 33;
            // 
            // ag_BIKTextBox
            // 
            this.ag_BIKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "Ag_BIK", true));
            this.ag_BIKTextBox.Location = new System.Drawing.Point(71, 15);
            this.ag_BIKTextBox.Name = "ag_BIKTextBox";
            this.ag_BIKTextBox.Size = new System.Drawing.Size(173, 20);
            this.ag_BIKTextBox.TabIndex = 35;
            // 
            // ag_OGRNTextBox
            // 
            this.ag_OGRNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "Ag_OGRN", true));
            this.ag_OGRNTextBox.Location = new System.Drawing.Point(70, 118);
            this.ag_OGRNTextBox.Name = "ag_OGRNTextBox";
            this.ag_OGRNTextBox.Size = new System.Drawing.Size(173, 20);
            this.ag_OGRNTextBox.TabIndex = 25;
            // 
            // ag_KPPTextBox
            // 
            this.ag_KPPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "Ag_KPP", true));
            this.ag_KPPTextBox.Location = new System.Drawing.Point(304, 15);
            this.ag_KPPTextBox.Name = "ag_KPPTextBox";
            this.ag_KPPTextBox.Size = new System.Drawing.Size(174, 20);
            this.ag_KPPTextBox.TabIndex = 27;
            // 
            // ag_OKPOTextBox
            // 
            this.ag_OKPOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "Ag_OKPO", true));
            this.ag_OKPOTextBox.Location = new System.Drawing.Point(304, 118);
            this.ag_OKPOTextBox.Name = "ag_OKPOTextBox";
            this.ag_OKPOTextBox.Size = new System.Drawing.Size(173, 20);
            this.ag_OKPOTextBox.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(ag_type_idLabel);
            this.groupBox1.Controls.Add(this.ag_type_idComboBox);
            this.groupBox1.Controls.Add(ag_INNLabel);
            this.groupBox1.Controls.Add(this.ag_INNTextBox);
            this.groupBox1.Controls.Add(ag_fullnameLabel);
            this.groupBox1.Controls.Add(this.ag_fullnameTextBox);
            this.groupBox1.Controls.Add(ag_addrLabel);
            this.groupBox1.Controls.Add(this.ag_addrTextBox);
            this.groupBox1.Controls.Add(ag_telLabel);
            this.groupBox1.Controls.Add(this.ag_telTextBox);
            this.groupBox1.Controls.Add(ag_faxLabel);
            this.groupBox1.Controls.Add(this.ag_faxTextBox);
            this.groupBox1.Controls.Add(ag_mailLabel);
            this.groupBox1.Controls.Add(this.ag_mailTextBox);
            this.groupBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "AgentsContactInformationText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 186);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = global::Edocsys.Properties.Settings.Default.AgentsContactInformationText;
            // 
            // ag_type_idComboBox
            // 
            this.ag_type_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.agentsBindingSource, "Ag_type_id", true));
            this.ag_type_idComboBox.DataSource = this.agentstypesBindingSource;
            this.ag_type_idComboBox.DisplayMember = "Agent_type";
            this.ag_type_idComboBox.FormattingEnabled = true;
            this.ag_type_idComboBox.Location = new System.Drawing.Point(129, 45);
            this.ag_type_idComboBox.Name = "ag_type_idComboBox";
            this.ag_type_idComboBox.Size = new System.Drawing.Size(121, 21);
            this.ag_type_idComboBox.TabIndex = 28;
            this.ag_type_idComboBox.ValueMember = "idAgents_types";
            // 
            // ag_INNTextBox
            // 
            this.ag_INNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "Ag_INN", true));
            this.ag_INNTextBox.Location = new System.Drawing.Point(303, 45);
            this.ag_INNTextBox.Name = "ag_INNTextBox";
            this.ag_INNTextBox.Size = new System.Drawing.Size(174, 20);
            this.ag_INNTextBox.TabIndex = 27;
            // 
            // ag_fullnameTextBox
            // 
            this.ag_fullnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "Ag_fullname", true));
            this.ag_fullnameTextBox.Location = new System.Drawing.Point(100, 19);
            this.ag_fullnameTextBox.Name = "ag_fullnameTextBox";
            this.ag_fullnameTextBox.Size = new System.Drawing.Size(377, 20);
            this.ag_fullnameTextBox.TabIndex = 25;
            // 
            // ag_addrTextBox
            // 
            this.ag_addrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "Ag_addr", true));
            this.ag_addrTextBox.Location = new System.Drawing.Point(70, 71);
            this.ag_addrTextBox.Multiline = true;
            this.ag_addrTextBox.Name = "ag_addrTextBox";
            this.ag_addrTextBox.Size = new System.Drawing.Size(408, 49);
            this.ag_addrTextBox.TabIndex = 17;
            // 
            // ag_telTextBox
            // 
            this.ag_telTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "Ag_tel", true));
            this.ag_telTextBox.Location = new System.Drawing.Point(70, 126);
            this.ag_telTextBox.Name = "ag_telTextBox";
            this.ag_telTextBox.Size = new System.Drawing.Size(174, 20);
            this.ag_telTextBox.TabIndex = 19;
            // 
            // ag_faxTextBox
            // 
            this.ag_faxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "Ag_fax", true));
            this.ag_faxTextBox.Location = new System.Drawing.Point(305, 126);
            this.ag_faxTextBox.Name = "ag_faxTextBox";
            this.ag_faxTextBox.Size = new System.Drawing.Size(173, 20);
            this.ag_faxTextBox.TabIndex = 21;
            // 
            // ag_mailTextBox
            // 
            this.ag_mailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "Ag_mail", true));
            this.ag_mailTextBox.Location = new System.Drawing.Point(70, 152);
            this.ag_mailTextBox.Name = "ag_mailTextBox";
            this.ag_mailTextBox.Size = new System.Drawing.Size(408, 20);
            this.ag_mailTextBox.TabIndex = 23;
            // 
            // toolStripLabelAgent
            // 
            this.toolStripLabelAgent.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabelAgent.Name = "toolStripLabelAgent";
            this.toolStripLabelAgent.Size = new System.Drawing.Size(97, 22);
            this.toolStripLabelAgent.Text = "Контрагент: НЕТ";
            // 
            // toolStripButtonSaveContact
            // 
            this.toolStripButtonSaveContact.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSaveContact.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSaveContact.Image")));
            this.toolStripButtonSaveContact.Name = "toolStripButtonSaveContact";
            this.toolStripButtonSaveContact.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSaveContact.Text = "Save Data";
            this.toolStripButtonSaveContact.Click += new System.EventHandler(this.toolStripButtonSaveContact_Click);
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 547);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.agentsBindingNavigator);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ClientsFormText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Name = "ClientsForm";
            this.Text = global::Edocsys.Properties.Settings.Default.ClientsFormText;
            this.Load += new System.EventHandler(this.clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agentsBindingNavigator)).EndInit();
            this.agentsBindingNavigator.ResumeLayout(false);
            this.agentsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edocbaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentstypesBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agents_contactsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agents_contactsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorContacts)).EndInit();
            this.bindingNavigatorContacts.ResumeLayout(false);
            this.bindingNavigatorContacts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agentsDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EdocbaseDataSet edocbaseDataSet;
        private System.Windows.Forms.BindingSource agentsBindingSource;
        private System.Windows.Forms.BindingNavigator agentsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton agentsBindingNavigatorSaveItem;
        private EdocbaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource agentstypesBindingSource;
        private EdocbaseDataSetTableAdapters.Agents_typesTableAdapter agents_typesTableAdapter;
        private EdocbaseDataSetTableAdapters.AgentsTableAdapter agentsTableAdapter;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView agentsDataGridView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox ag_pers_statusTextBox;
        private System.Windows.Forms.TextBox ag_docTextBox;
        private System.Windows.Forms.TextBox ag_pers_firstnameTextBox;
        private System.Windows.Forms.TextBox ag_pers_lastnameTextBox;
        private System.Windows.Forms.TextBox ag_pers_middlenameTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ag_bankTextBox;
        private System.Windows.Forms.TextBox ag_RcouTextBox;
        private System.Windows.Forms.TextBox ag_KcouTextBox;
        private System.Windows.Forms.TextBox ag_BIKTextBox;
        private System.Windows.Forms.TextBox ag_OGRNTextBox;
        private System.Windows.Forms.TextBox ag_KPPTextBox;
        private System.Windows.Forms.TextBox ag_OKPOTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ag_type_idComboBox;
        private System.Windows.Forms.TextBox ag_INNTextBox;
        private System.Windows.Forms.TextBox ag_fullnameTextBox;
        private System.Windows.Forms.TextBox ag_addrTextBox;
        private System.Windows.Forms.TextBox ag_telTextBox;
        private System.Windows.Forms.TextBox ag_faxTextBox;
        private System.Windows.Forms.TextBox ag_mailTextBox;
        private System.Windows.Forms.BindingSource agents_contactsBindingSource;
        private EdocbaseDataSetTableAdapters.Agents_contactsTableAdapter agents_contactsTableAdapter;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView agents_contactsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ac_agent_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAgents_contacts;
        private System.Windows.Forms.BindingNavigator bindingNavigatorContacts;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ag_fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn agINNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn person_shortname;
        private System.Windows.Forms.ToolStripLabel toolStripLabelAgent;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveContact;
    }
}