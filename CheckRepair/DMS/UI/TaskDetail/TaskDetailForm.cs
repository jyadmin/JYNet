using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DMS.DomainObjects.BusinessFunctions;
using TX.Framework.WindowUI.Controls;
using DMS.UI.Forms;
using DMS.DomainObjects;


namespace DMS.UI.TaskDetail
{
    /// <summary>
    /// 详细步骤展示
    /// </summary>
    public partial class TaskDetailForm : TX.Framework.WindowUI.Forms.BaseForm
    {
        //任务分配单ID
        private int AssignedTaskID;
        //主步骤模板ID
        private int FlowTemplateMainID;
        //设备接收单ID
        private int DeviceReceiveID;
        //行标志
        private int r = 0;
        //列标志
        private int c = 0;
        //详细步骤完成标识，完成为1，未完成为0
        static public int isFinished = 0;
        //详细步骤操作结果背景色，合格为0绿色，不合格为1红色。isFinished为1时判断
        static public int statusColor = 0;
        //详细步骤列表
        private List<UserTaskDetail> utdList;

        /// <summary>
        /// TaskDetailForm构造方法
        /// </summary>
        /// <param name="assignedTaskID">任务分配单ID</param>
        /// <param name="templateMainID">主步骤模板ID</param>
        /// <param name="deviceReceiveID">设备接收单ID</param>
        /// <param name="formName">form表单标题</param>
        /// <param name="funcType">功能类型，1检修，2检验</param>
        public TaskDetailForm(int assignedTaskID, int templateMainID, int deviceReceiveID, string formName, int funcType)
        {
            InitializeComponent();
            //设置form的标题
            this.Text = formName;
            //初始化全局变量
            AssignedTaskID = assignedTaskID;
            FlowTemplateMainID = templateMainID;
            DeviceReceiveID = deviceReceiveID;
            //从数据库获取任务信息
            AssignedTask at = new AssignedTask();
            at.Retrieve(AssignedTaskID);
            //任务已完成，设置提交按钮失效
            if (at.Status != "2")
            {
                txButtonFinished.Enabled = true;
            }
            if (funcType ==2)//是质检员
            {
                txButtonFinished.Visible = false;
            }
            else
            {
                txButtonInspect1.Visible = false;
                txButtonInspect2.Visible = false;
            }
        }

        /// <summary>
        /// 详细步骤方框点击事件，展示检测信息输入Form表单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void label_DoubleClick(object sender, EventArgs e)
        {
            Label label = sender as Label;
            //从数据库获取详细步骤和人员关联
            UserTaskDetail utd = new UserTaskDetail();
            utd.Retrieve(int.Parse(label.Name));
            //从数据库获取详细步骤模板
            FlowTemplateDetail ftd = new FlowTemplateDetail();
            ftd.Retrieve(utd.TemplateDetailId);
            //根据FormType展示对应的信息输入form表单
            if (ftd.FormType == 1)
            {
                new Form1(DeviceReceiveID, utd.ID, utd.Status).ShowDialog();
            }
            else if (ftd.FormType == 2)
            {
                new Form2(DeviceReceiveID, utd.ID, utd.Status).ShowDialog();
            }
            else if (ftd.FormType == 3)
            {
                new Form3(DeviceReceiveID, utd.ID, utd.Status).ShowDialog();
            }
            else if (ftd.FormType == 4)
            {
                new Form4(DeviceReceiveID, utd.ID, utd.Status).ShowDialog();
            }
            else if (ftd.FormType == 5)
            {
                new Form5(DeviceReceiveID, utd.ID, utd.Status).ShowDialog();
            }

            //检测信息输入完成后，修改label背景色和对应数据库中数据的status置为2
            if(isFinished == 1){
               
                if (statusColor == 0)
                {
                    label.Parent.GetNextControl(label, false).BackColor = Color.Green;
                    label.BackColor = Color.Green;
                }
                else
                {
                    label.Parent.GetNextControl(label, false).BackColor = Color.Red;
                    label.BackColor = Color.Red;
                }
                //在数据库中设置UserTaskDetail的状态Status为2已经完成
                utd.Status = "2";
                utd.statusColor = statusColor;
                utd.Update();
                //设置全局变量中被操作的UserTaskDetail的状态Status为2
                foreach (var userTaskDetail in utdList)
                {
                    if (userTaskDetail.ID == int.Parse(label.Name))
                    {
                        userTaskDetail.Status = "2";
                        userTaskDetail.statusColor = statusColor;
                    }
                }
            }
            //标识重新置0
            isFinished = 0;
            statusColor = 0;
        }

        /// <summary>
        /// Form加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
        }

        /// <summary>
        /// 加载主步骤所属的详情步骤
        /// </summary>
        private void loadData()
        {
            //从数据库查询主步骤模板
            FlowTemplateMain template = new FlowTemplateMain();
            template.Retrieve(FlowTemplateMainID);
            //根据主步骤模板查询详细步骤
            string where1 = "where LinkId = " + FlowTemplateMainID + "Order by ID";
            List<FlowTemplateDetail> templateDetailList = FlowTemplateDetail.GetList(where1);
            //根据主步骤ID和设备接收ID查询详细步骤与人员的关联
            string where2 = "where DeviceReceiveID = " + DeviceReceiveID + "and TemplateMainId = " + FlowTemplateMainID +" Order by ID";
            utdList = UserTaskDetail.GetList(where2);
            //清空详情步骤展示控件txPanelRight
            txPanelRight.Controls.Clear();
            //加载主步骤所属的详细步骤：
            //在panel放置两个Label，labelA和labelB，labelA显示详细步骤的名称，labelB显示详细步骤的内容
            for (int i = 0; i < templateDetailList.Count; i++ )
            {
                TXPanel txPanel = new TXPanel();
                txPanel.Size = new Size(240, 226);
                //显示标题的labelA
                Label labelA = new Label();
                labelA.Size = new Size(230, 23);
                labelA.Location = new Point(5, 6);
                labelA.Text = templateDetailList[i].OperateItem;
                labelA.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                labelA.TextAlign = ContentAlignment.MiddleLeft;
                //根据人员与详细步骤关联的状态设置背景色
                if (utdList[i].Status == "0")
                {
                    labelA.BackColor = Color.Silver;
                }
                else if (utdList[i].Status == "2")
                {
                    if (utdList[i].statusColor == 1)
                    {
                        labelA.BackColor = Color.Red;
                    }
                    else
                    {
                        labelA.BackColor = Color.Green;
                    }
                }
                //显示详细步骤内容的labelB
                Label labelB = new Label();
                labelB.Size = new Size(230, 190);
                labelB.Location = new Point(5, 29);
                labelB.Text = templateDetailList[i].OperateContentAndStandard;
                labelB.TextAlign = ContentAlignment.MiddleLeft;
                labelB.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                //根据人员与详细步骤关联的状态设置背景色
                if (utdList[i].Status == "0")
                {
                    labelB.BackColor = Color.Silver;
                }
                else if (utdList[i].Status == "2")
                {
                    if (utdList[i].statusColor == 1)
                    {
                        labelB.BackColor = Color.Red;
                    }
                    else
                    {
                        labelB.BackColor = Color.Green;
                    }
                }

                //在Name属性中存放UserTaskDetail的ID，点击事件中用来获取UserTaskDetail
                labelB.Name = utdList[i].ID.ToString();
                //添加双击事件
                labelB.DoubleClick += label_DoubleClick;
                //labelA和labelB添加到txPanel中
                txPanel.Controls.Add(labelA);
                txPanel.Controls.Add(labelB);
                //箭头图片
                PictureBox pic = new PictureBox();
                //设置txPanel和图片的显示位置
                setPosition(txPanel, pic);
                //判断是否是最后一步，若不是则显示箭头图片
                if (templateDetailList[i] != templateDetailList.Last())
                {
                    pic.Size = new Size(60, 80);
                    //pic.Location = new Point(262, 99);
                    pic.Image = global::DMS.Properties.Resources.right;
                    txPanelRight.Controls.Add(pic);
                }
                //txPanel添加到txPanelRight展示
                txPanelRight.Controls.Add(txPanel);
            }
        }

        /// <summary>
        /// 设置展示单个详细步骤的txPanel和箭头图片的放置位置
        /// </summary>
        /// <param name="txPanel"></param>
        /// <param name="pic"></param>
        private void setPosition(TXPanel txPanel, PictureBox pic)
        {
            //txPanel的坐标
            int x = 16 + (240 + 6 + 60 + 6) * c;
            int y = 16 + (226 + 16) * r;
            //pic的坐标
            int x1 = x + 240 + 6;
            int y1 = y + 113 - 30;
            //横向超出，换行
            if (x1 + 60 + 6 > txPanelRight.ClientSize.Width)
            {
                r++;
                c = 0;
                //txPanel的坐标
                x = 16 + (240 + 6 + 60 + 6) * c;
                y = 16 + (226 + 16) * r;
                //pic的坐标
                x1 = x + 240 + 6;
                y1 = y + 113 - 30;
            }
            txPanel.Location = new Point(x, y);
            pic.Location = new Point(x1, y1);
            c++;
        }

        /// <summary>
        /// 完成提交按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txButtonFinished_Click(object sender, EventArgs e)
        {
            //检查所有详细步骤是否检测完成
            foreach (var utd in utdList)
            {
                if (utd.Status != "2")
                {
                    this.Info("提示", "有未完成的步骤，请完成后再提交");
                    return;
                }
            }
            DialogResult r = this.Info("确定提交？");
            if (r == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
            //更新任务分配单状态为“已完成”
            AssignedTask at = new AssignedTask();
            at.Retrieve(AssignedTaskID);
            at.Status = "2";
            at.Update();
            //更新下一步任务分配单状态为“待执行”

            AssignedTask at1 = new AssignedTask();
            
            //获取最大ID
            int maxID = at1.GetInsertID();
            if (maxID >= AssignedTaskID + 1)//判断ID未超出最后一个任务分配单
            {
                at1.Retrieve(AssignedTaskID + 1);//获取下一个任务分配单
                if (at1.Component == at.Component && at1.LinkIdToDeviceReceive == at.LinkIdToDeviceReceive)//同一个部件的下一个任务
                {
                    at1.Status = "1";//下一个任务状态变为“待执行”
                    at1.Update();
                }
            }
            this.Close();
        }

        /// <summary>
        /// 检验合格按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txButtonInspect1_Click(object sender, EventArgs e)
        {
            DialogResult r = this.Info("确定提交？");
            if (r == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
            //更新任务分配单状态为“检验合格”
            AssignedTask at = new AssignedTask();
            at.Retrieve(AssignedTaskID);
            at.Status = "3";//合格
            at.InspectorID = CurrentUser.Instance.User.ID;
            at.Update();
            this.Close();
        }

        /// <summary>
        /// 检验不合格按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txButtonInspect2_Click(object sender, EventArgs e)
        {
            DialogResult r = this.Info("确定提交？");
            if (r == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
            //更新任务分配单状态为“检验不合格”
            AssignedTask at = new AssignedTask();
            at.Retrieve(AssignedTaskID);
            at.Status = "4";//不合格
            at.InspectorID = CurrentUser.Instance.User.ID;
            at.Update();
            this.Close();
        }

       
    }
}
