﻿using System;
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
        public MainForm()
        {
            InitializeComponent();

            wmgr.SetMDIParent(this);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
           wmgr.ShowClientsForm();
        }
    }
}
