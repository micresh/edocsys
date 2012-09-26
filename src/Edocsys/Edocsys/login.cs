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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            formcount = true;
        }
        public static bool formcount = false;

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            formcount = false;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'issl1DataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.issl1DataSet.users);

        }
    }
}
