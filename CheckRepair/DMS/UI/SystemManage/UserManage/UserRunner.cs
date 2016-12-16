/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/15/2009 11:38:16 AM
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DMS.UI.Common;

namespace DMS.UI.SystemManage.UserManage
{
    public class UserRunner:IModule
    {
        public void Run()
        {
            SystemSetForm.Current.AddChild(new UserMainForm());            
        }
    }
}
