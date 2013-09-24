using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Edocsys.Helpers;

namespace Edocsys
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            labelVersion.Text = AppInfoHelper.AssemblyVersion;
            labelPath.Text = AppInfoHelper.AssemblyDirectory;
        }

        private void AboutForm_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }
    }
}
