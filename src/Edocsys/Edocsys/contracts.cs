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

        private void contractsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

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



        private void ContractsForm_Load(object sender, EventArgs e)
        {

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

        private void contractsToStartDataTableDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == contractsToStartDataTableDataGridView.Columns["ProcessTaskColumn"].Index)
            {
                if (contractsToStartDataTableBindingSource.Position >= 0)
                {
                    DataRow currentRow = edocbaseDataSet.Tables["ContractsToStartDataTable"].DefaultView[contractsToStartDataTableBindingSource.Position].Row;
                    int idContract = Convert.ToInt32(currentRow["idContract"]);

                    if (MessageBox.Show("Начать работы по договору #" + idContract, "Подтвердить начало работ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            ////set task processed
                            //this.contractsTableAdapter.ProcessTask((int)Constants.ContractStatuses.TaskProcessed, idContract);

                            ////add executed contract
                            //DateTime now = DateTime.Now;
                            //DateTime nxt = now; ;
                            //nxt = nxt.AddMonths(9);
                            //this.exec_contractsTableAdapter.TaskProcessed(now, nxt, idContract);

                            ////refresh data
                            //UpdateDatabaseAndRefresh();

                         }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Save Error");
                        }
                    }
                }
            }
        }

        private void taskProcessedDataTableDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == taskProcessedDataTableDataGridView.Columns["TaskReadyColumn"].Index)
            {
                if (taskProcessedDataTableBindingSource.Position >= 0)
                {
                    DataRow currentRow = edocbaseDataSet.Tables["TaskProcessedDataTable"].DefaultView[taskProcessedDataTableBindingSource.Position].Row;
                    int idContract = Convert.ToInt32(currentRow["idContract"]);

                    if (MessageBox.Show("Оформить акт договора #" + idContract, "Подтвердить оформление акта", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            ////set task ready
                            //this.contractsTableAdapter.TaskReady((int)Constants.ContractStatuses.TaskReady, idContract);


                            ////refresh data
                            //UpdateDatabaseAndRefresh();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Save Error");
                        }
                    }
                }
            }

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

        private void buttonGenerateContract_Click(object sender, EventArgs e)
        {
            //int docType = GetContractTypeID();
            //GenerateDoc(docType);
        }

        private void buttonEditContract_Click(object sender, EventArgs e)
        {
            //int docType = GetContractTypeID();
            //EditDoc(docType);
        }

    }
}
