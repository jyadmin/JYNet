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
using DMS.DomainObjects;
using System.Threading;

namespace DMS.UI.UserAssignedTask
{
    public partial class UserAssignedTaskListForm :  TX.Framework.WindowUI.Forms.BaseForm
    {
        protected int ItemIndex;
        protected string status = "0";
        public UserAssignedTaskListForm()
        {
            InitializeComponent();
            
            //设置时间选择器
            this.txDateTimePicker1.ShowCheckBox = false;
            this.txDateTimePicker2.ShowCheckBox = false;
            loadUserAssignedTask();
        }

        private void loadUserAssignedTask()
        {
            //查询登录人员未执行的派工
            string where = "";
            //处理查询时间区间
            DateTime dtS = DateTime.Today;
            DateTime dtE = DateTime.Today;
            long dtStart = 0;
            long dtEnd = 0;
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
                dtEnd = DateTimeHelper.ConvertDataTimeToLong(dtE.Date) + 24 * 60 * 60 * 1000 - 1;
            }
            else
            {
                dtEnd = DateTimeHelper.ConvertDataTimeToLong(dtE.Date) + 24 * 60 * 60 * 1000 - 1;
            }
            if (status == "0")
            {
                where = "where CheckerIDs like \'%" + CurrentUser.Instance.User.ID + "%\' and ( Status = \'0\' or Status = \'1\' ) and ArrangedStartTime > " + dtStart + " and ArrangedStartTime < " + dtEnd + " order by ArrangedStartTime ASC";
            }
            else if (status == "1")
            {
                where = "where CheckerIDs like \'%" + CurrentUser.Instance.User.ID + "%\' and Status = \'2\' and ArrangedStartTime > " + dtStart + " and ArrangedStartTime < " + dtEnd + " order by ArrangedStartTime ASC";
            }
            else
            {
                where = "where CheckerIDs like \'%" + CurrentUser.Instance.User.ID + "%\' and ArrangedStartTime > " + dtStart + " and ArrangedStartTime < " + dtEnd + " order by ArrangedStartTime ASC";
            }
            List<AssignedTask> UserAssignedTaskList = AssignedTask.GetList(where);
            treeListView1.Items.Clear();
            //根据AssignedTask的Id获取AssignedTask
            foreach (AssignedTask userTask in UserAssignedTaskList)
            {
                
                TreeListViewItem itemA = new TreeListViewItem();
                
                //查询设备接收信息
                int DeviceReceiveID = userTask.LinkIdToDeviceReceive;
                DeviceReceive dr = new DeviceReceive();
                dr.Retrieve(DeviceReceiveID);
                //查询模板信息
                int TemplateID = userTask.TemplateID;
                FlowTemplateMain tmplt = new FlowTemplateMain();
                tmplt.Retrieve(TemplateID);
                itemA.Name = DeviceReceiveID.ToString();
                itemA.Text = dr.EngineCode;
                TreeListViewItem.ListViewSubItem subItem1 = new TreeListViewItem.ListViewSubItem();
                subItem1.Text = DateTimeHelper.ConvertLongToDateTime(dr.ReceiveTime).ToString();
                itemA.SubItems.Add(subItem1);
                TreeListViewItem.ListViewSubItem subItem2 = new TreeListViewItem.ListViewSubItem();
                subItem2.Name = userTask.ID.ToString();
                subItem2.Text = tmplt.Component;
                itemA.SubItems.Add(subItem2);
                TreeListViewItem.ListViewSubItem subItem3 = new TreeListViewItem.ListViewSubItem();
                subItem3.Text = tmplt.DisplayOrder.ToString();
                itemA.SubItems.Add(subItem3);
                TreeListViewItem.ListViewSubItem subItem4 = new TreeListViewItem.ListViewSubItem();
                subItem4.Name = tmplt.ID.ToString();
                subItem4.Text = tmplt.ProcedureName;
                itemA.SubItems.Add(subItem4);
                TreeListViewItem.ListViewSubItem subItem5 = new TreeListViewItem.ListViewSubItem();
                subItem5.Text = tmplt.OperateTime + " min";
                itemA.SubItems.Add(subItem5);
                TreeListViewItem.ListViewSubItem subItem6 = new TreeListViewItem.ListViewSubItem();
                string userNames = "";
                foreach(string id in userTask.CheckerIDs.Split(','))
                {
                    UserInfo user = new UserInfo();
                    user.Retrieve(int.Parse(id));
                    userNames  += user.UserName + ",";
                }
                userNames = userNames.Substring(0, userNames.Length - 1);
                subItem6.Text = userNames;
                itemA.SubItems.Add(subItem6);
                TreeListViewItem.ListViewSubItem subItem7 = new TreeListViewItem.ListViewSubItem();
                if (userTask.ArrangedStartTime != 0)
                {
                    subItem7.Text = DateTimeHelper.ConvertLongToDateTime(userTask.ArrangedStartTime).ToString();
                }
                itemA.SubItems.Add(subItem7);
                TreeListViewItem.ListViewSubItem subItem8 = new TreeListViewItem.ListViewSubItem();
                if (userTask.ActualStartTime != 0)
                {
                    subItem8.Text = DateTimeHelper.ConvertLongToDateTime(userTask.ActualStartTime).ToString();
                }
                itemA.SubItems.Add(subItem8);
                TreeListViewItem.ListViewSubItem subItem9 = new TreeListViewItem.ListViewSubItem();
                if (userTask.ActualEndTime != 0)
                {
                    subItem9.Text = DateTimeHelper.ConvertLongToDateTime(userTask.ActualEndTime).ToString();
                }
                itemA.SubItems.Add(subItem9);
                treeListView1.Items.Add(itemA);
            }
            //treeListView1.Click += treeListView1_SelectedIndexChanged;
        }

        private void treeListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TreeListView tlv = sender as TreeListView;

            //ItemIndex = tlv.SelectedItems[0].Index;
            //MessageBox.Show(ItemIndex.ToString());
            
            //MessageBox.Show(tlv.SelectedItems[0].SubItems[4].Name);
            int assignedTaskID = int.Parse(tlv.SelectedItems[0].SubItems[2].Name); ;
            int templateID = int.Parse(tlv.SelectedItems[0].SubItems[4].Name);
            int deviceReceiveID = int.Parse(tlv.SelectedItems[0].Name);
            string formName = tlv.SelectedItems[0].SubItems[2].Text + " - " + tlv.SelectedItems[0].SubItems[4].Text;
            new DMS.UI.TaskDetail.TaskDetailForm(assignedTaskID, templateID, deviceReceiveID, formName).ShowDialog();
            loadUserAssignedTask();
        }

        private void txCbbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            TXComboBox txCbbStatus = sender as TXComboBox;
            status = txCbbStatus.SelectedIndex.ToString();
            loadUserAssignedTask();
        }

        private void txDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            loadUserAssignedTask();
        }
    }
}
