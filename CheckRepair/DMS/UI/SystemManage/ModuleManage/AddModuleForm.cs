using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DMS.Common;
using DMS.UI.Common;

namespace DMS.UI.SystemManage.ModuleManage
{
    public partial class AddModuleForm : ModuleFormBase
    {
        public AddModuleForm()
        {
            InitializeComponent();
        }

        public override void AddCommands(List<ToolBarCommand> commands)
        {
            base.AddCommands(commands);
            commands.Insert(0, tbcSave);
        }

        private void AddModuleForm_Load(object sender, EventArgs e)
        {
            SetTitle("添加功能模块");
        }

        private void tbcSave_Commanded(object sender, EventArgs e)
        {
            if (!base.Validate())
            {
                return;
            }

            GetFormToModule();

            if (m_Module.Add())
            {
                MsgHelper.ShowInformationMsgBox("添加功能模块成功！");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MsgHelper.ShowInformationMsgBox("添加功能模块失败！");
            }
        }
    }
}
