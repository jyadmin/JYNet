using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DMS.Common;
using DMS.DomainObjects.BasicInfo;
using DMS.UI.Common;

namespace DMS.UI.SystemManage.ModuleManage
{
    public partial class EditModuleForm : ModuleFormBase
    {
        public EditModuleForm(Module module)
        {
            InitializeComponent();
            m_Module = module;
        }

        public override void AddCommands(List<ToolBarCommand> commands)
        {
            base.AddCommands(commands);
            commands.Insert(0, tbcUpdate);
        }

        private void EditModuleForm_Load(object sender, EventArgs e)
        {
            SetTitle("编辑功能模块");
            SetModuleToForm();
        }

        private void tbcUpdate_Commanded(object sender, EventArgs e)
        {
            if (!base.Validate())
            {
                return;
            }

            GetFormToModule();
            
            if (m_Module.Update())
            {
                MsgHelper.ShowInformationMsgBox("更新功能模块成功！");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MsgHelper.ShowInformationMsgBox("更新功能模块失败！");
            }
        }
    }
}
