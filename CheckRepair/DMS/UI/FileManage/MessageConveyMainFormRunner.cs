using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DMS.UI.Common;

namespace DMS.UI.FileManage
{
    class MessageConveyMainFormRunner : IModule
    {
         public void Run()
        {
            new FileManageMainForm("文电传达", "文电传达").ShowDialog();
         }
    }
}
