/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/19/2009 10:49:41 AM
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
using DMS.DomainObjects;

namespace DMS.UI.SystemManage.RoleManage
{
    public partial class AddRoleForm : RoleFormBase
    {
        public AddRoleForm()
        {
            InitializeComponent();
        }

        public override void AddCommands(List<ToolBarCommand> commands)
        {
            base.AddCommands(commands);
            commands.Insert(0, tbcSave);
        }

        private void AddRoleForm_Load(object sender, EventArgs e)
        {
            SetTitle("添加角色");
        }

        private void tbcSave_Commanded(object sender, EventArgs e)
        {
            if (!base.Validate())
            {
                return;
            }

            GetFormToRole();

            if (m_Role.Add(CurrentUser.Instance.Edition.ID))
            {
                MsgHelper.ShowInformationMsgBox("添加角色成功！");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MsgHelper.ShowInformationMsgBox("添加角色失败！");
            }
        }
    }
}
