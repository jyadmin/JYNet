/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/19/2009 12:53:09 PM
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

namespace DMS.UI.SystemManage.EditionManage
{
    public partial class EditEditionForm : EditionFormBase
    {
        public EditEditionForm(Edition edition)
        {
            InitializeComponent();
            m_Edition = edition;
            m_Edition.Retrieve(edition.ID);
        }

        public override void AddCommands(List<ToolBarCommand> commands)
        {
            base.AddCommands(commands);
            commands.Insert(0, tbcUpdate);
        }

        private void EditEditionForm_Load(object sender, EventArgs e)
        {
            SetTitle("编辑版本");
            SetEditionToForm();
        }

        private void tbcUpdate_Commanded(object sender, EventArgs e)
        {
            if (!base.Validate())
            {
                return;
            }

            GetFormToEdition();

            if (m_Edition.Update())
            {
                MsgHelper.ShowInformationMsgBox("更新版本成功！");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MsgHelper.ShowInformationMsgBox("更新版本失败！");
            }
        }
    }
}
