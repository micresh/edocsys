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
    public partial class UseradmForm : Form
    {
        public UseradmForm()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.edocbaseDataSet);

        }

        private void UseradmForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'edocbaseDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.edocbaseDataSet.users);

        }

        private void btnUseradd_Click(object sender, EventArgs e)
        {
            usersTableAdapter.Useradd(loginTextBox.Text, psmgr.GetHashString(passwordTextBox.Text), Convert.ToInt32(typeTextBox.Text), log_databaseTextBox.Text);
        }
    }
}
