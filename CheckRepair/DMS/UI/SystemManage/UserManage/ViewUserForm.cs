/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/17/2009 8:25:47 PM
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DMS.DomainObjects.BasicInfo;
using DMS.UI.Common;

namespace DMS.UI.SystemManage.UserManage
{
    public partial class ViewUserForm : UserFormBase
    {
        public ViewUserForm(UserInfo userInfo)
        {
            m_UserInfo = userInfo;
            InitializeComponent();
        }


        private void ViewUserForm_Load(object sender, System.EventArgs e)
        {
            SetTitle("用户详细");
            SetUserToForm();
            SetReadonlyControl();
        }
    }
}
