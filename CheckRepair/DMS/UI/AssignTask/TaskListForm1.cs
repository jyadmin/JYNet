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
using DMS.DomainObjects.BasicInfo;

namespace DMS.UI.AssignTask
{
    public partial class TaskListForm1 :  TX.Framework.WindowUI.Forms.BaseForm
    {
        protected int ItemIndex;
        protected string selectedCheckerCodes;
        protected int templateID;
        public TaskListForm1()
        {
            InitializeComponent();
        }
        private void btnEngineType_Click(object sender, EventArgs e)
        {

            List<DeviceReceive> list = new List<DeviceReceive>();
            string where = String.Empty;
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnHXD1BC5":
                    where = "where EngineType = \'HXD1B\' and XC = \'C5\'";
                    btnHXD1BC5.BackColor = Color.DodgerBlue;
                    btnHXD1DC5.BackColor = Color.White;
                    btnHXD1C5.BackColor = Color.White;
                    btnHXD3CC4.BackColor = Color.White;
                    btnHXD3CC5.BackColor = Color.White;
                    btnHXD3C5.BackColor = Color.White;
                    break;
                case "btnHXD1DC5":
                    where = "where EngineType = \'HXD1D\' and XC = \'C5\'";
                    btnHXD1BC5.BackColor = Color.White;
                    btnHXD1DC5.BackColor = Color.DodgerBlue;
                    btnHXD1C5.BackColor = Color.White;
                    btnHXD3CC4.BackColor = Color.White;
                    btnHXD3CC5.BackColor = Color.White;
                    btnHXD3C5.BackColor = Color.White;
                    break;
                case "btnHXD1C5":
                    where = "where EngineType = \'HXD1\' and XC = \'C5\'";
                    btnHXD1BC5.BackColor = Color.White;
                    btnHXD1DC5.BackColor = Color.White;
                    btnHXD1C5.BackColor = Color.DodgerBlue;
                    btnHXD3CC4.BackColor = Color.White;
                    btnHXD3CC5.BackColor = Color.White;
                    btnHXD3C5.BackColor = Color.White;
                    break;
                case "btnHXD3CC4":
                    where = "where EngineType = \'HXD3C\' and XC = \'C4\'";
                    btnHXD1BC5.BackColor = Color.White;
                    btnHXD1DC5.BackColor = Color.White;
                    btnHXD1C5.BackColor = Color.White;
                    btnHXD3CC4.BackColor = Color.DodgerBlue;
                    btnHXD3CC5.BackColor = Color.White;
                    btnHXD3C5.BackColor = Color.White;
                    break;
                case "btnHXD3CC5":
                    where = "where EngineType = \'HXD3C\' and XC = \'C5\'";
                    btnHXD1BC5.BackColor = Color.White;
                    btnHXD1DC5.BackColor = Color.White;
                    btnHXD1C5.BackColor = Color.White;
                    btnHXD3CC4.BackColor = Color.White;
                    btnHXD3CC5.BackColor = Color.DodgerBlue;
                    btnHXD3C5.BackColor = Color.White;
                    break;
                case "btnHXD3C5":
                    where = "where EngineType = \'HXD3\' and XC = \'C5\'";
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
                            tvEngineCode.Nodes[i].Nodes.Add(list[j].DeviceType);
                            tvEngineCode.Nodes[i].LastNode.Name = list[j].EngineType + "," + list[j].XC + "," + list[j].DeviceType + "," + list[j].EngineCode;
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
                itemA0.SubItems.Add(flowTemplateMainList[i].ProcedureName);
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
                itemA0.SubItems.Add(userNames);
                //将模板ID、treeListViewItem的Index、上次分配人员存入Name属性中，点击时取出
                itemA0.Name = flowTemplateMainList[i].ID.ToString() + ";" + flowTemplateMainList[i].LastCheckerCode;
                itemA.Items.Add(itemA0);
            }
            treeListView1.Items.Add(itemA);
        }

        public void LoadUsers(string templateId, int itemIndex, string UserIDs)
        {
            ////设置显示模式
            //this.listViewUser.View = View.LargeIcon;
            //this.listViewUser.BeginUpdate();
            //查询所有人员
            List<UserInfo> userList = UserInfo.GetList();
            //查询上次检查人员
            string[] userIds = UserIDs.Split(',');

            //清空
            txGroupBox1.Controls.Clear();
            
            //加载人员数据
            for (int i = 0; i < userList.Count; i++)
            {
                Label label = new Label();
                label.Size = new System.Drawing.Size(80, 80);
                int x = (i % 3) * 100 + 30;
                int y = (i / 3) * 100 + 30;
                label.Location = new Point(x, y);
                if (userIds.Contains(userList[i].ID.ToString()))
                {
                    label.BackColor = Color.DodgerBlue;
                }
                else
                {
                    label.BackColor = Color.LightSkyBlue;
                }
                label.Text = userList[i].UserName;
                label.Name = userList[i].ID.ToString();
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Click += new System.EventHandler(this.label_Click);
                txGroupBox1.Controls.Add(label);
                
            }
        }

        private void treeListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            TreeListView tlv = sender as TreeListView;
            if (tlv.SelectedItems[0].Name == "")
            {
                return;
            }
            ItemIndex = tlv.SelectedItems[0].Index;
            FlowTemplateMain t = new FlowTemplateMain();
            string ID = tlv.SelectedItems[0].Name.Split(';').GetValue(0).ToString();
            t.Retrieve(int.Parse(ID));
            templateID = t.ID;
            selectedCheckerCodes = t.LastCheckerCode;
            string[] strs = tlv.SelectedItems[0].Name.Split(';');
            LoadUsers(strs[0], ItemIndex, strs[1]);
        }

        private void label_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;
            string userID = label.Name;
            string userIDs = "";
            string[] checkerCodes = selectedCheckerCodes.Split(',');
            if (checkerCodes.Contains(userID))//已经包含该人员
            {
                label.BackColor = Color.LightSkyBlue;//背景变为浅色
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
                label.BackColor = Color.DodgerBlue;//背景变为深色
                if (selectedCheckerCodes != "" && selectedCheckerCodes != null)
                {
                    selectedCheckerCodes = selectedCheckerCodes + "," + userID;
                }
                else
                {
                    selectedCheckerCodes = userID;
                }
            }
            //写入数据库
           // t.Update();
            //修改模板后分配人员
            string[] str = selectedCheckerCodes.Split(',');
            string userNames = "";
            for (int j = 0; j < str.Length; j++)
            {
                if(str[j] != "" && str[j] != null){
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
            
        }
    }
}
