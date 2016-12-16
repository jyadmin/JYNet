/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/19/2009 10:47:36 AM
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
using DMS.DomainObjects.BasicInfo;
using DMS.UI.Common;

namespace DMS.UI.SystemManage.RoleManage
{
    public partial class RoleMainForm : CRUDListForm
    {
        public RoleMainForm()
        {
            InitializeComponent();
        }

        #region override method
        protected override void SetPermissionOfCommands()
        {
            this.SetPermission(new ToolBarCommand[] { this.tbcAdd, this.tbcModify, this.tbcDelete }, new int[] { RoleFunctions.AddRole, RoleFunctions.EditRole, RoleFunctions.DeleteRole });
        }

        protected override void BindGridData()
        {
            this.dgMain.DataSource = new SortList(Role.GetList());
            DataGridStyleHelper.SetStyle(this.dgMain, typeof(Role));
            SetRecordsCount((dgMain.DataSource as SortList).Count);
            SetLogic();
        }
        #endregion

        private void RoleMainForm_Load(object sender, System.EventArgs e)
        {
            SetTitle("角色管理");
        }

        #region 事件处理
        protected override void tbcAdd_Commanded(object sender, EventArgs e)
        {
            new AddRoleForm().ShowDialog();

            BindGridData();
        }

        protected override void tbcModify_Commanded(object sender, EventArgs e)
        {
            GetSelectNode();

            if (m_CurrentNode == null)
            {
                return;
            }

            new EditRoleForm(m_CurrentNode as Role).ShowDialog();

            BindGridData();
        }

        protected override void tbcDelete_Commanded(object sender, EventArgs e)
        {
            GetSelectNode();

            if (m_CurrentNode == null)
            {
                return;
            }

            if (MsgHelper.ShowQuestionMsgBox(string.Format("确定要删除[{0}]吗?", (m_CurrentNode as Role).Name)) == DialogResult.Yes)
            {
                if ((m_CurrentNode as Role).Delete())
                {
                    MsgHelper.ShowInformationMsgBox("删除角色成功！");
                    m_CurrentNode = null;
                    BindGridData();
                }
                else
                {
                    MsgHelper.ShowInformationMsgBox("删除角色失败！");
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

            new ViewRoleForm(m_CurrentNode as Role).ShowDialog();

            BindGridData();
        }
        #endregion
    }
}
