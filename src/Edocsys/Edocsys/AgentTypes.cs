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
    public partial class AgentTypesForm : Form
    {
        public AgentTypesForm()
        {
            InitializeComponent();
        }

        private void expertsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveExperts();
            RefreshExperts();
        }

        private void SaveExperts()
        {
            try
            {
                this.Validate();
                this.agent_typesBindingSource.EndEdit();
                this.agent_typesTableAdapter.Update(this.edocbaseDataSet.agent_types);

                this.edocbaseDataSet.AcceptChanges();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {

                if (ex.Number == (int)MySql.Data.MySqlClient.MySqlErrorCode.RowIsReferenced2)
                {
                    string msg = "Невозможно удалить используемую форму собственности";

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

        private void RefreshExperts()
        {
            try
            {
                int pos = agent_typesBindingSource.Position;
                this.agent_typesTableAdapter.Fill(this.edocbaseDataSet.agent_types);
                agent_typesBindingSource.Position = pos;
                this.agentTypesDataGridView.Refresh();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                string title = "Refresh ERROR";
                string type = "Refresh ERROR";
                TraceHelper.LogError(type, ex, this);
                MessageBox.Show(msg, title);
            }
        }

        private void AgentTypesForm_Load(object sender, EventArgs e)
        {
            this.agent_typesTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;

            this.agent_typesTableAdapter.Fill(this.edocbaseDataSet.agent_types);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if ((agent_typesBindingSource.Position < 0) ||
                (agent_typesBindingSource.Position >= agent_typesBindingSource.Count))
            {
                return;
            }

            DataRowView currentRow = (DataRowView)agent_typesBindingSource.Current;

            string name = Convert.ToString(currentRow["name"]);

            if (MessageBox.Show("Удалить форму собственности " + name , "Подтвердить удаление формы собственности", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                agent_typesBindingSource.RemoveCurrent();
                SaveExperts();
                RefreshExperts();
            }
        }
    }
}
