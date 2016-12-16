/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/21/2009 10:04:34 AM
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

namespace DMS.UI.SystemManage.DictionaryManage
{
    public partial class EditDictionaryForm : DictionaryFormBase
    {
        public EditDictionaryForm(Dictionary dictionary)
        {
            InitializeComponent();
            m_Dictionary = dictionary;
        }

        public override void AddCommands(List<ToolBarCommand> commands)
        {
            base.AddCommands(commands);
            commands.Insert(0, tbcUpdate);
        }

        private void EditDictionaryForm_Load(object sender, EventArgs e)
        {
            SetTitle("编辑数据项");
            SetDictionaryToForm();
        }

        private void tbcUpdate_Commanded(object sender, EventArgs e)
        {
            if (!base.Validate())
            {
                return;
            }

            GetFormToDictionary();

            if (m_Dictionary.Update())
            {
                MsgHelper.ShowInformationMsgBox("更新数据项成功！");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MsgHelper.ShowInformationMsgBox("更新数据项失败！");
            }
        }
    }
}
