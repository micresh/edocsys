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
            labelAppVersion.Text = AppInfoHelper.AssemblyVersion;
            labelDeployVersion.Text = AppInfoHelper.DeploymentVersion;
            labelPath.Text = AppInfoHelper.AssemblyDirectory;
            labelDatabaseVersion.Text = AppInfoHelper.DatabaseVersion;
        }

        private void AboutForm_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }
    }
}
