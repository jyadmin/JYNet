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

namespace DMS.UI.TaskDetail
{
    public partial class TaskDetailForm : TX.Framework.WindowUI.Forms.BaseForm
    {
        private int AssignedTaskID;
        private int FlowTemplateMainID;
        private int DeviceReceiveID;
        //private List<Dictionary<TXPanel, PictureBox>> list = new List<Dictionary<TXPanel, PictureBox>>();
        private int h = 0;
        private int w = 0;
        static public int isFinished = 0;
        private List<UserTaskDetail> utdList;
        public TaskDetailForm(int assignedTaskID, int templateMainID, int deviceReceiveID, string formName)
        {
            InitializeComponent();
            this.Text = formName;
            AssignedTaskID = assignedTaskID;
            FlowTemplateMainID = templateMainID;
            DeviceReceiveID = deviceReceiveID;
            AssignedTask at = new AssignedTask();
            at.Retrieve(AssignedTaskID);
            //任务完成，提交按钮失效
            if (at.Status != "2")
            {
                txButtonFinished.Enabled = true;
            }
        }

        void label_DoubleClick(object sender, EventArgs e)
        {
            Label label = sender as Label;
            UserTaskDetail utd = new UserTaskDetail();
            utd.Retrieve(int.Parse(label.Name));
            new Form1(utd.Status).ShowDialog();
            if(isFinished == 1){//修改label背景色和对应数据库中数据的status置为1
                label.Parent.GetNextControl(label,false).BackColor = Color.Green;
                label.BackColor = Color.Green;
                utd.Status = "1";
                utd.Update();
                foreach (var userTaskDetail in utdList)
                {
                    if (userTaskDetail.ID == int.Parse(label.Name))
                    {
                        userTaskDetail.Status = "1";
                    }
                }
            }
            //完成标识重新置0
            isFinished = 0;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            FlowTemplateMain template = new FlowTemplateMain();
            template.Retrieve(FlowTemplateMainID);
            /*
            if (template.DisplayOrder != 1)//不是第一项
            {
                template.Retrieve(FlowTemplateMainID - 1);
                string where = "where LinkIdToDeviceReceive = " + DeviceReceiveID + " and TemplateID = " + FlowTemplateMainID;
                List<AssignedTask> assignedTaskList = AssignedTask.GetList(where);
            }*/
            string where1 = "where LinkId = " + FlowTemplateMainID + "Order by ID";
            List<FlowTemplateDetail> templateDetailList = FlowTemplateDetail.GetList(where1);
            string where2 = "where DeviceReceiveID = " + DeviceReceiveID + "and TemplateMainId = " + FlowTemplateMainID +" Order by ID";
            utdList = UserTaskDetail.GetList(where2);
            txPanelRight.Controls.Clear();
            for (int i = 0; i < templateDetailList.Count; i++ )
                //foreach (FlowTemplateDetail ftd in templateDetailList)
            {
                TXPanel txPanel = new TXPanel();

                txPanel.Size = new Size(240, 226);
                //txPanel.Location = new Point(16, 16);
                Label labelA = new Label();
                labelA.Size = new Size(230, 23);
                labelA.Location = new Point(5, 6);
                labelA.Text = templateDetailList[i].OperateItem;
                labelA.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                labelA.TextAlign = ContentAlignment.MiddleLeft;
                if (utdList[i].Status == "0")
                {
                    labelA.BackColor = Color.Silver;
                }
                else if (utdList[i].Status == "1")
                {
                    labelA.BackColor = Color.Green;
                }
                Label labelB = new Label();
                labelB.Size = new Size(230, 190);
                labelB.Location = new Point(5, 29);
                labelB.Text = templateDetailList[i].OperateContentAndStandard;
                labelB.TextAlign = ContentAlignment.MiddleLeft;
                labelB.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                if (utdList[i].Status == "0")
                {
                    labelB.BackColor = Color.Silver;
                }
                else if (utdList[i].Status == "1")
                {
                    labelB.BackColor = Color.Green;
                }

                //在Name属性中存放UserTaskDetail的ID，点击事件中用来获取UserTaskDetail
                labelB.Name = utdList[i].ID.ToString();
                labelB.DoubleClick += label_DoubleClick;
                txPanel.Controls.Add(labelA);
                txPanel.Controls.Add(labelB);
                PictureBox pic = new PictureBox();
                setPosition(txPanel, pic);
                if (templateDetailList[i] != templateDetailList.Last())
                {
                    pic.Size = new Size(60, 80);
                    //pic.Location = new Point(262, 99);
                    pic.Image = global::DMS.Properties.Resources.right;
                    txPanelRight.Controls.Add(pic);
                }
                txPanelRight.Controls.Add(txPanel);
            }
        }

        private void setPosition(TXPanel txPanel, PictureBox pic)
        {
            //txPanel的坐标
            int x = 16 + (240 + 6 + 60 + 6) * w;
            int y = 16 + (226 + 16) * h;
            //pic的坐标
            int x1 = x + 240 + 6;
            int y1 = y + 113 - 30;
            if (x1 + 60 + 6 > txPanelRight.ClientSize.Width)
            {
                h++;
                w = 0;
                //txPanel的坐标
                x = 16 + (240 + 6 + 60 + 6) * w;
                y = 16 + (226 + 16) * h;
                //pic的坐标
                x1 = x + 240 + 6;
                y1 = y + 113 - 30;
            }
            txPanel.Location = new Point(x, y);
            pic.Location = new Point(x1, y1);
            w++;
        }

        private void txButtonFinished_Click(object sender, EventArgs e)
        {
            foreach (var utd in utdList)
            {
                if (utd.Status != "1")
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
            AssignedTask at = new AssignedTask();
            at.Retrieve(AssignedTaskID);
            at.Status = "2";
            at.Update();
            this.Close();
        }
    }
}
