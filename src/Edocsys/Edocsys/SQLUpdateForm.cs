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
    public partial class SQLUpdateForm : Form
    {
        public SQLUpdateForm()
        {
            InitializeComponent();
        }
        
        public void InitProgressBar(int value)
        {
            progressBarSQL.Minimum = 0;
            progressBarSQL.Maximum = value;
        }

        public void SetProgressBarValue(int value)
        {
            progressBarSQL.Value = value;
        }
    }
}
