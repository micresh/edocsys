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
            if (MessageBox.Show("Расторгнуть контракт #" + contract_id, "Подтвердить расторжение контракта", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    //send proposal to Expert Assignment
                    this.contractsTableAdapter.CancelContract((int)Constants.ContractStatuses.BadJobByAgent, contract_id);

                    this.edocbaseDataSet.AcceptChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Save Error");
                }
                this.Close();
            }
        }

        private void DeleteContractForm_Load(object sender, EventArgs e)
        {
            this.contractsTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
        }

        private void buttonBadJobByExpert_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Расторгнуть контракт #" + contract_id, "Подтвердить расторжение контракта", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    //send proposal to Expert Assignment
                    this.contractsTableAdapter.CancelContract((int)Constants.ContractStatuses.BadJobByExpert, contract_id);

                    this.edocbaseDataSet.AcceptChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Save Error");
                }
                this.Close();
            }

        }
    }
}
