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
    public partial class DeviceReceiveForm : BaseForm
    {
        public DeviceReceiveForm()
        {
            InitializeComponent();
            LoadInfo();
        }

        private void LoadInfo()
        {
            List<Dictionary> engineTypeList = Dictionary.GetList("where [Type]= \'EngineType\'");
            cmbEngineType.DataSource = engineTypeList;
            cmbEngineType.DataBindings.Add("Name", engineTypeList, "ID");
            List<Dictionary> deviceTypeList = Dictionary.GetList("where [Type]= \'DeviceType\'");
            cmbDeviceType.DataSource = deviceTypeList;
            cmbDeviceType.DataBindings.Add("Name", engineTypeList, "ID");
            List<Dictionary> xcList = Dictionary.GetList("where [Type]= \'xc\'");
            cmbXc.DataSource = xcList;
            cmbXc.DataBindings.Add("Name", engineTypeList, "ID");
            tbReceiver.Text = CurrentUser.Instance.User.UserName;
            tbReceiver.ReadOnly = true;
            tbReceiver.BackColor = Color.Gray;
            InitControl();
        }

        private void LoadDeviceTypeInfo(object sender, EventArgs e)
        {
            if (cmbEngineType.Text != String.Empty && cmbXc.Text != String.Empty)
            {
                List<FlowTemplateMain> flowTemplateMainList = FlowTemplateMain.GetList("where [EngineType]= \'" + cmbEngineType.Text + "\' and [XC]= \'" + cmbXc.Text + "\'");
                List<String> strList = new List<String>();
                for (int i = 0; i < flowTemplateMainList.Count; i++)
                {
                    strList.Add(flowTemplateMainList[i].DeviceType);
                }
                //HashSet<string> hs = new HashSet<string>(strList);
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
                cmbDeviceType.DataSource = strList;
                //cmbDeviceType.DataBindings.Clear();
                //cmbDeviceType.DataBindings.Add("Name", strList, "ID");
            }

        }

        public void InitControl()
        {
            //AddRequiredTextItem(cmbEngineType, "车型不能为空!");
            AddRequiredTextItem(tbEngineCode, "车号不能为空!");
            //AddRequiredTextItem(cmbDeviceType, "设备类型不能为空!");
            AddRequiredTextItem(tbDeviceCode, "设备编号不能为空!");
            //AddRequiredTextItem(cmbXc, "修程不能为空!");
        }

        private void tbcSave_Commanded(object sender, EventArgs e)
        {
            if (!base.Validate())
            {
                return;
            }
            DeviceReceive dr = new DeviceReceive();
            dr.EngineType = cmbEngineType.Text;
            dr.EngineCode = tbEngineCode.Text;
            dr.XC = cmbXc.Text;
            dr.DeviceType = cmbDeviceType.Text;
            dr.DeviceCode = tbDeviceCode.Text;
            dr.Receiver = CurrentUser.Instance.User.UserName;
            dr.ReceiverCode = CurrentUser.Instance.User.ID;
            dr.ReceiveTime = DateTimeHelper.ConvertDataTimeToLong(DateTime.Now);
            //DateTime dt = DateTimeHelper.ConvertLongToDateTime(dr.ReceiveTime);
            dr.BatchCode = Guid.NewGuid().ToString("N");
            if (dr.Add())
            {
                MsgHelper.ShowInformationMsgBox("添加设备接收信息成功！");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MsgHelper.ShowInformationMsgBox("添加设备接收信息失败！");
            }
        }

        private void LoadDeviceTypeInfo()
        {

        }
    }
}
