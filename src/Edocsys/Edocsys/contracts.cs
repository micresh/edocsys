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

        private FilterHelper filterContractSigning, filterPrepareForWork, filterInWork;
        private DocGeneratorHelper contractGenerator;


        private void ContractsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'edocbaseDataSet.ContractInWork' table. You can move, or remove it, as needed.
            this.contractInWorkTableAdapter.Fill(this.edocbaseDataSet.ContractInWork);

            this.contractSigningTableAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;
            this.contractPrepareForWorkTAdapter.Connection.ConnectionString = ConnectionManager.ConnectionString;



            RefreshDatabase();

            //add filters
            filterContractSigning = new FilterHelper(contractsSigningDataGridView, filterContractSigningText.TextBox);
            filterPrepareForWork = new FilterHelper(contractPrepareForWorkDataGridView, filterPrepareForWorkTextBox.TextBox);
            filterInWork = new FilterHelper(contractInWorkDataGridView, filterInWorkTextBox.TextBox);


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

                this.contractSigningTableAdapter.Fill(this.edocbaseDataSet.ContractSigning);
                this.contractPrepareForWorkTAdapter.Fill(this.edocbaseDataSet.ContractPrepareForWork);

                this.contractPrepareForWorkDataGridView.Refresh();

                this.contractsSigningDataGridView.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Refresh Error");
            }
            /**/
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

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contractSigningBindingSource.EndEdit();
            this.contractSigningTableAdapter.Update(this.edocbaseDataSet.ContractSigning);

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

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contractPrepareForWorkBindingSource.EndEdit();
            this.contractPrepareForWorkTAdapter.Update(this.edocbaseDataSet.ContractPrepareForWork);

            this.edocbaseDataSet.AcceptChanges();

            RefreshDatabase();
        }

        private void contractPrepareForWorkDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == contractPrepareForWorkDataGridView.Columns["StartWorkColumn"].Index)
            {
                if ((contractPrepareForWorkBindingSource.Position < 0) ||
                    (contractPrepareForWorkBindingSource.Position >= contractPrepareForWorkBindingSource.Count))
                {
                    //contract not selected
                    MessageBox.Show("Не выбран договор", "Ошибка");
                    return;
                }

                DataRow currentRow = edocbaseDataSet.ContractPrepareForWork.DefaultView[contractPrepareForWorkBindingSource.Position].Row;
                int idContract = Convert.ToInt32(currentRow["id"]);

                if (MessageBox.Show("Начать работы по договору #" + idContract, "Подтвердить начало работ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        //set task processed
                        this.contractPrepareForWorkTAdapter.StartWork((int)Constants.ContractStatuses.InWork, idContract);

                        ////add executed contract
                        //DateTime now = DateTime.Now;
                        //DateTime nxt = now; ;
                        //nxt = nxt.AddMonths(9);


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

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contractInWorkBindingSource.EndEdit();
            //this.contractInWorkTableAdapter.Update(this.edocbaseDataSet.ContractInWork);

            this.edocbaseDataSet.AcceptChanges();

            RefreshDatabase();
        }

        private void contractInWorkDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == contractInWorkDataGridView.Columns["WorkDoneColumn"].Index)
            {
                if ((contractInWorkBindingSource.Position < 0) ||
                    (contractInWorkBindingSource.Position >= contractInWorkBindingSource.Count))
                {
                    //contract not selected
                    MessageBox.Show("Не выбран договор", "Ошибка");
                    return;
                }

                DataRow currentRow = edocbaseDataSet.ContractInWork.DefaultView[contractInWorkBindingSource.Position].Row;
                int idContract = Convert.ToInt32(currentRow["id"]);

                //if (MessageBox.Show("Подтвердить выполнение договора #" + idContract, "Подтвердить выполнение работ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                if (MessageBox.Show("Подтвердить завершение работ по договору #" + idContract, "Подтвердить завершение работ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        //set task finished
                        this.contractInWorkTableAdapter.WorkDone((int)Constants.ContractStatuses.ComplitionManagerConfrim, idContract);

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
    }
}
