using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DMS.UI.Common;

namespace DMS.UI.SystemManage
{
    public class SystemSetRunner : IModule
    {
        public void Run()
        {
            SystemSetForm.Current.ShowDialog();
        }
    }
}
