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
    public partial class DocTemplatesForm : Form
    {
        public DocTemplatesForm()
        {
            InitializeComponent();
        }

        private void contractsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void DocTemplatesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'edocbaseDataSet.ContractTypes' table. You can move, or remove it, as needed.
            this.contractTypesTableAdapter.Fill(this.edocbaseDataSet.ContractTypes);
        }
    }
}
