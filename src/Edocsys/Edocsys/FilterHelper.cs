using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Edocsys
{
    class FilterHelper
    {
        public FilterHelper(DataGridView dataGrid, TextBox filterBox)
        {
            this.DataGrid = dataGrid;
            this.FilterBox = filterBox;

            this.FieldName = String.Empty;
            // set events handlers
            this.DataGrid.KeyDown += DataGridView_OnKeyDown;
            this.DataGrid.ColumnHeaderMouseClick += DataGridView_OnColumnHeaderMouseClick;
            this.FilterBox.KeyDown += TextBox_OnKeyDown;
            this.FilterBox.TextChanged += TextBox_OnTextChanged;

            if (this.DataGrid.Columns.Count > 0)
            {
                this.FieldName = this.DataGrid.Columns[0].DataPropertyName;
                this.type = this.DataGrid.Columns[0].ValueType;
            }
        }
        private Type type;

        public void ApplyFilter(string value)
        {
            BindingSource source = ((BindingSource)this.DataGrid.DataSource);

            if ((value == String.Empty) || (FieldName == String.Empty)
                || (value == null) || (FieldName == null))
            {
                ResetFilter();
                return;
            }

            if (type == typeof(string))
            {
                if (value != String.Empty && FieldName != String.Empty)
                    source.Filter = FieldName + " LIKE '%" + value + "%'";
                    
            }
            else
            //if (type == typeof(int))
            {
                    source.Filter = FieldName + " = " + value + "";
            }

        }

        public void ResetFilter()
        {
            ((BindingSource)this.DataGrid.DataSource).Filter = "";
        }

        // Event handlers
        private void DataGridView_OnKeyDown(object sender, KeyEventArgs e)
        {
            // ESC resets filter
            if (e.KeyCode == Keys.Escape)
            {
                this.ResetFilter();
                this.FilterBox.Clear();
            }

            // Search key
            if (e.KeyCode == Keys.F3)
            {
                FilterBox.Focus();
            }

            // Nonfunctional keys
            if ((e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z)
                 || (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
                 || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
                )
            {
                FilterBox.AppendText(String.Format("{0}", (char)e.KeyValue));
                FilterBox.Focus();
            }
        }

        private void DataGridView_OnColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.FieldName = this.DataGrid.Columns[e.ColumnIndex].DataPropertyName;
            this.type = this.DataGrid.Columns[e.ColumnIndex].ValueType;

            string value = this.FilterBox.Text;

            this.ApplyFilter(value);
        }

        private void TextBox_OnTextChanged(object sender, EventArgs e)
        {
            this.ApplyFilter(((TextBox)sender).Text);
        }

        private void TextBox_OnKeyDown(object sender, KeyEventArgs e)
        {
            // select datagrid
            if ((e.KeyCode == Keys.Down)
                || (e.KeyCode == Keys.Enter))
            {
                this.DataGrid.Focus();
            }

            // remove filter data
            if (e.KeyCode == Keys.Escape)
            {
                this.FilterBox.Clear();
                this.ResetFilter();
            }
        }

        // Fields Properties
        public string FieldName
        {
            get;
            set;
        }

        public DataGridView DataGrid
        {
            get;
            set;
        }

        public TextBox FilterBox
        {
            get;
            set;
        }
    }
}
