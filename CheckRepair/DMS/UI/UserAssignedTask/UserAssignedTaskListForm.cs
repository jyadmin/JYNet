﻿using System;
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
using MSWord = Microsoft.Office.Interop.Word;
using System.IO;

namespace DMS.UI.UserAssignedTask
{
    /// <summary>
    /// 个人分配到的任务列表
    /// </summary>
    public partial class UserAssignedTaskListForm :  TX.Framework.WindowUI.Forms.BaseForm
    {
        /*******用于Word模板输出*********/
        private MSWord.Application wordApp;  //Word应用程序变量
        private MSWord.Document wordDoc;     //Word文档变量
        private Object Nothing = System.Reflection.Missing.Value;
        /*******************************/
        //protected int ItemIndex;
        //状态下拉框的选中项
        protected string status = "0";
        public UserAssignedTaskListForm()
        {
            InitializeComponent();

            //设置时间选择控件不显示勾选框，（在时间选择器控件属性中设置无效，只能初始化时动态设置）
            this.txDateTimePicker1.ShowCheckBox = false;
            this.txDateTimePicker2.ShowCheckBox = false;
            loadUserAssignedTask();
        }

        /// <summary>
        /// 加载登录人员的
        /// </summary>
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
            //拼接查询条件字符串
            where = "where CheckerIDs like \'%" + CurrentUser.Instance.User.ID + "%\' and Status = \'1\' and ArrangedStartTime > " + dtStart + " and ArrangedStartTime < " + dtEnd + " order by ArrangedStartTime ASC";
            /*
            if (status == "0")//未完成
            {
                where = "where CheckerIDs like \'%" + CurrentUser.Instance.User.ID + "%\' and Status = \'1\' and ArrangedStartTime > " + dtStart + " and ArrangedStartTime < " + dtEnd + " order by ArrangedStartTime ASC";
            }
            else if (status == "1")//已完成
            {
                where = "where CheckerIDs like \'%" + CurrentUser.Instance.User.ID + "%\' and Status = \'2\' and ArrangedStartTime > " + dtStart + " and ArrangedStartTime < " + dtEnd + " order by ArrangedStartTime ASC";
            }
            else//全部
            {
                where = "where CheckerIDs like \'%" + CurrentUser.Instance.User.ID + "%\' and ArrangedStartTime > " + dtStart + " and ArrangedStartTime < " + dtEnd + " order by ArrangedStartTime ASC";
            }
            */
            //查询任务分配单
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
                //Item的Name属性中存放设备接收单ID
                itemA.Name = DeviceReceiveID.ToString();
                itemA.Text = dr.EngineCode;//下车号
                //设备接收时刻
                TreeListViewItem.ListViewSubItem subItem1 = new TreeListViewItem.ListViewSubItem();
                subItem1.Text = DateTimeHelper.ConvertLongToDateTime(dr.ReceiveTime).ToString();
                itemA.SubItems.Add(subItem1);
                
                TreeListViewItem.ListViewSubItem subItem2 = new TreeListViewItem.ListViewSubItem();
                //Name属性中存放任务分配单AssignedTask的ID
                subItem2.Name = userTask.ID.ToString();
                //从模板中获取部件名称
                subItem2.Text = tmplt.Component;
                itemA.SubItems.Add(subItem2);
                //序号
                TreeListViewItem.ListViewSubItem subItem3 = new TreeListViewItem.ListViewSubItem();
                subItem3.Text = tmplt.DisplayOrder.ToString();
                itemA.SubItems.Add(subItem3);
                //步骤名称
                TreeListViewItem.ListViewSubItem subItem4 = new TreeListViewItem.ListViewSubItem();
                subItem4.Name = tmplt.ID.ToString();
                subItem4.Text = tmplt.ProcedureName;
                itemA.SubItems.Add(subItem4);
                //操作时长
                TreeListViewItem.ListViewSubItem subItem5 = new TreeListViewItem.ListViewSubItem();
                subItem5.Text = tmplt.OperateTime + " min";
                itemA.SubItems.Add(subItem5);
                //执行人员
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
                //计划开始时间
                TreeListViewItem.ListViewSubItem subItem7 = new TreeListViewItem.ListViewSubItem();
                if (userTask.ArrangedStartTime != 0)
                {
                    subItem7.Text = DateTimeHelper.ConvertLongToDateTime(userTask.ArrangedStartTime).ToString();
                }
                itemA.SubItems.Add(subItem7);
                //实际开始时间
                TreeListViewItem.ListViewSubItem subItem8 = new TreeListViewItem.ListViewSubItem();
                if (userTask.ActualStartTime != 0)
                {
                    subItem8.Text = DateTimeHelper.ConvertLongToDateTime(userTask.ActualStartTime).ToString();
                }
                itemA.SubItems.Add(subItem8);
                //结束时间
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

        /// <summary>
        /// 展示分配任务的treeListView1双击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeListView1_DoubleClick(object sender, EventArgs e)
        {
            TreeListView tlv = sender as TreeListView;
            if (tlv.SelectedItems.Count > 0)
            {
                //获取选中项的任务分配单ID
                int assignedTaskID = int.Parse(tlv.SelectedItems[0].SubItems[2].Name);
                //获取选中项的主步骤模板ID
                int templateID = int.Parse(tlv.SelectedItems[0].SubItems[4].Name);
                //获取选中项的设备接收单ID
                int deviceReceiveID = int.Parse(tlv.SelectedItems[0].Name);
                //拼接要打开的form表单标题
                string formName = tlv.SelectedItems[0].SubItems[2].Text + " - " + tlv.SelectedItems[0].SubItems[4].Text;
                new DMS.UI.TaskDetail.TaskDetailForm(assignedTaskID, templateID, deviceReceiveID, formName, 1).ShowDialog();
                //刷新数据
                loadUserAssignedTask();
            }
        }

        /// <summary>
        /// 状态下拉框选项变动事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txCbbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            //获取下拉框选项
            TXComboBox txCbbStatus = sender as TXComboBox;
            status = txCbbStatus.SelectedIndex.ToString();
            //重新加载
            loadUserAssignedTask();
        }

        /// <summary>
        /// 时间选择控件值改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            //重新加载
            loadUserAssignedTask();
        }

        /// <summary>
        /// 向模板写入数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txButtonOutput_Click(object sender, EventArgs e)
        {
            string strPath = "D:\\21牵引风机检修纪录-6份.docx";
            //复制文件
            string strPath1 = "";
            if (File.Exists(strPath))
            {
                string[] str = strPath.Split('.');
                strPath1 = str[0] + "-副本." + str[1];
                File.Copy(strPath, strPath1, true);
            }
            //向复制的模板写入数据
            ExcelWriteData(treeListView1, strPath1);
        }

        /// <summary>
        /// 将指定字符串写入指定单元格中
        /// </summary>
        /// <param name="modelPath">工作表名称（全路径+EXCEL表名称）</param>
        public void ExcelWriteData(TreeListView treeListView, string modelPath)
        {

            //初始化
            object FileName = modelPath;
            object readOnly = false;
            object isVisible = false;
            wordApp = new MSWord.Application();
            wordApp.Visible = false;
            wordDoc = wordApp.Documents.Add(ref Nothing, ref Nothing, ref Nothing, ref Nothing);

            // 打开Word
            wordDoc = wordApp.Documents.Open(ref FileName, ref Nothing, ref readOnly,
            ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing,
            ref Nothing, ref Nothing, ref Nothing, ref isVisible, ref Nothing,
            ref Nothing, ref Nothing, ref Nothing);

            for (int i = 0; i < treeListView.Items.Count; i++)
            {
                int assignedTaskId = int.Parse(treeListView1.Items[i].SubItems[2].Name);
                string where = "where AssignedTaskId = " + assignedTaskId;
                List<UserTaskDetail> utdList = UserTaskDetail.GetList(where);
                foreach (var utd in utdList)
                {
                    string where1 = "where UserTaskDetailID = " + utd.ID;
                    List<CheckResultContent> crcList = CheckResultContent.GetList(where1);
                    foreach (var crc in crcList)
                    {
                        object bookMarks = crc.CheckKeys;
                        if (wordDoc.Bookmarks.Exists(crc.CheckKeys))
                        {
                            if (crc.CheckKeys.EndsWith("b"))
                            {
                                if (crc.CheckValue == "1")
                                {
                                    wordDoc.Bookmarks.get_Item(ref bookMarks).Range.Text = "☑"; // 插入文本
                                }
                                else
                                {
                                    string str1 = crc.CheckKeys.Substring(0, crc.CheckKeys.Length - 2);
                                    string str2 = crc.CheckKeys.Substring(crc.CheckKeys.Length - 2, 1);
                                    int.Parse(str2);
                                    string str = str1 + (int.Parse(str2) + 1) + "b";
                                    bookMarks = str;
                                    wordDoc.Bookmarks.get_Item(ref bookMarks).Range.Text = "☑"; // 插入文本
                                }
                            }
                            else
                            {
                                wordDoc.Bookmarks.get_Item(ref bookMarks).Range.Text = crc.CheckValue; // 插入文本
                            }
                        }                            
                    }

                }

            }

            //避免弹出normal.dotm被使用的对话框，自动保存模板
            wordApp.NormalTemplate.Saved = true;
            wordApp.Visible = false;

            //先关闭打开的文档
            Object saveChanges = MSWord.WdSaveOptions.wdSaveChanges;
            Object originalFormat = Type.Missing;
            Object remoteDocument = Type.Missing;
            wordDoc.Close(ref saveChanges, ref originalFormat, ref remoteDocument);
            if (wordApp.Documents.Count == 0)
            {
                wordApp.Quit(Type.Missing, Type.Missing, Type.Missing);
            }

        }
    }
}
