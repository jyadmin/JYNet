using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DMS.DomainObjects.BasicInfo;

namespace DMS.UI.SystemManage.ModuleManage
{
    public partial class ViewModuleForm : ModuleFormBase
    {
        public ViewModuleForm(Module module)
        {
            InitializeComponent();
            m_Module = module;
        }

        private void ViewModuleForm_Load(object sender, EventArgs e)
        {
            SetTitle("功能模块详细");
            SetModuleToForm();
            SetReadonlyControl();
        }
    }
}
