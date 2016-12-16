/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/12/2009 11:17:47 PM
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
    public partial class ListForm : ChildrenForm
    {
        public ListForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {   
            dgMain.CurrentCellChanged+=new EventHandler(dgMain_CurrentCellChanged);
            dgMain.MouseDown+=new MouseEventHandler(dgMain_MouseDown);
            dgMain.DoubleClick+=new EventHandler(dgMain_DoubleClick);            
        }

        private void dgMain_CurrentCellChanged(object sender, EventArgs e)
        {
            this.SetLogic();
        }

        private void dgMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (dgMain.CurrentRowIndex == 0)
                SetLogic();
        }

        protected virtual void SetLogic()
        { 
        }

        protected virtual void dgMain_DoubleClick(object sender, EventArgs e)
        {

        }

        protected void SetRecordsCount(int recordCount)
        {
            lblRecord.Text = string.Format("当前一共检索出 {0} 条记录", recordCount);
        }
    }
}
