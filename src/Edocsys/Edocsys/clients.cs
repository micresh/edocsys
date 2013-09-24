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
            SaveAgents();
            RefreshClients();
        }

        private void SaveAgents()
        {
            try
            {
                this.Validate();
                this.agentsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.edocbaseDataSet);

                this.edocbaseDataSet.AcceptChanges();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {

                if (ex.Number == (int)MySql.Data.MySqlClient.MySqlErrorCode.RowIsReferenced2)
                {
                    string msg = "Невозможно удалить клиента.";

                    string title = "Ошибка удаления";
                    string type = "Delete constrain ERROR";
                    TraceHelper.LogError(type, ex, this);
                    MessageBox.Show(msg, title);
                }
                else
                {
                    throw;
                }

            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                string title = "Save ERROR";
                string type = "Save ERROR";
                TraceHelper.LogError(type, ex, this);
                MessageBox.Show(msg, title);
            }
        }

        private void SaveContacts()
        {
            try
            {
                this.Validate();

                this.agents_contactsBindingSource.EndEdit();
                this.agents_contactsTableAdapter.Update(this.edocbaseDataSet);

                this.edocbaseDataSet.AcceptChanges();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                string title = "Save contacts ERROR";
                string type = "Save contacts ERROR";
                TraceHelper.LogError(type, ex, this);
                MessageBox.Show(msg, title);
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
            SaveContacts();
            RefreshContacts();
        }

        private void agentsBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if ((agentsBindingSource.Position >= 0)
                && (edocbaseDataSet.agents.DefaultView.Count > agentsBindingSource.Position))
            {
                DataRow currentRow = edocbaseDataSet.agents.DefaultView[agentsBindingSource.Position].Row;
                if (currentRow.RowState != DataRowState.Deleted)
                {
                    string agent = String.Format("Контрагент: {0}", Convert.ToString(currentRow["name"]));

                    toolStripLabelAgent.Text = agent;
                }
            }
        }

        private void bindingNavigatorAddNewItem1_Click(object sender, EventArgs e)
        {
            int pos = agentsBindingSource.Position;
            SaveAgents();
            agentsBindingSource.Position = pos;

            DataRowView row = edocbaseDataSet.agents_contacts.DefaultView.AddNew();

            DataRowView currentRow = (DataRowView)agentsBindingSource.Current;

            int idAgent = Convert.ToInt32(currentRow["id"]);

            row["agents_id"] = idAgent;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            DataRowView row = edocbaseDataSet.agents.DefaultView.AddNew();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if ((agentsBindingSource.Position < 0) ||
                (agentsBindingSource.Position >= agentsBindingSource.Count))
            {
                return;
            }

            DataRowView currentRow = (DataRowView)agentsBindingSource.Current;

            int id = Convert.ToInt32(currentRow["id"]);


            if (MessageBox.Show("Удалить контрагента #" + id, "Подтвердить удаление контрагента", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                agentsBindingSource.RemoveCurrent();

                SaveAgents();
                RefreshClients();
            }
        }

        private void bindingNavigatorDeleteItem1_Click(object sender, EventArgs e)
        {
            if ((agents_contactsBindingSource.Position < 0) ||
                (agents_contactsBindingSource.Position >= agents_contactsBindingSource.Count))
            {
                return;
            }

            DataRowView currentRow = (DataRowView)agents_contactsBindingSource.Current;

            int id = Convert.ToInt32(currentRow["id"]);


            if (MessageBox.Show("Удалить контактное лицо #" + id, "Подтвердить удаление контактного лица", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                agents_contactsBindingSource.RemoveCurrent();
                SaveContacts();
                RefreshContacts();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            RefreshClients();
        }

        private void RefreshClients()
        {
            int pos = agentsBindingSource.Position;

            this.agentsTableAdapter.Fill(this.edocbaseDataSet.agents);

            agentsBindingSource.Position = pos;
            
            this.agentsDataGridView.Refresh();
        }

        private void RefreshContacts()
        {
            int pos = agents_contactsBindingSource.Position;

            this.agents_contactsTableAdapter.Fill(this.edocbaseDataSet.agents_contacts);

            agents_contactsBindingSource.Position = pos;
            
            this.agents_contactsDataGridView.Refresh();
        }

        private void toolStripButtonCreateNewContract_Click(object sender, EventArgs e)
        {
            if ((agentsBindingSource.Position < 0) ||
                (agentsBindingSource.Position >= agentsBindingSource.Count))
            {
                return;
            }

            DataRowView currentRow = (DataRowView)agentsBindingSource.Current;

            int id = Convert.ToInt32(currentRow["id"]);


            if (MessageBox.Show("Создать заявку для Контрагента #" + id, "Подтвердить создание заявки", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                wmgr.ShowProporsalForm(id);
            }
            
        }

    }
}
