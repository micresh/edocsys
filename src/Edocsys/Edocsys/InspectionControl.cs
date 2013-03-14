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

        private void buttonGenerateContract_Click(object sender, EventArgs e)
        {
            if ((inspectionContractsBindingSource.Position < 0) ||
                (inspectionContractsBindingSource.Position >= inspectionContractsBindingSource.Count))
            {
                //contract not selected
                MessageBox.Show("Не выбран договор", "Ошибка");
                return;
            }

            int docType = (int)Constants.ContractTypes.Reattestation;
            int contract_id = DocGeneratorHelper.GetContractID(inspectionContractsBindingSource);

            try
            {
                contractGenerator.GenerateDoc(contract_id, docType, (id) =>
                {
                    //found doc -> update?
                    return MessageBox.Show("Обновить документ для контракта #" + id, "Подтвердить обновление документа", MessageBoxButtons.YesNo) == DialogResult.Yes;
                });
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Ошибка получения данных для заполнения: " + ex.Message, "Ошибка");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "GenerateDoc Error");
            }

            RefreshDatabase();
        }

        private void buttonEditContract_Click(object sender, EventArgs e)
        {
            if ((inspectionContractsBindingSource.Position < 0) ||
                (inspectionContractsBindingSource.Position >= inspectionContractsBindingSource.Count))
            {
                //contract not selected
                MessageBox.Show("Не выбран договор", "Ошибка");
                return;
            }

            int docType = (int)Constants.ContractTypes.Reattestation;
            int contract_id = DocGeneratorHelper.GetContractID(inspectionContractsBindingSource);

            try
            {
                contractGenerator.EditDoc(contract_id, docType, (id) =>
                {
                    //file changed -> update?
                    return MessageBox.Show("Обновить документ договора #" + id, "Подтвердить обновление документа", MessageBoxButtons.YesNo) == DialogResult.Yes;
                });
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Файл заявки отсутствует в БД: " + ex.Message, "Отсутствие заявки");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "EditDoc ERROR");
            }

            RefreshDatabase();
        }

        private void buttonSaveContract_Click(object sender, EventArgs e)
        {
            if ((inspectionContractsBindingSource.Position < 0) ||
                (inspectionContractsBindingSource.Position >= inspectionContractsBindingSource.Count))
            {
                //contract not selected
                MessageBox.Show("Не выбран договор", "Ошибка");
                return;
            }

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            int docType = (int)Constants.ContractTypes.Reattestation;
            int contract_id = DocGeneratorHelper.GetContractID(inspectionContractsBindingSource);

            try
            {
                contractGenerator.SaveDoc(contract_id, docType, saveFileDialog.FileName);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Файл договора отсутствует в БД: " + ex.Message, "Отсутствие договора");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SaveDoc ERROR");
            }

            RefreshDatabase();
        }

        private void buttonLoadContract_Click(object sender, EventArgs e)
        {
            if ((inspectionContractsBindingSource.Position < 0) ||
                (inspectionContractsBindingSource.Position >= inspectionContractsBindingSource.Count))
            {
                //contract not selected
                MessageBox.Show("Не выбран договор", "Ошибка");
                return;
            }

            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            int docType = (int)Constants.ContractTypes.Reattestation;
            int contract_id = DocGeneratorHelper.GetContractID(inspectionContractsBindingSource);

            try
            {
                contractGenerator.SaveDoc(contract_id, docType, openFileDialog.FileName);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Ошибка загрузки документа: " + ex.Message, "Ошибка");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LoadDoc ERROR");
            }

            RefreshDatabase();
        }

        private void toolStripButton6_Click_1(object sender, EventArgs e)
        {
            SaveInspectionControl();
        }

        private void SaveInspectionControl()
        {
            int pos1 = this.inspectionContractsBindingSource.Position;
            int pos2 = this.contractsOnInspectionBindingSource.Position;

            this.Validate();
            this.inspectionContractsBindingSource.EndEdit();
            this.contractsOnInspectionBindingSource.EndEdit();

            this.tableAdapterManager.UpdateAll(this.edocbaseDataSet);

            this.edocbaseDataSet.AcceptChanges();

            this.inspectionContractsBindingSource.Position = pos1;
            this.contractsOnInspectionBindingSource.Position = pos2;
        }

        private void usersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            SaveInspectionControl();
        }

        private void buttonReatt1_Click(object sender, EventArgs e)
        {
            SaveInspectionControl();
        }

        private void buttonReatt2_Click(object sender, EventArgs e)
        {
            SaveInspectionControl();
        }

        private void buttonResert_Click(object sender, EventArgs e)
        {
            SaveInspectionControl();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if ((inspectionContractsBindingSource.Position < 0) ||
                (inspectionContractsBindingSource.Position >= inspectionContractsBindingSource.Count))
            {
                //contract not selected
                MessageBox.Show("Не выбран договор", "Ошибка");
                return;
            }

            int contract_id = DocGeneratorHelper.GetContractID(inspectionContractsBindingSource);
            wmgr.ShowDeleteContractForm(contract_id);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if ((contractsOnInspectionBindingSource.Position < 0) ||
                (contractsOnInspectionBindingSource.Position >= contractsOnInspectionBindingSource.Count))
            {
                //contract not selected
                MessageBox.Show("Не выбран договор", "Ошибка");
                return;
            }

            int contract_id = DocGeneratorHelper.GetContractID(contractsOnInspectionBindingSource);
            wmgr.ShowDeleteContractForm(contract_id);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            RefreshDatabase();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            RefreshDatabase();
        }
    }
}
