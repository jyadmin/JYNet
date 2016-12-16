/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/19/2009 9:56:41 AM
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DMS.UI.Common
{
    public partial class CRUDListForm : ListForm
    {
        protected object m_CurrentNode;
        public CRUDListForm()
        {
            InitializeComponent();
        }

        #region override
        public override ToolBarCommand[] GetCommands()
        {
            return new ToolBarCommand[] { this.tbcAdd, this.tbcModify, this.tbcView, this.tbcDelete };
        }

        protected override void SetLogic()
        {
            GetSelectNode();
            if (m_CurrentNode != null)
            {
                SetSpecialLogicVisible();
            }
            else
            {
                this.SetLogicVisible(new ToolBarCommand[] { this.tbcAdd, this.tbcModify, this.tbcDelete, this.tbcView }, new bool[] { true, false, false, false });
            }
        }

        protected override void dgMain_DoubleClick(object sender, EventArgs e)
        {
            GetSelectNode();
            if (m_CurrentNode == null)
            {
                return;
            }

            tbcView.Command();
        }
        #endregion

        #region CommonMethod
        protected void GetSelectNode()
        {
            if (this.dgMain.DataSource == null)
            {
                m_CurrentNode = null;
                return;
            }

            if (this.dgMain.CurrentRowIndex == -1)
            {
                m_CurrentNode = null;
                return;
            }

            m_CurrentNode = this.dgMain.BindingContext[this.dgMain.DataSource].Current;
        }
        #endregion

        private void CRUDList_Load(object sender, System.EventArgs e)
        {        
            SetPermissionOfCommands();
            BindGridData();
        }

        #region virtual Method
        protected virtual void SetPermissionOfCommands()
        {
        }

        protected virtual void BindGridData()
        { }

        protected virtual void SetSpecialLogicVisible()
        {
            this.SetLogicVisible(new ToolBarCommand[] { this.tbcAdd, this.tbcModify, this.tbcDelete, this.tbcView }, new bool[] { true, true, true, true });
        }
        #endregion

        #region EventHandler
        protected virtual void tbcAdd_Commanded(object sender, EventArgs e)
        {

        }

        protected virtual void tbcModify_Commanded(object sender, EventArgs e)
        {

        }

        protected virtual void tbcView_Commanded(object sender, EventArgs e)
        {

        }

        protected virtual void tbcDelete_Commanded(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
