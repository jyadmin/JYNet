/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/12/2009 11:14:22 PM
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace DMS.UI.Common
{
    public class ChildrenForm:CommandsForm
    {
        public override void RefreshCommands()
        {
            base.RefreshCommands();
            DMS.UI.SystemManage.SystemSetForm.Current.RefreshToolBar();
        }
    }
}
