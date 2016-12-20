using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DMS.Common;
using DMS.UI.Common;
using DMS.DomainObjects.BasicInfo;

namespace DMS.UI.SystemManage.ModuleManage
{
    public partial class ModuleFormBase :DetailForm
    {
        protected Module m_Module;
        public ModuleFormBase()
        {
            InitializeComponent();
            m_Module = new Module();
        }

        public override void AddCommands(List<ToolBarCommand> commands)
        {
            base.AddCommands(commands);
            commands.Insert(0, tbcCancel);
        }

        private void ModuleFormBase_Load(object sender, EventArgs e)
        {
            InitControl();
        }

        public void InitControl()
        {
            AddRequiredTextItem(txtName, "模块名称不能为空!");
            AddRequiredTextItem(txtPriorModule, "上级模块不能为空!",@"^\d{1,5}$","必须为数字!");
            AddRequiredTextItem(txtDisplayOrder, "显示顺序不能为空!", @"^\d{1,5}$", "必须为数字!");
        }

        protected void SetReadonlyControl()
        {
            SetReadOnly(txtName , true, Color.White);
            SetReadOnly(txtRunner, true, Color.White);
            SetReadOnly(txtPriorModule, true, Color.White);
            SetReadOnly(txtDisplayOrder, true, Color.White);
            SetReadOnly(txtMemo, true, Color.White);
            SetEnable(cbDisplay, false);
            SetReadOnly(txtLevel, true, Color.White);
            SetReadOnly(txtSize, true, Color.White);
        }

        public void SetModuleToForm()
        {
            txtModuleId.Text = m_Module.ID.ToString();
            txtName.Text = m_Module.Name;
            txtRunner.Text = m_Module.TypeFullName;
            txtPriorModule.Text = m_Module.PriorModule.ToString();
            txtDisplayOrder.Text = m_Module.DisplayOrder.ToString();
            txtMemo.Text = m_Module.Description;
            cbDisplay.Checked = (m_Module.IsDisplay == 1 ? true : false);
            txtLevel.Text = m_Module.Level.ToString();
            txtSize.Text = m_Module.Size.ToString();
        }

        public void GetFormToModule()
        {
            m_Module.Name = txtName.Text;
            m_Module.TypeFullName = txtRunner.Text;
            m_Module.PriorModule = ConvertHelper.ToInt32(txtPriorModule.Text);
            m_Module.DisplayOrder = ConvertHelper.ToInt32(txtDisplayOrder.Text);
            m_Module.Description = txtMemo.Text;
            m_Module.IsDisplay = Int16.Parse((cbDisplay.Checked == true ? 1 : 0).ToString());
            m_Module.Level = ConvertHelper.ToInt32(txtLevel.Text);
            m_Module.Size = ConvertHelper.ToInt32(txtSize.Text);
        }
    }
}
