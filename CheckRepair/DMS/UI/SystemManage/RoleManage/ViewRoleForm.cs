/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/19/2009 10:48:49 AM
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

namespace DMS.UI.SystemManage.RoleManage
{
    public partial class ViewRoleForm : RoleFormBase
    {
        public ViewRoleForm(Role role)
        {
            InitializeComponent();
            m_Role = role;
            m_Role.Retrieve(role.ID);
        }

        private void ViewRoleForm_Load(object sender, EventArgs e)
        {
            SetTitle("角色详细");
            SetRoleToForm();            
            SetReadonlyControl();
        }
    }
}
