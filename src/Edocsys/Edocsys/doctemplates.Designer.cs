namespace Edocsys
{
    partial class DocTemplatesForm
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
            this.edocbaseDataSet = new Edocsys.EdocbaseDataSet();
            this.tableAdapterManager = new Edocsys.EdocbaseDataSetTableAdapters.TableAdapterManager();
            this.docTemplatesTableAdapter = new Edocsys.EdocbaseDataSetTableAdapters.DocTemplatesTableAdapter();
            this.docTemplatesOperaqtionsGroupBox = new System.Windows.Forms.GroupBox();
            this.template_presenceCheckBox = new System.Windows.Forms.CheckBox();
            this.templatesDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editTemplateButton = new System.Windows.Forms.Button();
            this.saveTemplateButton = new System.Windows.Forms.Button();
            this.loadTemplateButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.docTemplatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.templatesDataTableTableAdapter = new Edocsys.EdocbaseDataSetTableAdapters.TemplatesDataTableTableAdapter();
            this.templatesDataTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.edocbaseDataSet)).BeginInit();
            this.docTemplatesOperaqtionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.templatesDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docTemplatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templatesDataTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // edocbaseDataSet
            // 
            this.edocbaseDataSet.DataSetName = "EdocbaseDataSet";
            this.edocbaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Agents_contactsTableAdapter = null;
            this.tableAdapterManager.Agents_typesTableAdapter = null;
            this.tableAdapterManager.AgentsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ContractsTableAdapter = null;
            this.tableAdapterManager.ContractStatusTableAdapter = null;
            this.tableAdapterManager.ContractTypesTableAdapter = null;
            this.tableAdapterManager.DocTemplatesTableAdapter = this.docTemplatesTableAdapter;
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
            // docTemplatesTableAdapter
            // 
            this.docTemplatesTableAdapter.ClearBeforeFill = true;
            // 
            // docTemplatesOperaqtionsGroupBox
            // 
            this.docTemplatesOperaqtionsGroupBox.Controls.Add(this.template_presenceCheckBox);
            this.docTemplatesOperaqtionsGroupBox.Controls.Add(this.editTemplateButton);
            this.docTemplatesOperaqtionsGroupBox.Controls.Add(this.saveTemplateButton);
            this.docTemplatesOperaqtionsGroupBox.Controls.Add(this.loadTemplateButton);
            this.docTemplatesOperaqtionsGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.docTemplatesOperaqtionsGroupBox.Location = new System.Drawing.Point(0, 172);
            this.docTemplatesOperaqtionsGroupBox.Name = "docTemplatesOperaqtionsGroupBox";
            this.docTemplatesOperaqtionsGroupBox.Size = new System.Drawing.Size(523, 102);
            this.docTemplatesOperaqtionsGroupBox.TabIndex = 4;
            this.docTemplatesOperaqtionsGroupBox.TabStop = false;
            this.docTemplatesOperaqtionsGroupBox.Text = global::Edocsys.Properties.Settings.Default.DocTemplateOperationsText;
            // 
            // template_presenceCheckBox
            // 
            this.template_presenceCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.templatesDataTableBindingSource, "template_presence", true));
            this.template_presenceCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "TemplatePresenceText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.template_presenceCheckBox.Location = new System.Drawing.Point(12, 18);
            this.template_presenceCheckBox.Name = "template_presenceCheckBox";
            this.template_presenceCheckBox.Size = new System.Drawing.Size(235, 24);
            this.template_presenceCheckBox.TabIndex = 9;
            this.template_presenceCheckBox.Text = global::Edocsys.Properties.Settings.Default.TemplatePresenceText;
            this.template_presenceCheckBox.UseVisualStyleBackColor = true;
            // 
            // templatesDataTableBindingSource
            // 
            this.templatesDataTableBindingSource.DataMember = "TemplatesDataTable";
            this.templatesDataTableBindingSource.DataSource = this.edocbaseDataSet;
            // 
            // editTemplateButton
            // 
            this.editTemplateButton.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "EditTemplateButton", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.editTemplateButton.Location = new System.Drawing.Point(310, 19);
            this.editTemplateButton.Name = "editTemplateButton";
            this.editTemplateButton.Size = new System.Drawing.Size(184, 23);
            this.editTemplateButton.TabIndex = 8;
            this.editTemplateButton.Text = global::Edocsys.Properties.Settings.Default.EditTemplateButton;
            this.editTemplateButton.UseVisualStyleBackColor = true;
            this.editTemplateButton.Click += new System.EventHandler(this.editTemplateButton_Click);
            // 
            // saveTemplateButton
            // 
            this.saveTemplateButton.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "SaveTemplateButton", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.saveTemplateButton.Location = new System.Drawing.Point(310, 67);
            this.saveTemplateButton.Name = "saveTemplateButton";
            this.saveTemplateButton.Size = new System.Drawing.Size(184, 23);
            this.saveTemplateButton.TabIndex = 7;
            this.saveTemplateButton.Text = global::Edocsys.Properties.Settings.Default.SaveTemplateButton;
            this.saveTemplateButton.UseVisualStyleBackColor = true;
            this.saveTemplateButton.Click += new System.EventHandler(this.saveTemplateButton_Click);
            // 
            // loadTemplateButton
            // 
            this.loadTemplateButton.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "loadTemplateButton", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.loadTemplateButton.Location = new System.Drawing.Point(12, 67);
            this.loadTemplateButton.Name = "loadTemplateButton";
            this.loadTemplateButton.Size = new System.Drawing.Size(184, 23);
            this.loadTemplateButton.TabIndex = 6;
            this.loadTemplateButton.Text = global::Edocsys.Properties.Settings.Default.LoadTemplateButton;
            this.loadTemplateButton.UseVisualStyleBackColor = true;
            this.loadTemplateButton.Click += new System.EventHandler(this.loadTemplateButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Файлы Word 2007-2010| *.docx|Все файлы|*.*";
            // 
            // docTemplatesBindingSource
            // 
            this.docTemplatesBindingSource.DataMember = "DocTemplates";
            this.docTemplatesBindingSource.DataSource = this.edocbaseDataSet;
            // 
            // templatesDataTableTableAdapter
            // 
            this.templatesDataTableTableAdapter.ClearBeforeFill = true;
            // 
            // templatesDataTableDataGridView
            // 
            this.templatesDataTableDataGridView.AllowUserToAddRows = false;
            this.templatesDataTableDataGridView.AllowUserToDeleteRows = false;
            this.templatesDataTableDataGridView.AutoGenerateColumns = false;
            this.templatesDataTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.templatesDataTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1});
            this.templatesDataTableDataGridView.DataSource = this.templatesDataTableBindingSource;
            this.templatesDataTableDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.templatesDataTableDataGridView.Location = new System.Drawing.Point(0, 0);
            this.templatesDataTableDataGridView.Name = "templatesDataTableDataGridView";
            this.templatesDataTableDataGridView.ReadOnly = true;
            this.templatesDataTableDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.templatesDataTableDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.templatesDataTableDataGridView.Size = new System.Drawing.Size(523, 172);
            this.templatesDataTableDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Тип документа";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.ToolTipText = "Тип документа";
            this.dataGridViewTextBoxColumn2.Width = 350;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DTid";
            this.dataGridViewTextBoxColumn3.HeaderText = "DTid";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "template_presence";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Наличие загруженного шаблона";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.ToolTipText = "Наличие загруженного шаблона";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Файлы Word 2007-2010| *.docx|Все файлы|*.*";
            // 
            // DocTemplatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 274);
            this.Controls.Add(this.templatesDataTableDataGridView);
            this.Controls.Add(this.docTemplatesOperaqtionsGroupBox);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "DocTemplatesTitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Name = "DocTemplatesForm";
            this.Text = global::Edocsys.Properties.Settings.Default.DocTemplatesTitle;
            this.Load += new System.EventHandler(this.DocTemplatesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.edocbaseDataSet)).EndInit();
            this.docTemplatesOperaqtionsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.templatesDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docTemplatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templatesDataTableDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EdocbaseDataSet edocbaseDataSet;
        private EdocbaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox docTemplatesOperaqtionsGroupBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button loadTemplateButton;
        private System.Windows.Forms.Button saveTemplateButton;
        private System.Windows.Forms.Button editTemplateButton;
        private System.Windows.Forms.BindingSource docTemplatesBindingSource;
        private EdocbaseDataSetTableAdapters.DocTemplatesTableAdapter docTemplatesTableAdapter;
        private System.Windows.Forms.BindingSource templatesDataTableBindingSource;
        private EdocbaseDataSetTableAdapters.TemplatesDataTableTableAdapter templatesDataTableTableAdapter;
        private System.Windows.Forms.DataGridView templatesDataTableDataGridView;
        private System.Windows.Forms.CheckBox template_presenceCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}