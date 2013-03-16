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
                string type = "Save ERROR";
                string msg = ex.Message;
                string title = type;
                TraceHelper.LogError(type, ex, this);
                MessageBox.Show(msg, title);
            }
        }

        private void RefreshDatabase()
        {
            try
            {
                int pos = contractSigningBindingSource.Position;

                this.contractSigningTableAdapter.Fill(this.edocbaseDataSet.ContractSigning);
                this.contractComplitionMgrCfmTableAdapter.Fill(this.edocbaseDataSet.ContractComplitionMgrCfm);
                this.contractDoneTableAdapter.Fill(this.edocbaseDataSet.ContractDone);

                this.contractsSigningDataGridView.Refresh();

                contractSigningBindingSource.Position = pos;

            }
            catch (Exception ex)
            {
                string type = "Refresh ERROR";
                string msg = ex.Message;
                string title = type;
                TraceHelper.LogError(type, ex, this);
                MessageBox.Show(msg, title);
            }
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

            int docType = DocGeneratorHelper.GetContractTypeID(contractSigningBindingSource);
            int contract_id = DocGeneratorHelper.GetContractID(contractSigningBindingSource);

            try
            {
                contractGenerator.GenerateDoc(contract_id, docType, (id) =>
                    {
                        //found doc -> update?
                        return MessageBox.Show("Обновить документ для договора #" + id, "Подтвердить обновление документа", MessageBoxButtons.YesNo) == DialogResult.Yes;
                    });

                this.edocbaseDataSet.AcceptChanges();
            }
            catch (NullReferenceException ex)
            {
                string msg = "Ошибка получения данных для заполнения: " + ex.Message;
                string title = "Ошибка";
                string type = "GenerateDoc GetData ERROR";
                TraceHelper.LogError(type, ex, sender);
                MessageBox.Show(msg, title);
            }
            catch (Exception ex)
            {
                string type = "GenerateDoc ERROR";
                string msg = ex.Message;
                string title = type;
                TraceHelper.LogError(type, ex, sender);
                MessageBox.Show(msg, title);
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

            int docType = DocGeneratorHelper.GetContractTypeID(contractSigningBindingSource);
            int contract_id = DocGeneratorHelper.GetContractID(contractSigningBindingSource);

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
                string msg = "Файл заявки отсутствует в БД: " + ex.Message;
                string title = "Отсутствие документа";
                string type = "EditDoc GetData ERROR";
                TraceHelper.LogError(type, ex, sender);
                MessageBox.Show(msg, title);
            }
            catch (Exception ex)
            {
                string type = "EditDoc ERROR";
                string msg = ex.Message;
                string title = type;
                TraceHelper.LogError(type, ex, sender);
                MessageBox.Show(msg, title);
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

            int docType = DocGeneratorHelper.GetContractTypeID(contractSigningBindingSource);
            int contract_id = DocGeneratorHelper.GetContractID(contractSigningBindingSource);

            try
            {
                contractGenerator.SaveDoc(contract_id, docType, saveFileDialog.FileName);
            }
            catch (NullReferenceException ex)
            {
                string msg = "Файл договора отсутствует в БД: " + ex.Message;
                string title = "Отсутствие договора";
                string type = "SaveDoc GetData ERROR";
                TraceHelper.LogError(type, ex, sender);
                MessageBox.Show(msg, title);

            }
            catch (Exception ex)
            {
                string type = "SaveDoc ERROR";
                string msg = ex.Message;
                string title = type;
                TraceHelper.LogError(type, ex, sender);
                MessageBox.Show(msg, title);
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

            int docType = DocGeneratorHelper.GetContractTypeID(contractSigningBindingSource);
            int contract_id = DocGeneratorHelper.GetContractID(contractSigningBindingSource);

            try
            {
                contractGenerator.LoadDoc(contract_id, docType, openFileDialog.FileName);
            }
            catch (NullReferenceException ex)
            {
                string msg = "Ошибка загрузки документа: " + ex.Message;
                string title = "Ошибка";
                string type = "LoadDoc GetData ERROR";
                TraceHelper.LogError(type, ex, sender);
                MessageBox.Show(msg, title);
            }
            catch (Exception ex)
            {
                string type = "LoadDoc ERROR";
                string msg = ex.Message;
                string title = type;
                TraceHelper.LogError(type, ex, sender);
                MessageBox.Show(msg, title);
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
                            string type = "Send save ERROR";
                            string msg = ex.Message;
                            string title = type;
                            TraceHelper.LogError(type, ex, sender);
                            MessageBox.Show(msg, title);
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
                        string type = "Confirm save ERROR";
                        string msg = ex.Message;
                        string title = type;
                        TraceHelper.LogError(type, ex, sender);
                        MessageBox.Show(msg, title); ;
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

            if (e.ColumnIndex == contractDoneDataTableDataGridView.Columns["FinishContractColumn"].Index)
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
                        string type = "Act save ERROR";
                        string msg = ex.Message;
                        string title = type;
                        TraceHelper.LogError(type, ex, sender);
                        MessageBox.Show(msg, title);
                    }
                }
            }

            if (e.ColumnIndex == contractDoneDataTableDataGridView.Columns["ReattSignColumn"].Index)
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
                        string type = "Send save ERROR";
                        string msg = ex.Message;
                        string title = type;
                        TraceHelper.LogError(type, ex, sender);
                        MessageBox.Show(msg, title);
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
                string type = "Act save ERROR";
                string msg = "Ошибка получения данных для заполнения: " + ex.Message;
                string title = "Ошибка";
                TraceHelper.LogError(type, ex, sender);
                MessageBox.Show(msg, title);
            }
            catch (Exception ex)
            {
                string type = "GenerateDocACT ERROR";
                string msg = ex.Message;
                string title = type;
                TraceHelper.LogError(type, ex, sender);
                MessageBox.Show(msg, title);
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
                string type = "EditDocACT GetData ERROR";
                string msg = "Файл акта отсутствует в БД: " + ex.Message;
                string title = "Отсутствие акта";
                TraceHelper.LogError(type, ex, sender);
                MessageBox.Show(msg, title);
            }
            catch (Exception ex)
            {
                string type = "EditDocACT ERROR";
                string msg = ex.Message;
                string title = type;
                TraceHelper.LogError(type, ex, sender);
                MessageBox.Show(msg, title);
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
                string type = "SaveDocACT GetData ERROR";
                string msg = "Файл акта отсутствует в БД: " + ex.Message;
                string title = "Отсутствие акта";
                TraceHelper.LogError(type, ex, sender);
                MessageBox.Show(msg, title);
            }
            catch (Exception ex)
            {
                string type = "SaveDocACT ERROR";
                string msg = ex.Message;
                string title = type;
                TraceHelper.LogError(type, ex, sender);
                MessageBox.Show(msg, title);
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
                string type = "LoadDocACT GetData ERROR";
                string msg = "Ошибка загрузки документа: " + ex.Message;
                string title = "Ошибка";
                TraceHelper.LogError(type, ex, sender);
                MessageBox.Show(msg, title);
            }
            catch (Exception ex)
            {
                string type = "LoadDocACT ERROR";
                string msg = ex.Message;
                string title = type;
                TraceHelper.LogError(type, ex, sender);
                MessageBox.Show(msg, title);
            }

            RefreshDatabase();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if ((contractSigningBindingSource.Position < 0) ||
                (contractSigningBindingSource.Position >= contractSigningBindingSource.Count))
            {
                //contract not selected
                MessageBox.Show("Не выбран договор", "Ошибка");
                return;
            }

            int contract_id = DocGeneratorHelper.GetContractID(contractSigningBindingSource);
            wmgr.ShowDeleteContractForm(contract_id);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            RefreshDatabase();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            RefreshDatabase();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            RefreshDatabase();
        }
    }
}
