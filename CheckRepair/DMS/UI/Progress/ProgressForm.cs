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

namespace DMS.UI.Progress
{
    public partial class ProgressForm :  TX.Framework.WindowUI.Forms.BaseForm
    {

        private int c = 0;//列编号,用于循环布局Label
        private int r = 0;//行编号,用于循环布局Label

        public ProgressForm()
        {
            InitializeComponent();
            //设置时间选择器不显示勾选框，（在时间选择器控件属性中设置无效，只能初始化时动态设置）
            this.txDateTimePicker1.ShowCheckBox = false;
            this.txDateTimePicker2.ShowCheckBox = false;
            //Form的Load事件调用LoadTreeView加载已分配任务
        }

        /// <summary>
        /// 树形控件TreeView点击事件，根据被点击的项展示具体步骤完成情况
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvEngineCode_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeView treeView = sender as TreeView;
            TreeNode selectedNode = treeView.SelectedNode;
            //点击后三级选项背景色置为白色
            foreach (TreeNode tn in treeView.Nodes)
            {
                tn.BackColor = Color.White;
                tn.ForeColor = Color.Black;
                foreach (TreeNode tn1 in tn.Nodes)
                {
                    tn1.BackColor = Color.White;
                    tn1.ForeColor = Color.Black;
                    foreach (TreeNode tn2 in tn1.Nodes)
                    {
                        tn2.BackColor = Color.White;
                        tn2.ForeColor = Color.Black;
                    }
                }
            }
            //选中项背景色置为蓝色DodgerBlue
            selectedNode.BackColor = Color.DodgerBlue;
            selectedNode.ForeColor = Color.White;
            

            //查询分配工单，关联模板展示
            if (selectedNode.Level == 2)//选中项等级为2，标识选中的是风机的部件（风机或电机）
            {
                //展示主步骤的panel清空
                panelMainProgress.Controls.Clear();
                //展示详细步骤的panel清空
                panelDetailProgress.Controls.Clear();
                //从选中项的Name属性中获取设备接收ID
                string[] parameters = selectedNode.Name.Split(',');
                //根据设备接收ID查询任务分配单
                string where = "where LinkIdToDeviceReceive = \'" + parameters[5] + "\' order by TemplateID ASC";
                List<AssignedTask> assignedTaskList = AssignedTask.GetList(where);
                //根据任务分配单查询对应的主步骤模板，用Label显示
                for (int i = 0; i < assignedTaskList.Count; i++ )
                {
                    //查询主步骤模板
                    FlowTemplateMain ftm = new FlowTemplateMain();
                    ftm.Retrieve(assignedTaskList[i].TemplateID);
                    //判断主步骤模板与树形控件选中项是否一致，若一致则调用setMainLabel()方法显示
                    if (ftm.Component == selectedNode.Text)                
                    {
                        //显示主步骤
                        setMainLabel(ftm.ProcedureName, r, assignedTaskList[i].Status);
                        //根据任务分配单ID查询详细步骤与人员的关联关系UserTaskDetail
                        List<UserTaskDetail> utdList = UserTaskDetail.GetList("where AssignedTaskID = \'" + assignedTaskList[i].ID + "\' order by TemplateDetailId ASC");
                        for (int j = 0; j < utdList.Count; j++)
                        {
                            //根据详细步骤与人员关系查询详细步骤模板
                            FlowTemplateDetail ftd = new FlowTemplateDetail();
                            ftd.Retrieve(utdList[j].TemplateDetailId);
                            //显示详细步骤
                            setDetailLabel(ftd.OperateItem, r, c, utdList[j]);
                            //列数增长
                            c++;
                        }
                        //列数归零
                        c = 0;
                        //行数增长
                        r++;
                    }
                }
                //全局变量行列数归零
                r = 0;
                
            }
        }

        /// <summary>
        /// 设置主步骤Label的位置，显示文本
        /// </summary>
        /// <param name="labelText">显示文本</param>
        /// <param name="row">行数</param>
        /// <param name="status">执行状态</param>
        public void setMainLabel(string labelText, int row, string status)
        {
            Label label = new Label();
            label.AutoSize = false;
            label.Size = new Size(120, 50);
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Text = labelText;
            label.Location = new Point(10, 10 + row * 60);
            //判断步骤执行状态，设置Label背景色
            if (status == "3")//检验合格，绿色
            {
                label.BackColor = Color.Green;
            }
            else if (status == "2")//待检验，浅绿色
            {
                label.BackColor = Color.LightGreen;
            }
            else if (status == "4")//检验不合格红色
            {
                label.BackColor = Color.Red;
            }
            else//未执行或待执行
            {
                label.BackColor = Color.Silver;
            }
            //在panel中添加Label
            panelMainProgress.Controls.Add(label);
        }

        /// <summary>
        /// 设置详细步骤Label的位置，显示文本
        /// </summary>
        /// <param name="labelText">显示文本</param>
        /// <param name="row">行数</param>
        /// <param name="col">列数</param>
        /// <param name="status">执行状态</param>
        public void setDetailLabel(string labelText, int row, int col, UserTaskDetail utd)
        {
            Label label = new Label();
            label.AutoSize = false;
            label.Size = new Size(120, 50);
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Text = labelText;
            label.Location = new Point(10 + col * 130, 10 + row * 60);
            //判断步骤执行状态，设置Label背景色
            if (utd.Status == "2")//完成
            {
                if (utd.statusColor == 0)//符合标准
                {
                    label.BackColor = Color.Green;
                }
                else
                {
                    label.BackColor = Color.Red;//不符合标准
                }
            }
            else//未完成
            {
                label.BackColor = Color.Silver;
            }
            //在panel中添加Label
            panelDetailProgress.Controls.Add(label);
        }

        /// <summary>
        /// 加载左侧树形结构，展示下车号，车型，修程，部件
        /// </summary>
        private void LoadTreeView(object sender, EventArgs e)
        {
            //TreeView清空
            tvEngineCode.Nodes.Clear();
            List<DeviceReceive> list = new List<DeviceReceive>();
            //处理时间区间
            DateTime dtS = DateTime.Today;//开始时间DateTime
            DateTime dtE = DateTime.Today;//结束时间DateTime
            long dtStart = 0;//开始时间long形式
            long dtEnd = 0;//结束时间long形式
            //获取时间选择控件的值，时间选择控件在未点选前的值为null，需要做特殊处理，当时间控件的值为null时取值为当前系统时间
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
            //根据时间段查询设备接收单
            string where = "where ReceiveTime >= " + dtStart + " and ReceiveTime <= " + dtEnd;
            list = DeviceReceive.GetList(where);
            //获取下车号EngineCode字段
            List<string> EngineCodeStrList = new List<string>();
            for (int i = 0; i < list.Count; i++)
            {
                EngineCodeStrList.Add(list[i].EngineCode);
            }
            if (list.Count > 0)
            {
                //去除重复的下车号
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
                    //显示下车号的节点
                    TreeNode tn = new TreeNode();
                    tn.Text = EngineCodeStrList[i];
                    tn.Name = EngineCodeStrList[i];
                    for (int j = 0; j < list.Count; j++)
                    {
                        if (EngineCodeStrList[i] == list[j].EngineCode)
                        {
                            //显示车型、修程、设备类型的节点
                            TreeNode tn1 = new TreeNode();
                            tn1.Text = list[j].EngineType + "_" + list[j].XC + "_" + list[j].DeviceType;

                            //根据设备接收单的设备类型、修程、机车类型查询主模板，获取模板部件Component字段
                            string where1 = "where Enginetype = \'" + list[j].EngineType + "\' and XC = \'" + list[j].XC + "\' and DeviceType = \'" + list[j].DeviceType + "\' order by Component ASC, DisplayOrder DESC";
                            List<FlowTemplateMain> flowTemplateMainList = FlowTemplateMain.GetList(where1);
                            //临时存放上次加载的FlowTemplateMain的Component字段，循环判断flowTemplateMainList中每个类的Component是否与已加载的相同，相同则不加载，不同则加载。
                            string lastComponent = "";
                            for (int k = 0; k < flowTemplateMainList.Count; k++)
                            {
                                if (flowTemplateMainList[k].Component != lastComponent)
                                {
                                    TreeNode tn2 = new TreeNode();
                                    //加载
                                    tn2.Text = flowTemplateMainList[k].Component;
                                    //在Name中存放车型、修程、设备类型、车号（下车号）、设备接收ID
                                    tn2.Name = list[j].EngineType + "," + list[j].XC + "," + list[j].DeviceType + "," + flowTemplateMainList[k].Component + "," + list[j].EngineCode + "," + list[j].ID;
                                    //附加到上级节点
                                    tn1.Nodes.Add(tn2);
                                    //修改上次加载的Component
                                    lastComponent = flowTemplateMainList[k].Component;
                                }
                            }
                            //附加到上级节点
                            tn.Nodes.Add(tn1);
                        }
                    }
                    //附加到TreeView
                    tvEngineCode.Nodes.Add(tn);
                }
            }
        }

    }
}
