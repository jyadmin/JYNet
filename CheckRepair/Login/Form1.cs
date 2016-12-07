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

namespace Login
{
    public partial class Form1 : MainForm
    {
        public Form1()
        {
                     
            InitializeComponent();
            //SSS短短的
            
        }

        private void txButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txButton1_Click(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                string connstr = ConfigurationManager.AppSettings["strCon"];  
                SqlConnection conn = new SqlConnection(connstr);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                string username = txTextBox1.Text.ToString();
                string password = txTextBox2.Text.ToString();
                string selectSql = "select password from C_DMS_User where  loginname = '" + username + "'";
                cmd.CommandText = selectSql;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    msg = reader.GetString(0);
                   
                }
                else
                {
                    msg = "未查询到数据";
                }
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }

            this.Info(msg);

        }
    }
}
