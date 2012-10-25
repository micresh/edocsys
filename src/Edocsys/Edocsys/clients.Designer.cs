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
            System.Windows.Forms.Label ag_docLabel;
            System.Windows.Forms.Label ag_pers_statusLabel;
            System.Windows.Forms.Label ag_pers_firstnameLabel;
            System.Windows.Forms.Label ag_pers_lastnameLabel;
            System.Windows.Forms.Label ag_pers_middlenameLabel;
            System.Windows.Forms.Label ag_bankLabel;
            System.Windows.Forms.Label ag_RcouLabel;
            System.Windows.Forms.Label ag_KcouLabel;
            System.Windows.Forms.Label ag_BIKLabel;
            System.Windows.Forms.Label ag_INNLabel;
            System.Windows.Forms.Label ag_OGRNLabel;
            System.Windows.Forms.Label ag_KPPLabel;
            System.Windows.Forms.Label ag_OKPOLabel;
            System.Windows.Forms.Label ag_fullnameLabel;
            System.Windows.Forms.Label ag_shortnameLabel;
            System.Windows.Forms.Label ag_addrLabel;
            System.Windows.Forms.Label ag_telLabel;
            System.Windows.Forms.Label ag_faxLabel;
            System.Windows.Forms.Label ag_mailLabel;
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
            this.agentsTableAdapter = new Edocsys.EdocbaseDataSetTableAdapters.AgentsTableAdapter();
            this.tableAdapterManager = new Edocsys.EdocbaseDataSetTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ag_docTextBox = new System.Windows.Forms.TextBox();
            this.ag_pers_statusTextBox = new System.Windows.Forms.TextBox();
            this.ag_pers_firstnameTextBox = new System.Windows.Forms.TextBox();
            this.ag_pers_lastnameTextBox = new System.Windows.Forms.TextBox();
            this.ag_pers_middlenameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ag_bankTextBox = new System.Windows.Forms.TextBox();
            this.ag_RcouTextBox = new System.Windows.Forms.TextBox();
            this.ag_KcouTextBox = new System.Windows.Forms.TextBox();
            this.ag_BIKTextBox = new System.Windows.Forms.TextBox();
            this.ag_INNTextBox = new System.Windows.Forms.TextBox();
            this.ag_OGRNTextBox = new System.Windows.Forms.TextBox();
            this.ag_KPPTextBox = new System.Windows.Forms.TextBox();
            this.ag_OKPOTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ag_fullnameTextBox = new System.Windows.Forms.TextBox();
            this.ag_shortnameTextBox = new System.Windows.Forms.TextBox();
            this.ag_addrTextBox = new System.Windows.Forms.TextBox();
            this.ag_telTextBox = new System.Windows.Forms.TextBox();
            this.ag_faxTextBox = new System.Windows.Forms.TextBox();
            this.ag_mailTextBox = new System.Windows.Forms.TextBox();
            this.agentsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.person_shortname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ag_docLabel = new System.Windows.Forms.Label();
            ag_pers_statusLabel = new System.Windows.Forms.Label();
            ag_pers_firstnameLabel = new System.Windows.Forms.Label();
            ag_pers_lastnameLabel = new System.Windows.Forms.Label();
            ag_pers_middlenameLabel = new System.Windows.Forms.Label();
            ag_bankLabel = new System.Windows.Forms.Label();
            ag_RcouLabel = new System.Windows.Forms.Label();
            ag_KcouLabel = new System.Windows.Forms.Label();
            ag_BIKLabel = new System.Windows.Forms.Label();
            ag_INNLabel = new System.Windows.Forms.Label();
            ag_OGRNLabel = new System.Windows.Forms.Label();
            ag_KPPLabel = new System.Windows.Forms.Label();
            ag_OKPOLabel = new System.Windows.Forms.Label();
            ag_fullnameLabel = new System.Windows.Forms.Label();
            ag_shortnameLabel = new System.Windows.Forms.Label();
            ag_addrLabel = new System.Windows.Forms.Label();
            ag_telLabel = new System.Windows.Forms.Label();
            ag_faxLabel = new System.Windows.Forms.Label();
            ag_mailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.agentsBindingNavigator)).BeginInit();
            this.agentsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edocbaseDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agentsDataGridView)).BeginInit();
            this.SuspendLayout();
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
            // ag_bankLabel
            // 
            ag_bankLabel.AutoSize = true;
            ag_bankLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "AgentsBankText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            ag_bankLabel.Location = new System.Drawing.Point(7, 121);
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
            ag_KcouLabel.Location = new System.Drawing.Point(6, 69);
            ag_KcouLabel.Name = "ag_KcouLabel";
            ag_KcouLabel.Size = new System.Drawing.Size(53, 13);
            ag_KcouLabel.TabIndex = 32;
            ag_KcouLabel.Text = global::Edocsys.Properties.Settings.Default.AgentsKSText;
            // 
            // ag_BIKLabel
            // 
            ag_BIKLabel.AutoSize = true;
            ag_BIKLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "AgentsBIKText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            ag_BIKLabel.Location = new System.Drawing.Point(8, 95);
            ag_BIKLabel.Name = "ag_BIKLabel";
            ag_BIKLabel.Size = new System.Drawing.Size(29, 13);
            ag_BIKLabel.TabIndex = 34;
            ag_BIKLabel.Text = global::Edocsys.Properties.Settings.Default.AgentsBIKText;
            // 
            // ag_INNLabel
            // 
            ag_INNLabel.AutoSize = true;
            ag_INNLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "AgentsINNText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            ag_INNLabel.Location = new System.Drawing.Point(7, 18);
            ag_INNLabel.Name = "ag_INNLabel";
            ag_INNLabel.Size = new System.Drawing.Size(31, 13);
            ag_INNLabel.TabIndex = 22;
            ag_INNLabel.Text = global::Edocsys.Properties.Settings.Default.AgentsINNText;
            // 
            // ag_OGRNLabel
            // 
            ag_OGRNLabel.AutoSize = true;
            ag_OGRNLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "AgentsOGRNText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            ag_OGRNLabel.Location = new System.Drawing.Point(7, 147);
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
            ag_OKPOLabel.Location = new System.Drawing.Point(263, 147);
            ag_OKPOLabel.Name = "ag_OKPOLabel";
            ag_OKPOLabel.Size = new System.Drawing.Size(38, 13);
            ag_OKPOLabel.TabIndex = 28;
            ag_OKPOLabel.Text = global::Edocsys.Properties.Settings.Default.AgentsOKPOText;
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
            // ag_shortnameLabel
            // 
            ag_shortnameLabel.AutoSize = true;
            ag_shortnameLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "AgentsShortNameText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            ag_shortnameLabel.Location = new System.Drawing.Point(7, 48);
            ag_shortnameLabel.Name = "ag_shortnameLabel";
            ag_shortnameLabel.Size = new System.Drawing.Size(128, 13);
            ag_shortnameLabel.TabIndex = 14;
            ag_shortnameLabel.Text = global::Edocsys.Properties.Settings.Default.AgentsShortNameText;
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
            ag_telLabel.Location = new System.Drawing.Point(7, 129);
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
            ag_mailLabel.Location = new System.Drawing.Point(7, 155);
            ag_mailLabel.Name = "ag_mailLabel";
            ag_mailLabel.Size = new System.Drawing.Size(35, 13);
            ag_mailLabel.TabIndex = 22;
            ag_mailLabel.Text = global::Edocsys.Properties.Settings.Default.AgentsEMailText;
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
            this.agentsBindingNavigator.Size = new System.Drawing.Size(1207, 25);
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
            this.agentsBindingSource.DataMember = "Agents";
            this.agentsBindingSource.DataSource = this.edocbaseDataSet;
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
            // agentsTableAdapter
            // 
            this.agentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AgentsTableAdapter = this.agentsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ContractsTableAdapter = null;
            this.tableAdapterManager.ContractTypesTableAdapter = null;
            this.tableAdapterManager.Exec_contractsTableAdapter = null;
            this.tableAdapterManager.ExpertsTableAdapter = null;
            this.tableAdapterManager.log_journalTableAdapter = null;
            this.tableAdapterManager.ProdGostTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Edocsys.EdocbaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(713, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 523);
            this.panel1.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(ag_docLabel);
            this.groupBox3.Controls.Add(this.ag_docTextBox);
            this.groupBox3.Controls.Add(ag_pers_statusLabel);
            this.groupBox3.Controls.Add(this.ag_pers_statusTextBox);
            this.groupBox3.Controls.Add(ag_pers_firstnameLabel);
            this.groupBox3.Controls.Add(this.ag_pers_firstnameTextBox);
            this.groupBox3.Controls.Add(ag_pers_lastnameLabel);
            this.groupBox3.Controls.Add(this.ag_pers_lastnameTextBox);
            this.groupBox3.Controls.Add(ag_pers_middlenameLabel);
            this.groupBox3.Controls.Add(this.ag_pers_middlenameTextBox);
            this.groupBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "AgentsContactPersonText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 348);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(494, 175);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = global::Edocsys.Properties.Settings.Default.AgentsContactPersonText;
            // 
            // ag_docTextBox
            // 
            this.ag_docTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "Ag_doc", true));
            this.ag_docTextBox.Location = new System.Drawing.Point(79, 19);
            this.ag_docTextBox.Multiline = true;
            this.ag_docTextBox.Name = "ag_docTextBox";
            this.ag_docTextBox.Size = new System.Drawing.Size(398, 47);
            this.ag_docTextBox.TabIndex = 41;
            // 
            // ag_pers_statusTextBox
            // 
            this.ag_pers_statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "Ag_pers_status", true));
            this.ag_pers_statusTextBox.Location = new System.Drawing.Point(79, 72);
            this.ag_pers_statusTextBox.Name = "ag_pers_statusTextBox";
            this.ag_pers_statusTextBox.Size = new System.Drawing.Size(398, 20);
            this.ag_pers_statusTextBox.TabIndex = 43;
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
            this.groupBox2.Controls.Add(ag_INNLabel);
            this.groupBox2.Controls.Add(this.ag_INNTextBox);
            this.groupBox2.Controls.Add(ag_OGRNLabel);
            this.groupBox2.Controls.Add(this.ag_OGRNTextBox);
            this.groupBox2.Controls.Add(ag_KPPLabel);
            this.groupBox2.Controls.Add(this.ag_KPPTextBox);
            this.groupBox2.Controls.Add(ag_OKPOLabel);
            this.groupBox2.Controls.Add(this.ag_OKPOTextBox);
            this.groupBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "AgentsBankInformationText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 167);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = global::Edocsys.Properties.Settings.Default.AgentsBankInformationText;
            // 
            // ag_bankTextBox
            // 
            this.ag_bankTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "Ag_bank", true));
            this.ag_bankTextBox.Location = new System.Drawing.Point(129, 118);
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
            this.ag_BIKTextBox.Location = new System.Drawing.Point(71, 92);
            this.ag_BIKTextBox.Name = "ag_BIKTextBox";
            this.ag_BIKTextBox.Size = new System.Drawing.Size(173, 20);
            this.ag_BIKTextBox.TabIndex = 35;
            // 
            // ag_INNTextBox
            // 
            this.ag_INNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "Ag_INN", true));
            this.ag_INNTextBox.Location = new System.Drawing.Point(70, 15);
            this.ag_INNTextBox.Name = "ag_INNTextBox";
            this.ag_INNTextBox.Size = new System.Drawing.Size(174, 20);
            this.ag_INNTextBox.TabIndex = 23;
            // 
            // ag_OGRNTextBox
            // 
            this.ag_OGRNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "Ag_OGRN", true));
            this.ag_OGRNTextBox.Location = new System.Drawing.Point(70, 144);
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
            this.ag_OKPOTextBox.Location = new System.Drawing.Point(305, 140);
            this.ag_OKPOTextBox.Name = "ag_OKPOTextBox";
            this.ag_OKPOTextBox.Size = new System.Drawing.Size(173, 20);
            this.ag_OKPOTextBox.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(ag_fullnameLabel);
            this.groupBox1.Controls.Add(this.ag_fullnameTextBox);
            this.groupBox1.Controls.Add(ag_shortnameLabel);
            this.groupBox1.Controls.Add(this.ag_shortnameTextBox);
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
            this.groupBox1.Size = new System.Drawing.Size(494, 181);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = global::Edocsys.Properties.Settings.Default.AgentsContactInformationText;
            // 
            // ag_fullnameTextBox
            // 
            this.ag_fullnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "Ag_fullname", true));
            this.ag_fullnameTextBox.Location = new System.Drawing.Point(101, 19);
            this.ag_fullnameTextBox.Name = "ag_fullnameTextBox";
            this.ag_fullnameTextBox.Size = new System.Drawing.Size(377, 20);
            this.ag_fullnameTextBox.TabIndex = 25;
            // 
            // ag_shortnameTextBox
            // 
            this.ag_shortnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "Ag_shortname", true));
            this.ag_shortnameTextBox.Location = new System.Drawing.Point(135, 45);
            this.ag_shortnameTextBox.Name = "ag_shortnameTextBox";
            this.ag_shortnameTextBox.Size = new System.Drawing.Size(343, 20);
            this.ag_shortnameTextBox.TabIndex = 15;
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
            // agentsDataGridView
            // 
            this.agentsDataGridView.AllowUserToAddRows = false;
            this.agentsDataGridView.AutoGenerateColumns = false;
            this.agentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.agentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7,
            this.person_shortname});
            this.agentsDataGridView.DataSource = this.agentsBindingSource;
            this.agentsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.agentsDataGridView.Location = new System.Drawing.Point(0, 25);
            this.agentsDataGridView.Name = "agentsDataGridView";
            this.agentsDataGridView.Size = new System.Drawing.Size(1207, 523);
            this.agentsDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idAgents";
            this.dataGridViewTextBoxColumn1.HeaderText = "#";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ToolTipText = "#";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 32;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ag_fullname";
            this.dataGridViewTextBoxColumn2.HeaderText = "Полное название";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ToolTipText = "Полное название";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Ag_shortname";
            this.dataGridViewTextBoxColumn3.HeaderText = "Сокращенное название";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ToolTipText = "Сокращенное название";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Ag_tel";
            this.dataGridViewTextBoxColumn5.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ToolTipText = "Телефон";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Ag_mail";
            this.dataGridViewTextBoxColumn7.HeaderText = "E-mail";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ToolTipText = "E-mail";
            // 
            // person_shortname
            // 
            this.person_shortname.DataPropertyName = "person_shortname";
            this.person_shortname.HeaderText = "Ф.И.О. ответственного";
            this.person_shortname.Name = "person_shortname";
            this.person_shortname.ToolTipText = "Ф.И.О. ответственного";
            this.person_shortname.Width = 150;
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 548);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.agentsDataGridView);
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
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agentsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EdocbaseDataSet edocbaseDataSet;
        private System.Windows.Forms.BindingSource agentsBindingSource;
        private EdocbaseDataSetTableAdapters.AgentsTableAdapter agentsTableAdapter;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox ag_docTextBox;
        private System.Windows.Forms.TextBox ag_pers_statusTextBox;
        private System.Windows.Forms.TextBox ag_pers_firstnameTextBox;
        private System.Windows.Forms.TextBox ag_pers_lastnameTextBox;
        private System.Windows.Forms.TextBox ag_pers_middlenameTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ag_bankTextBox;
        private System.Windows.Forms.TextBox ag_RcouTextBox;
        private System.Windows.Forms.TextBox ag_KcouTextBox;
        private System.Windows.Forms.TextBox ag_BIKTextBox;
        private System.Windows.Forms.TextBox ag_INNTextBox;
        private System.Windows.Forms.TextBox ag_OGRNTextBox;
        private System.Windows.Forms.TextBox ag_KPPTextBox;
        private System.Windows.Forms.TextBox ag_OKPOTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ag_fullnameTextBox;
        private System.Windows.Forms.TextBox ag_shortnameTextBox;
        private System.Windows.Forms.TextBox ag_addrTextBox;
        private System.Windows.Forms.TextBox ag_telTextBox;
        private System.Windows.Forms.TextBox ag_faxTextBox;
        private System.Windows.Forms.TextBox ag_mailTextBox;
        private System.Windows.Forms.DataGridView agentsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn person_shortname;
    }
}