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
        public FilterHelper(DataGridView dataGrid, BindingSource source, TextBox filterBox, string fieldName)
        {
            this.FieldName = fieldName;
            this.Source = source;
            this.DataGrid = dataGrid;
            this.FilterBox = filterBox;

            // set events handlers
            this.DataGrid.KeyDown += DataGridView_OnKeyDown;
            this.DataGrid.ColumnHeaderMouseClick += DataGridView_OnColumnHeaderMouseClick;
            this.FilterBox.KeyDown += TextBox_OnKeyDown;
            this.FilterBox.TextChanged += TextBox_OnTextChanged;
        }

        public void ApplyFilter(string value)
        {
            if (value != String.Empty)
                Source.Filter = FieldName + " LIKE '%" + value + "%'";
            else
                ResetFilter();
        }

        public void ResetFilter()
        {
            Source.Filter = "";
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

            // Nonfunctional keys
            if ((e.KeyCode > Keys.A && e.KeyCode < Keys.Z)
                 || (e.KeyCode > Keys.D0 && e.KeyCode < Keys.D9)
                 || (e.KeyCode > Keys.NumPad0 && e.KeyCode < Keys.NumPad9)
                )
            {
                FilterBox.AppendText(String.Format("{0}", (char)e.KeyValue));
                FilterBox.Focus();
            }
        }

        private void DataGridView_OnColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string field = this.DataGrid.Columns[e.ColumnIndex].DataPropertyName;
            string value = this.FilterBox.Text;

            this.FieldName = field;
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
        public BindingSource Source
        {
            get;
            set;
        }
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
