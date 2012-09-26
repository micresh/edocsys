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
        private LoginForm logchild;
        public MainForm()
        {
            InitializeComponent();

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

           

        private void LoginToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (!LoginForm.formcount)
            {
                //create newform
                logchild = new LoginForm();
                logchild.MdiParent = this;
                // Display the new form.
                logchild.Show();
            }
            else
                logchild.Focus();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
