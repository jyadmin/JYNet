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

namespace DMS.UI.Forms
{
    public partial class Form1 :  TX.Framework.WindowUI.Forms.BaseForm
    {
        private int FlowTemplateMainID;
        private int DeviceReceiveID;
        private List<Dictionary<TXPanel, PictureBox>> list = new List<Dictionary<TXPanel, PictureBox>>();
        private int h = 0;
        private int w = 0;
        public Form1(int templateMainID, int deviceReceiveID, string formName)
        {
            InitializeComponent();
            this.Text = formName;
            FlowTemplateMainID = templateMainID;
            DeviceReceiveID = deviceReceiveID;
        }

        private void loadData()
        {
            FlowTemplateMain template = new FlowTemplateMain();
            template.Retrieve(FlowTemplateMainID);
            if (template.DisplayOrder != 1)//不是第一项
            {
                template.Retrieve(FlowTemplateMainID - 1);
                string where = "where LinkIdToDeviceReceive = " + DeviceReceiveID + " and TemplateID = " + FlowTemplateMainID;
                List<AssignedTask> assignedTaskList = AssignedTask.GetList(where);
                string Status = assignedTaskList[0].Status;
                //txPanelLeft.Controls.Add();
            }
            string where1 = "where LinkId = " + FlowTemplateMainID + "Order by ID";
            List<FlowTemplateDetail> templateDetailList = FlowTemplateDetail.GetList(where1);
            txPanelRight.Controls.Clear();
            foreach (FlowTemplateDetail ftd in templateDetailList)
            {
                TXPanel txPanel = new TXPanel();
                txPanel.Size = new Size(240, 226);
                //txPanel.Location = new Point(16, 16);
                Label labelA = new Label();
                labelA.Size = new Size(230, 23);
                labelA.Location = new Point(5, 6);
                labelA.Text = ftd.OperateItem;
                labelA.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                labelA.TextAlign = ContentAlignment.MiddleLeft;
                labelA.BackColor = Color.Silver;
                Label labelB = new Label();
                labelB.Size = new Size(230, 190);
                labelB.Location = new Point(5, 29);
                labelB.Text = ftd.OperateContentAndStandard;
                labelB.TextAlign = ContentAlignment.MiddleLeft;
                labelB.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                labelB.BackColor = Color.Silver;
                txPanel.Controls.Add(labelA);
                txPanel.Controls.Add(labelB);
                PictureBox pic = new PictureBox();
                setPosition(txPanel, pic);
                if (ftd != templateDetailList.Last())
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
            int x = 16 + (240 + 6 +60 + 6) * w;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
