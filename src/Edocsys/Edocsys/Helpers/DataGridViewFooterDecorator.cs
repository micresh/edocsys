using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.Drawing;
using System.Data;

using System.ComponentModel;

namespace Edocsys
{
    public delegate string ColumnAction(string name, string value, DataGridView source);

    public class ColumnHandler
    {
        public ColumnAction Action { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public DataGridView Source { get; set; }

        public ColumnHandler(ColumnAction action, string name, string value, DataGridView source)
        {
            this.Action = action;
            this.Name = name;
            this.Value = value;
            this.Source = source;
        }
    }
    public class DataGridViewFooterDecorator
    {
        protected DataGridViewFooterDecorator()
        {
        }

        private DataGridView mainGrid;
        private DataGridView footerGrid;
        private Panel containerPanel;

        private Dictionary<string, ColumnHandler> columnActions;

        public static string StaticText(string name, string value, DataGridView source)
        {
            return value;
        }

        public static string Sum(string name, string value, DataGridView source)
        {
            if (source.DataSource == null)
                return "";

            BindingSource bs = ((BindingSource)source.DataSource);
            int p = bs.Position;
            
            double sum = 0;

            bs.MoveFirst();
            for (int i = 0; i < bs.Count; ++i )
            {
                if ((((DataRowView)bs.Current).Row[name]) != DBNull.Value)
                    sum += Convert.ToDouble(((DataRowView)bs.Current).Row[name]);
                bs.MoveNext();
            }

            bs.Position = p;
            return sum.ToString();
        }

        private static void SetCellValue(DataGridView grid, string name, string value)
        {
            grid.Rows[0].Cells[name].Value = value;
        }

        public DataGridViewFooterDecorator(DataGridView grid, List<ColumnHandler> columnActions)
        {
            this.mainGrid = grid;
            this.footerGrid = new DataGridView();
            this.containerPanel = new Panel();

            this.columnActions = new Dictionary<string, ColumnHandler>();

            foreach (ColumnHandler ch in columnActions)
            {
                string key = "";
                foreach (DataGridViewColumn x in this.mainGrid.Columns)
                {
                    if (ch.Name == x.DataPropertyName)
                    {
                        key = x.Name;
                        break;
                    }
                }

                this.columnActions[key] = ch;
            }

            Control p = mainGrid.Parent;

            p.SuspendLayout();
            p.Controls.Remove(grid);

            int newI = 0;
            for (int i = 0; i < p.Controls.Count; ++i)
            {
                if (p.Controls[i] == grid)
                {
                    newI = i;
                    break;
                }
            }

            p.Controls.Add(containerPanel);
            p.Controls.SetChildIndex(containerPanel, newI);
            p.Controls.Remove(grid);


            grid.ColumnWidthChanged += ColumnWidthChangedHandler;
            ((BindingSource)grid.DataSource).ListChanged += ListChangedHandler;

            grid.ScrollBars = ScrollBars.Vertical;

            grid.Dock = System.Windows.Forms.DockStyle.Fill;

            footerGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            footerGrid.Name = "footerDGV" + mainGrid.Name;

            footerGrid.ColumnWidthChanged += FooterColumnWidthChangedHandler;
            footerGrid.Scroll += ScrollHander;

            footerGrid.Location = new System.Drawing.Point(100, 100);
            footerGrid.Size = new System.Drawing.Size(200, 40);
            footerGrid.ReadOnly = true;

            footerGrid.ScrollBars = ScrollBars.Horizontal;


            footerGrid.ColumnHeadersVisible = false;
            //footerDGV.RowHeadersVisible = false;

            footerGrid.RowCount = 1;
            footerGrid.ColumnCount = 1;

            footerGrid.Columns.Clear();
            footerGrid.Rows.Clear();



            foreach (DataGridViewColumn c in grid.Columns)
            {
                DataGridViewColumn cc = new DataGridViewTextBoxColumn();
                cc.Name = c.Name;
                cc.Width = c.Width;
                cc.Visible = c.Visible;


                footerGrid.Columns.Add(cc);
                if (footerGrid.RowCount == 1)
                    footerGrid.Rows.Add();

                RefreshFooter(cc);
            }

            footerGrid.AllowUserToAddRows = false;
            footerGrid.AllowUserToDeleteRows = false;


            containerPanel.SuspendLayout();
            containerPanel.Controls.Add(grid);
            containerPanel.Controls.Add(footerGrid);
            containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            containerPanel.Location = new System.Drawing.Point(grid.Location.X, grid.Location.Y);
            containerPanel.Name = "containerPanel" + mainGrid.Name;
            containerPanel.Size = new System.Drawing.Size(grid.Size.Width, grid.Size.Height - 24);
            containerPanel.ResumeLayout();
            containerPanel.PerformLayout();

            p.ResumeLayout();
            p.PerformLayout();
        }

        private void RefreshFooter(DataGridViewColumn column)
        {
            if (columnActions.ContainsKey(column.Name))
            {
                //cc.DefaultCellStyle.BackColor = Color.Red;
                ColumnHandler handler = (ColumnHandler)columnActions[column.Name];
                SetCellValue(footerGrid, column.Name, handler.Action(handler.Name, handler.Value, handler.Source));
            }
        }

        private void RefreshFooters()
        {
            foreach (KeyValuePair<string, ColumnHandler> column in columnActions)
            {
                ColumnHandler handler = (ColumnHandler)columnActions[column.Key];
                SetCellValue(footerGrid, column.Key, handler.Action(handler.Name, handler.Value, handler.Source));
            }
        }

        private void ColumnWidthChangedHandler(object sender, DataGridViewColumnEventArgs e)
        {
            this.footerGrid.Columns[e.Column.Name].Width = e.Column.Width;
        }

        private void FooterColumnWidthChangedHandler(object sender, DataGridViewColumnEventArgs e)
        {
            this.mainGrid.Columns[e.Column.Name].Width = e.Column.Width;
        }

        private void ListChangedHandler(object sender, ListChangedEventArgs e)
        {
            RefreshFooters();
        }

        private void ScrollHander(object sender, ScrollEventArgs e)
        {
            mainGrid.HorizontalScrollingOffset = e.NewValue;
        }
    }
}