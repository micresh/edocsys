using System;
using System.Drawing;
using System.Windows.Forms;

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
                bk = Color.FromArgb(0xFF, 0xCB, 0xDB);
                sbk = Color.FromArgb(255, 0, 0);
            }
            if (days_left < (int)Constants.DeadlineAlerts.Week)
            {
                bk = Color.FromArgb(0xFA, 0xDA, 0xDD);
                sbk = Color.FromArgb(255, 0, 0);
            }
            if (days_left < (int)Constants.DeadlineAlerts.Overdue)
            {
                bk = Color.FromArgb(0xFD, 0xD7, 0xE4);
                sbk = Color.FromArgb(255, 0, 0);
            }

            row.DefaultCellStyle.BackColor = bk;
            row.DefaultCellStyle.SelectionBackColor = sbk;
        }
    }
}
