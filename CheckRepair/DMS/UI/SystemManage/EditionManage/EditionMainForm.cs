/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/16/2009 11:04:28 PM
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
using DMS.DomainObjects.BasicInfo;

namespace DMS.UI.SystemManage.EditionManage
{
    public partial class EditionMainForm : CRUDListForm
    {
        public EditionMainForm()
        {
            InitializeComponent();
        }

        #region override
        protected override void SetPermissionOfCommands()
        {
            this.SetPermission(new ToolBarCommand[] { this.tbcAdd, this.tbcModify, this.tbcDelete }, new int[] { EditionFunctions.AddEdition, EditionFunctions.EditEdition, EditionFunctions.DeleteEdition });
        }

        protected override void BindGridData()
        {
            this.dgMain.DataSource = new SortList(Edition.GetList());
            DataGridStyleHelper.SetStyle(this.dgMain, typeof(Edition));
            SetRecordsCount((dgMain.DataSource as SortList).Count);
            SetLogic();
        }

        protected override void SetSpecialLogicVisible()
        {
            this.SetLogicVisible(new ToolBarCommand[] { this.tbcAdd, this.tbcModify, this.tbcDelete, this.tbcView }, new bool[] { true, true, !((m_CurrentNode as Edition).IsDefault == 1), true });
        }
        #endregion

        private void EditionMainForm_Load(object sender, EventArgs e)
        {
            SetTitle("版本管理");
        }

        #region EventHandler
        protected override void tbcAdd_Commanded(object sender, EventArgs e)
        {
            new AddEditionForm().ShowDialog();

            BindGridData();
        }

        protected override void tbcModify_Commanded(object sender, EventArgs e)
        {
            GetSelectNode();

            if (m_CurrentNode == null)
            {
                return;
            }

            new EditEditionForm(m_CurrentNode as Edition).ShowDialog();

            BindGridData();
        }

        protected override void tbcView_Commanded(object sender, EventArgs e)
        {
            GetSelectNode();

            if (m_CurrentNode == null)
            {
                return;
            }

            new ViewEditionForm(m_CurrentNode as Edition).ShowDialog();

            BindGridData();
        }

        protected override void tbcDelete_Commanded(object sender, EventArgs e)
        {
            GetSelectNode();

            if (m_CurrentNode == null)
            {
                return;
            }

            if (MsgHelper.ShowQuestionMsgBox(string.Format("确定要删除[{0}]吗？删除将删除用户和角色的功能模块！", (m_CurrentNode as Edition).Name)) == DialogResult.Yes)
            {
                if ((m_CurrentNode as Edition).Delete())
                {
                    MsgHelper.ShowInformationMsgBox("删版本能成功！");
                    m_CurrentNode = null;
                    BindGridData();
                }
                else
                {
                    MsgHelper.ShowInformationMsgBox("删除版本失败！");
                }
            }
        }
        #endregion
    }
}
