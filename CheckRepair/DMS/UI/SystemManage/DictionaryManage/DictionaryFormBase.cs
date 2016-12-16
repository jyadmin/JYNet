/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/21/2009 9:38:15 AM
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
    public partial class DictionaryFormBase : DetailForm
    {
        public Dictionary m_Dictionary;
        public DictionaryFormBase()
        {
            InitializeComponent();
            m_Dictionary = new Dictionary();
        }

        public override void AddCommands(List<ToolBarCommand> commands)
        {
            base.AddCommands(commands);
            commands.Insert(0, tbcCancel);
        }

        private void DictionaryFormBase_Load(object sender, EventArgs e)
        {
            InitControl();
        }

        public void InitControl()
        {
            AddRequiredTextItem(txtName, "模块名称不能为空!");            
            AddRequiredTextItem(txtDisplayOrder, "显示顺序不能为空!", @"^\d{1,5}$", "必须为数字!");
            AddRequiredTextItem(txtPriorID, "父数据项不能为空!", @"^\d{1,5}$", "必须为数字!");
            AddRequiredTextItem(txtTypeName, "显示数据类型不能为空!");
        }

        protected void SetReadonlyControl()
        {
            SetReadOnly(txtName, true, Color.White);
            SetReadOnly(txtDisplayOrder, true, Color.White);
            SetReadOnly(txtPriorID, true, Color.White);
            SetReadOnly(txtTypeName, true, Color.White);
        }

        public void SetDictionaryToForm()
        {
            
            txtDictionaryId.Text = m_Dictionary.ID.ToString();
            txtName.Text = m_Dictionary.Name;
            txtDisplayOrder.Text = m_Dictionary.DisplayOrder.ToString();
            txtPriorID.Text = m_Dictionary.ParentID.ToString();
            txtTypeName.Text = m_Dictionary.Type;
        }

        public void GetFormToDictionary()
        {
            m_Dictionary.Name = txtName.Text;
            m_Dictionary.DisplayOrder = ConvertHelper.ToInt32(txtDisplayOrder.Text);
            m_Dictionary.ParentID = ConvertHelper.ToInt32(txtPriorID.Text);
            m_Dictionary.Type = txtTypeName.Text;
        }
    }
}
