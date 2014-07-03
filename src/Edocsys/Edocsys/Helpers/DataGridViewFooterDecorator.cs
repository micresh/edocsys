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

        private DataGridView mainDGV;
        private DataGridView footerDGV;
        private Panel containerPanel;

        private Dictionary<string, ColumnHandler> columnActions;

        public static string StaticText(string name, string value, DataGridView source)
        {
            return value;
        }

        public static string Sum(string name, string value, DataGridView source)
        {
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

        private static void SetCellValue(DataGridView dgv, string name, string value)
        {
            dgv.Rows[0].Cells[name].Value = value;
        }

        public DataGridViewFooterDecorator(DataGridView dgv, Dictionary<string, ColumnHandler> columnActions)
        {
            this.columnActions = columnActions;

            this.mainDGV = dgv;
            this.footerDGV = new DataGridView();
            this.containerPanel = new Panel();

            Control p = mainDGV.Parent;

            p.SuspendLayout();
            p.Controls.Remove(dgv);

            int newI = 0;
            for (int i = 0; i < p.Controls.Count; ++i)
            {
                if (p.Controls[i] == dgv)
                {
                    newI = i;
                    break;
                }
            }

            p.Controls.Add(containerPanel);
            p.Controls.SetChildIndex(containerPanel, newI);
            p.Controls.Remove(dgv);


            dgv.ColumnWidthChanged += ColumnWidthChangedHandler;
            ((BindingSource)dgv.DataSource).ListChanged += ListChangedHandler;

            dgv.ScrollBars = ScrollBars.Vertical;

            dgv.Dock = System.Windows.Forms.DockStyle.Fill;

            footerDGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            footerDGV.Name = "footerDGV";

            footerDGV.ColumnWidthChanged += FooterColumnWidthChangedHandler;
            footerDGV.Scroll += ScrollHander;

            footerDGV.Location = new System.Drawing.Point(100, 100);
            footerDGV.Size = new System.Drawing.Size(200, 40);
            footerDGV.ReadOnly = true;

            footerDGV.ScrollBars = ScrollBars.Horizontal;


            footerDGV.ColumnHeadersVisible = false;
            //footerDGV.RowHeadersVisible = false;

            footerDGV.RowCount = 1;
            footerDGV.ColumnCount = 1;
            
            footerDGV.Columns.Clear();
            footerDGV.Rows.Clear();


            
            foreach (DataGridViewColumn c in dgv.Columns)
            {
                DataGridViewColumn cc = new DataGridViewTextBoxColumn();
                cc.Name = c.Name;
                cc.Width = c.Width;
                cc.Visible = c.Visible;


                footerDGV.Columns.Add(cc);
                if (footerDGV.RowCount == 1)
                    footerDGV.Rows.Add();

                RefreshFooter(cc);
            }
            
            footerDGV.AllowUserToAddRows = false;
            footerDGV.AllowUserToDeleteRows = false;
          

            containerPanel.SuspendLayout();
            containerPanel.Controls.Add(dgv);
            containerPanel.Controls.Add(footerDGV);
            containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            containerPanel.Location = new System.Drawing.Point(dgv.Location.X, dgv.Location.Y);
            containerPanel.Name = "containerPanel";
            containerPanel.Size = new System.Drawing.Size(dgv.Size.Width, dgv.Size.Height - 24);
            containerPanel.ResumeLayout();
            containerPanel.PerformLayout();

            p.ResumeLayout();
            p.PerformLayout();
        }

        private void RefreshFooter(DataGridViewColumn cc)
        {
            if (columnActions.ContainsKey(cc.Name))
            {
                //cc.DefaultCellStyle.BackColor = Color.Red;
                ColumnHandler ch = (ColumnHandler)columnActions[cc.Name];
                SetCellValue(footerDGV, cc.Name, ch.Action(ch.Name, ch.Value, ch.Source));
            }
        }

        private void RefreshFooters()
        {
            foreach (KeyValuePair<string, ColumnHandler> c in columnActions)
            {
                ColumnHandler ch = (ColumnHandler)columnActions[c.Key];
                SetCellValue(footerDGV, c.Key, ch.Action(ch.Name, ch.Value, ch.Source));
            }
        }

        private void ColumnWidthChangedHandler(object sender, DataGridViewColumnEventArgs e)
        {
            this.footerDGV.Columns[e.Column.Name].Width = e.Column.Width;
        }

        private void FooterColumnWidthChangedHandler(object sender, DataGridViewColumnEventArgs e)
        {
            this.mainDGV.Columns[e.Column.Name].Width = e.Column.Width;
        }

        private void ListChangedHandler(object sender, ListChangedEventArgs e)
        {
            RefreshFooters();
        }

        private void ScrollHander(object sender, ScrollEventArgs e)
        {
            mainDGV.HorizontalScrollingOffset = e.NewValue;
        }
    }
}
