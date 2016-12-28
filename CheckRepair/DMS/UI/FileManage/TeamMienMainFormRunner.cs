using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DMS.UI.Common;

namespace DMS.UI.FileManage
{
    class TeamMienMainFormRunner : IModule
    {
         public void Run()
        {
            new FileManageMainForm("班组风采", "班组风采").ShowDialog();
         }
    }
}
