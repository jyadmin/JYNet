/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/19/2009 12:53:01 PM
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

namespace DMS.UI.SystemManage.EditionManage
{
    public partial class AddEditionForm : EditionFormBase
    {
        public AddEditionForm()
        {
            InitializeComponent();
        }

        public override void AddCommands(List<ToolBarCommand> commands)
        {
            base.AddCommands(commands);
            commands.Insert(0, tbcSave);
        }

        private void AddEditionForm_Load(object sender, EventArgs e)
        {
            SetTitle("添加版本");
        }

        private void tbcSave_Commanded(object sender, EventArgs e)
        {
            if (!base.Validate())
            {
                return;
            }

            GetFormToEdition();
            
            if (m_Edition.Add())
            {
                MsgHelper.ShowInformationMsgBox("添加版本成功！");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MsgHelper.ShowInformationMsgBox("添加版本失败！");
            }
        }
    }
}
