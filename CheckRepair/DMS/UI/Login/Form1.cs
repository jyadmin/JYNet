using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TX.Framework.WindowUI.Forms;
using System.Configuration;
using System.Data.SqlClient;
using MainPage;
using System.Threading;
using DMS.DomainObjects.BasicInfo;
using DMS.DomainObjects;

namespace Login
{
    public partial class Form1 : MainForm
    {
       
        public Form1()
        {
                     
            InitializeComponent();
            
            
        }

        private void txButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txButton1_Click(object sender, EventArgs e)
        {

            string loginName = txTextBox1.Text;
            string password = txTextBox2.Text;

            UserInfo userInfo = new UserInfo();
            string message = userInfo.Login(loginName, password);
            if (string.IsNullOrEmpty(message))
            {
                this.Hide();
                string connstr = ConfigurationManager.AppSettings["strCon"];
                SqlConnection conn = new SqlConnection(connstr);
                Thread th = new Thread(fun => { Application.Run(new MainPage.MainPage(loginName, conn)); });
                th.Start();
                this.Close();
            }
            else
            {
                //errorProviderUser.SetError(password, message);
                //MessageBox.Show("登录错误");
                this.Error(message);
            }
        }

        private void txTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//如果输入的是回车键  
            {
                this.txButton1_Click(sender, e);//触发button事件  
            } 
        }

    }
}
