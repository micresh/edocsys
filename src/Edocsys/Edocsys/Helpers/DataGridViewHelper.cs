using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

using System.Configuration;

using System.Reflection;

namespace Edocsys
{
    public static class DataGridViewHelper
    {
        public static void DoubleBuffered_(DataGridView grid, bool setting)
        {
            typeof(DataGridView).InvokeMember(
                           "DoubleBuffered",
                           BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                           null,
                           grid,
                           new object[] { true });
        }

        public static void DoubleBuffered(DataGridView grid, bool setting)
        {
            Type gridType = grid.GetType();
            PropertyInfo pi = gridType.GetProperty("DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(grid, setting, null);
        }


        [Serializable]
        public sealed class ColumnOrderItem
        {
            public int DisplayIndex { get; set; }
            public int Width { get; set; }
            public bool Visible { get; set; }
            public int ColumnIndex { get; set; }
        }

        private static void SetColumnOrder(DataGridView grid)
        {
            if (!gfDataGridViewSetting.Default.ColumnOrder.ContainsKey(grid.Name))
                return;

            List<ColumnOrderItem> columnOrder =
                gfDataGridViewSetting.Default.ColumnOrder[grid.Name];

            if (columnOrder != null)
            {
                //var sorted = columnOrder.OrderBy(i => i.DisplayIndex);
                
                //foreach (var item in sorted)
                foreach (var item in columnOrder)
                {
                    grid.Columns[item.ColumnIndex].DisplayIndex =
                                        item.DisplayIndex;
                    grid.Columns[item.ColumnIndex].Visible = item.Visible;
                    grid.Columns[item.ColumnIndex].Width = item.Width;
                }
            }
        }

        internal sealed class gfDataGridViewSetting : ApplicationSettingsBase
        {
            private static gfDataGridViewSetting _defaultInstace =
                (gfDataGridViewSetting)ApplicationSettingsBase
                .Synchronized(new gfDataGridViewSetting());
            //---------------------------------------------------------------------
            public static gfDataGridViewSetting Default
            {
                get { return _defaultInstace; }
            }
            //---------------------------------------------------------------------
            // Because there can be more than one DGV in the user-application
            // a dictionary is used to save the settings for this DGV.
            // As key the name of the control is used.
            [UserScopedSetting]
            [SettingsSerializeAs(SettingsSerializeAs.Binary)]
            [DefaultSettingValue("")]
            public Dictionary<string, List<ColumnOrderItem>> ColumnOrder
            {
                get
                {
                    return this["ColumnOrder"] as Dictionary<string,
                             List<ColumnOrderItem>>;
                }
                set { this["ColumnOrder"] = value; }
            }
        }
        private static void SaveColumnOrder(DataGridView grid)
        {
            if (grid.AllowUserToOrderColumns)
            {
                List<ColumnOrderItem> columnOrder = new List<ColumnOrderItem>();
                DataGridViewColumnCollection columns = grid.Columns;
                for (int i = 0; i < columns.Count; i++)
                {
                    columnOrder.Add(new ColumnOrderItem
                    {
                        ColumnIndex = i,
                        DisplayIndex = columns[i].DisplayIndex,
                        Visible = columns[i].Visible,
                        Width = columns[i].Width
                    });
                }

                gfDataGridViewSetting.Default.ColumnOrder[grid.Name] = columnOrder;
                gfDataGridViewSetting.Default.Save();
            }
        }

        public static void ChangeGridRowColor(DataGridViewRow row, int days_left)
        {
            Color bk, sbk;

            bk = row.DefaultCellStyle.BackColor;
            sbk = row.DefaultCellStyle.SelectionBackColor;



            if (days_left < (int)Constants.DeadlineAlerts.Fortnight)
            {
                //yellow
                bk = Color.FromArgb(0xFF, 0xCC, 0x00);
                sbk = Color.FromArgb(255, 0, 0);
            }
            if (days_left < (int)Constants.DeadlineAlerts.Week)
            {
                //orenge
                bk = Color.FromArgb(0xFF, 0x66, 0x33);
                sbk = Color.FromArgb(255, 0, 0);
            }
            if (days_left < (int)Constants.DeadlineAlerts.Overdue)
            {
                //pink
                bk = Color.FromArgb(0xFF, 0x66, 0x99);
                sbk = Color.FromArgb(255, 0, 0);
            }

            row.DefaultCellStyle.BackColor = bk;
            row.DefaultCellStyle.SelectionBackColor = sbk;
        }

        public static void HighlightStandartStats(DataGridView s, int idx)
        {
            //skip errors
            if ((s.Rows[idx].Cells["days_to_deadline"].Value == null) ||
                (s.Rows[idx].Cells["date_real_reatt_1"].Value == null) ||
                (s.Rows[idx].Cells["days_to_deadline_reatt_1"].Value == null) ||
                (s.Rows[idx].Cells["date_real_reatt_2"].Value == null) ||
                (s.Rows[idx].Cells["days_to_deadline_reatt_2"].Value == null) ||
                (s.Rows[idx].Cells["date_real_resert"].Value == null) ||
                (s.Rows[idx].Cells["days_to_deadline_resert"].Value == null))
                return;

            //count days
            int days_left = (int)Constants.DeadlineAlerts.Fortnight + 1;

            if (s.Rows[idx].Cells["date_planed_reatt_1"].Value == DBNull.Value)
            {
                if (s.Rows[idx].Cells["days_to_deadline"].Value != DBNull.Value)
                {
                    days_left = Math.Min(Convert.ToInt32(s.Rows[idx].Cells["days_to_deadline"].Value), days_left);
                }
            }

            if (s.Rows[idx].Cells["date_real_reatt_1"].Value == DBNull.Value)
            {
                if (s.Rows[idx].Cells["days_to_deadline_reatt_1"].Value != DBNull.Value)
                    days_left = Math.Min(Convert.ToInt32(s.Rows[idx].Cells["days_to_deadline_reatt_1"].Value), days_left);
            }

            if (s.Rows[idx].Cells["date_real_reatt_2"].Value == DBNull.Value)
            {
                if (s.Rows[idx].Cells["days_to_deadline_reatt_2"].Value != DBNull.Value)
                    days_left = Math.Min(Convert.ToInt32(s.Rows[idx].Cells["days_to_deadline_reatt_2"].Value), days_left);
            }

            if (s.Rows[idx].Cells["date_real_resert"].Value == DBNull.Value)
            {
                if (s.Rows[idx].Cells["days_to_deadline_resert"].Value != DBNull.Value)
                    days_left = Math.Min(Convert.ToInt32(s.Rows[idx].Cells["days_to_deadline_resert"].Value), days_left);
            }

            DataGridViewRow row = s.Rows[idx];

            ChangeGridRowColor(row, days_left);
        }
    }
}
