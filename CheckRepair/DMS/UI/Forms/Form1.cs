using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DMS.UI.Forms
{
    public partial class Form1 : TX.Framework.WindowUI.Forms.BaseForm
    {
        private string Status = "0";
        public Form1(string status)
        {
            InitializeComponent();
            Status = status;
            if (status == "1")
            {
                txButtonComplete.Enabled = false;
            }
        }

        private void txButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            if (true)
            {

                DMS.UI.TaskDetail.TaskDetailForm.isFinished = 1;
            }
        }
    }
}
