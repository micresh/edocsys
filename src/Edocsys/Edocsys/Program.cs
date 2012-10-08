using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace Edocsys
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
        public static class Data
        {
            public static string constr { get; set; }
            public static int sessid { get; set; }
        }
    }
}
