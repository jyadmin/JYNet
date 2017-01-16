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

namespace DMS.UI.AssignTask
{
    public partial class TaskListForm1 :  TX.Framework.WindowUI.Forms.BaseForm
    {
        protected int ItemIndex;
        protected string selectedCheckerCodes;
        protected int templateID;
        protected int IsUsersLoaded = 0;
        protected List<UserInfo> userList;
        public TaskListForm1()
        {
            InitializeComponent();
            //查询所有人员
            userList = UserInfo.GetList();
        }
        private void btnEngineType_Click(object sender, EventArgs e)
        {

            List<DeviceReceive> list = new List<DeviceReceive>();
            string where = String.Empty;
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnHXD1BC5":
                    where = "where EngineType = \'HXD1B\' and XC = \'C5\' and Status = \'0\'";
                    btnHXD1BC5.BackColor = Color.DodgerBlue;
                    btnHXD1DC5.BackColor = Color.White;
                    btnHXD1C5.BackColor = Color.White;
                    btnHXD3CC4.BackColor = Color.White;
                    btnHXD3CC5.BackColor = Color.White;
                    btnHXD3C5.BackColor = Color.White;
                    break;
                case "btnHXD1DC5":
                    where = "where EngineType = \'HXD1D\' and XC = \'C5\' and Status = \'0\'";
                    btnHXD1BC5.BackColor = Color.White;
                    btnHXD1DC5.BackColor = Color.DodgerBlue;
                    btnHXD1C5.BackColor = Color.White;
                    btnHXD3CC4.BackColor = Color.White;
                    btnHXD3CC5.BackColor = Color.White;
                    btnHXD3C5.BackColor = Color.White;
                    break;
                case "btnHXD1C5":
                    where = "where EngineType = \'HXD1\' and XC = \'C5\' and Status = \'0\'";
                    btnHXD1BC5.BackColor = Color.White;
                    btnHXD1DC5.BackColor = Color.White;
                    btnHXD1C5.BackColor = Color.DodgerBlue;
                    btnHXD3CC4.BackColor = Color.White;
                    btnHXD3CC5.BackColor = Color.White;
                    btnHXD3C5.BackColor = Color.White;
                    break;
                case "btnHXD3CC4":
                    where = "where EngineType = \'HXD3C\' and XC = \'C4\' and Status = \'0\'";
                    btnHXD1BC5.BackColor = Color.White;
                    btnHXD1DC5.BackColor = Color.White;
                    btnHXD1C5.BackColor = Color.White;
                    btnHXD3CC4.BackColor = Color.DodgerBlue;
                    btnHXD3CC5.BackColor = Color.White;
                    btnHXD3C5.BackColor = Color.White;
                    break;
                case "btnHXD3CC5":
                    where = "where EngineType = \'HXD3C\' and XC = \'C5\' and Status = \'0\'";
                    btnHXD1BC5.BackColor = Color.White;
                    btnHXD1DC5.BackColor = Color.White;
                    btnHXD1C5.BackColor = Color.White;
                    btnHXD3CC4.BackColor = Color.White;
                    btnHXD3CC5.BackColor = Color.DodgerBlue;
                    btnHXD3C5.BackColor = Color.White;
                    break;
                case "btnHXD3C5":
                    where = "where EngineType = \'HXD3\' and XC = \'C5\' and Status = \'0\'";
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
            if (list.Count > 0)//去除重复的车号
            {
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
                tvEngineCode.Nodes.Clear();
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

        private void tvEngineCode_AfterSelect(object sender, TreeViewEventArgs e)
        {
            treeListView1.Items.Clear();
            TreeView treeView = sender as TreeView;
            TreeNode selectedNode = treeView.SelectedNode;
            
            if (selectedNode.Level != 1)
            {
                return;
            }
            //选中的树节点改变背景颜色
            foreach(TreeNode tn in treeView.Nodes){
                foreach (TreeNode t in tn.Nodes)
                {
                    t.BackColor = Color.White;
                    t.ForeColor = Color.Black;
                }
            }
            selectedNode.BackColor = Color.DodgerBlue;
            selectedNode.ForeColor = Color.White;

            string[] parameters = selectedNode.Name.Split(',');
            string where = "where Enginetype = \'" + parameters[0] + "\' and XC = \'" + parameters[1] + "\' and DeviceType = \'" + parameters[2] + "\' order by Component ASC, DisplayOrder DESC";
            List<FlowTemplateMain> flowTemplateMainList = FlowTemplateMain.GetList(where);
            string temp = "";
            TreeListViewItem itemA = new TreeListViewItem();;
            TreeListViewItem itemA0;
            for (int i = 0; i < flowTemplateMainList.Count; i++)
            {
                if (flowTemplateMainList[i].Component != temp)
                {
                    temp = flowTemplateMainList[i].Component;
                    treeListView1.Items.Add(itemA);
                    itemA = new TreeListViewItem(temp);
                    itemA.Expand();//展开
                }
                itemA0 = new TreeListViewItem();
                itemA0.SubItems.Add(flowTemplateMainList[i].DisplayOrder.ToString());
                TreeListViewItem.ListViewSubItem subItem0 = new TreeListViewItem.ListViewSubItem();
                subItem0.Text = flowTemplateMainList[i].ProcedureName;
                subItem0.Name = flowTemplateMainList[i].TaskAssignID.ToString();
                itemA0.SubItems.Add(subItem0);
                
                itemA0.SubItems.Add(flowTemplateMainList[i].OperateTime.ToString() + " min");
                //获取上次分配人员
                string userNames = "";
                if (flowTemplateMainList[i].LastCheckerCode != "" && flowTemplateMainList[i].LastCheckerCode != null)
                {
                    string[] str = flowTemplateMainList[i].LastCheckerCode.Split(',');
                    List<UserInfo> userList = new List<UserInfo>();
                    
                    for (int j = 0; j < str.Length; j++)
                    {
                        UserInfo user = new UserInfo();
                        user.Retrieve(int.Parse(str[j]));
                        userList.Add(user);
                        userNames = userNames + user.UserName + ",";
                    }
                    userNames = userNames.Substring(0, userNames.Length - 1);
                }
                TreeListViewItem.ListViewSubItem subItem1 = new TreeListViewItem.ListViewSubItem();
                subItem1.Name = flowTemplateMainList[i].LastCheckerCode;
                subItem1.Text = userNames;
                itemA0.SubItems.Add(subItem1);
                //将模板ID存入Name属性中，点击时取出
                itemA0.Name = flowTemplateMainList[i].ID.ToString();
                itemA.Items.Add(itemA0);
            }
            treeListView1.Items.Add(itemA);
        }

        private void treeListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TreeListView tlv = sender as TreeListView;
            
            ItemIndex = tlv.SelectedItems[0].Index;
            if (tlv.SelectedItems[0].Level == 1)
            {
                FlowTemplateMain t = new FlowTemplateMain();
                string ID = tlv.SelectedItems[0].Name;
                t.Retrieve(int.Parse(ID));
                templateID = t.ID;
                selectedCheckerCodes = treeListView1.GetTreeListViewItemFromIndex(ItemIndex).SubItems[4].Name;
            }
            else
            {
                templateID = 0;
                selectedCheckerCodes = "";
            }
            LoadUsers();
            
        }

        /// <summary>
        /// 加载待选人员，渲染上次选择的人员
        /// </summary>
        /// <param name="templateId">模板ID</param>
        /// <returns></returns>
        public void LoadUsers()
        {
            if (treeListView1.SelectedItems[0].Level == 1)
            {
                //查询上次检查人员
                string[] userIds = selectedCheckerCodes.Split(',');
                if (IsUsersLoaded == 0)
                {
                    //清空
                    txGroupBox1.Controls.Clear();
                    //加载人员数据
                    for (int i = 0; i < userList.Count; i++)
                    {
                        Label label = new Label();
                        label.Size = new System.Drawing.Size(80, 80);
                        int x = (i % 4) * 100 + 30;
                        int y = (i / 4) * 100 + 30;
                        label.Location = new Point(x, y);
                        if (userIds.Contains(userList[i].ID.ToString()))
                        {
                            label.BackColor = Color.LimeGreen;
                        }
                        else
                        {
                            label.BackColor = Color.LightCyan;
                        }
                        label.Text = userList[i].UserName;
                        label.Name = userList[i].ID.ToString();
                        label.TextAlign = ContentAlignment.MiddleCenter;
                        label.Click += new System.EventHandler(this.label_Click);
                        txGroupBox1.Controls.Add(label);
                    }
                    IsUsersLoaded = 1;
                }
                else
                {
                    foreach (Control ctrl in txGroupBox1.Controls)
                    {
                        //Label label = ctrl as Label;
                        if (userIds.Contains(ctrl.Name))
                        {
                            ctrl.BackColor = Color.LimeGreen;
                        }
                        else
                        {
                            ctrl.BackColor = Color.LightCyan;
                        }
                    }
                }
            }
            else
            {
                foreach (Control ctrl in txGroupBox1.Controls)
                {
                    ctrl.BackColor = Color.LightCyan;
                }
            }
            
        }

        private void label_Click(object sender, EventArgs e)
        {
            if (treeListView1.SelectedItems[0].Level == 1)
            {
                Label label = sender as Label;
                string userID = label.Name;
                string userIDs = "";
                string[] checkerCodes = selectedCheckerCodes.Split(',');
                if (checkerCodes.Contains(userID))//已经包含该人员
                {
                    label.BackColor = Color.LightCyan;//背景变为浅色
                    for (int i = 0; i < checkerCodes.Length; i++)
                    {
                        if (checkerCodes[i] != userID)
                        {
                            userIDs = userIDs + checkerCodes[i] + ",";
                        }
                    }
                    if (userIDs.Length > 1)
                    {
                        userIDs = userIDs.Substring(0, userIDs.Length - 1);
                    }
                    selectedCheckerCodes = userIDs;
                }
                else//不包含该人员
                {
                    label.BackColor = Color.LimeGreen;//背景变为深色
                    if (selectedCheckerCodes != "" && selectedCheckerCodes != null)
                    {
                        selectedCheckerCodes = selectedCheckerCodes + "," + userID;
                    }
                    else
                    {
                        selectedCheckerCodes = userID;
                    }
                }

                //修改模板后分配人员
                string[] str = selectedCheckerCodes.Split(',');
                string userNames = "";
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[j] != "" && str[j] != null)
                    {
                        UserInfo user = new UserInfo();
                        user.Retrieve(int.Parse(str[j]));
                        userNames = userNames + user.UserName + ",";
                    }
                }
                if (userNames.Length > 1)
                {
                    userNames = userNames.Substring(0, userNames.Length - 1);
                }
                treeListView1.GetTreeListViewItemFromIndex(ItemIndex).SubItems[4].Text = userNames;
                treeListView1.GetTreeListViewItemFromIndex(ItemIndex).SubItems[4].Name = selectedCheckerCodes;
            }
            else 
            {
                return;
            }
        }

        //一次全部分配
        private void btnAssign_Click(object sender, EventArgs e)
        {
            //验证所有任务是否已经分配人员
            for (int i = 0; i < treeListView1.ItemsCount; i++)
            {
                TreeListViewItem itm = treeListView1.GetTreeListViewItemFromIndex(i);
                if (itm.Name != "" && itm.Name != null)
                {
                    //选中的分配人员id
                    string checkerIDs = itm.SubItems[4].Name;
                    if (checkerIDs == "" || checkerIDs == null)
                    {
                        this.Error("\"" + itm.Parent.Text + "-" + itm.SubItems[1].Text + "-" + itm.SubItems[2].Text + "\" 未指定人员，所有任务指定人员后才能分配！");
                        return;
                    }
                }
            }
            for (int i = 0; i < treeListView1.ItemsCount; i++)
            {
                TreeListViewItem itm = treeListView1.GetTreeListViewItemFromIndex(i);
                //TreeListViewItem itm = treeListView1.SelectedItems[0];
                if (itm.Name != "" && itm.Name != null)
                {
                    //选中的分配人员id
                    string checkerIDs = itm.SubItems[4].Name;
                    //模板id
                    int templateID = int.Parse(itm.Name);

                    //时间
                    System.DateTime arrangedStartTime = DateTime.Now;
                    long arrangedStartTimeLong = DateTimeHelper.ConvertDataTimeToLong(arrangedStartTime);

                    if (tvEngineCode.SelectedNode.Level == 1)
                    {
                        AssignedTask at = new AssignedTask();
                        string[] st = tvEngineCode.SelectedNode.Name.Split(',');
                        //设备接收ID
                        string deviceReceiveID = st.Last();
                        at.LinkIdToDeviceReceive = int.Parse(deviceReceiveID);
                        DeviceReceive deviceReceive = new DeviceReceive();
                        deviceReceive.Retrieve(at.LinkIdToDeviceReceive);
                        at.BatchCode = deviceReceive.BatchCode;
                        at.TemplateID = templateID;
                        at.CheckerIDs = checkerIDs;
                        at.ArrangedStartTime = arrangedStartTimeLong;
                        FlowTemplateMain template = new FlowTemplateMain();
                        template.Retrieve(templateID);
                        if (template.DisplayOrder == 1)
                        {
                            //开始
                            at.Status = "1";
                            //计划结束时间
                            at.ArrangedEndTime = arrangedStartTimeLong + template.OperateTime * 60 * 1000;
                        }
                        else
                        {
                            at.Status = "0";
                        }
                        if (itm.SubItems[3].Name == "" || itm.SubItems[3].Name == null)
                        {
                            at.Add();
                            //添加完成后拿回新增数据的ID，通过long型时间拿回，放在操作时长字段的Name中
                            //分配时，需要判断该字段是否为空，为空则调用Add，否则调用Update
                            List<AssignedTask> atList = AssignedTask.GetList("where ArrangedStartTime = " + at.ArrangedStartTime);
                            int ID = atList[0].ID;
                            itm.SubItems[3].Name = ID.ToString();
                        }
                        else
                        {
                            at.ID = int.Parse(itm.SubItems[3].Name);
                            at.Update();
                        }
                        template.LastCheckerCode = checkerIDs;
                        template.Update();
                    }
                }
            }
            //将设备接收数据状态置为1
            int DeviceReceiveID = int.Parse(tvEngineCode.SelectedNode.Name.Split(',').GetValue(4).ToString());
            DeviceReceive devReceive = new DeviceReceive();
            devReceive.Retrieve(DeviceReceiveID);
            devReceive.Status = "1";
            devReceive.Update();
            this.Info("分配完成！");
        }
    }
}
