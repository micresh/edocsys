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
        private FilterHelper agentsFilter;

        public ClientsForm()
        {
            InitializeComponent();
        }

        private void agentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                int pos = agentsBindingSource.Position;
                this.Validate();
                this.agentsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.edocbaseDataSet);

                this.edocbaseDataSet.AcceptChanges();
                this.agentsTableAdapter.Fill(this.edocbaseDataSet.agents);
                this.agentsDataGridView.Refresh();
                agentsBindingSource.Position = pos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save Error");
            }
        }

        private void clients_Load(object sender, EventArgs e)
        {
            this.agentsTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.agent_typesTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.agents_contactsTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;


            this.agentsTableAdapter.Fill(this.edocbaseDataSet.agents);
            this.agent_typesTableAdapter.Fill(this.edocbaseDataSet.agent_types);
            this.agents_contactsTableAdapter.Fill(this.edocbaseDataSet.agents_contacts);

            // create filter with default filter name
            agentsFilter = new FilterHelper(agentsDataGridView, filterToolStripTextBox.TextBox);
        }

        private void toolStripButtonSaveContact_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.agents_contactsBindingSource.EndEdit();
                this.agents_contactsTableAdapter.Update(this.edocbaseDataSet);
               // this.tableAdapterManager.UpdateAll(this.edocbaseDataSet);

                this.edocbaseDataSet.AcceptChanges();
                this.agents_contactsTableAdapter.Fill(this.edocbaseDataSet.agents_contacts);
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
                && (edocbaseDataSet.agents.DefaultView.Count > agentsBindingSource.Position))
            {
                DataRow currentRow = edocbaseDataSet.agents.DefaultView[agentsBindingSource.Position].Row;

                string agent = String.Format("Контрагент: {0}", Convert.ToString(currentRow["name"]));

                toolStripLabelAgent.Text = agent;
            }
        }

        private void bindingNavigatorAddNewItem1_Click(object sender, EventArgs e)
        {
            DataRowView row = edocbaseDataSet.agents_contacts.DefaultView.AddNew();

            DataRow currentRow = edocbaseDataSet.agents.DefaultView[agentsBindingSource.Position].Row;

            int idAgent = Convert.ToInt32(currentRow["id"]);

            row["agents_id"] = idAgent;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            DataRowView row = edocbaseDataSet.agents.DefaultView.AddNew();
        }
    }
}
