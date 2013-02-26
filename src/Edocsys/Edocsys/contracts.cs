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
    public partial class ContractsForm : Form
    {
        public ContractsForm()
        {
            InitializeComponent();
        }

        private FilterHelper filterContractSigning, filterComplitionManagerConfrim, filterContractDone;
        private DocGeneratorHelper contractGenerator, actGenerator;


        private void ContractsForm_Load(object sender, EventArgs e)
        {
            this.contractSigningTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.contractComplitionMgrCfmTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.contractDoneTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;



            RefreshDatabase();

            //add filters
            filterContractSigning = new FilterHelper(contractsSigningDataGridView, filterContractSigningText.TextBox);
            filterComplitionManagerConfrim = new FilterHelper(contractComplitionManagerConfrimDataGridView, filterComplitionTextBox.TextBox);
            filterContractDone = new FilterHelper(contractDoneDataTableDataGridView, filterContractDoneTextBox.TextBox);

            //doc helper
            contractGenerator = new DocGeneratorHelper(edocbaseDataSet.documents, edocbaseDataSet.doc_templates, edocbaseDataSet.ContractDocData);
            actGenerator = new DocGeneratorHelper(edocbaseDataSet.documents, edocbaseDataSet.doc_templates, edocbaseDataSet.ContractDocData);
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

                this.contractSigningTableAdapter.Fill(this.edocbaseDataSet.ContractSigning);
                this.contractComplitionMgrCfmTableAdapter.Fill(this.edocbaseDataSet.ContractComplitionMgrCfm);
                this.contractDoneTableAdapter.Fill(this.edocbaseDataSet.ContractDone);

                this.contractsSigningDataGridView.Refresh();
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

            DataRow currentRow = edocbaseDataSet.ContractSigning.DefaultView[contractSigningBindingSource.Position].Row;

            id = Convert.ToInt32(currentRow["contract_types_id"]);

            return id;
        }

        private int GetContractID()
        {
            int id = -1;

            DataRow currentRow = edocbaseDataSet.ContractSigning.DefaultView[contractSigningBindingSource.Position].Row;

            id = Convert.ToInt32(currentRow["id"]);

            return id;
        }

        private void buttonGenerateContract_Click(object sender, EventArgs e)
        {
            if ((contractSigningBindingSource.Position < 0) ||
                (contractSigningBindingSource.Position >= contractSigningBindingSource.Count))
            {
                //contract not selected
                MessageBox.Show("Не выбран договор", "Ошибка");
                return;
            }

            int docType = GetContractTypeID();
            int contract_id = GetContractID();

            try
            {
                contractGenerator.GenerateDoc(contract_id, docType, (id) =>
                    {
                        //found doc -> update?
                        return MessageBox.Show("Обновить документ для договора #" + id, "Подтвердить обновление документа", MessageBoxButtons.YesNo) == DialogResult.Yes;
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

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            //this.contractSigningBindingSource.EndEdit();
            //this.contractSigningTableAdapter.Update(this.edocbaseDataSet.ContractSigning);

            this.edocbaseDataSet.AcceptChanges();

            RefreshDatabase();
        }

        private void buttonEditContract_Click(object sender, EventArgs e)
        {
            if ((contractSigningBindingSource.Position < 0) ||
                (contractSigningBindingSource.Position >= contractSigningBindingSource.Count))
            {
                //contract not selected
                MessageBox.Show("Не выбран договор", "Ошибка");
                return;
            }

            int docType = GetContractTypeID();
            int contract_id = GetContractID();

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
            if ((contractSigningBindingSource.Position < 0) ||
                (contractSigningBindingSource.Position >= contractSigningBindingSource.Count))
            {
                //contract not selected
                MessageBox.Show("Не выбран договор", "Ошибка");
                return;
            }

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            int docType = GetContractTypeID();
            int contract_id = GetContractID();

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
            if ((contractSigningBindingSource.Position < 0) ||
                (contractSigningBindingSource.Position >= contractSigningBindingSource.Count))
            {
                //contract not selected
                MessageBox.Show("Не выбран договор", "Ошибка");
                return;
            }

            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            int docType = GetContractTypeID();
            int contract_id = GetContractID();

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

        private void contractsSigningDataTableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == contractsSigningDataGridView.Columns["SignContractColumn"].Index)
            {
                if (contractSigningBindingSource.Position >= 0)
                {
                    DataRow currentRow = edocbaseDataSet.ContractSigning.DefaultView[contractSigningBindingSource.Position].Row;
                    int idContract = Convert.ToInt32(currentRow["id"]);

                    if (MessageBox.Show("Подтвердить подписание договора #" + idContract, "Подписание договора", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            //set task finished
                            this.contractSigningTableAdapter.ConfirmSigning((int)Constants.ContractStatuses.PrepareForWork, idContract);

                            //refresh data
                            UpdateDatabase();
                            RefreshDatabase();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Save Error");
                        }
                    }
                }
            }

            RefreshDatabase();
        }

        private void contractComplitionManagerConfrimDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == contractComplitionManagerConfrimDataGridView.Columns["ConfirmTaskFinishedColumn"].Index)
            {
                if ((contractComplitionMgrCfmBindingSource.Position < 0) ||
                    (contractComplitionMgrCfmBindingSource.Position >= contractComplitionMgrCfmBindingSource.Count))
                {
                    //contract not selected
                    MessageBox.Show("Не выбран договор", "Ошибка");
                    return;
                }

                DataRow currentRow = edocbaseDataSet.ContractComplitionMgrCfm.DefaultView[contractComplitionMgrCfmBindingSource.Position].Row;
                int idContract = Convert.ToInt32(currentRow["id"]);

                if (MessageBox.Show("Подтвердить выполнение договора #" + idContract, "Подтвердить выполнение работ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        //set task finished
                        this.contractComplitionMgrCfmTableAdapter.ConfirmFinished((int)Constants.ContractStatuses.ComplitionAgentConfrim, idContract);

                        //refresh data
                        UpdateDatabase();
                        RefreshDatabase();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Save Error");
                    }
                }
            }
        }

        private void contractDoneDataTableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((contractDoneBindingSource.Position < 0) ||
                (contractDoneBindingSource.Position >= contractDoneBindingSource.Count))
            {
                //contract not selected
                MessageBox.Show("Не выбран договор", "Ошибка");
                return;
            }

            DataRow currentRow = edocbaseDataSet.ContractDone.DefaultView[contractDoneBindingSource.Position].Row;
            int idContract = Convert.ToInt32(currentRow["id"]);

            if (e.ColumnIndex == contractComplitionManagerConfrimDataGridView.Columns["FinishContractColumn"].Index)
            {

                if (MessageBox.Show("Подтвердить оформление акта и завершение договора #" + idContract, "Подтвердить завершение работ по договору", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        //set task finished
                        this.contractDoneTableAdapter.ConfirmContractDone((int)Constants.ContractStatuses.FinishedTasks, idContract);

                        UpdateDatabase();
                        RefreshDatabase();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Save Error");
                    }
                }
            }

            if (e.ColumnIndex == contractComplitionManagerConfrimDataGridView.Columns["ReattSignColumn"].Index)
            {
                if (MessageBox.Show("Подтвердить направление договора #" + idContract + " на инспекционный контроль", "Подтвердить инспекционный контроль по договору", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        this.contractDoneTableAdapter.SendContractToInspectionControl((int)Constants.ContractStatuses.ReattestationSign, idContract);
                        UpdateDatabase();
                        RefreshDatabase();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Save Error");
                    }
                }
            }
        }

        private int GetActContractID()
        {
            int id = -1;

            DataRow currentRow = edocbaseDataSet.ContractDone.DefaultView[contractDoneBindingSource.Position].Row;

            id = Convert.ToInt32(currentRow["id"]);

            return id;
        }

        private void buttonGenerateAct_Click(object sender, EventArgs e)
        {
            if ((contractDoneBindingSource.Position < 0) ||
                (contractDoneBindingSource.Position >= contractDoneBindingSource.Count))
            {
                //contract not selected
                MessageBox.Show("Не выбран договор", "Ошибка");
                return;
            }

            int docType = (int)Constants.ContractTypes.Act;
            int contract_id = GetActContractID();

            try
            {
                actGenerator.GenerateDoc(contract_id, docType, (id) =>
                {
                    //found doc -> update?
                    return MessageBox.Show("Обновить документ для акта #" + id, "Подтвердить обновление документа", MessageBoxButtons.YesNo) == DialogResult.Yes;
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

        private void buttonEditAct_Click(object sender, EventArgs e)
        {
            if ((contractDoneBindingSource.Position < 0) ||
                (contractDoneBindingSource.Position >= contractDoneBindingSource.Count))
            {
                //contract not selected
                MessageBox.Show("Не выбран договор", "Ошибка");
                return;
            }

            int docType = (int)Constants.ContractTypes.Act;
            int contract_id = GetActContractID();

            try
            {
                actGenerator.EditDoc(contract_id, docType, (id) =>
                {
                    //file changed -> update?
                    return MessageBox.Show("Обновить документ для акта #" + id, "Подтвердить обновление документа", MessageBoxButtons.YesNo) == DialogResult.Yes;
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

        private void buttonSaveAct_Click(object sender, EventArgs e)
        {
            if ((contractDoneBindingSource.Position < 0) ||
                (contractDoneBindingSource.Position >= contractDoneBindingSource.Count))
            {
                //contract not selected
                MessageBox.Show("Не выбран договор", "Ошибка");
                return;
            }

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            int docType = (int)Constants.ContractTypes.Act;
            int contract_id = GetActContractID();

            try
            {
                actGenerator.SaveDoc(contract_id, docType, saveFileDialog.FileName);
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

        private void buttonLoadAct_Click(object sender, EventArgs e)
        {
            if ((contractDoneBindingSource.Position < 0) ||
                (contractDoneBindingSource.Position >= contractDoneBindingSource.Count))
            {
                //contract not selected
                MessageBox.Show("Не выбран договор", "Ошибка");
                return;
            }

            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            int docType = (int)Constants.ContractTypes.Act;
            int contract_id = GetActContractID();

            try
            {
                actGenerator.SaveDoc(contract_id, docType, openFileDialog.FileName);
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
    }
}
