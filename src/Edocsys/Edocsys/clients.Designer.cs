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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsForm));
            System.Windows.Forms.Label ag_fullnameLabel;
            System.Windows.Forms.Label ag_shortnameLabel;
            System.Windows.Forms.Label ag_addrLabel;
            System.Windows.Forms.Label ag_telLabel;
            System.Windows.Forms.Label ag_faxLabel;
            System.Windows.Forms.Label ag_mailLabel;
            System.Windows.Forms.Label ag_INNLabel;
            System.Windows.Forms.Label ag_OGRNLabel;
            System.Windows.Forms.Label ag_KPPLabel;
            System.Windows.Forms.Label ag_OKPOLabel;
            System.Windows.Forms.Label ag_RcouLabel;
            System.Windows.Forms.Label ag_KcouLabel;
            System.Windows.Forms.Label ag_BIKLabel;
            System.Windows.Forms.Label ag_bankLabel;
            System.Windows.Forms.Label ag_docLabel;
            System.Windows.Forms.Label ag_pers_statusLabel;
            System.Windows.Forms.Label ag_pers_firstnameLabel;
            System.Windows.Forms.Label ag_pers_lastnameLabel;
            System.Windows.Forms.Label ag_pers_middlenameLabel;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.edocbaseDataSet = new Edocsys.EdocbaseDataSet();
            this.agentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agentsTableAdapter = new Edocsys.EdocbaseDataSetTableAdapters.AgentsTableAdapter();
            this.tableAdapterManager = new Edocsys.EdocbaseDataSetTableAdapters.TableAdapterManager();
            this.agentsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.agentsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.agentsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ag_fullnameTextBox = new System.Windows.Forms.TextBox();
            this.ag_shortnameTextBox = new System.Windows.Forms.TextBox();
            this.ag_addrTextBox = new System.Windows.Forms.TextBox();
            this.ag_telTextBox = new System.Windows.Forms.TextBox();
            this.ag_faxTextBox = new System.Windows.Forms.TextBox();
            this.ag_mailTextBox = new System.Windows.Forms.TextBox();
            this.ag_INNTextBox = new System.Windows.Forms.TextBox();
            this.ag_OGRNTextBox = new System.Windows.Forms.TextBox();
            this.ag_KPPTextBox = new System.Windows.Forms.TextBox();
            this.ag_OKPOTextBox = new System.Windows.Forms.TextBox();
            this.ag_RcouTextBox = new System.Windows.Forms.TextBox();
            this.ag_KcouTextBox = new System.Windows.Forms.TextBox();
            this.ag_BIKTextBox = new System.Windows.Forms.TextBox();
            this.ag_bankTextBox = new System.Windows.Forms.TextBox();
            this.ag_docTextBox = new System.Windows.Forms.TextBox();
            this.ag_pers_statusTextBox = new System.Windows.Forms.TextBox();
            this.ag_pers_firstnameTextBox = new System.Windows.Forms.TextBox();
            this.ag_pers_lastnameTextBox = new System.Windows.Forms.TextBox();
            this.ag_pers_middlenameTextBox = new System.Windows.Forms.TextBox();
            ag_fullnameLabel = new System.Windows.Forms.Label();
            ag_shortnameLabel = new System.Windows.Forms.Label();
            ag_addrLabel = new System.Windows.Forms.Label();
            ag_telLabel = new System.Windows.Forms.Label();
            ag_faxLabel = new System.Windows.Forms.Label();
            ag_mailLabel = new System.Windows.Forms.Label();
            ag_INNLabel = new System.Windows.Forms.Label();
            ag_OGRNLabel = new System.Windows.Forms.Label();
            ag_KPPLabel = new System.Windows.Forms.Label();
            ag_OKPOLabel = new System.Windows.Forms.Label();
            ag_RcouLabel = new System.Windows.Forms.Label();
            ag_KcouLabel = new System.Windows.Forms.Label();
            ag_BIKLabel = new System.Windows.Forms.Label();
            ag_bankLabel = new System.Windows.Forms.Label();
            ag_docLabel = new System.Windows.Forms.Label();
            ag_pers_statusLabel = new System.Windows.Forms.Label();
            ag_pers_firstnameLabel = new System.Windows.Forms.Label();
            ag_pers_lastnameLabel = new System.Windows.Forms.Label();
            ag_pers_middlenameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edocbaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentsBindingNavigator)).BeginInit();
            this.agentsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.agentsDataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(ag_pers_middlenameLabel);
            this.splitContainer1.Panel2.Controls.Add(this.ag_pers_middlenameTextBox);
            this.splitContainer1.Panel2.Controls.Add(ag_pers_lastnameLabel);
            this.splitContainer1.Panel2.Controls.Add(this.ag_pers_lastnameTextBox);
            this.splitContainer1.Panel2.Controls.Add(ag_pers_firstnameLabel);
            this.splitContainer1.Panel2.Controls.Add(this.ag_pers_firstnameTextBox);
            this.splitContainer1.Panel2.Controls.Add(ag_pers_statusLabel);
            this.splitContainer1.Panel2.Controls.Add(this.ag_pers_statusTextBox);
            this.splitContainer1.Panel2.Controls.Add(ag_docLabel);
            this.splitContainer1.Panel2.Controls.Add(this.ag_docTextBox);
            this.splitContainer1.Panel2.Controls.Add(ag_bankLabel);
            this.splitContainer1.Panel2.Controls.Add(this.ag_bankTextBox);
            this.splitContainer1.Panel2.Controls.Add(ag_BIKLabel);
            this.splitContainer1.Panel2.Controls.Add(this.ag_BIKTextBox);
            this.splitContainer1.Panel2.Controls.Add(ag_KcouLabel);
            this.splitContainer1.Panel2.Controls.Add(this.ag_KcouTextBox);
            this.splitContainer1.Panel2.Controls.Add(ag_RcouLabel);
            this.splitContainer1.Panel2.Controls.Add(this.ag_RcouTextBox);
            this.splitContainer1.Panel2.Controls.Add(ag_OKPOLabel);
            this.splitContainer1.Panel2.Controls.Add(this.ag_OKPOTextBox);
            this.splitContainer1.Panel2.Controls.Add(ag_KPPLabel);
            this.splitContainer1.Panel2.Controls.Add(this.ag_KPPTextBox);
            this.splitContainer1.Panel2.Controls.Add(ag_OGRNLabel);
            this.splitContainer1.Panel2.Controls.Add(this.ag_OGRNTextBox);
            this.splitContainer1.Panel2.Controls.Add(ag_INNLabel);
            this.splitContainer1.Panel2.Controls.Add(this.ag_INNTextBox);
            this.splitContainer1.Panel2.Controls.Add(ag_mailLabel);
            this.splitContainer1.Panel2.Controls.Add(this.ag_mailTextBox);
            this.splitContainer1.Panel2.Controls.Add(ag_faxLabel);
            this.splitContainer1.Panel2.Controls.Add(this.ag_faxTextBox);
            this.splitContainer1.Panel2.Controls.Add(ag_telLabel);
            this.splitContainer1.Panel2.Controls.Add(this.ag_telTextBox);
            this.splitContainer1.Panel2.Controls.Add(ag_addrLabel);
            this.splitContainer1.Panel2.Controls.Add(this.ag_addrTextBox);
            this.splitContainer1.Panel2.Controls.Add(ag_shortnameLabel);
            this.splitContainer1.Panel2.Controls.Add(this.ag_shortnameTextBox);
            this.splitContainer1.Panel2.Controls.Add(ag_fullnameLabel);
            this.splitContainer1.Panel2.Controls.Add(this.ag_fullnameTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(1278, 607);
            this.splitContainer1.SplitterDistance = 292;
            this.splitContainer1.TabIndex = 0;
            // 
            // edocbaseDataSet
            // 
            this.edocbaseDataSet.DataSetName = "EdocbaseDataSet";
            this.edocbaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agentsBindingSource
            // 
            this.agentsBindingSource.DataMember = "Agents";
            this.agentsBindingSource.DataSource = this.edocbaseDataSet;
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
            this.tableAdapterManager.Exec_contractsTableAdapter = null;
            this.tableAdapterManager.ExpertsTableAdapter = null;
            this.tableAdapterManager.log_journalTableAdapter = null;
            this.tableAdapterManager.ProdGostTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Edocsys.EdocbaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
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
            this.agentsBindingNavigator.Size = new System.Drawing.Size(1278, 25);
            this.agentsBindingNavigator.TabIndex = 1;
            this.agentsBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 13);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // agentsBindingNavigatorSaveItem
            // 
            this.agentsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.agentsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("agentsBindingNavigatorSaveItem.Image")));
            this.agentsBindingNavigatorSaveItem.Name = "agentsBindingNavigatorSaveItem";
            this.agentsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.agentsBindingNavigatorSaveItem.Text = "Save Data";
            this.agentsBindingNavigatorSaveItem.Click += new System.EventHandler(this.agentsBindingNavigatorSaveItem_Click_1);
            // 
            // agentsDataGridView
            // 
            this.agentsDataGridView.AutoGenerateColumns = false;
            this.agentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.agentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20});
            this.agentsDataGridView.DataSource = this.agentsBindingSource;
            this.agentsDataGridView.Location = new System.Drawing.Point(0, 28);
            this.agentsDataGridView.Name = "agentsDataGridView";
            this.agentsDataGridView.Size = new System.Drawing.Size(1278, 220);
            this.agentsDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idAgents";
            this.dataGridViewTextBoxColumn1.HeaderText = "idAgents";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ag_fullname";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ag_fullname";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Ag_shortname";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ag_shortname";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Ag_addr";
            this.dataGridViewTextBoxColumn4.HeaderText = "Ag_addr";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Ag_tel";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ag_tel";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Ag_fax";
            this.dataGridViewTextBoxColumn6.HeaderText = "Ag_fax";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Ag_mail";
            this.dataGridViewTextBoxColumn7.HeaderText = "Ag_mail";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Ag_INN";
            this.dataGridViewTextBoxColumn8.HeaderText = "Ag_INN";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Ag_OGRN";
            this.dataGridViewTextBoxColumn9.HeaderText = "Ag_OGRN";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Ag_KPP";
            this.dataGridViewTextBoxColumn10.HeaderText = "Ag_KPP";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Ag_OKPO";
            this.dataGridViewTextBoxColumn11.HeaderText = "Ag_OKPO";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Ag_Rcou";
            this.dataGridViewTextBoxColumn12.HeaderText = "Ag_Rcou";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Ag_Kcou";
            this.dataGridViewTextBoxColumn13.HeaderText = "Ag_Kcou";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Ag_BIK";
            this.dataGridViewTextBoxColumn14.HeaderText = "Ag_BIK";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Ag_bank";
            this.dataGridViewTextBoxColumn15.HeaderText = "Ag_bank";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Ag_doc";
            this.dataGridViewTextBoxColumn16.HeaderText = "Ag_doc";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Ag_pers_status";
            this.dataGridViewTextBoxColumn17.HeaderText = "Ag_pers_status";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Ag_pers_firstname";
            this.dataGridViewTextBoxColumn18.HeaderText = "Ag_pers_firstname";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Ag_pers_lastname";
            this.dataGridViewTextBoxColumn19.HeaderText = "Ag_pers_lastname";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Ag_pers_middlename";
            this.dataGridViewTextBoxColumn20.HeaderText = "Ag_pers_middlename";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // ag_fullnameLabel
            // 
            ag_fullnameLabel.AutoSize = true;
            ag_fullnameLabel.Location = new System.Drawing.Point(21, 35);
            ag_fullnameLabel.Name = "ag_fullnameLabel";
            ag_fullnameLabel.Size = new System.Drawing.Size(65, 13);
            ag_fullnameLabel.TabIndex = 2;
            ag_fullnameLabel.Text = "Ag fullname:";
            // 
            // ag_fullnameTextBox
            // 
            this.ag_fullnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "Ag_fullname", true));
            this.ag_fullnameTextBox.Location = new System.Drawing.Point(92, 32);
            this.ag_fullnameTextBox.Name = "ag_fullnameTextBox";
            this.ag_fullnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.ag_fullnameTextBox.TabIndex = 3;
            // 
            // ag_shortnameLabel
            // 
            ag_shortnameLabel.AutoSize = true;
            ag_shortnameLabel.Location = new System.Drawing.Point(12, 60);
            ag_shortnameLabel.Name = "ag_shortnameLabel";
            ag_shortnameLabel.Size = new System.Drawing.Size(75, 13);
            ag_shortnameLabel.TabIndex = 4;
            ag_shortnameLabel.Text = "Ag shortname:";
            // 
            // ag_shortnameTextBox
            // 
            this.ag_shortnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "Ag_shortname", true));
            this.ag_shortnameTextBox.Location = new System.Drawing.Point(93, 57);
            this.ag_shortnameTextBox.Name = "ag_shortnameTextBox";
            this.ag_shortnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.ag_shortnameTextBox.TabIndex = 5;
            // 
            // ag_addrLabel
            // 
            ag_addrLabel.AutoSize = true;
            ag_addrLabel.Location = new System.Drawing.Point(40, 148);
            ag_addrLabel.Name = "ag_addrLabel";
            ag_addrLabel.Size = new System.Drawing.Size(47, 13);
            ag_addrLabel.TabIndex = 6;
            ag_addrLabel.Text = "Ag addr:";
            // 
            // ag_addrTextBox
            // 
            this.ag_addrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "Ag_addr", true));
            this.ag_addrTextBox.Location = new System.Drawing.Point(93, 145);
            this.ag_addrTextBox.Name = "ag_addrTextBox";
            this.ag_addrTextBox.Size = new System.Drawing.Size(100, 20);
            this.ag_addrTextBox.TabIndex = 7;
            // 
            // ag_telLabel
            // 
            ag_telLabel.AutoSize = true;
            ag_telLabel.Location = new System.Drawing.Point(50, 86);
            ag_telLabel.Name = "ag_telLabel";
            ag_telLabel.Size = new System.Drawing.Size(37, 13);
            ag_telLabel.TabIndex = 8;
            ag_telLabel.Text = "Ag tel:";
            // 
            // ag_telTextBox
            // 
            this.ag_telTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "Ag_tel", true));
            this.ag_telTextBox.Location = new System.Drawing.Point(93, 83);
            this.ag_telTextBox.Name = "ag_telTextBox";
            this.ag_telTextBox.Size = new System.Drawing.Size(100, 20);
            this.ag_telTextBox.TabIndex = 9;
            // 
            // ag_faxLabel
            // 
            ag_faxLabel.AutoSize = true;
            ag_faxLabel.Location = new System.Drawing.Point(46, 118);
            ag_faxLabel.Name = "ag_faxLabel";
            ag_faxLabel.Size = new System.Drawing.Size(40, 13);
            ag_faxLabel.TabIndex = 10;
            ag_faxLabel.Text = "Ag fax:";
            // 
            // ag_faxTextBox
            // 
            this.ag_faxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "Ag_fax", true));
            this.ag_faxTextBox.Location = new System.Drawing.Point(92, 115);
            this.ag_faxTextBox.Name = "ag_faxTextBox";
            this.ag_faxTextBox.Size = new System.Drawing.Size(100, 20);
            this.ag_faxTextBox.TabIndex = 11;
            // 
            // ag_mailLabel
            // 
            ag_mailLabel.AutoSize = true;
            ag_mailLabel.Location = new System.Drawing.Point(42, 176);
            ag_mailLabel.Name = "ag_mailLabel";
            ag_mailLabel.Size = new System.Drawing.Size(44, 13);
            ag_mailLabel.TabIndex = 12;
            ag_mailLabel.Text = "Ag mail:";
            // 
            // ag_mailTextBox
            // 
            this.ag_mailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "Ag_mail", true));
            this.ag_mailTextBox.Location = new System.Drawing.Point(92, 173);
            this.ag_mailTextBox.Name = "ag_mailTextBox";
            this.ag_mailTextBox.Size = new System.Drawing.Size(100, 20);
            this.ag_mailTextBox.TabIndex = 13;
            // 
            // ag_INNLabel
            // 
            ag_INNLabel.AutoSize = true;
            ag_INNLabel.Location = new System.Drawing.Point(460, 35);
            ag_INNLabel.Name = "ag_INNLabel";
            ag_INNLabel.Size = new System.Drawing.Size(45, 13);
            ag_INNLabel.TabIndex = 14;
            ag_INNLabel.Text = "Ag INN:";
            // 
            // ag_INNTextBox
            // 
            this.ag_INNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "Ag_INN", true));
            this.ag_INNTextBox.Location = new System.Drawing.Point(511, 32);
            this.ag_INNTextBox.Name = "ag_INNTextBox";
            this.ag_INNTextBox.Size = new System.Drawing.Size(100, 20);
            this.ag_INNTextBox.TabIndex = 15;
            // 
            // ag_OGRNLabel
            // 
            ag_OGRNLabel.AutoSize = true;
            ag_OGRNLabel.Location = new System.Drawing.Point(447, 63);
            ag_OGRNLabel.Name = "ag_OGRNLabel";
            ag_OGRNLabel.Size = new System.Drawing.Size(58, 13);
            ag_OGRNLabel.TabIndex = 16;
            ag_OGRNLabel.Text = "Ag OGRN:";
            // 
            // ag_OGRNTextBox
            // 
            this.ag_OGRNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "Ag_OGRN", true));
            this.ag_OGRNTextBox.Location = new System.Drawing.Point(511, 60);
            this.ag_OGRNTextBox.Name = "ag_OGRNTextBox";
            this.ag_OGRNTextBox.Size = new System.Drawing.Size(100, 20);
            this.ag_OGRNTextBox.TabIndex = 17;
            // 
            // ag_KPPLabel
            // 
            ag_KPPLabel.AutoSize = true;
            ag_KPPLabel.Location = new System.Drawing.Point(458, 92);
            ag_KPPLabel.Name = "ag_KPPLabel";
            ag_KPPLabel.Size = new System.Drawing.Size(47, 13);
            ag_KPPLabel.TabIndex = 18;
            ag_KPPLabel.Text = "Ag KPP:";
            // 
            // ag_KPPTextBox
            // 
            this.ag_KPPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "Ag_KPP", true));
            this.ag_KPPTextBox.Location = new System.Drawing.Point(511, 89);
            this.ag_KPPTextBox.Name = "ag_KPPTextBox";
            this.ag_KPPTextBox.Size = new System.Drawing.Size(100, 20);
            this.ag_KPPTextBox.TabIndex = 19;
            // 
            // ag_OKPOLabel
            // 
            ag_OKPOLabel.AutoSize = true;
            ag_OKPOLabel.Location = new System.Drawing.Point(449, 121);
            ag_OKPOLabel.Name = "ag_OKPOLabel";
            ag_OKPOLabel.Size = new System.Drawing.Size(56, 13);
            ag_OKPOLabel.TabIndex = 20;
            ag_OKPOLabel.Text = "Ag OKPO:";
            // 
            // ag_OKPOTextBox
            // 
            this.ag_OKPOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "Ag_OKPO", true));
            this.ag_OKPOTextBox.Location = new System.Drawing.Point(511, 118);
            this.ag_OKPOTextBox.Name = "ag_OKPOTextBox";
            this.ag_OKPOTextBox.Size = new System.Drawing.Size(100, 20);
            this.ag_OKPOTextBox.TabIndex = 21;
            // 
            // ag_RcouLabel
            // 
            ag_RcouLabel.AutoSize = true;
            ag_RcouLabel.Location = new System.Drawing.Point(453, 179);
            ag_RcouLabel.Name = "ag_RcouLabel";
            ag_RcouLabel.Size = new System.Drawing.Size(52, 13);
            ag_RcouLabel.TabIndex = 22;
            ag_RcouLabel.Text = "Ag Rcou:";
            // 
            // ag_RcouTextBox
            // 
            this.ag_RcouTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "Ag_Rcou", true));
            this.ag_RcouTextBox.Location = new System.Drawing.Point(511, 176);
            this.ag_RcouTextBox.Name = "ag_RcouTextBox";
            this.ag_RcouTextBox.Size = new System.Drawing.Size(100, 20);
            this.ag_RcouTextBox.TabIndex = 23;
            // 
            // ag_KcouLabel
            // 
            ag_KcouLabel.AutoSize = true;
            ag_KcouLabel.Location = new System.Drawing.Point(454, 231);
            ag_KcouLabel.Name = "ag_KcouLabel";
            ag_KcouLabel.Size = new System.Drawing.Size(51, 13);
            ag_KcouLabel.TabIndex = 24;
            ag_KcouLabel.Text = "Ag Kcou:";
            // 
            // ag_KcouTextBox
            // 
            this.ag_KcouTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "Ag_Kcou", true));
            this.ag_KcouTextBox.Location = new System.Drawing.Point(511, 228);
            this.ag_KcouTextBox.Name = "ag_KcouTextBox";
            this.ag_KcouTextBox.Size = new System.Drawing.Size(100, 20);
            this.ag_KcouTextBox.TabIndex = 25;
            // 
            // ag_BIKLabel
            // 
            ag_BIKLabel.AutoSize = true;
            ag_BIKLabel.Location = new System.Drawing.Point(462, 205);
            ag_BIKLabel.Name = "ag_BIKLabel";
            ag_BIKLabel.Size = new System.Drawing.Size(43, 13);
            ag_BIKLabel.TabIndex = 26;
            ag_BIKLabel.Text = "Ag BIK:";
            // 
            // ag_BIKTextBox
            // 
            this.ag_BIKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "Ag_BIK", true));
            this.ag_BIKTextBox.Location = new System.Drawing.Point(511, 202);
            this.ag_BIKTextBox.Name = "ag_BIKTextBox";
            this.ag_BIKTextBox.Size = new System.Drawing.Size(100, 20);
            this.ag_BIKTextBox.TabIndex = 27;
            // 
            // ag_bankLabel
            // 
            ag_bankLabel.AutoSize = true;
            ag_bankLabel.Location = new System.Drawing.Point(455, 151);
            ag_bankLabel.Name = "ag_bankLabel";
            ag_bankLabel.Size = new System.Drawing.Size(50, 13);
            ag_bankLabel.TabIndex = 28;
            ag_bankLabel.Text = "Ag bank:";
            // 
            // ag_bankTextBox
            // 
            this.ag_bankTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "Ag_bank", true));
            this.ag_bankTextBox.Location = new System.Drawing.Point(511, 148);
            this.ag_bankTextBox.Name = "ag_bankTextBox";
            this.ag_bankTextBox.Size = new System.Drawing.Size(100, 20);
            this.ag_bankTextBox.TabIndex = 29;
            // 
            // ag_docLabel
            // 
            ag_docLabel.AutoSize = true;
            ag_docLabel.Location = new System.Drawing.Point(42, 202);
            ag_docLabel.Name = "ag_docLabel";
            ag_docLabel.Size = new System.Drawing.Size(44, 13);
            ag_docLabel.TabIndex = 30;
            ag_docLabel.Text = "Ag doc:";
            // 
            // ag_docTextBox
            // 
            this.ag_docTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "Ag_doc", true));
            this.ag_docTextBox.Location = new System.Drawing.Point(92, 199);
            this.ag_docTextBox.Name = "ag_docTextBox";
            this.ag_docTextBox.Size = new System.Drawing.Size(100, 20);
            this.ag_docTextBox.TabIndex = 31;
            // 
            // ag_pers_statusLabel
            // 
            ag_pers_statusLabel.AutoSize = true;
            ag_pers_statusLabel.Location = new System.Drawing.Point(231, 32);
            ag_pers_statusLabel.Name = "ag_pers_statusLabel";
            ag_pers_statusLabel.Size = new System.Drawing.Size(77, 13);
            ag_pers_statusLabel.TabIndex = 32;
            ag_pers_statusLabel.Text = "Ag pers status:";
            // 
            // ag_pers_statusTextBox
            // 
            this.ag_pers_statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "Ag_pers_status", true));
            this.ag_pers_statusTextBox.Location = new System.Drawing.Point(314, 29);
            this.ag_pers_statusTextBox.Name = "ag_pers_statusTextBox";
            this.ag_pers_statusTextBox.Size = new System.Drawing.Size(100, 20);
            this.ag_pers_statusTextBox.TabIndex = 33;
            // 
            // ag_pers_firstnameLabel
            // 
            ag_pers_firstnameLabel.AutoSize = true;
            ag_pers_firstnameLabel.Location = new System.Drawing.Point(217, 89);
            ag_pers_firstnameLabel.Name = "ag_pers_firstnameLabel";
            ag_pers_firstnameLabel.Size = new System.Drawing.Size(91, 13);
            ag_pers_firstnameLabel.TabIndex = 34;
            ag_pers_firstnameLabel.Text = "Ag pers firstname:";
            // 
            // ag_pers_firstnameTextBox
            // 
            this.ag_pers_firstnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "Ag_pers_firstname", true));
            this.ag_pers_firstnameTextBox.Location = new System.Drawing.Point(314, 86);
            this.ag_pers_firstnameTextBox.Name = "ag_pers_firstnameTextBox";
            this.ag_pers_firstnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.ag_pers_firstnameTextBox.TabIndex = 35;
            // 
            // ag_pers_lastnameLabel
            // 
            ag_pers_lastnameLabel.AutoSize = true;
            ag_pers_lastnameLabel.Location = new System.Drawing.Point(217, 59);
            ag_pers_lastnameLabel.Name = "ag_pers_lastnameLabel";
            ag_pers_lastnameLabel.Size = new System.Drawing.Size(91, 13);
            ag_pers_lastnameLabel.TabIndex = 36;
            ag_pers_lastnameLabel.Text = "Ag pers lastname:";
            // 
            // ag_pers_lastnameTextBox
            // 
            this.ag_pers_lastnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "Ag_pers_lastname", true));
            this.ag_pers_lastnameTextBox.Location = new System.Drawing.Point(314, 56);
            this.ag_pers_lastnameTextBox.Name = "ag_pers_lastnameTextBox";
            this.ag_pers_lastnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.ag_pers_lastnameTextBox.TabIndex = 37;
            // 
            // ag_pers_middlenameLabel
            // 
            ag_pers_middlenameLabel.AutoSize = true;
            ag_pers_middlenameLabel.Location = new System.Drawing.Point(203, 117);
            ag_pers_middlenameLabel.Name = "ag_pers_middlenameLabel";
            ag_pers_middlenameLabel.Size = new System.Drawing.Size(105, 13);
            ag_pers_middlenameLabel.TabIndex = 38;
            ag_pers_middlenameLabel.Text = "Ag pers middlename:";
            // 
            // ag_pers_middlenameTextBox
            // 
            this.ag_pers_middlenameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "Ag_pers_middlename", true));
            this.ag_pers_middlenameTextBox.Location = new System.Drawing.Point(314, 114);
            this.ag_pers_middlenameTextBox.Name = "ag_pers_middlenameTextBox";
            this.ag_pers_middlenameTextBox.Size = new System.Drawing.Size(100, 20);
            this.ag_pers_middlenameTextBox.TabIndex = 39;
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 607);
            this.Controls.Add(this.agentsBindingNavigator);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ClientsForm";
            this.Text = "clients";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClientsForm_FormClosed);
            this.Load += new System.EventHandler(this.ClientsForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edocbaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentsBindingNavigator)).EndInit();
            this.agentsBindingNavigator.ResumeLayout(false);
            this.agentsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agentsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private EdocbaseDataSet edocbaseDataSet;
        private System.Windows.Forms.BindingSource agentsBindingSource;
        private EdocbaseDataSetTableAdapters.AgentsTableAdapter agentsTableAdapter;
        private EdocbaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.DataGridView agentsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.TextBox ag_pers_middlenameTextBox;
        private System.Windows.Forms.TextBox ag_pers_lastnameTextBox;
        private System.Windows.Forms.TextBox ag_pers_firstnameTextBox;
        private System.Windows.Forms.TextBox ag_pers_statusTextBox;
        private System.Windows.Forms.TextBox ag_docTextBox;
        private System.Windows.Forms.TextBox ag_bankTextBox;
        private System.Windows.Forms.TextBox ag_BIKTextBox;
        private System.Windows.Forms.TextBox ag_KcouTextBox;
        private System.Windows.Forms.TextBox ag_RcouTextBox;
        private System.Windows.Forms.TextBox ag_OKPOTextBox;
        private System.Windows.Forms.TextBox ag_KPPTextBox;
        private System.Windows.Forms.TextBox ag_OGRNTextBox;
        private System.Windows.Forms.TextBox ag_INNTextBox;
        private System.Windows.Forms.TextBox ag_mailTextBox;
        private System.Windows.Forms.TextBox ag_faxTextBox;
        private System.Windows.Forms.TextBox ag_telTextBox;
        private System.Windows.Forms.TextBox ag_addrTextBox;
        private System.Windows.Forms.TextBox ag_shortnameTextBox;
        private System.Windows.Forms.TextBox ag_fullnameTextBox;
    }
}