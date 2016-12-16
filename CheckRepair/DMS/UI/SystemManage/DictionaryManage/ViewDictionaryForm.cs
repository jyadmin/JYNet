/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/21/2009 10:04:45 AM
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DMS.DomainObjects.BasicInfo;

namespace DMS.UI.SystemManage.DictionaryManage
{
    public partial class ViewDictionaryForm : DictionaryFormBase
    {
        public ViewDictionaryForm(Dictionary dictionary)
        {
            InitializeComponent();
            m_Dictionary = dictionary;
        }

        private void ViewDictionaryForm_Load(object sender, EventArgs e)
        {
            SetTitle("数据项详细");
            SetDictionaryToForm();
            SetReadonlyControl();
        }
    }
}
