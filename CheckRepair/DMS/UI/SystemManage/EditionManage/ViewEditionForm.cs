/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/19/2009 12:53:16 PM
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

namespace DMS.UI.SystemManage.EditionManage
{
    public partial class ViewEditionForm : EditionFormBase
    {
        public ViewEditionForm(Edition edition)
        {
            InitializeComponent();
            m_Edition = edition;
            m_Edition.Retrieve(edition.ID);
        }

        private void ViewEditionForm_Load(object sender, EventArgs e)
        {
            SetTitle("版本详细");
            SetEditionToForm();
            SetReadonlyControl();
        }
    }
}
