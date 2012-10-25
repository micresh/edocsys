using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using System.Diagnostics;

namespace Edocsys
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            wmgr.SetMDIParent(this);

            //set trace information logger 
            Debug.Listeners.Add(new TextWriterTraceListener(global::Edocsys.Properties.Settings.Default.LogFilename));
            Trace.Listeners.Add(new TextWriterTraceListener(global::Edocsys.Properties.Settings.Default.LogFilename));
        }

        private void LoginToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           wmgr.ShowLoginForm();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void proposalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wmgr.ShowProporsalForm();
        }

        private void AdmpanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wmgr.ShowUseradmForm();
        }

        private void ProductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wmgr.ShowProductionForm();
        }

        private void ContractorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wmgr.ShowClientsForm();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
  
        }

        private void AssignexpertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wmgr.ShowAssignexpertForm();
        }

        private void ExpertsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wmgr.ShowExpertsForm();
        }

        private void configFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wmgr.ShowConfigForm();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //save debug information
            Trace.Flush();
            Debug.Flush();
        }
    }
}
