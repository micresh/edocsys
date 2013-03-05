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
    public partial class DeleteContractForm : Form
    {
        public DeleteContractForm()
        {
            InitializeComponent();
        }

        public int contract_id;

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBadJobByAgent_Click(object sender, EventArgs e)
        {

        }
    }
}
