/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/17/2009 8:24:26 PM
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

namespace DMS.UI.SystemManage.UserManage
{
    public partial class EditUserForm : UserFormBase
    {
        public EditUserForm(UserInfo userInfo)
        {
            m_UserInfo = userInfo;
            InitializeComponent();
        }

        public override void AddCommands(List<ToolBarCommand> commands)
        {
            base.AddCommands(commands);
            commands.Insert(0, tbcUpdate);
        }

        private void EditUserForm_Load(object sender, System.EventArgs e)
        {
            SetTitle("编辑用户");
            SetUserToForm();
            SetEditReadonlyControl();
        }

        private void tbcUpdate_Commanded(object sender, EventArgs e)
        {
            if (!base.Validate())
            {
                return;
            }

            GetFormToUser();

            if(m_UserInfo.Update())
            {                    
                MsgHelper.ShowInformationMsgBox("更新用户成功！");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MsgHelper.ShowInformationMsgBox("更新用户失败！");
            }
        }
    }
}
