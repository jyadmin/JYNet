/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/19/2009 10:47:03 AM
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DMS.UI.Common;

namespace DMS.UI.SystemManage.RoleManage
{
    public class RoleRunner : IModule
    {
        public void Run()
        {
            SystemSetForm.Current.AddChild(new RoleMainForm());
        }
    }
}
