using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DMS.DomainObjects.BusinessFunctions;


namespace DMS.UI.Forms
{
    public partial class Form5 : TX.Framework.WindowUI.Forms.BaseForm
    {
        private string Status = "0";
        private DeviceReceive dr;
        private UserTaskDetail utd;
        //private int StepCode = 0;
        //private int SubStepCode = 0;


        public Form5(int deviceReceiveID, int UserTaskDetailID, string status)
        {
            InitializeComponent();
            Status = status;
            dr = new DeviceReceive();
            dr.Retrieve(deviceReceiveID);
            utd = new UserTaskDetail();
            utd.Retrieve(UserTaskDetailID);
            //查询主模板和详细模板
            FlowTemplateMain ftm = new FlowTemplateMain();
            ftm.Retrieve(utd.TemplateMainId);
            FlowTemplateDetail ftd = new FlowTemplateDetail();
            ftd.Retrieve(utd.TemplateDetailId);
            labelA.Text = ftm.ProcedureName;
            labelB.Text = ftd.OperateContentAndStandard;
            if (ftd.QualityCharacteristic == 1)
            {
                labelC.Text = "○";
            }
            else if (ftd.QualityCharacteristic == 2)
            {
                labelC.Text = "△";
            }
            else if (ftd.QualityCharacteristic == 3)
            {
                labelC.Text = "☆";
            }
            //如果是已经填写并提交的信息，只可查看，不可修改
            string where = "where UserTaskDetailID = " + UserTaskDetailID + "order by ID";
            List<CheckResultContent> list = CheckResultContent.GetList(where);
            if (status == "2")
            {
                txButtonComplete.Enabled = false;//提交按钮不可用
                if (list.Count == 4)
                {
                    tbA.Enabled = false;//不可编辑
                    tbB.Enabled = false;//不可编辑
                    tbC.Enabled = false;//不可编辑
                    rb1.Enabled = false;//不可编辑
                    rb2.Enabled = false;//不可编辑
                    
                    tbA.Text = list[0].CheckValue;
                    tbB.Text = list[1].CheckValue;
                    tbC.Text = list[2].CheckValue;
                    if (list[3].CheckValue == "1")
                    {
                        rb1.Checked = true;
                        rb2.Checked = false;
                    }
                    else
                    {
                        rb1.Checked = false;
                        rb2.Checked = true;
                    }
                }
            }
            
        }

        private void txButton1_Click(object sender, EventArgs e)
        {
            if (tbA.Text == "" || tbA.Text == null || tbB.Text == "" || tbB.Text == null || tbC.Text == "" || tbC.Text == null)
            {
                this.Info("提示", "未输入检测值");
                return;
            }
            else
            {
                CheckResultContent crc1 = new CheckResultContent();
                CheckResultContent crc2 = new CheckResultContent();
                CheckResultContent crc3 = new CheckResultContent();
                CheckResultContent crc4 = new CheckResultContent();
                crc1.DeviceReceiveID = dr.ID;
                crc2.DeviceReceiveID = dr.ID;
                crc3.DeviceReceiveID = dr.ID;
                crc4.DeviceReceiveID = dr.ID;
                crc1.DeviceType = dr.DeviceType;
                crc2.DeviceType = dr.DeviceType;
                crc3.DeviceType = dr.DeviceType;
                crc4.DeviceType = dr.DeviceType;
                crc1.BatchCode = dr.BatchCode;
                crc2.BatchCode = dr.BatchCode;
                crc3.BatchCode = dr.BatchCode;
                crc4.BatchCode = dr.BatchCode;
                //word书签命名必须以字母开头，不能以数字开头
                crc1.CheckKeys = "a" + utd.TemplateMainId + "_" + utd.TemplateDetailId + "_" + 1;
                crc2.CheckKeys = "a" + utd.TemplateMainId + "_" + utd.TemplateDetailId + "_" + 2;
                crc3.CheckKeys = "a" + utd.TemplateMainId + "_" + utd.TemplateDetailId + "_" + 3;
                crc4.CheckKeys = "a" + utd.TemplateMainId + "_" + utd.TemplateDetailId + "_" + 4 + "b";//以'b'结尾表示checkBox
                crc1.UserTaskDetailID = utd.ID;
                crc2.UserTaskDetailID = utd.ID;
                crc3.UserTaskDetailID = utd.ID;
                crc4.UserTaskDetailID = utd.ID;
                crc1.XC = dr.XC;
                crc2.XC = dr.XC;
                crc3.XC = dr.XC;
                crc4.XC = dr.XC;
                crc1.CheckValue = tbA.Text;
                crc2.CheckValue = tbB.Text;
                crc3.CheckValue = tbC.Text;
                if (rb1.Checked == true)//合格
                {
                    crc4.CheckValue = "1";
                    DMS.UI.TaskDetail.TaskDetailForm.statusColor = 0;
                }
                else//不合格
                {
                    crc4.CheckValue = "2";
                    DMS.UI.TaskDetail.TaskDetailForm.statusColor = 1;
                }
                crc1.Add();
                crc2.Add();
                crc3.Add();
                crc4.Add();

                DMS.UI.TaskDetail.TaskDetailForm.isFinished = 1;
                this.Close();
            }
        }
    }
}
