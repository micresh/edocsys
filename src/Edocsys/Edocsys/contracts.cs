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

        private FilterHelper filterContractSigning;
        private DocGeneratorHelper contractGenerator;


        private void ContractsForm_Load(object sender, EventArgs e)
        {

            this.contractSigningTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;

            this.contractSigningTableAdapter.Fill(this.edocbaseDataSet.ContractSigning);


            //add filters
            filterContractSigning = new FilterHelper(contractsSigningDataTableDataGridView, filterContractSigningText.TextBox);


            //doc helper
            contractGenerator = new DocGeneratorHelper(edocbaseDataSet.documents, edocbaseDataSet.doc_templates, edocbaseDataSet.ContractDocData);


            //this.exec_contractsTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            //this.contractsTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;

            //this.contractsToStartDataTableTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            //this.taskFinishedDataTableTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            //this.taskReadyDataTableTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            //this.taskProcessedDataTableTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            //this.badJobsDataTableTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;


            //this.exec_contractsTableAdapter.Fill(this.edocbaseDataSet.Exec_contracts);
            //this.contractsTableAdapter.Fill(this.edocbaseDataSet.Contracts);
            
            //this.contractsToStartDataTableTableAdapter.Fill(this.edocbaseDataSet.ContractsToStartDataTable);
            //this.badJobsDataTableTableAdapter.Fill(this.edocbaseDataSet.BadJobsDataTable);
            //this.taskFinishedDataTableTableAdapter.Fill(this.edocbaseDataSet.TaskFinishedDataTable);
            //this.taskReadyDataTableTableAdapter.Fill(this.edocbaseDataSet.TaskReadyDataTable);
            //this.taskProcessedDataTableTableAdapter.Fill(this.edocbaseDataSet.TaskProcessedDataTable);
        }


        private void UpdateDatabaseAndRefresh()
        {
            try
            {
                //this.Validate();

                //this.tableAdapterManager.UpdateAll(this.edocbaseDataSet);

                //this.edocbaseDataSet.AcceptChanges();


                //this.exec_contractsTableAdapter.Fill(this.edocbaseDataSet.Exec_contracts);
                //this.contractsTableAdapter.Fill(this.edocbaseDataSet.Contracts);

                //this.contractsToStartDataTableTableAdapter.Fill(this.edocbaseDataSet.ContractsToStartDataTable);
                //this.badJobsDataTableTableAdapter.Fill(this.edocbaseDataSet.BadJobsDataTable);
                //this.taskFinishedDataTableTableAdapter.Fill(this.edocbaseDataSet.TaskFinishedDataTable);
                //this.taskReadyDataTableTableAdapter.Fill(this.edocbaseDataSet.TaskReadyDataTable);
                //this.taskProcessedDataTableTableAdapter.Fill(this.edocbaseDataSet.TaskProcessedDataTable);


                //this.contractsToStartDataTableDataGridView.Refresh();
                //this.badJobsDataTableDataGridView.Refresh();
                //this.taskFinishedDataTableDataGridView.Refresh();
                //this.taskReadyDataTableDataGridView.Refresh();
                //this.taskProcessedDataTableDataGridView.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save Error");
            }
            /**/
        }
        private void contractsToStartDataTableDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == contractsWaitingDataTableDataGridView.Columns["ProcessTaskColumn"].Index)
            //{
            //    if (contractsToStartDataTableBindingSource.Position >= 0)
            //    {
            //        DataRow currentRow = edocbaseDataSet.Tables["ContractsToStartDataTable"].DefaultView[contractsToStartDataTableBindingSource.Position].Row;
            //        int idContract = Convert.ToInt32(currentRow["idContract"]);

            //        if (MessageBox.Show("Начать работы по договору #" + idContract, "Подтвердить начало работ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //        {
            //            try
            //            {
            //                ////set task processed
            //                //this.contractsTableAdapter.ProcessTask((int)Constants.ContractStatuses.TaskProcessed, idContract);

            //                ////add executed contract
            //                //DateTime now = DateTime.Now;
            //                //DateTime nxt = now; ;
            //                //nxt = nxt.AddMonths(9);
            //                //this.exec_contractsTableAdapter.TaskProcessed(now, nxt, idContract);

            //                ////refresh data
            //                //UpdateDatabaseAndRefresh();

            //             }
            //            catch (Exception ex)
            //            {
            //                MessageBox.Show(ex.Message, "Save Error");
            //            }
            //        }
            //    }
            //}
        }

        private void taskProcessedDataTableDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == taskProcessedDataTableDataGridView.Columns["TaskReadyColumn"].Index)
            //{
            //    if (taskProcessedDataTableBindingSource.Position >= 0)
            //    {
            //        DataRow currentRow = edocbaseDataSet.Tables["TaskProcessedDataTable"].DefaultView[taskProcessedDataTableBindingSource.Position].Row;
            //        int idContract = Convert.ToInt32(currentRow["idContract"]);

            //        if (MessageBox.Show("Оформить акт договора #" + idContract, "Подтвердить оформление акта", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //        {
            //            try
            //            {
            //                ////set task ready
            //                //this.contractsTableAdapter.TaskReady((int)Constants.ContractStatuses.TaskReady, idContract);


            //                ////refresh data
            //                //UpdateDatabaseAndRefresh();

            //            }
            //            catch (Exception ex)
            //            {
            //                MessageBox.Show(ex.Message, "Save Error");
            //            }
            //        }
            //    }
            //}

        }

        private void taskReadyDataTableDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == taskReadyDataTableDataGridView.Columns["ConfirmTaskFinishedColumn"].Index)
            //{
            //    if (taskReadyDataTableBindingSource.Position >= 0)
            //    {
            //        DataRow currentRow = edocbaseDataSet.Tables["TaskReadyDataTable"].DefaultView[taskReadyDataTableBindingSource.Position].Row;
            //        int idContract = Convert.ToInt32(currentRow["idContract"]);

            //        if (MessageBox.Show("Подтвердить выполнение договора #" + idContract, "Подтвердить выполнение работ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //        {
            //            try
            //            {
            //                //set task finished
            //                this.contractsTableAdapter.TaskFinished((int)Constants.ContractStatuses.TaskFinished, idContract);

            //                //refresh data
            //                UpdateDatabaseAndRefresh();
            //            }
            //            catch (Exception ex)
            //            {
            //                MessageBox.Show(ex.Message, "Save Error");
            //            }
            //        }
            //    }
            //}
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
                MessageBox.Show("Не выбрана заявка", "Ошибка");
                return;
            }

            int docType = GetContractTypeID();
            int contract_id = GetContractID();

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
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contractSigningBindingSource.EndEdit();
            this.contractSigningTableAdapter.Update(this.edocbaseDataSet.ContractSigning);

            this.edocbaseDataSet.AcceptChanges();
        }

        private void buttonEditContract_Click(object sender, EventArgs e)
        {
            if ((contractSigningBindingSource.Position < 0) ||
                (contractSigningBindingSource.Position >= contractSigningBindingSource.Count))
            {
                //contract not selected
                MessageBox.Show("Не выбрана заявка", "Ошибка");
                return;
            }

            int docType = GetContractTypeID();
            int contract_id = GetContractID();

            try
            {
                contractGenerator.EditDoc(contract_id, docType, (id) =>
                {
                    //file changed -> update?
                    return MessageBox.Show("Обновить документ для заявки #" + id, "Подтвердить обновление документа", MessageBoxButtons.YesNo) == DialogResult.Yes;
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

        }

        private void buttonSaveContract_Click(object sender, EventArgs e)
        {
            if ((contractSigningBindingSource.Position < 0) ||
                (contractSigningBindingSource.Position >= contractSigningBindingSource.Count))
            {
                //contract not selected
                MessageBox.Show("Не выбрана заявка", "Ошибка");
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
        }

        private void buttonLoadContract_Click(object sender, EventArgs e)
        {
            if ((contractSigningBindingSource.Position < 0) ||
                (contractSigningBindingSource.Position >= contractSigningBindingSource.Count))
            {
                //contract not selected
                MessageBox.Show("Не выбрана заявка", "Ошибка");
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
        }

        private void contractsSigningDataTableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == contractsSigningDataTableDataGridView.Columns["SignContractColumn"].Index)
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
                            UpdateDatabaseAndRefresh();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Save Error");
                        }
                    }
                }
            }
        }
    }
}
