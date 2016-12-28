using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DMS.UI.Common;

namespace DMS.UI.FileManage
{
    class EightSManageMainFormRunner : IModule
    {
         public void Run()
        {
            new FileManageMainForm("8S管理", "8S管理").ShowDialog();
         }
    }
}
