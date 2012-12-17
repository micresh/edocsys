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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocTemplatesForm));
            this.edocbaseDataSet = new Edocsys.EdocbaseDataSet();
            this.tableAdapterManager = new Edocsys.EdocbaseDataSetTableAdapters.TableAdapterManager();
            this.contractTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractTypesTableAdapter = new Edocsys.EdocbaseDataSetTableAdapters.ContractTypesTableAdapter();
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
            this.contractTypesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.contractTypesListBox = new System.Windows.Forms.ListBox();
            this.docTemplatesOperaqtionsGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.edocbaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractTypesBindingNavigator)).BeginInit();
            this.contractTypesBindingNavigator.SuspendLayout();
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
            this.tableAdapterManager.Connection = null;
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
            // contractTypesBindingSource
            // 
            this.contractTypesBindingSource.DataMember = "ContractTypes";
            this.contractTypesBindingSource.DataSource = this.edocbaseDataSet;
            // 
            // contractTypesTableAdapter
            // 
            this.contractTypesTableAdapter.ClearBeforeFill = true;
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
            // contractTypesBindingNavigator
            // 
            this.contractTypesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.contractTypesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.contractTypesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.contractTypesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.contractTypesBindingNavigator.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.contractTypesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.contractTypesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.contractTypesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.contractTypesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.contractTypesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.contractTypesBindingNavigator.Name = "contractTypesBindingNavigator";
            this.contractTypesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.contractTypesBindingNavigator.Size = new System.Drawing.Size(580, 25);
            this.contractTypesBindingNavigator.TabIndex = 0;
            // 
            // contractTypesListBox
            // 
            this.contractTypesListBox.DataSource = this.contractTypesBindingSource;
            this.contractTypesListBox.DisplayMember = "name";
            this.contractTypesListBox.FormattingEnabled = true;
            this.contractTypesListBox.Location = new System.Drawing.Point(12, 45);
            this.contractTypesListBox.Name = "contractTypesListBox";
            this.contractTypesListBox.Size = new System.Drawing.Size(203, 329);
            this.contractTypesListBox.TabIndex = 3;
            this.contractTypesListBox.ValueMember = "id";
            // 
            // docTemplatesOperaqtionsGroupBox
            // 
            this.docTemplatesOperaqtionsGroupBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractTypesBindingSource, "name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.docTemplatesOperaqtionsGroupBox.Location = new System.Drawing.Point(253, 45);
            this.docTemplatesOperaqtionsGroupBox.Name = "docTemplatesOperaqtionsGroupBox";
            this.docTemplatesOperaqtionsGroupBox.Size = new System.Drawing.Size(170, 329);
            this.docTemplatesOperaqtionsGroupBox.TabIndex = 4;
            this.docTemplatesOperaqtionsGroupBox.TabStop = false;
            this.docTemplatesOperaqtionsGroupBox.Text = global::Edocsys.Properties.Settings.Default.DocTemplateOperationsText;
            // 
            // DocTemplatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 425);
            this.Controls.Add(this.docTemplatesOperaqtionsGroupBox);
            this.Controls.Add(this.contractTypesListBox);
            this.Controls.Add(this.contractTypesBindingNavigator);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Edocsys.Properties.Settings.Default, "DocTemplatesTitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Name = "DocTemplatesForm";
            this.Text = global::Edocsys.Properties.Settings.Default.DocTemplatesTitle;
            this.Load += new System.EventHandler(this.DocTemplatesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.edocbaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractTypesBindingNavigator)).EndInit();
            this.contractTypesBindingNavigator.ResumeLayout(false);
            this.contractTypesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EdocbaseDataSet edocbaseDataSet;
        private EdocbaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource contractTypesBindingSource;
        private EdocbaseDataSetTableAdapters.ContractTypesTableAdapter contractTypesTableAdapter;
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
        private System.Windows.Forms.BindingNavigator contractTypesBindingNavigator;
        private System.Windows.Forms.ListBox contractTypesListBox;
        private System.Windows.Forms.GroupBox docTemplatesOperaqtionsGroupBox;
    }
}