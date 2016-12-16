/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/18/2009 6:32:14 PM
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DMS.UI.Common;

namespace DMS.UI.SystemManage.ModuleManage
{
    public class ModuleRunner : IModule
    {
        public void Run()
        {
            SystemSetForm.Current.AddChild(new ModuleMainForm());
        }
    }
}
