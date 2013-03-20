namespace Edocsys
{
    partial class InspectionControlForm
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
            System.Windows.Forms.Label date_planed_reatt_1Label;
            System.Windows.Forms.Label date_planed_reatt_2Label;
            System.Windows.Forms.Label date_planed_resertLabel;
            System.Windows.Forms.Label date_real_reatt_1Label;
            System.Windows.Forms.Label date_real_reatt_2Label;
            System.Windows.Forms.Label date_real_resertLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InspectionControlForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabReattestationSign = new System.Windows.Forms.TabPage();
            this.inspectionContractsDataGridView = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contracttypesnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentsnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agenttypesnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_planed_reatt_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_planed_reatt_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_planed_resert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.has_inspection_document = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateproposalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentsfullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expertFIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartControlColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.inspectionContractsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.edocbaseDataSet = new Edocsys.EdocbaseDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSetDateResert = new System.Windows.Forms.Button();
            this.buttonSetDateReatt2 = new System.Windows.Forms.Button();
            this.buttonSetDateReatt1 = new System.Windows.Forms.Button();
            this.date_planed_resertDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.date_planed_reatt_2DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.date_planed_reatt_1DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBoxContract = new System.Windows.Forms.GroupBox();
            this.buttonLoadContract = new System.Windows.Forms.Button();
            this.buttonSaveContract = new System.Windows.Forms.Button();
            this.buttonEditContract = new System.Windows.Forms.Button();
            this.buttonGenerateContract = new System.Windows.Forms.Button();
            this.bindingNavigatorInspectionContracts = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.usersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.filterInspectionContractsTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.tabInspectionControl = new System.Windows.Forms.TabPage();
            this.contractsOnInspectionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_real_reatt_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.days_to_deadline_reatt_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_real_reatt_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.days_to_deadline_reatt_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_real_resert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.days_to_deadline_resert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinishInspectionControlColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.contractsOnInspectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonResert = new System.Windows.Forms.Button();
            this.buttonReatt2 = new System.Windows.Forms.Button();
            this.buttonReatt1 = new System.Windows.Forms.Button();
            this.date_real_resertDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.date_real_reatt_2DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.date_real_reatt_1DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.contractsOnInspectionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.filterContractsOnInspectionTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tableAdapterManager = new Edocsys.EdocbaseDataSetTableAdapters.TableAdapterManager();
            this.contractDocDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractDocDataTableAdapter = new Edocsys.EdocbaseDataSetTableAdapters.ContractDocDataTableAdapter();
            this.inspectionContractsTableAdapter = new Edocsys.EdocbaseDataSetTableAdapters.InspectionContractsTableAdapter();
            this.contractsOnInspectionTableAdapter = new Edocsys.EdocbaseDataSetTableAdapters.ContractsOnInspectionTableAdapter();
            date_planed_reatt_1Label = new System.Windows.Forms.Label();
            date_planed_reatt_2Label = new System.Windows.Forms.Label();
            date_planed_resertLabel = new System.Windows.Forms.Label();
            date_real_reatt_1Label = new System.Windows.Forms.Label();
            date_real_reatt_2Label = new System.Windows.Forms.Label();
            date_real_resertLabel = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabReattestationSign.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionContractsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionContractsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edocbaseDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBoxContract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorInspectionContracts)).BeginInit();
            this.bindingNavigatorInspectionContracts.SuspendLayout();
            this.tabInspectionControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractsOnInspectionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsOnInspectionBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractsOnInspectionBindingNavigator)).BeginInit();
            this.contractsOnInspectionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractDocDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // date_planed_reatt_1Label
            // 
            date_planed_reatt_1Label.AutoSize = true;
            date_planed_reatt_1Label.Location = new System.Drawing.Point(19, 17);
            date_planed_reatt_1Label.Name = "date_planed_reatt_1Label";
            date_planed_reatt_1Label.Size = new System.Drawing.Size(219, 13);
            date_planed_reatt_1Label.TabIndex = 25;
            date_planed_reatt_1Label.Text = "Ориентировочная дата 1-ой реаттестации";
            // 
            // date_planed_reatt_2Label
            // 
            date_planed_reatt_2Label.AutoSize = true;
            date_planed_reatt_2Label.Location = new System.Drawing.Point(19, 59);
            date_planed_reatt_2Label.Name = "date_planed_reatt_2Label";
            date_planed_reatt_2Label.Size = new System.Drawing.Size(219, 13);
            date_planed_reatt_2Label.TabIndex = 26;
            date_planed_reatt_2Label.Text = "Ориентировочная дата 2-ой реаттестации";
            // 
            // date_planed_resertLabel
            // 
            date_planed_resertLabel.AutoSize = true;
            date_planed_resertLabel.Location = new System.Drawing.Point(19, 100);
            date_planed_resertLabel.Name = "date_planed_resertLabel";
            date_planed_resertLabel.Size = new System.Drawing.Size(121, 13);
            date_planed_resertLabel.TabIndex = 27;
            date_planed_resertLabel.Text = "Дата ресертификации";
            // 
            // date_real_reatt_1Label
            // 
            date_real_reatt_1Label.AutoSize = true;
            date_real_reatt_1Label.Location = new System.Drawing.Point(15, 13);
            date_real_reatt_1Label.Name = "date_real_reatt_1Label";
            date_real_reatt_1Label.Size = new System.Drawing.Size(178, 13);
            date_real_reatt_1Label.TabIndex = 26;
            date_real_reatt_1Label.Text = "Реальная дата 1-ой реаттестации";
            // 
            // date_real_reatt_2Label
            // 
            date_real_reatt_2Label.AutoSize = true;
            date_real_reatt_2Label.Location = new System.Drawing.Point(15, 54);
            date_real_reatt_2Label.Name = "date_real_reatt_2Label";
            date_real_reatt_2Label.Size = new System.Drawing.Size(178, 13);
            date_real_reatt_2Label.TabIndex = 28;
            date_real_reatt_2Label.Text = "Реальная дата 2-ой реаттестации";
            // 
            // date_real_resertLabel
            // 
            date_real_resertLabel.AutoSize = true;
            date_real_resertLabel.Location = new System.Drawing.Point(15, 99);
            date_real_resertLabel.Name = "date_real_resertLabel";
            date_real_resertLabel.Size = new System.Drawing.Size(170, 13);
            date_real_resertLabel.TabIndex = 30;
            date_real_resertLabel.Text = "Реальная дата ресертификации";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabReattestationSign);
            this.tabControl.Controls.Add(this.tabInspectionControl);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1114, 470);
            this.tabControl.TabIndex = 2;
            // 
            // tabReattestationSign
            // 
            this.tabReattestationSign.AutoScroll = true;
            this.tabReattestationSign.Controls.Add(this.inspectionContractsDataGridView);
            this.tabReattestationSign.Controls.Add(this.panel1);
            this.tabReattestationSign.Controls.Add(this.bindingNavigatorInspectionContracts);
            this.tabReattestationSign.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ReattestationSignTitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tabReattestationSign.Location = new System.Drawing.Point(4, 22);
            this.tabReattestationSign.Name = "tabReattestationSign";
            this.tabReattestationSign.Padding = new System.Windows.Forms.Padding(3);
            this.tabReattestationSign.Size = new System.Drawing.Size(1106, 444);
            this.tabReattestationSign.TabIndex = 6;
            this.tabReattestationSign.Text = global::Edocsys.Properties.Settings.Default.ReattestationSignTitle;
            this.tabReattestationSign.UseVisualStyleBackColor = true;
            // 
            // inspectionContractsDataGridView
            // 
            this.inspectionContractsDataGridView.AllowUserToAddRows = false;
            this.inspectionContractsDataGridView.AllowUserToDeleteRows = false;
            this.inspectionContractsDataGridView.AutoGenerateColumns = false;
            this.inspectionContractsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inspectionContractsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.productsnameDataGridViewTextBoxColumn,
            this.contracttypesnameDataGridViewTextBoxColumn,
            this.agentsnameDataGridViewTextBoxColumn,
            this.agenttypesnameDataGridViewTextBoxColumn,
            this.date_planed_reatt_1,
            this.date_planed_reatt_2,
            this.date_planed_resert,
            this.has_inspection_document,
            this.costDataGridViewTextBoxColumn,
            this.totalcostDataGridViewTextBoxColumn,
            this.dateproposalDataGridViewTextBoxColumn,
            this.agentsfullnameDataGridViewTextBoxColumn,
            this.expertFIODataGridViewTextBoxColumn,
            this.StartControlColumn});
            this.inspectionContractsDataGridView.DataSource = this.inspectionContractsBindingSource;
            this.inspectionContractsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inspectionContractsDataGridView.Location = new System.Drawing.Point(3, 28);
            this.inspectionContractsDataGridView.MultiSelect = false;
            this.inspectionContractsDataGridView.Name = "inspectionContractsDataGridView";
            this.inspectionContractsDataGridView.ReadOnly = true;
            this.inspectionContractsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inspectionContractsDataGridView.Size = new System.Drawing.Size(1100, 253);
            this.inspectionContractsDataGridView.TabIndex = 30;
            this.inspectionContractsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inspectionContractsDataGridView_CellContentClick);
            // 
            // number
            // 
            this.number.DataPropertyName = "number";
            this.number.HeaderText = "Номер";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            // 
            // productsnameDataGridViewTextBoxColumn
            // 
            this.productsnameDataGridViewTextBoxColumn.DataPropertyName = "products_name";
            this.productsnameDataGridViewTextBoxColumn.HeaderText = "Продукция";
            this.productsnameDataGridViewTextBoxColumn.Name = "productsnameDataGridViewTextBoxColumn";
            this.productsnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contracttypesnameDataGridViewTextBoxColumn
            // 
            this.contracttypesnameDataGridViewTextBoxColumn.DataPropertyName = "contract_types_name";
            this.contracttypesnameDataGridViewTextBoxColumn.HeaderText = "Тип работ";
            this.contracttypesnameDataGridViewTextBoxColumn.Name = "contracttypesnameDataGridViewTextBoxColumn";
            this.contracttypesnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // agentsnameDataGridViewTextBoxColumn
            // 
            this.agentsnameDataGridViewTextBoxColumn.DataPropertyName = "agents_name";
            this.agentsnameDataGridViewTextBoxColumn.HeaderText = "Контрагент";
            this.agentsnameDataGridViewTextBoxColumn.Name = "agentsnameDataGridViewTextBoxColumn";
            this.agentsnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // agenttypesnameDataGridViewTextBoxColumn
            // 
            this.agenttypesnameDataGridViewTextBoxColumn.DataPropertyName = "agent_types_name";
            this.agenttypesnameDataGridViewTextBoxColumn.HeaderText = "Форма собственности";
            this.agenttypesnameDataGridViewTextBoxColumn.Name = "agenttypesnameDataGridViewTextBoxColumn";
            this.agenttypesnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // date_planed_reatt_1
            // 
            this.date_planed_reatt_1.DataPropertyName = "date_planed_reatt_1";
            this.date_planed_reatt_1.HeaderText = "Дата 1-ой реаттестации";
            this.date_planed_reatt_1.Name = "date_planed_reatt_1";
            this.date_planed_reatt_1.ReadOnly = true;
            // 
            // date_planed_reatt_2
            // 
            this.date_planed_reatt_2.DataPropertyName = "date_planed_reatt_2";
            this.date_planed_reatt_2.HeaderText = "Дата 2-ой реаттестации";
            this.date_planed_reatt_2.Name = "date_planed_reatt_2";
            this.date_planed_reatt_2.ReadOnly = true;
            // 
            // date_planed_resert
            // 
            this.date_planed_resert.DataPropertyName = "date_planed_resert";
            this.date_planed_resert.HeaderText = "Дата ресертификации";
            this.date_planed_resert.Name = "date_planed_resert";
            this.date_planed_resert.ReadOnly = true;
            // 
            // has_inspection_document
            // 
            this.has_inspection_document.DataPropertyName = "has_inspection_document";
            this.has_inspection_document.HeaderText = "Договор";
            this.has_inspection_document.Name = "has_inspection_document";
            this.has_inspection_document.ReadOnly = true;
            this.has_inspection_document.Width = 70;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalcostDataGridViewTextBoxColumn
            // 
            this.totalcostDataGridViewTextBoxColumn.DataPropertyName = "total_cost";
            this.totalcostDataGridViewTextBoxColumn.HeaderText = "Общая сумма";
            this.totalcostDataGridViewTextBoxColumn.Name = "totalcostDataGridViewTextBoxColumn";
            this.totalcostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateproposalDataGridViewTextBoxColumn
            // 
            this.dateproposalDataGridViewTextBoxColumn.DataPropertyName = "date_proposal";
            this.dateproposalDataGridViewTextBoxColumn.HeaderText = "Дата поступления заявки";
            this.dateproposalDataGridViewTextBoxColumn.Name = "dateproposalDataGridViewTextBoxColumn";
            this.dateproposalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // agentsfullnameDataGridViewTextBoxColumn
            // 
            this.agentsfullnameDataGridViewTextBoxColumn.DataPropertyName = "agents_fullname";
            this.agentsfullnameDataGridViewTextBoxColumn.HeaderText = "Контрагент";
            this.agentsfullnameDataGridViewTextBoxColumn.Name = "agentsfullnameDataGridViewTextBoxColumn";
            this.agentsfullnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expertFIODataGridViewTextBoxColumn
            // 
            this.expertFIODataGridViewTextBoxColumn.DataPropertyName = "expert_FIO";
            this.expertFIODataGridViewTextBoxColumn.HeaderText = "Эксперт";
            this.expertFIODataGridViewTextBoxColumn.Name = "expertFIODataGridViewTextBoxColumn";
            this.expertFIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // StartControlColumn
            // 
            this.StartControlColumn.HeaderText = "Начать инспекционный контроль";
            this.StartControlColumn.Name = "StartControlColumn";
            this.StartControlColumn.ReadOnly = true;
            // 
            // inspectionContractsBindingSource
            // 
            this.inspectionContractsBindingSource.DataMember = "InspectionContracts";
            this.inspectionContractsBindingSource.DataSource = this.edocbaseDataSet;
            // 
            // edocbaseDataSet
            // 
            this.edocbaseDataSet.CaseSensitive = true;
            this.edocbaseDataSet.DataSetName = "EdocbaseDataSet";
            this.edocbaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSetDateResert);
            this.panel1.Controls.Add(this.buttonSetDateReatt2);
            this.panel1.Controls.Add(this.buttonSetDateReatt1);
            this.panel1.Controls.Add(date_planed_resertLabel);
            this.panel1.Controls.Add(this.date_planed_resertDateTimePicker);
            this.panel1.Controls.Add(date_planed_reatt_2Label);
            this.panel1.Controls.Add(this.date_planed_reatt_2DateTimePicker);
            this.panel1.Controls.Add(date_planed_reatt_1Label);
            this.panel1.Controls.Add(this.date_planed_reatt_1DateTimePicker);
            this.panel1.Controls.Add(this.groupBoxContract);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 281);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 160);
            this.panel1.TabIndex = 28;
            // 
            // buttonSetDateResert
            // 
            this.buttonSetDateResert.Location = new System.Drawing.Point(392, 96);
            this.buttonSetDateResert.Name = "buttonSetDateResert";
            this.buttonSetDateResert.Size = new System.Drawing.Size(292, 23);
            this.buttonSetDateResert.TabIndex = 39;
            this.buttonSetDateResert.Text = "Установить сегдняшнюю дату для  ресертификации";
            this.buttonSetDateResert.UseVisualStyleBackColor = true;
            this.buttonSetDateResert.Click += new System.EventHandler(this.buttonSetDateResert_Click);
            // 
            // buttonSetDateReatt2
            // 
            this.buttonSetDateReatt2.Location = new System.Drawing.Point(392, 54);
            this.buttonSetDateReatt2.Name = "buttonSetDateReatt2";
            this.buttonSetDateReatt2.Size = new System.Drawing.Size(292, 23);
            this.buttonSetDateReatt2.TabIndex = 38;
            this.buttonSetDateReatt2.Text = "Установить сегдняшнюю дату для 2-ой реаттестации";
            this.buttonSetDateReatt2.UseVisualStyleBackColor = true;
            this.buttonSetDateReatt2.Click += new System.EventHandler(this.buttonSetDateReatt2_Click);
            // 
            // buttonSetDateReatt1
            // 
            this.buttonSetDateReatt1.Location = new System.Drawing.Point(392, 12);
            this.buttonSetDateReatt1.Name = "buttonSetDateReatt1";
            this.buttonSetDateReatt1.Size = new System.Drawing.Size(292, 23);
            this.buttonSetDateReatt1.TabIndex = 37;
            this.buttonSetDateReatt1.Text = "Установить сегдняшнюю дату для 1-ой реаттестации";
            this.buttonSetDateReatt1.UseVisualStyleBackColor = true;
            this.buttonSetDateReatt1.Click += new System.EventHandler(this.buttonSetDateReatt1_Click);
            // 
            // date_planed_resertDateTimePicker
            // 
            this.date_planed_resertDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.inspectionContractsBindingSource, "date_planed_resert", true));
            this.date_planed_resertDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_planed_resertDateTimePicker.Location = new System.Drawing.Point(244, 99);
            this.date_planed_resertDateTimePicker.Name = "date_planed_resertDateTimePicker";
            this.date_planed_resertDateTimePicker.Size = new System.Drawing.Size(127, 20);
            this.date_planed_resertDateTimePicker.TabIndex = 28;
            // 
            // date_planed_reatt_2DateTimePicker
            // 
            this.date_planed_reatt_2DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.inspectionContractsBindingSource, "date_planed_reatt_2", true));
            this.date_planed_reatt_2DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_planed_reatt_2DateTimePicker.Location = new System.Drawing.Point(244, 54);
            this.date_planed_reatt_2DateTimePicker.Name = "date_planed_reatt_2DateTimePicker";
            this.date_planed_reatt_2DateTimePicker.Size = new System.Drawing.Size(127, 20);
            this.date_planed_reatt_2DateTimePicker.TabIndex = 27;
            // 
            // date_planed_reatt_1DateTimePicker
            // 
            this.date_planed_reatt_1DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.inspectionContractsBindingSource, "date_planed_reatt_1", true));
            this.date_planed_reatt_1DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_planed_reatt_1DateTimePicker.Location = new System.Drawing.Point(244, 15);
            this.date_planed_reatt_1DateTimePicker.Name = "date_planed_reatt_1DateTimePicker";
            this.date_planed_reatt_1DateTimePicker.Size = new System.Drawing.Size(127, 20);
            this.date_planed_reatt_1DateTimePicker.TabIndex = 26;
            this.date_planed_reatt_1DateTimePicker.Value = new System.DateTime(2013, 3, 17, 0, 0, 0, 0);
            // 
            // groupBoxContract
            // 
            this.groupBoxContract.Controls.Add(this.buttonLoadContract);
            this.groupBoxContract.Controls.Add(this.buttonSaveContract);
            this.groupBoxContract.Controls.Add(this.buttonEditContract);
            this.groupBoxContract.Controls.Add(this.buttonGenerateContract);
            this.groupBoxContract.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "ReattContractTitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBoxContract.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxContract.Location = new System.Drawing.Point(813, 0);
            this.groupBoxContract.Name = "groupBoxContract";
            this.groupBoxContract.Size = new System.Drawing.Size(287, 160);
            this.groupBoxContract.TabIndex = 25;
            this.groupBoxContract.TabStop = false;
            this.groupBoxContract.Text = global::Edocsys.Properties.Settings.Default.ReattContractTitle;
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
            this.buttonSaveContract.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.inspectionContractsBindingSource, "has_inspection_document", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
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
            this.buttonEditContract.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.inspectionContractsBindingSource, "has_inspection_document", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
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
            // bindingNavigatorInspectionContracts
            // 
            this.bindingNavigatorInspectionContracts.AddNewItem = null;
            this.bindingNavigatorInspectionContracts.BindingSource = this.inspectionContractsBindingSource;
            this.bindingNavigatorInspectionContracts.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorInspectionContracts.DeleteItem = null;
            this.bindingNavigatorInspectionContracts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripButton7,
            this.toolStripSeparator6,
            this.bindingNavigatorDeleteItem,
            this.usersBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.filterInspectionContractsTextBox});
            this.bindingNavigatorInspectionContracts.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigatorInspectionContracts.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorInspectionContracts.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorInspectionContracts.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorInspectionContracts.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorInspectionContracts.Name = "bindingNavigatorInspectionContracts";
            this.bindingNavigatorInspectionContracts.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorInspectionContracts.Size = new System.Drawing.Size(1100, 25);
            this.bindingNavigatorInspectionContracts.TabIndex = 29;
            this.bindingNavigatorInspectionContracts.Text = "bindingNavigator1";
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
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "Обновить";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
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
            this.usersBindingNavigatorSaveItem.Click += new System.EventHandler(this.usersBindingNavigatorSaveItem_Click_1);
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
            // filterInspectionContractsTextBox
            // 
            this.filterInspectionContractsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterInspectionContractsTextBox.Name = "filterInspectionContractsTextBox";
            this.filterInspectionContractsTextBox.Size = new System.Drawing.Size(300, 25);
            // 
            // tabInspectionControl
            // 
            this.tabInspectionControl.AutoScroll = true;
            this.tabInspectionControl.Controls.Add(this.contractsOnInspectionDataGridView);
            this.tabInspectionControl.Controls.Add(this.panel2);
            this.tabInspectionControl.Controls.Add(this.contractsOnInspectionBindingNavigator);
            this.tabInspectionControl.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "InspectionControlTitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tabInspectionControl.Location = new System.Drawing.Point(4, 22);
            this.tabInspectionControl.Name = "tabInspectionControl";
            this.tabInspectionControl.Padding = new System.Windows.Forms.Padding(3);
            this.tabInspectionControl.Size = new System.Drawing.Size(1106, 444);
            this.tabInspectionControl.TabIndex = 7;
            this.tabInspectionControl.Text = global::Edocsys.Properties.Settings.Default.InspectionControlTitle;
            this.tabInspectionControl.UseVisualStyleBackColor = true;
            // 
            // contractsOnInspectionDataGridView
            // 
            this.contractsOnInspectionDataGridView.AllowUserToAddRows = false;
            this.contractsOnInspectionDataGridView.AllowUserToDeleteRows = false;
            this.contractsOnInspectionDataGridView.AutoGenerateColumns = false;
            this.contractsOnInspectionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contractsOnInspectionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.date_real_reatt_1,
            this.days_to_deadline_reatt_1,
            this.dataGridViewTextBoxColumn7,
            this.date_real_reatt_2,
            this.days_to_deadline_reatt_2,
            this.dataGridViewTextBoxColumn8,
            this.date_real_resert,
            this.days_to_deadline_resert,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.FinishInspectionControlColumn});
            this.contractsOnInspectionDataGridView.DataSource = this.contractsOnInspectionBindingSource;
            this.contractsOnInspectionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contractsOnInspectionDataGridView.Location = new System.Drawing.Point(3, 28);
            this.contractsOnInspectionDataGridView.MultiSelect = false;
            this.contractsOnInspectionDataGridView.Name = "contractsOnInspectionDataGridView";
            this.contractsOnInspectionDataGridView.ReadOnly = true;
            this.contractsOnInspectionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.contractsOnInspectionDataGridView.Size = new System.Drawing.Size(1100, 246);
            this.contractsOnInspectionDataGridView.TabIndex = 30;
            this.contractsOnInspectionDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.contractsOnInspectionDataGridView_CellContentClick);
            this.contractsOnInspectionDataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.contractsOnInspectionDataGridView_CellPainting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "products_name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Продукция";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "contract_types_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Тип работ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "agents_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Контрагент";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "agent_types_name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Форма собственности";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "cost";
            this.dataGridViewTextBoxColumn5.HeaderText = "Сумма";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "date_planed_reatt_1";
            this.dataGridViewTextBoxColumn6.HeaderText = "Планируемая дата 1-ой реаттестации";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // date_real_reatt_1
            // 
            this.date_real_reatt_1.DataPropertyName = "date_real_reatt_1";
            this.date_real_reatt_1.HeaderText = "Реальная дата 1-ой реаттестации";
            this.date_real_reatt_1.Name = "date_real_reatt_1";
            this.date_real_reatt_1.ReadOnly = true;
            // 
            // days_to_deadline_reatt_1
            // 
            this.days_to_deadline_reatt_1.DataPropertyName = "days_to_deadline_reatt_1";
            this.days_to_deadline_reatt_1.HeaderText = "Дней до 1-ой реаттестации";
            this.days_to_deadline_reatt_1.Name = "days_to_deadline_reatt_1";
            this.days_to_deadline_reatt_1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "date_planed_reatt_2";
            this.dataGridViewTextBoxColumn7.HeaderText = "Планируемая дата 2-ой реаттестации";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // date_real_reatt_2
            // 
            this.date_real_reatt_2.DataPropertyName = "date_real_reatt_2";
            this.date_real_reatt_2.HeaderText = "Реальная дата 2-ой реаттестации";
            this.date_real_reatt_2.Name = "date_real_reatt_2";
            this.date_real_reatt_2.ReadOnly = true;
            // 
            // days_to_deadline_reatt_2
            // 
            this.days_to_deadline_reatt_2.DataPropertyName = "days_to_deadline_reatt_2";
            this.days_to_deadline_reatt_2.HeaderText = "Дней до 2-ой реаттестации";
            this.days_to_deadline_reatt_2.Name = "days_to_deadline_reatt_2";
            this.days_to_deadline_reatt_2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "date_planed_resert";
            this.dataGridViewTextBoxColumn8.HeaderText = "Планируемая дата ресертификации";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // date_real_resert
            // 
            this.date_real_resert.DataPropertyName = "date_real_resert";
            this.date_real_resert.HeaderText = "Реальная дата ресертификации";
            this.date_real_resert.Name = "date_real_resert";
            this.date_real_resert.ReadOnly = true;
            // 
            // days_to_deadline_resert
            // 
            this.days_to_deadline_resert.DataPropertyName = "days_to_deadline_resert";
            this.days_to_deadline_resert.HeaderText = "Дней до ресертификации";
            this.days_to_deadline_resert.Name = "days_to_deadline_resert";
            this.days_to_deadline_resert.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "total_cost";
            this.dataGridViewTextBoxColumn9.HeaderText = "Общая сумма";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "date_proposal";
            this.dataGridViewTextBoxColumn10.HeaderText = "Дата поступления заявки";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "agents_fullname";
            this.dataGridViewTextBoxColumn11.HeaderText = "Контрагент";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "expert_FIO";
            this.dataGridViewTextBoxColumn12.HeaderText = "Эксперт";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // FinishInspectionControlColumn
            // 
            this.FinishInspectionControlColumn.HeaderText = "Завершить обслуживание";
            this.FinishInspectionControlColumn.Name = "FinishInspectionControlColumn";
            this.FinishInspectionControlColumn.ReadOnly = true;
            // 
            // contractsOnInspectionBindingSource
            // 
            this.contractsOnInspectionBindingSource.DataMember = "ContractsOnInspection";
            this.contractsOnInspectionBindingSource.DataSource = this.edocbaseDataSet;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonResert);
            this.panel2.Controls.Add(this.buttonReatt2);
            this.panel2.Controls.Add(this.buttonReatt1);
            this.panel2.Controls.Add(date_real_resertLabel);
            this.panel2.Controls.Add(this.date_real_resertDateTimePicker);
            this.panel2.Controls.Add(date_real_reatt_2Label);
            this.panel2.Controls.Add(this.date_real_reatt_2DateTimePicker);
            this.panel2.Controls.Add(date_real_reatt_1Label);
            this.panel2.Controls.Add(this.date_real_reatt_1DateTimePicker);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 274);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1100, 167);
            this.panel2.TabIndex = 28;
            // 
            // buttonResert
            // 
            this.buttonResert.Location = new System.Drawing.Point(355, 94);
            this.buttonResert.Name = "buttonResert";
            this.buttonResert.Size = new System.Drawing.Size(221, 23);
            this.buttonResert.TabIndex = 34;
            this.buttonResert.Text = "Провести ресертификацию";
            this.buttonResert.UseVisualStyleBackColor = true;
            this.buttonResert.Click += new System.EventHandler(this.buttonResert_Click);
            // 
            // buttonReatt2
            // 
            this.buttonReatt2.Location = new System.Drawing.Point(355, 44);
            this.buttonReatt2.Name = "buttonReatt2";
            this.buttonReatt2.Size = new System.Drawing.Size(221, 23);
            this.buttonReatt2.TabIndex = 33;
            this.buttonReatt2.Text = "Провести 2-ю реаттестация";
            this.buttonReatt2.UseVisualStyleBackColor = true;
            this.buttonReatt2.Click += new System.EventHandler(this.buttonReatt2_Click);
            // 
            // buttonReatt1
            // 
            this.buttonReatt1.Location = new System.Drawing.Point(355, 9);
            this.buttonReatt1.Name = "buttonReatt1";
            this.buttonReatt1.Size = new System.Drawing.Size(221, 23);
            this.buttonReatt1.TabIndex = 32;
            this.buttonReatt1.Text = "Провести 1-ю реаттестацию";
            this.buttonReatt1.UseVisualStyleBackColor = true;
            this.buttonReatt1.Click += new System.EventHandler(this.buttonReatt1_Click);
            // 
            // date_real_resertDateTimePicker
            // 
            this.date_real_resertDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contractsOnInspectionBindingSource, "date_real_resert", true));
            this.date_real_resertDateTimePicker.Location = new System.Drawing.Point(205, 94);
            this.date_real_resertDateTimePicker.Name = "date_real_resertDateTimePicker";
            this.date_real_resertDateTimePicker.Size = new System.Drawing.Size(144, 20);
            this.date_real_resertDateTimePicker.TabIndex = 31;
            // 
            // date_real_reatt_2DateTimePicker
            // 
            this.date_real_reatt_2DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contractsOnInspectionBindingSource, "date_real_reatt_2", true));
            this.date_real_reatt_2DateTimePicker.Location = new System.Drawing.Point(205, 44);
            this.date_real_reatt_2DateTimePicker.Name = "date_real_reatt_2DateTimePicker";
            this.date_real_reatt_2DateTimePicker.Size = new System.Drawing.Size(144, 20);
            this.date_real_reatt_2DateTimePicker.TabIndex = 29;
            // 
            // date_real_reatt_1DateTimePicker
            // 
            this.date_real_reatt_1DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contractsOnInspectionBindingSource, "date_real_reatt_1", true));
            this.date_real_reatt_1DateTimePicker.Location = new System.Drawing.Point(205, 9);
            this.date_real_reatt_1DateTimePicker.Name = "date_real_reatt_1DateTimePicker";
            this.date_real_reatt_1DateTimePicker.Size = new System.Drawing.Size(144, 20);
            this.date_real_reatt_1DateTimePicker.TabIndex = 27;
            // 
            // contractsOnInspectionBindingNavigator
            // 
            this.contractsOnInspectionBindingNavigator.AddNewItem = null;
            this.contractsOnInspectionBindingNavigator.BindingSource = this.contractsOnInspectionBindingSource;
            this.contractsOnInspectionBindingNavigator.CountItem = this.toolStripLabel2;
            this.contractsOnInspectionBindingNavigator.DeleteItem = null;
            this.contractsOnInspectionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.toolStripTextBox1,
            this.toolStripLabel2,
            this.toolStripSeparator3,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator4,
            this.toolStripButton8,
            this.toolStripSeparator7,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator5,
            this.toolStripLabel3,
            this.filterContractsOnInspectionTextBox});
            this.contractsOnInspectionBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.contractsOnInspectionBindingNavigator.MoveFirstItem = this.toolStripButton1;
            this.contractsOnInspectionBindingNavigator.MoveLastItem = this.toolStripButton4;
            this.contractsOnInspectionBindingNavigator.MoveNextItem = this.toolStripButton3;
            this.contractsOnInspectionBindingNavigator.MovePreviousItem = this.toolStripButton2;
            this.contractsOnInspectionBindingNavigator.Name = "contractsOnInspectionBindingNavigator";
            this.contractsOnInspectionBindingNavigator.PositionItem = this.toolStripTextBox1;
            this.contractsOnInspectionBindingNavigator.Size = new System.Drawing.Size(1100, 25);
            this.contractsOnInspectionBindingNavigator.TabIndex = 29;
            this.contractsOnInspectionBindingNavigator.Text = "bindingNavigator1";
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
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Delete";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Save Data";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click_1);
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
            // filterContractsOnInspectionTextBox
            // 
            this.filterContractsOnInspectionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterContractsOnInspectionTextBox.Name = "filterContractsOnInspectionTextBox";
            this.filterContractsOnInspectionTextBox.Size = new System.Drawing.Size(200, 25);
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
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.contract_statusTableAdapter = null;
            this.tableAdapterManager.contract_types_for_workTableAdapter = null;
            this.tableAdapterManager.contract_typesTableAdapter = null;
            this.tableAdapterManager.ContractInfoTableAdapter = null;
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
            // contractDocDataBindingSource
            // 
            this.contractDocDataBindingSource.DataMember = "ContractDocData";
            this.contractDocDataBindingSource.DataSource = this.edocbaseDataSet;
            // 
            // contractDocDataTableAdapter
            // 
            this.contractDocDataTableAdapter.ClearBeforeFill = true;
            // 
            // inspectionContractsTableAdapter
            // 
            this.inspectionContractsTableAdapter.ClearBeforeFill = true;
            // 
            // contractsOnInspectionTableAdapter
            // 
            this.contractsOnInspectionTableAdapter.ClearBeforeFill = true;
            // 
            // InspectionControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 470);
            this.Controls.Add(this.tabControl);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "InspectionControlMenuTitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Name = "InspectionControlForm";
            this.Text = global::Edocsys.Properties.Settings.Default.InspectionControlMenuTitle;
            this.Load += new System.EventHandler(this.ContractsForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabReattestationSign.ResumeLayout(false);
            this.tabReattestationSign.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionContractsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionContractsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edocbaseDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxContract.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorInspectionContracts)).EndInit();
            this.bindingNavigatorInspectionContracts.ResumeLayout(false);
            this.bindingNavigatorInspectionContracts.PerformLayout();
            this.tabInspectionControl.ResumeLayout(false);
            this.tabInspectionControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractsOnInspectionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsOnInspectionBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractsOnInspectionBindingNavigator)).EndInit();
            this.contractsOnInspectionBindingNavigator.ResumeLayout(false);
            this.contractsOnInspectionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractDocDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EdocbaseDataSet edocbaseDataSet;
        private EdocbaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.BindingSource contractDocDataBindingSource;
        private EdocbaseDataSetTableAdapters.ContractDocDataTableAdapter contractDocDataTableAdapter;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TabPage tabReattestationSign;
        private System.Windows.Forms.TabPage tabInspectionControl;
        private System.Windows.Forms.DataGridView inspectionContractsDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxContract;
        private System.Windows.Forms.Button buttonLoadContract;
        private System.Windows.Forms.Button buttonSaveContract;
        private System.Windows.Forms.Button buttonEditContract;
        private System.Windows.Forms.Button buttonGenerateContract;
        private System.Windows.Forms.BindingNavigator bindingNavigatorInspectionContracts;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton usersBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox filterInspectionContractsTextBox;
        private System.Windows.Forms.DataGridView contractsOnInspectionDataGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingNavigator contractsOnInspectionBindingNavigator;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox filterContractsOnInspectionTextBox;
        private System.Windows.Forms.BindingSource inspectionContractsBindingSource;
        private EdocbaseDataSetTableAdapters.InspectionContractsTableAdapter inspectionContractsTableAdapter;
        private System.Windows.Forms.DateTimePicker date_planed_resertDateTimePicker;
        private System.Windows.Forms.DateTimePicker date_planed_reatt_2DateTimePicker;
        private System.Windows.Forms.DateTimePicker date_planed_reatt_1DateTimePicker;
        private System.Windows.Forms.BindingSource contractsOnInspectionBindingSource;
        private EdocbaseDataSetTableAdapters.ContractsOnInspectionTableAdapter contractsOnInspectionTableAdapter;
        private System.Windows.Forms.DateTimePicker date_real_resertDateTimePicker;
        private System.Windows.Forms.DateTimePicker date_real_reatt_2DateTimePicker;
        private System.Windows.Forms.DateTimePicker date_real_reatt_1DateTimePicker;
        private System.Windows.Forms.Button buttonReatt1;
        private System.Windows.Forms.Button buttonResert;
        private System.Windows.Forms.Button buttonReatt2;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.Button buttonSetDateReatt1;
        private System.Windows.Forms.Button buttonSetDateResert;
        private System.Windows.Forms.Button buttonSetDateReatt2;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn productsnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contracttypesnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentsnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agenttypesnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_planed_reatt_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_planed_reatt_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_planed_resert;
        private System.Windows.Forms.DataGridViewCheckBoxColumn has_inspection_document;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateproposalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentsfullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expertFIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn StartControlColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_real_reatt_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn days_to_deadline_reatt_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_real_reatt_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn days_to_deadline_reatt_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_real_resert;
        private System.Windows.Forms.DataGridViewTextBoxColumn days_to_deadline_resert;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewButtonColumn FinishInspectionControlColumn;

        //private EdocbaseDataSetTableAdapters.Exec_contractsTableAdapter exec_contractsTableAdapter;
    }
}