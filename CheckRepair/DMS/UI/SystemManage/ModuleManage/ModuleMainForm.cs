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
    public partial class ModuleMainForm : CRUDListForm
    {
        public ModuleMainForm()
        {
            InitializeComponent();
        }

        #region override
        protected override void SetPermissionOfCommands()
        {
            this.SetPermission(new ToolBarCommand[] { this.tbcAdd, this.tbcModify, this.tbcDelete }, new int[] { ModuleFunctions.AddModule, ModuleFunctions.EditModule, ModuleFunctions.DeleteModule });
        }

        protected override void BindGridData()
        {
            this.dgMain.DataSource = new SortList(Module.GetList());
            DataGridStyleHelper.SetStyle(this.dgMain, typeof(Module));
            SetRecordsCount((dgMain.DataSource as SortList).Count);
            SetLogic();
        }
        #endregion

        #region Load Event
        private void ModuleMainForm_Load(object sender, EventArgs e)
        {
            SetTitle("功能管理");
        }

        #endregion

        #region EventHandler
        protected override void tbcAdd_Commanded(object sender, EventArgs e)
        {
            new AddModuleForm().ShowDialog();

            BindGridData();
        }

        protected override void tbcModify_Commanded(object sender, EventArgs e)
        {
            GetSelectNode();

            if (m_CurrentNode == null)
            {
                return;
            }

            new EditModuleForm(m_CurrentNode as Module).ShowDialog();

            BindGridData();
        }

        protected override void tbcView_Commanded(object sender, EventArgs e)
        {
            GetSelectNode();

            if (m_CurrentNode == null)
            {
                return;
            }

            new ViewModuleForm(m_CurrentNode as Module).ShowDialog();

            BindGridData();
        }

        protected override void tbcDelete_Commanded(object sender, EventArgs e)
        {
            GetSelectNode();

            if (m_CurrentNode == null)
            {
                return;
            }

            if (MsgHelper.ShowQuestionMsgBox(string.Format("确定要删除[{0}]吗？删除将删除版本和角色的功能模块！", (m_CurrentNode as Module).Name)) == DialogResult.Yes)
            {
                if ((m_CurrentNode as Module).Delete())
                {
                    MsgHelper.ShowInformationMsgBox("删除功能成功！");
                    m_CurrentNode = null;
                    BindGridData();
                }
                else
                {
                    MsgHelper.ShowInformationMsgBox("删除功能失败！");
                }
            }
        }
        #endregion
    }
}
