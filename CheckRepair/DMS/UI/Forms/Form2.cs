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
    /// <summary>
    /// 详细步骤检查信息输入Form表单1
    /// </summary>
    public partial class Form2 : TX.Framework.WindowUI.Forms.BaseForm
    {
        //本详细步骤完成状态
        private string Status = "0";
        //设备接收单
        private DeviceReceive dr;
        //任务详情
        private UserTaskDetail utd;
        //检查结果
        private CheckResultContent crc;
        //private int StepCode = 0;
        //private int SubStepCode = 0;


        public Form2(int deviceReceiveID, int UserTaskDetailID, string status)
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
            //检修项点
            labelA.Text = ftm.ProcedureName;
            //作业内容和标准
            labelB.Text = ftd.OperateContentAndStandard;
            //判断质量特性标识
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
            string where = "where UserTaskDetailID = " + UserTaskDetailID;
            List<CheckResultContent> list = CheckResultContent.GetList(where);
            if (status == "2")
            {
                txButtonComplete.Enabled = false;//提交按钮不可用
                if (list.Count > 0)
                {
                    crc = list[0];
                    rb1.Enabled = false;//不可编辑
                    rb2.Enabled = false;//不可编辑
                   
                    if (crc.CheckValue == "1")
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
            CheckResultContent crc1 = new CheckResultContent();
            crc1.DeviceReceiveID = dr.ID;
            crc1.DeviceType = dr.DeviceType;
            crc1.BatchCode = dr.BatchCode;
            //word书签命名必须以字母开头，不能以数字开头
            crc1.CheckKeys = "a" + utd.TemplateMainId + "_" + utd.TemplateDetailId + "_" + 1 + "b";//以'b'结尾表示checkBox
            crc1.UserTaskDetailID = utd.ID;
            crc1.XC = dr.XC;
            if (rb1.Checked == true)//合格
            {
                crc1.CheckValue = "1";
                //父form表单的statusColor属性置1，对应方框背景色为红色。置0表示正常，绿色
                DMS.UI.TaskDetail.TaskDetailForm.statusColor = 0;
            }
            else//不合格
            {
                crc1.CheckValue = "2";
                //父form表单的statusColor属性置1，对应方框背景色为红色。置0表示正常，绿色
                DMS.UI.TaskDetail.TaskDetailForm.statusColor = 1;
            }
            crc1.Add();
            
            //父form表单的isFinished属性置1，标识输入完毕已提交
            DMS.UI.TaskDetail.TaskDetailForm.isFinished = 1;
            this.Close();
        }
    }
}
