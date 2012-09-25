using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Edocsys
{
    public partial class MainForm : Form
    {
        private ClientsForm newMDIChild;
        public MainForm()
        {
            InitializeComponent();

        }
        
        private void windowToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (!ClientsForm.formcount)
            {
                //create newform
                newMDIChild = new ClientsForm();
                newMDIChild.MdiParent = this;
                // Display the new form.
                newMDIChild.Show();
            }
            else
                newMDIChild.Focus();

        }
    }
}
