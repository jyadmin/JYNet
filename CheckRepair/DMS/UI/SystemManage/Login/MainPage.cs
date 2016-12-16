using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TX.Framework.WindowUI.Forms;
using DMS;
using System.Threading;
using System.Data.SqlClient;

namespace MainPage
{
    public partial class MainPage : MainForm
    {
        public string userName = "";
        public SqlConnection conn;

        public MainPage(string userName, SqlConnection conn)
        {
            InitializeComponent();
            this.userName = userName;
            this.conn = conn;
            label1.Text = "欢迎你，" + userName;
           
        }

       
        private void button_Click(object sender, EventArgs e)
        {
            //判断按钮编号
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "SystemSettings":
                    //Thread th = new Thread(fun => { Application.Run(new DMS.UI.SystemSetForm()); });
                    //th.Start();
                    DMS.UI.SystemSetForm.Current.ShowDialog();
                   break;
                case "AssignTask":
                   MessageBox.Show("AssignTask");
                   break;
            }
        }
    }
}
