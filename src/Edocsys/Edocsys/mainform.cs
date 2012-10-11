using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Edocsys
{
    public partial class MainForm : Form
    {
        public String CS;
        public MainForm()
        {
            InitializeComponent();
            wmgr.SetMDIParent(this);
         
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
           wmgr.ShowClientsForm();
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



    }
}
