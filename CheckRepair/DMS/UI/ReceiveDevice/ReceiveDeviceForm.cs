using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DMS.DomainObjects.BasicInfo;
using DMS.UI.Common;
using DMS.Common;
using DMS.DomainObjects;
using DMS.DomainObjects.BusinessFunctions;

namespace DMS.UI.DeviceReceives
{
    public partial class DeviceReceiveForm : BaseForm1
    {
        public DeviceReceiveForm()
        {
            InitializeComponent();
            LoadInfo();
        }

        /// <summary>
        /// 查询基本信息
        /// </summary>
        private void LoadInfo()
        {
            //机车类型
            List<Dictionary> engineTypeList = Dictionary.GetList("where [Type]= \'EngineType\'");
            cmbEngineType.DataSource = engineTypeList;
            cmbEngineType.DataBindings.Add("Name", engineTypeList, "ID");
            //设备类型
            List<Dictionary> deviceTypeList = Dictionary.GetList("where [Type]= \'DeviceType\'");
            cmbDeviceType.DataSource = deviceTypeList;
            cmbDeviceType.DataBindings.Add("Name", engineTypeList, "ID");
            //修程
            List<Dictionary> xcList = Dictionary.GetList("where [Type]= \'xc\'");
            cmbXc.DataSource = xcList;
            cmbXc.DataBindings.Add("Name", engineTypeList, "ID");
            //默认登录人员为接收人员
            tbReceiver.Text = CurrentUser.Instance.User.UserName;
            //人员不可更改
            tbReceiver.ReadOnly = true;
            tbReceiver.BackColor = Color.Gray;
            //添加验证项目
            InitControl();
        }

        /// <summary>
        /// 车型、修程下拉框SelectedIndexChanged事件，根据车型和修程加载设备
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadDeviceTypeInfo(object sender, EventArgs e)
        {
            if (cmbEngineType.Text != String.Empty && cmbXc.Text != String.Empty)//车型、修程都不为空
            {
                //根据车型、修程查询主步骤模板
                List<FlowTemplateMain> flowTemplateMainList = FlowTemplateMain.GetList("where [EngineType]= \'" + cmbEngineType.Text + "\' and [XC]= \'" + cmbXc.Text + "\'");
                //设备类型名称字符串
                List<String> strList = new List<String>();
                //获取主步骤模板设备类型字段
                for (int i = 0; i < flowTemplateMainList.Count; i++)
                {
                    strList.Add(flowTemplateMainList[i].DeviceType);
                }
                //去除重复字段
                for (int i = 0; i < strList.Count; i++)  //外循环是循环的次数
                {
                    for (int j = strList.Count - 1; j > i; j--)  //内循环是 外循环一次比较的次数
                    {

                        if (strList[i] == strList[j])
                        {
                            strList.RemoveAt(j);
                        }

                    }
                }
                //设置设备类型下拉框数据源
                cmbDeviceType.DataSource = strList;
            }

        }

        /// <summary>
        /// 校验各信息输入框
        /// </summary>
        public void InitControl()
        {
            //AddRequiredTextItem(cmbEngineType, "车型不能为空!");
            AddRequiredTextItem(tbEngineCode, "车号不能为空!");
            AddRequiredTextItem(cmbDeviceType, "设备类型不能为空!");
            AddRequiredTextItem(tbDeviceCode, "设备编号不能为空!");
        }

        /// <summary>
        /// 完成接收按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbcSave_Commanded(object sender, EventArgs e)
        {
            if (!base.Validate())
            {
                return;
            }
            DeviceReceive dr = new DeviceReceive();
            //设备接收单机车类型
            dr.EngineType = cmbEngineType.Text;
            //机车编号
            dr.EngineCode = tbEngineCode.Text;
            //修程
            dr.XC = cmbXc.Text;
            //设备类型
            dr.DeviceType = cmbDeviceType.Text;
            //设备编号
            dr.DeviceCode = tbDeviceCode.Text;
            //接收人员
            dr.Receiver = CurrentUser.Instance.User.UserName;
            //接收人员编号
            dr.ReceiverCode = CurrentUser.Instance.User.ID;
            //接收时间
            dr.ReceiveTime = DateTimeHelper.ConvertDataTimeToLong(DateTime.Now);
            //接收单状态置为0
            dr.Status = "0";
            //生成批次号，32位GUID
            dr.BatchCode = Guid.NewGuid().ToString("N");
            if (dr.Add())
            {
                this.Info("添加设备接收信息成功！");
                //关闭本form表单
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MsgHelper.ShowInformationMsgBox("添加设备接收信息失败！");
            }
        }

        /// <summary>
        /// 取消按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseForm(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
