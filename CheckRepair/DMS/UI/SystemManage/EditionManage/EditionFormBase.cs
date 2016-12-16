/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/19/2009 12:50:49 PM
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
    public partial class EditionFormBase : DetailForm
    {
        protected Edition m_Edition;

        public EditionFormBase()
        {
            InitializeComponent();
            m_Edition = new Edition();
        }

        public override void AddCommands(List<ToolBarCommand> commands)
        {
            base.AddCommands(commands);
            commands.Insert(0, tbcCancel);
        }

        private void EditionFormBase_Load(object sender, EventArgs e)
        {
            InitControl();
            CommonModule.LoadModule(tvModule, Module.GetList());            
        }

        public void InitControl()
        {
            AddRequiredTextItem(txtName, "版本名称不能为空!");
        }

        protected void SetReadonlyControl()
        {
            SetReadOnly(txtName, true, Color.White);
            SetReadOnly(txtMemo, true, Color.White);
        }

        public void SetEditionToForm()
        {
            txtID.Text = m_Edition.ID.ToString();
            txtName.Text = m_Edition.Name;
            txtMemo.Text = m_Edition.Description;
            CommonModule.SetModule(tvModule, m_Edition.Modules);
        }

        public void GetFormToEdition()
        {
            m_Edition.Name = txtName.Text;
            m_Edition.Description = txtMemo.Text;
            m_Edition.Modules.Clear();            
            m_Edition.Modules.AddRange(CommonModule.GetModule(tvModule));
        }

        private void btnSelectChildren_Click(object sender, EventArgs e)
        {
            CommonModule.SelectAllChildNodesOfCurrentNode(tvModule.SelectedNode);
        }
    }
}
