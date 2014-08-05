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
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void buttonSaveConfig_Click(object sender, EventArgs e)
        {
            global::Edocsys.Properties.Settings.Default.Save();
            global::Edocsys.Properties.Settings.Default.Reload();

            //reload connection data
            ConnectionManager.ResetToDefaults();

            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            global::Edocsys.Properties.Settings.Default.Reload();

            this.Close();
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonResetToDefaults_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Сборосить настройки в начальное состояние?", "Сборос настроек", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                global::Edocsys.Properties.Settings.Default.Reset();
            }
        }

        private void buttonTestConnection_Click(object sender, EventArgs e)
        {
            // here we're trying connecting to database
            if (ConnectionManager.TestConnection(textBoxHost.Text, textBoxPort.Text))
            {
                MessageBox.Show("Соединение успешено установлено.");
            }
            else
                MessageBox.Show("Не удалось выполнить подключение к базе данных.");
        }
    }
}
