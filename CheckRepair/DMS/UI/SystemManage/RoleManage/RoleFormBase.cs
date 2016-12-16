/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/19/2009 10:49:16 AM
 * */
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DMS.Common;
using DMS.UI.Common;
using DMS.DomainObjects;
using DMS.DomainObjects.BasicInfo;

namespace DMS.UI.SystemManage.RoleManage
{
    public partial class RoleFormBase : DetailForm
    {
        protected Role m_Role;
        public RoleFormBase()
        {
            InitializeComponent();
            m_Role = new Role();
        }

        public override void AddCommands(List<ToolBarCommand> commands)
        {
            base.AddCommands(commands);
            commands.Insert(0, tbcCancel);
        }

        private void RoleFormBase_Load(object sender, System.EventArgs e)
        {
            InitControl();
            CommonModule.LoadModule(tvModule, Module.GetModulesByEdition(CurrentUser.Instance.Edition.ID));
        }

        public void InitControl()
        {
            AddRequiredTextItem(txtName, "角色名称不能为空!");
        }

        protected void SetReadonlyControl()
        {
            SetReadOnly(txtName, true, Color.White);
            SetReadOnly(txtMemo, true, Color.White);            
        }

        public void SetRoleToForm()
        {
            txtID.Text = m_Role.ID.ToString();
            txtName.Text = m_Role.Name;
            txtMemo.Text = m_Role.Description;
            CommonModule.SetModule(tvModule, m_Role.Modules);
        }

        public void GetFormToRole()
        {
            m_Role.Name = txtName.Text;
            m_Role.Description = txtMemo.Text;
            m_Role.Modules.Clear();
            m_Role.Modules.AddRange(CommonModule.GetModule(tvModule));
        }

        private void btnSelectChildren_Click(object sender, EventArgs e)
        {
            CommonModule.SelectAllChildNodesOfCurrentNode(tvModule.SelectedNode);
        }
    }
}
