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
    public partial class SetPasswordForm : Form
    {
        public SetPasswordForm(Form parent)
        {
            this.parent = (UseradmForm)parent;

            InitializeComponent();
        }
        private UseradmForm parent;

        private void SetPasswordForm_Load(object sender, EventArgs e)
        {
            textBoxPassword.Text = parent.password;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            parent.password = textBoxPassword.Text;
        }
    }
}
