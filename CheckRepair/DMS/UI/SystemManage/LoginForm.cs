/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/12/2009 11:16:19 AM
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DMS.DomainObjects;
using DMS.DomainObjects.BasicInfo;

namespace DMS.UI.SystemManage
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string loginName = txtName.Text;
            string password = txtPassword.Text;

            UserInfo userInfo = new UserInfo();
            string message = userInfo.Login(loginName, password);
            if (string.IsNullOrEmpty(message))
            {               
                this.Hide();
                SystemSetForm.Current.ShowDialog();
                this.Close();
            }
            else
            {
                errorProviderUser.SetError(txtPassword, message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this, null);
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.errorProviderUser.Clear();
        }
    }
}
