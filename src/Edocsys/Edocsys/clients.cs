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
    public partial class ClientsForm : Form
    {
        public ClientsForm()
        {
            InitializeComponent();
            formcount=true;
        }
        public static bool formcount = false;
        private void ClientsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            formcount = false;
        }
    }
}
