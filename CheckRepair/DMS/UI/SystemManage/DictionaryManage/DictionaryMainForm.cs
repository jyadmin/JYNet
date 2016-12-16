/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/21/2009 9:37:45 AM
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

namespace DMS.UI.SystemManage.DictionaryManage
{
    public partial class DictionaryMainForm : CRUDListForm
    {
        public DictionaryMainForm()
        {
            InitializeComponent();
        }

        #region override
        protected override void SetPermissionOfCommands()
        {
            this.SetPermission(new ToolBarCommand[] { this.tbcAdd, this.tbcModify, this.tbcDelete }, new int[] { DictionaryFunctions.AddDataItem, DictionaryFunctions.EditDataItem, DictionaryFunctions.DeleteDataItem });
        }

        protected override void BindGridData()
        {
            this.dgMain.DataSource = new SortList(Dictionary.GetList());
            DataGridStyleHelper.SetStyle(this.dgMain, typeof(Dictionary));
            SetRecordsCount((dgMain.DataSource as SortList).Count);
            SetLogic();
        }
        #endregion

        #region Load Event
        private void ModuleMainForm_Load(object sender, EventArgs e)
        {
            SetTitle("数据字典管理");
        }

        #endregion

        #region EventHandler
        protected override void tbcAdd_Commanded(object sender, EventArgs e)
        {
            new AddDictionaryForm().ShowDialog();
            
            BindGridData();
        }

        protected override void tbcModify_Commanded(object sender, EventArgs e)
        {
            GetSelectNode();

            if (m_CurrentNode == null)
            {
                return;
            }

            new EditDictionaryForm(m_CurrentNode as Dictionary).ShowDialog();

            BindGridData();
        }

        protected override void tbcView_Commanded(object sender, EventArgs e)
        {
            GetSelectNode();

            if (m_CurrentNode == null)
            {
                return;
            }

            new ViewDictionaryForm(m_CurrentNode as Dictionary).ShowDialog();

            BindGridData();
        }

        protected override void tbcDelete_Commanded(object sender, EventArgs e)
        {
            GetSelectNode();

            if (m_CurrentNode == null)
            {
                return;
            }

            string message = string.Format("确定要删除[{0}]吗？", (m_CurrentNode as Dictionary).Name);
            if ((m_CurrentNode as Dictionary).ParentID == 0)
            {
                message += "删除将删除此数据项的子项！";
            }

            if (MsgHelper.ShowQuestionMsgBox(message) == DialogResult.Yes)
            {
                if ((m_CurrentNode as Dictionary).Delete())
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
