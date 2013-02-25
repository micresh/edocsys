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
    public partial class InspectionControlForm : Form
    {
        public InspectionControlForm()
        {
            InitializeComponent();
        }

        private DocGeneratorHelper contractGenerator;
        private FilterHelper filterInspection, filterOnInspection;


        private void ContractsForm_Load(object sender, EventArgs e)
        {

            this.contractsOnInspectionTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.inspectionContractsTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;

            RefreshDatabase();

            //
            filterInspection = new FilterHelper(inspectionContractsDataGridView, filterInspectionContractsTextBox.TextBox);
            filterOnInspection = new FilterHelper(contractsOnInspectionDataGridView, filterInspectionContractsTextBox.TextBox);

            //doc helper
            contractGenerator = new DocGeneratorHelper(edocbaseDataSet.documents, edocbaseDataSet.doc_templates, edocbaseDataSet.ContractDocData);

        }


        private void UpdateDatabase()
        {
            try
            {
                this.Validate();

                this.tableAdapterManager.UpdateAll(this.edocbaseDataSet);

                this.edocbaseDataSet.AcceptChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save Error");
            }
            /**/
        }

        private void RefreshDatabase()
        {
            try
            {
                this.contractsOnInspectionTableAdapter.Fill(this.edocbaseDataSet.ContractsOnInspection);
                this.inspectionContractsTableAdapter.Fill(this.edocbaseDataSet.InspectionContracts);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Refresh Error");
            }
            /**/
        }

        private int GetContractTypeID()
        {
            int id = -1;

            DataRow currentRow = edocbaseDataSet.InspectionContracts.DefaultView[inspectionContractsBindingSource.Position].Row;

            id = Convert.ToInt32(currentRow["contract_types_id"]);

            return id;
        }

        private int GetContractID()
        {
            int id = -1;

            DataRow currentRow = edocbaseDataSet.ContractSigning.DefaultView[inspectionContractsBindingSource.Position].Row;

            id = Convert.ToInt32(currentRow["id"]);

            return id;
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inspectionContractsBindingSource.EndEdit();
            //this.contractSigningTableAdapter.Update(this.edocbaseDataSet.ContractSigning);

            this.edocbaseDataSet.AcceptChanges();

            RefreshDatabase();
        }


        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            this.Validate();
            //this.contractPrepareForWorkBindingSource.EndEdit();
            //this.contractPrepareForWorkTAdapter.Update(this.edocbaseDataSet.ContractPrepareForWork);

            this.edocbaseDataSet.AcceptChanges();

            RefreshDatabase();
        }


        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.Validate();
            //this.contractInWorkBindingSource.EndEdit();
            //this.contractInWorkTableAdapter.Update(this.edocbaseDataSet.ContractInWork);

            this.edocbaseDataSet.AcceptChanges();

            RefreshDatabase();
        }

        private void date_real_reatt_1Label_Click(object sender, EventArgs e)
        {

        }

        private void date_real_reatt_1DateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void date_real_reatt_2Label_Click(object sender, EventArgs e)
        {

        }

        private void date_real_reatt_2DateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void date_real_resertLabel_Click(object sender, EventArgs e)
        {

        }

        private void date_real_resertDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonResert_Click(object sender, EventArgs e)
        {

        }

        private void buttonReatt2_Click(object sender, EventArgs e)
        {

        }

        private void buttonReatt1_Click(object sender, EventArgs e)
        {

        }
    }
}
