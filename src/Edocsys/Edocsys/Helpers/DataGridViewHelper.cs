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
