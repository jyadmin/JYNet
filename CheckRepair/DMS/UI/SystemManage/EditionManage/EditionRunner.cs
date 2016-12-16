/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/16/2009 11:04:13 PM
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DMS.UI.Common;

namespace DMS.UI.SystemManage.EditionManage
{
    public class EditionRunner : IModule
    {
        public void Run()
        {
            SystemSetForm.Current.AddChild(new EditionMainForm());
        }
    }
}
