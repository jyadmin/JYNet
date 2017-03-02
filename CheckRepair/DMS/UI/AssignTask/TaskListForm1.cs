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

namespace DMS.UI.AssignTask
{
    public partial class TaskListForm1 :  TX.Framework.WindowUI.Forms.BaseForm
    {
        protected int ItemIndex;//TreeListView选中的Item编号
        protected string selectedCheckerCodes;//选中的人员ID拼接字符串
        protected int templateMainID;//主模板ID
        protected int IsUsersLoaded = 0;//人员是否已加载标识
        protected List<UserInfo> userList;//所有人员List，Form加载时查询
        protected List<AssignedTask> assignedTaskList = new List<AssignedTask>();//任务分配
        protected List<FlowTemplateMain> templateList = new List<FlowTemplateMain>();//主步骤模板
        protected DeviceReceive devReceive = new DeviceReceive();//设备接收
        protected string btnName;//机车类型
        protected string status = "0";//设备接收单状态选择下拉框的值，默认未分配0，已分配1
        protected bool HasAssigned = false;//是否已分配状态

        public TaskListForm1()
        {
            InitializeComponent();
            //查询所有人员
            userList = UserInfo.GetList();
            //设置时间选择控件不显示勾选框，（在时间选择器控件属性中设置无效，只能初始化时动态设置）
            this.txDateTimePicker1.ShowCheckBox = false;
            this.txDateTimePicker2.ShowCheckBox = false;
        }

        /// <summary>
        /// 机车类型选择按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEngineType_Click(object sender, EventArgs e)
        {
            //清空下车号TreeView
            tvEngineCode.Nodes.Clear();
            //清空展示任务主步骤信息的treeListView1
            treeListView1.Items.Clear();
            //情况人员展示的txGroupBox1
            txGroupBox1.Controls.Clear();
            //人员已加载标识置0
            IsUsersLoaded = 0;

            //根据时间和分配状态查询设备接收单
            
            string where = String.Empty;
            
            Button btn = (Button)sender;
            btnName = btn.Name;
            //获取时间选择控件的值，时间选择控件在未点选前的值为null，需要做特殊处理，当时间控件的值为null时取值为当前系统时间
            DateTime dtS = DateTime.Today;//开始时间
            DateTime dtE = DateTime.Today;//结束时间
            long dtStart = 0;//开始时间long形式
            long dtEnd = 0;//结束时间long形式
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
            //获取设备接收单状态查询条件
            if (txCbbStatus.Text == "已分配")
            {
                status = "1";
            }
            else
            {
                status = "0";
            }
            //根据机车类型按钮确定设备接收单查询条件，并设置表示按钮状态的颜色：选中按钮置为蓝色，其余按钮置为白色
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
            //根据状态、时间段查询符合条件的设备接收单
            List<DeviceReceive> list = DeviceReceive.GetList(where);
            
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
                //加载树形结构tvEngineCode，显示下车号和该下车号下的设备名称
                for (int i = 0; i < EngineCodeStrList.Count; i++)
                {
                    //添加下车号节点
                    tvEngineCode.Nodes.Add(EngineCodeStrList[i]);
                    for (int j = 0; j < list.Count; j++)
                    {
                        //判断查询到设备接收单的下车号是否与本次循环的下车号相同，若相同就显示在该下车号下
                        if (EngineCodeStrList[i] == list[j].EngineCode)
                        {
                            //设备类型节点
                            TreeNode tn = new TreeNode();
                            tn.Text = list[j].DeviceType;
                            //在Name中存放车型、修程、设备类型、车号（下车号）、设备接收ID
                            tn.Name = list[j].EngineType + "," + list[j].XC + "," + list[j].DeviceType + "," + list[j].EngineCode + "," + list[j].ID;
                            //设备类型节点添加到下车号节点下
                            tvEngineCode.Nodes[i].Nodes.Add(tn);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 展示下车号、设备类型的TreeView节点选中事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvEngineCode_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //清空展示任务主步骤信息的treeListView1
            treeListView1.Items.Clear();
            //情况人员展示的txGroupBox1
            txGroupBox1.Controls.Clear();
            //人员是否已加载标识置0
            IsUsersLoaded = 0;
            TreeView treeView = sender as TreeView;
            //选中的设备类型节点
            TreeNode selectedNode = treeView.SelectedNode;
            //所有节点全部置为白色
            foreach (TreeNode tn in treeView.Nodes)
            {
                tn.BackColor = Color.White;
                tn.ForeColor = Color.Black;
                foreach (TreeNode t in tn.Nodes)
                {
                    t.BackColor = Color.White;
                    t.ForeColor = Color.Black;
                }
            }
            //选中的树节点设置背景颜色为蓝色
            selectedNode.BackColor = Color.DodgerBlue;
            selectedNode.ForeColor = Color.White;
            //选中节点的等级为1，表示选中的是设备类型，则进行一下操作；为0标识选中下车号，不做操作
            if (selectedNode.Level == 1)
            {
                //从选中的节点Name属性中获取：机车型号Enginetype、修程XC、设备类型DeviceType
                string[] parameters = selectedNode.Name.Split(',');
                string where = "where Enginetype = \'" + parameters[0] + "\' and XC = \'" + parameters[1] + "\' and DeviceType = \'" + parameters[2] + "\' order by Component ASC, DisplayOrder DESC";
                //根据机车类型、修程、设备类型查询对应的主步骤模板
                List<FlowTemplateMain> flowTemplateMainList = FlowTemplateMain.GetList(where);
                //存放上一次模板的部件字段Component，循环展示时主模板FlowTemplateMain的Component字段与temp对比，不一致时添加新的Item，表示不同部件
                string temp = "";
                //显示部件的TreeListViewItem
                TreeListViewItem itemA = new TreeListViewItem();
                //显示主步骤的TreeListViewItem，它的SubItems显示各字段
                TreeListViewItem itemA0;
                
                for (int i = 0; i < flowTemplateMainList.Count; i++)
                {
                    //判断部件Component是否与上次加载的相同，不相同则添加新的部件
                    if (flowTemplateMainList[i].Component != temp)
                    {
                        //更新temp
                        temp = flowTemplateMainList[i].Component;
                        
                        if (i > 0)//排除第一次加载空的Item
                        {
                            //加载上一个Item
                            treeListView1.Items.Add(itemA);
                        }
                        //生成新的Item显示新的部件
                        itemA = new TreeListViewItem(temp);
                        itemA.Expand();//展开
                    }
                    
                    itemA0 = new TreeListViewItem();
                    //显示序号的SubItem
                    TreeListViewItem.ListViewSubItem subItem1 = new ListViewItem.ListViewSubItem();
                    subItem1.Text = flowTemplateMainList[i].DisplayOrder.ToString();
                    subItem1.Name = flowTemplateMainList[i].Component;
                    itemA0.SubItems.Add(subItem1);
                    //显示步骤名称的SubItem
                    TreeListViewItem.ListViewSubItem subItem2 = new TreeListViewItem.ListViewSubItem();
                    subItem2.Text = flowTemplateMainList[i].ProcedureName;
                    subItem2.Name = flowTemplateMainList[i].Quality.ToString();
                    itemA0.SubItems.Add(subItem2);
                    //显示操作时长
                    TreeListViewItem.ListViewSubItem subItem3 = new TreeListViewItem.ListViewSubItem();
                    subItem3.Text = flowTemplateMainList[i].OperateTime.ToString() + " min";
                    itemA0.SubItems.Add(subItem3);

                    TreeListViewItem.ListViewSubItem subItem4 = new TreeListViewItem.ListViewSubItem();
                    //分配人员的名称拼接字符串
                    string userNames = "";
                    if (status == "0")//分配状态下拉框选中项，未分配的设备接收单
                    {
                        //从主步骤模板中获取上次分配人员
                        if (flowTemplateMainList[i].LastCheckerCode != "" && flowTemplateMainList[i].LastCheckerCode != null)
                        {
                            //分解人员ID拼接字符串
                            string[] str = flowTemplateMainList[i].LastCheckerCode.Split(',');
                            List<UserInfo> userList = new List<UserInfo>();
                            //循环人员信息，拼接人员名称
                            for (int j = 0; j < str.Length; j++)
                            {
                                UserInfo user = new UserInfo();
                                user.Retrieve(int.Parse(str[j]));
                                userList.Add(user);
                                userNames = userNames + user.UserName + ",";
                            }
                            userNames = userNames.Substring(0, userNames.Length - 1);
                            subItem4.Name = flowTemplateMainList[i].LastCheckerCode;
                            subItem4.Text = userNames;
                        }
                    }
                    else//分配状态下拉框选中项，已分配的设备接收单
                    {
                        //获取已分配人员
                        int temId = flowTemplateMainList[i].ID;//模板ID
                        int DevReceiveID = int.Parse(selectedNode.Name.Split(',').Last().ToString());//DeviceReceive的ID
                        //查询已分配AssignedTask的CheckerIDs
                        List<AssignedTask> atList = AssignedTask.GetList("where LinkIdToDeviceReceive = " + DevReceiveID + " and TemplateID = " + temId);
                        string[] str = atList[0].CheckerIDs.Split(',');
                        List<UserInfo> userList = new List<UserInfo>();

                        for (int j = 0; j < str.Length; j++)
                        {
                            UserInfo user = new UserInfo();
                            user.Retrieve(int.Parse(str[j]));
                            userList.Add(user);
                            userNames = userNames + user.UserName + ",";
                        }
                        userNames = userNames.Substring(0, userNames.Length - 1);
                        subItem4.Name = atList[0].CheckerIDs;
                        subItem4.Text = userNames;
                    }
                    itemA0.SubItems.Add(subItem4);
                    //将模板ID存入Name属性中，点击时取出
                    itemA0.Name = flowTemplateMainList[i].ID.ToString();
                    //添加itemA0到itemA中
                    itemA.Items.Add(itemA0);
                }
                //加载最后一个Item
                treeListView1.Items.Add(itemA);
            }
            //验证是否所有任务都已指定人员
            validateAssignedUsers();
            
        }

        /// <summary>
        /// TreeListView点击事件，点击任务步骤后，右侧待选人员区域显示全部人员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TreeListView tlv = sender as TreeListView;
            //获取TreeListView被选中的Item
            ItemIndex = tlv.SelectedItems[0].Index;
            //选中的Item等级为1，表示选中的是主步骤
            if (tlv.SelectedItems[0].Level == 1)
            {
                FlowTemplateMain t = new FlowTemplateMain();
                //从选中的Item的Name属性中获取主步骤模板ID
                string ID = tlv.SelectedItems[0].Name;
                t.Retrieve(int.Parse(ID));
                templateMainID = t.ID;
                //从子项SubItems[4]的Name属性中获取选中人员ID拼接字符串
                selectedCheckerCodes = treeListView1.GetTreeListViewItemFromIndex(ItemIndex).SubItems[4].Name;
            }
            else//选中的不是主步骤，不做操作
            {
                templateMainID = 0;
                selectedCheckerCodes = "";
            }
            if (txCbbStatus.Text == "未分配")//设备接收单状态下拉框状态为未分配，则调用LoadUsers()加载带选人员
            {
                LoadUsers();
            }
        }

        /// <summary>
        /// 加载待选人员，渲染上次选择的人员
        /// </summary>
        /// <param name="templateId">模板ID</param>
        /// <returns></returns>
        public void LoadUsers()
        {
            if (treeListView1.SelectedItems.Count == 1 && treeListView1.SelectedItems[0].Level == 1)
            {
                //获取上次检查人员
                string[] userIds = selectedCheckerCodes.Split(',');
                //判断人员是否已加载
                if (IsUsersLoaded == 0)
                {
                    //清空控件
                    txGroupBox1.Controls.Clear();
                    //加载人员数据
                    for (int i = 0; i < userList.Count; i++)
                    {
                        Label label = new Label();
                        label.Size = new System.Drawing.Size(80, 40);
                        int x = (i % 4) * 100 + 30;
                        int y = (i / 4) * 60 + 30;
                        label.Location = new Point(x, y);
                        //判断该人员ID是否存在userIds中，存在则Label背景为深绿色，不存在Label浅绿色背景
                        if (userIds.Contains(userList[i].ID.ToString()))
                        {
                            label.BackColor = Color.LimeGreen;
                        }
                        else
                        {
                            label.BackColor = Color.LightCyan;
                        }
                        //设置Label显示人员名称
                        label.Text = userList[i].UserName;
                        label.Name = userList[i].ID.ToString();
                        label.TextAlign = ContentAlignment.MiddleCenter;
                        //添加Label点击事件
                        label.Click += new System.EventHandler(this.label_Click);
                        //label添加到txGroupBox1
                        txGroupBox1.Controls.Add(label);
                    }
                    //人员加载完成标识置1
                    IsUsersLoaded = 1;
                }
                else//待选人员已加载，根据被选中的TreeListViewItem中的分配人员设置待选人员Label背景色
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
            else//选中的不是主步骤，待选人员全部标识为未选中
            {
                foreach (Control ctrl in txGroupBox1.Controls)
                {
                    ctrl.BackColor = Color.LightCyan;
                }
            }
            
        }

        /// <summary>
        /// 待选人员Label点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_Click(object sender, EventArgs e)
        {
            if (treeListView1.SelectedItems[0].Level == 1)//TreeListView被选中的是主步骤
            {
                Label label = sender as Label;
                string userID = label.Name;
                string userIDs = "";
                //已选人员ID数组checkerCodes
                string[] checkerCodes = selectedCheckerCodes.Split(',');
                if (checkerCodes.Contains(userID))//已经包含该人员，去掉该人员
                {
                    label.BackColor = Color.LightCyan;//背景变为浅色，表示去掉该人员
                    //去除本次点击的人员，重新生成选中人员ID拼接字符串
                    for (int i = 0; i < checkerCodes.Length; i++)
                    {
                        if (checkerCodes[i] != userID)//已选人员ID中与本次点击的人员ID不同的则保留
                        {
                            userIDs = userIDs + checkerCodes[i] + ",";
                        }
                    }
                    //去掉最后的“,”
                    if (userIDs.Length > 1)
                    {
                        userIDs = userIDs.Substring(0, userIDs.Length - 1);
                    }
                    selectedCheckerCodes = userIDs;
                }
                else//不包含该人员，添加上该人员
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

                //根据人员ID查询人员名称，拼接
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
                //去掉最后的“,”
                if (userNames.Length > 1)
                {
                    userNames = userNames.Substring(0, userNames.Length - 1);
                }
                //显示点选后的人员名称拼接字符串
                treeListView1.GetTreeListViewItemFromIndex(ItemIndex).SubItems[4].Text = userNames;
                //在SubItem的Name属性中记录选中人员的ID拼接字符串
                treeListView1.GetTreeListViewItemFromIndex(ItemIndex).SubItems[4].Name = selectedCheckerCodes;
                //验证所有任务是否已经分配人员
                validateAssignedUsers();
            }
            else 
            {
                return;
            }
        }

        /// <summary>
        /// 分配按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAssign_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.Enabled = false;
            //从TreeListView获取分配关系
            TaskAssign();
            //操作数据库
            this.backgroundWorker1.RunWorkerAsync();
            //加载等待界面
            this.Waiting(() =>
            {
                while (!HasAssigned)
                {
                    Thread.Sleep(1000);
                }
                //Thread.Sleep(100);
                //this.Invoke(taskAssignDelegate);
                this.Info("分配完成！");
            });
        }

        /// <summary>
        /// 获取TreeListView控件中设备接收、主步骤模板、分配人员的关系
        /// </summary>
        private void TaskAssign()
        {
            //获取系统时间
            System.DateTime arrangedStartTime = DateTime.Now;
            long arrangedStartTimeLong = DateTimeHelper.ConvertDataTimeToLong(arrangedStartTime);
            //各步骤操作时长的累计时间
            long startTime = 0;
            for (int i = 0; i < treeListView1.ItemsCount; i++)
            {
                TreeListViewItem itm = treeListView1.GetTreeListViewItemFromIndex(i);

                if (itm.Name != "" && itm.Name != null && tvEngineCode.SelectedNode.Level == 1)//判断Item是主步骤
                {
                    //选中的分配人员id
                    string checkerIDs = itm.SubItems[4].Name;
                    //模板id
                    int templateID = int.Parse(itm.Name);
                    //任务分配单
                    AssignedTask at = new AssignedTask();
                    //从TreeView中获取选中节点的设备接收ID
                    string[] st = tvEngineCode.SelectedNode.Name.Split(',');
                    //设备接收ID
                    string deviceReceiveID = st.Last();
                    //任务分配单关联设备接收ID
                    at.LinkIdToDeviceReceive = int.Parse(deviceReceiveID);
                    DeviceReceive deviceReceive = new DeviceReceive();
                    deviceReceive.Retrieve(at.LinkIdToDeviceReceive);
                    //任务分配单批次号
                    at.BatchCode = deviceReceive.BatchCode;
                    //任务分配单主步骤模板ID
                    at.TemplateID = templateID;
                    //部件
                    at.Component = itm.SubItems[1].Name;
                    //
                    at.Quality = Int16.Parse(itm.SubItems[2].Name);
                    //任务分配单分配人员ID拼接字符串
                    at.CheckerIDs = checkerIDs;
                   
                    //处理计划开始时间
                    at.ArrangedStartTime = arrangedStartTimeLong + startTime;
                    FlowTemplateMain template = new FlowTemplateMain();
                    template.Retrieve(templateID);
                    if (template.DisplayOrder == 1)
                    {
                        //开始
                        at.Status = "1";
                        //计划结束时间
                        at.ArrangedEndTime = arrangedStartTimeLong + startTime;
                    }
                    else
                    {
                        at.Status = "0";
                    }
                    //操作时长累加
                    startTime += template.OperateTime * 60 * 1000;
                    //添加到全局变量，之后做数据库操作
                    assignedTaskList.Add(at);
                    template.LastCheckerCode = checkerIDs;
                    //要更新上次操作人员的主步骤模板，之后做数据库操作
                    templateList.Add(template);
                }
                else
                {
                    //新部件，累计时间置零
                    startTime = 0;
                }
            }
            //从TreeView的节点获取设备接收ID，设备接收数据状态置为1：已分配，之后操作数据库修改
            int DeviceReceiveID = int.Parse(tvEngineCode.SelectedNode.Name.Split(',').GetValue(4).ToString());
            
            devReceive.Retrieve(DeviceReceiveID);
            devReceive.Status = "1";
            //devReceive.Update();
            
            //重新加载车号车型树形结构
            //判断该下车号下是否还有别的设备，若没有则去掉该下车号节点
            if (tvEngineCode.SelectedNode.Parent.Nodes.Count == 1)
            {
                tvEngineCode.SelectedNode.Parent.Remove();
            }
            else//该下车号下还有其他设备，去除该下车号下的ben此操作设备
            {
                tvEngineCode.SelectedNode.Remove();
            }
            //TreeView选中节点置为null；
            tvEngineCode.SelectedNode = null;
            //清空主步骤展示控件TreeListView
            treeListView1.Items.Clear();
            //清空待选选人员控件
            txGroupBox1.Controls.Clear();
            //人员加载完成标识置1
            IsUsersLoaded = 1;
        }

        /// <summary>
        /// 判断每个主步骤是否都已分配人员，并设置分配按钮是否可用
        /// </summary>
        /// <returns></returns>
        private bool validateAssignedUsers()
        {
            if (tvEngineCode.SelectedNode.Level == 1 && txCbbStatus.SelectedIndex == 0)//TreeView选中的是设备，并且设备接收单状态下拉框选中的未分配
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
                            //this.Error("\"" + itm.Parent.Text + "-" + itm.SubItems[1].Text + "-" + itm.SubItems[2].Text + "\" 未指定人员，所有任务指定人员后才能分配！");
                            //分配按钮置为不可用状态
                            btnAssign.Enabled = false;
                            btnAssign.BackColor = Color.Gray;
                            return false;
                        }
                    }
                }
                //所有任务都已分配人员后，分配按钮可用
                btnAssign.Enabled = true;
                btnAssign.BackColor = Color.DodgerBlue;
                return true;
            }
            else
            {
                btnAssign.Enabled = false;
                btnAssign.BackColor = Color.Gray;
                return false;
            }
        }

        /// <summary>
        /// 操作数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //新增已分配任务
            foreach(AssignedTask at in assignedTaskList){
                
                at.Add();
                string where = "where LinkId = " + at.TemplateID + " Order by ID";
                List<FlowTemplateDetail> list = FlowTemplateDetail.GetList(where);
                foreach (var ftd in list)
                {
                    UserTaskDetail utd = new UserTaskDetail();
                    utd.TemplateMainId = ftd.LinkId;
                    utd.TemplateDetailId = ftd.ID;
                    utd.UserIds = at.CheckerIDs;
                    utd.Status = "0";
                    utd.DeviceReceiveID = at.LinkIdToDeviceReceive;
                    utd.AssignedTaskID = at.GetInsertID();
                    utd.Add();
                }
            }
            //修改模板中上次分配人员
            foreach (FlowTemplateMain tmplt in templateList)
            {
                tmplt.Update();
            }
            //新增任务执行人员与任务具体步骤的关联，初始状态为0：具体步骤未执行；执行完毕为1

            devReceive.Update();
            
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HasAssigned = true;
        }

    }
}
