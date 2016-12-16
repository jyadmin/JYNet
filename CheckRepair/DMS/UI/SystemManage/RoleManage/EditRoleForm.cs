/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/19/2009 10:48:14 AM
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
    public partial class EditRoleForm : RoleFormBase
    {
        public EditRoleForm(Role role)
        {
            InitializeComponent();
            m_Role = role;
            m_Role.Retrieve(role.ID);
        }
        
        public override void AddCommands(List<ToolBarCommand> commands)
        {
            base.AddCommands(commands);
            commands.Insert(0, tbcUpdate);
        }

        private void EditRoleForm_Load(object sender, EventArgs e)
        {
            SetTitle("编辑角色");
            SetRoleToForm();
        }

        private void tbcUpdate_Commanded(object sender, EventArgs e)
        {
            if (!base.Validate())
            {
                return;
            }

            GetFormToRole();

            if (m_Role.Update())
            {
                MsgHelper.ShowInformationMsgBox("更新角色成功！");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MsgHelper.ShowInformationMsgBox("更新角色失败！");
            }
        }
    }
}
