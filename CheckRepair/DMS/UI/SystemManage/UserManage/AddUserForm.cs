/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/17/2009 5:46:29 PM
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

namespace DMS.UI.SystemManage.UserManage
{
    public partial class AddUserForm : UserFormBase
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        public override void AddCommands(List<ToolBarCommand> commands)
        {
            base.AddCommands(commands);
            commands.Insert(0, tbcSave);
        }

        private void AddUserForm_Load(object sender, System.EventArgs e)
        {
            SetTitle("添加用户");
        }

        private void tbcSave_Commanded(object sender, EventArgs e)
        {
            if (!base.Validate())
            {
                return;
            }

            string message;
            GetFormToUser();

            if (m_UserInfo.Add(out message))
            {
                MsgHelper.ShowInformationMsgBox(message);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MsgHelper.ShowInformationMsgBox(message);
            }
        }
    }
}
