using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Diagnostics;

namespace Edocsys
{
    public partial class DocXEditForm : Form
    {
        private DocXEditForm()
        {
            InitializeComponent();
        }
        private string filename;
        private Process process;

        public DocXEditForm(string filename)
        {
            this.filename = filename;
            process = new Process();

            InitializeComponent();
        }

        private void DocXEditForm_Load(object sender, EventArgs e)
        {
            //run word


            process.StartInfo.FileName = filename;
            process.StartInfo.UseShellExecute = true;
            process.Start();

        }

        private void DocXEditForm_Shown(object sender, EventArgs e)
        {
            process.WaitForExit();

            this.Close();
        }
    }
}
