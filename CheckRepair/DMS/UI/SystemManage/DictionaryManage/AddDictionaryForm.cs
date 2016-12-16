/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/21/2009 10:04:25 AM
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

namespace DMS.UI.SystemManage.DictionaryManage
{
    public partial class AddDictionaryForm : DictionaryFormBase
    {
        public AddDictionaryForm()
        {
            InitializeComponent();
        }

        public override void AddCommands(List<ToolBarCommand> commands)
        {
            base.AddCommands(commands);
            commands.Insert(0, tbcSave);
        }

        private void AddDictionaryForm_Load(object sender, EventArgs e)
        {
            SetTitle("添加数据项");
        }

        private void tbcSave_Commanded(object sender, EventArgs e)
        {
            if (!base.Validate())
            {
                return;
            }

            GetFormToDictionary();

            if (m_Dictionary.Add())
            {
                MsgHelper.ShowInformationMsgBox("添加数据项成功！");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MsgHelper.ShowInformationMsgBox("添加数据项失败！");
            }
        }
    }
}
