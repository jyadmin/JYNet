using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DMS.UI.Common;

namespace DMS.UI.FileManage
{
    class AffairsOpenMainFormRunner : IModule
    {
         public void Run()
        {
            new FileManageMainForm("事务公开", "事务公开").ShowDialog();
         }
    }
}
