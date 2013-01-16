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
    public partial class ClientsForm : Form
    {
        public ClientsForm()
        {
            InitializeComponent();
        }

        private void agentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {

                this.Validate();
                this.agentsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.edocbaseDataSet);

                this.edocbaseDataSet.AcceptChanges();
                this.agentsTableAdapter.FillShortInfo(this.edocbaseDataSet.Agents);
                this.agentsDataGridView.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save Error");
            }
        }

        private void clients_Load(object sender, EventArgs e)
        {
            this.agentsTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.agents_typesTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.agents_contactsTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;

            this.agentsTableAdapter.FillShortInfo(this.edocbaseDataSet.Agents);
            this.agents_typesTableAdapter.Fill(this.edocbaseDataSet.Agents_types);
            this.agents_contactsTableAdapter.Fill(this.edocbaseDataSet.Agents_contacts);
        }

        private void toolStripButtonSaveContact_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow currentRow = edocbaseDataSet.Tables["Agents"].DefaultView[agentsBindingSource.Position].Row;

                int idAgent = Convert.ToInt32(currentRow["idAgents"]);
                agents_contactsDataGridView.CurrentRow.Cells["ac_agent_id"].Value = idAgent;


                this.Validate();
                this.agents_contactsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.edocbaseDataSet);

                this.edocbaseDataSet.AcceptChanges();
                this.agents_contactsTableAdapter.Fill(this.edocbaseDataSet.Agents_contacts);
                this.agents_contactsDataGridView.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save Error");
            }
        }

        private void agentsBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if ((agentsBindingSource.Position >= 0)
                && (edocbaseDataSet.Tables["Agents"].DefaultView.Count > agentsBindingSource.Position))
            {
                DataRow currentRow = edocbaseDataSet.Tables["Agents"].DefaultView[agentsBindingSource.Position].Row;

                string agent = String.Format("Контрагент: {0}", Convert.ToString(currentRow["Ag_name"]));

                toolStripLabelAgent.Text = agent;
            }
        }
    }
}
