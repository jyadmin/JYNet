using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DMS.BaseORMappers.Clients;
using DMS.DomainObjects.BusinessFunctions;
using DMS.Common;
using DMS.UI.Common;
using TX.Framework.WindowUI.Controls;
using TX.Framework.WindowUI.Forms;
using DMS.DomainObjects.BasicInfo;
using System.Threading;

namespace DMS.UI.Output
{
    public partial class OutputForm :  TX.Framework.WindowUI.Forms.BaseForm
    {
        protected int ItemIndex;
        protected string selectedCheckerCodes;
        protected int templateID;
        protected int IsUsersLoaded = 0;
        protected List<UserInfo> userList;
        protected List<AssignedTask> assignedTaskList = new List<AssignedTask>();
        protected List<FlowTemplateMain> templateList = new List<FlowTemplateMain>();
        protected DeviceReceive devReceive = new DeviceReceive();
        protected string btnName;
        protected string status = "0";
        protected bool HasAssigned = false;

        
        public OutputForm()
        {
            InitializeComponent();
            //查询所有人员
            userList = UserInfo.GetList();
            //设置时间选择器
            this.txDateTimePicker1.ShowCheckBox = false;
            this.txDateTimePicker2.ShowCheckBox = false;
            LoadWebBrowser();
            //Thread t = new Thread(LoadWebBrowser);
            //t.SetApartmentState(ApartmentState.STA);
            //t.Name = "WebBrowserThread";
            //t.Start();
        }

        public void LoadWebBrowser()
        {
            WebBrowser wb = new System.Windows.Forms.WebBrowser();
            txPanelWebBrowser.Controls.Add(wb);
        }

        private void btnEngineType_Click(object sender, EventArgs e)
        {
            //清空
            tvEngineCode.Nodes.Clear();
            IsUsersLoaded = 0;
            List<DeviceReceive> list = new List<DeviceReceive>();
            string where = String.Empty;
            
            Button btn = (Button)sender;
            btnName = btn.Name;
            //处理时间区间
            DateTime dtS = DateTime.Today;//开始时间
            DateTime dtE = DateTime.Today;//结束时间
            long dtStart = 0;
            long dtEnd = 0;
            if (txDateTimePicker1.Value.ToString() != "" && txDateTimePicker1.Value.ToString() != null)
            {
                dtS = (DateTime)txDateTimePicker1.Value;
                dtStart = DateTimeHelper.ConvertDataTimeToLong(dtS.Date);
            }
            else
            {
                dtStart = DateTimeHelper.ConvertDataTimeToLong(dtS.Date);
            }
            if (txDateTimePicker2.Value.ToString() != "" && txDateTimePicker2.Value.ToString() != null)
            {
                dtE = (DateTime)txDateTimePicker2.Value;
                //结束时间为改天的23：59：59
                dtEnd = DateTimeHelper.ConvertDataTimeToLong(dtE.Date) + 24 * 60 * 60 * 1000 - 1;
            }
            else
            {
                //结束时间为改天的23：59：59
                dtEnd = DateTimeHelper.ConvertDataTimeToLong(dtE.Date) + 24 * 60 * 60 * 1000 - 1;
            }
            //获取已完成的设备接收单
            status = "2";
            switch (btnName)
            {
                case "btnHXD1BC5":
                    where = "where EngineType = \'HXD1B\' and XC = \'C5\' and Status = \'" + status + "\' and ReceiveTime >= " + dtStart + " and ReceiveTime <= " + dtEnd;
                    btnHXD1BC5.BackColor = Color.DodgerBlue;
                    btnHXD1DC5.BackColor = Color.White;
                    btnHXD1C5.BackColor = Color.White;
                    btnHXD3CC4.BackColor = Color.White;
                    btnHXD3CC5.BackColor = Color.White;
                    btnHXD3C5.BackColor = Color.White;
                    break;
                case "btnHXD1DC5":
                    where = "where EngineType = \'HXD1D\' and XC = \'C5\' and Status = \'" + status + "\' and ReceiveTime >= " + dtStart + " and ReceiveTime <= " + dtEnd;
                    btnHXD1BC5.BackColor = Color.White;
                    btnHXD1DC5.BackColor = Color.DodgerBlue;
                    btnHXD1C5.BackColor = Color.White;
                    btnHXD3CC4.BackColor = Color.White;
                    btnHXD3CC5.BackColor = Color.White;
                    btnHXD3C5.BackColor = Color.White;
                    break;
                case "btnHXD1C5":
                    where = "where EngineType = \'HXD1\' and XC = \'C5\' and Status = \'" + status + "\' and ReceiveTime >= " + dtStart + " and ReceiveTime <= " + dtEnd;
                    btnHXD1BC5.BackColor = Color.White;
                    btnHXD1DC5.BackColor = Color.White;
                    btnHXD1C5.BackColor = Color.DodgerBlue;
                    btnHXD3CC4.BackColor = Color.White;
                    btnHXD3CC5.BackColor = Color.White;
                    btnHXD3C5.BackColor = Color.White;
                    break;
                case "btnHXD3CC4":
                    where = "where EngineType = \'HXD3C\' and XC = \'C4\' and Status = \'" + status + "\' and ReceiveTime >= " + dtStart + " and ReceiveTime <= " + dtEnd;
                    btnHXD1BC5.BackColor = Color.White;
                    btnHXD1DC5.BackColor = Color.White;
                    btnHXD1C5.BackColor = Color.White;
                    btnHXD3CC4.BackColor = Color.DodgerBlue;
                    btnHXD3CC5.BackColor = Color.White;
                    btnHXD3C5.BackColor = Color.White;
                    break;
                case "btnHXD3CC5":
                    where = "where EngineType = \'HXD3C\' and XC = \'C5\' and Status = \'" + status + "\' and ReceiveTime >= " + dtStart + " and ReceiveTime <= " + dtEnd;
                    btnHXD1BC5.BackColor = Color.White;
                    btnHXD1DC5.BackColor = Color.White;
                    btnHXD1C5.BackColor = Color.White;
                    btnHXD3CC4.BackColor = Color.White;
                    btnHXD3CC5.BackColor = Color.DodgerBlue;
                    btnHXD3C5.BackColor = Color.White;
                    break;
                case "btnHXD3C5":
                    where = "where EngineType = \'HXD3\' and XC = \'C5\' and Status = \'" + status + "\' and ReceiveTime >= " + dtStart + " and ReceiveTime <= " + dtEnd;
                    btnHXD1BC5.BackColor = Color.White;
                    btnHXD1DC5.BackColor = Color.White;
                    btnHXD1C5.BackColor = Color.White;
                    btnHXD3CC4.BackColor = Color.White;
                    btnHXD3CC5.BackColor = Color.White;
                    btnHXD3C5.BackColor = Color.DodgerBlue;
                    break;
            }
            list = DeviceReceive.GetList(where);
            //获取车号字段
            List<string> EngineCodeStrList = new List<string>();
            for (int i = 0; i < list.Count; i++)
            {
                EngineCodeStrList.Add(list[i].EngineCode);
            }
            if (list.Count > 0)
            {
                //去除重复的车号
                for (int i = 0; i < EngineCodeStrList.Count; i++)  //外循环是循环的次数
                {
                    for (int j = EngineCodeStrList.Count - 1; j > i; j--)  //内循环是 外循环一次比较的次数
                    {
                        if (EngineCodeStrList[i] == EngineCodeStrList[j])
                        {
                            EngineCodeStrList.RemoveAt(j);
                        }
                    }
                }
                //加载树形结构tvEngineCode
                for (int i = 0; i < EngineCodeStrList.Count; i++)
                {
                    tvEngineCode.Nodes.Add(EngineCodeStrList[i]);
                    for (int j = 0; j < list.Count; j++)
                    {
                        if (EngineCodeStrList[i] == list[j].EngineCode)
                        {
                            TreeNode tn = new TreeNode();
                            tn.Text = list[j].DeviceType;
                            //在Name中存放车型、修程、设备类型、车号（下车号）、设备接收ID
                            tn.Name = list[j].EngineType + "," + list[j].XC + "," + list[j].DeviceType + "," + list[j].EngineCode + "," + list[j].ID;
                            tvEngineCode.Nodes[i].Nodes.Add(tn);
                        }
                    }
                }
            }
        }

       

       

    }
}
