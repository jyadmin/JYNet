﻿/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/15/2009 11:37:13 AM
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DMS.Common;
using DMS.UI.Common;
using DMS.DomainObjects.BasicInfo;

namespace DMS.UI.SystemManage.UserManage
{
    public partial class UserMainForm : CRUDListForm
    {
        public UserMainForm()
        {
            InitializeComponent();
        }

        #region override method
        protected override void SetPermissionOfCommands()
        {
            this.SetPermission(new ToolBarCommand[] { this.tbcAdd, this.tbcModify, this.tbcDelete }, new int[] { UserFunctions.AddUser, UserFunctions.EditUser, UserFunctions.DeleteUser });
        }

        protected override void SetSpecialLogicVisible()
        {
            this.SetLogicVisible(new ToolBarCommand[] { this.tbcAdd, this.tbcModify, this.tbcDelete, this.tbcView }, new bool[] { true, true, !((m_CurrentNode as UserInfo).IsDefault == 1), true });
        }

        protected override void BindGridData()
        {
            this.dgMain.DataSource = new SortList(UserInfo.GetList());
            DataGridStyleHelper.SetStyle(this.dgMain, typeof(UserInfo));
            SetRecordsCount((dgMain.DataSource as SortList).Count);
            SetLogic();
        }
        #endregion

        private void UserMainForm_Load(object sender, EventArgs e)
        {
            SetTitle("用户管理");
        }

        #region 事件处理
        protected override void tbcAdd_Commanded(object sender, EventArgs e)
        {
            new AddUserForm().ShowDialog();

            BindGridData();
        }

        protected override void tbcModify_Commanded(object sender, EventArgs e)
        {
            GetSelectNode();

            if (m_CurrentNode == null)
            {
                return;
            }

            new EditUserForm(m_CurrentNode as UserInfo).ShowDialog();

            BindGridData();
        }

        protected override void tbcDelete_Commanded(object sender, EventArgs e)
        {
            GetSelectNode();

            if (m_CurrentNode == null)
            {
                return;
            }

            if (MsgHelper.ShowQuestionMsgBox(string.Format("确定要删除[{0}]吗?", (m_CurrentNode as UserInfo).UserName)) == DialogResult.Yes)
            {
                if ((m_CurrentNode as UserInfo).Delete())
                {
                    MsgHelper.ShowInformationMsgBox("删除用户成功！");
                    m_CurrentNode = null;
                    BindGridData();
                }
                else
                {
                    MsgHelper.ShowInformationMsgBox("删除用户失败！");
                }
            }
        }

        protected override void tbcView_Commanded(object sender, EventArgs e)
        {
            GetSelectNode();

            if (m_CurrentNode == null)
            {
                return;
            }

            new ViewUserForm(m_CurrentNode as UserInfo).ShowDialog();

            BindGridData();
        }
        #endregion
    }
}
