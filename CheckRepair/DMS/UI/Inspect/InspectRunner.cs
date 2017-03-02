/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/21/2009 9:37:15 AM
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DMS.UI.Common;
using DMS.UI.DeviceReceives;

namespace DMS.UI.Inspect
{
    public class InspectRunner : IModule
    {
        public void Run()
        {
            new InspectForm().ShowDialog();
        }
    }
}
