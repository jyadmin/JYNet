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
using DMS.DomainObjects.BasicInfo;

namespace DMS.UI.AssignTask
{
    public partial class TaskListForm : TX.Framework.WindowUI.Forms.BaseForm
    {
        public TaskListForm()
        {
            InitializeComponent();
            //query();

            //txPager1.formsId = this;
        }
        /*
        #region LoadData
        
        public override void query()
        {
            string where = String.Empty;
            List<DeviceReceive> list1 = DeviceReceive.GetList(where);
            //txPager1.Total = list1.Count;
            
            //List<DeviceReceive> list = DeviceReceive.GetPageList(txPager1.PageSize, txPager1.PageIndex, where);

            for (int i = 0; i < list.Count; i++)
            {
                DateTime dt = DateTimeHelper.ConvertLongToDateTime(list[i].ReceiveTime);
                list[i].ReceiveTimeStr = dt.ToString();
                switch (list[i].Status)
                {
                    case "0": list[i].Status = "未派工";
                        break;
                    case "1": list[i].Status = "已派工";
                        break;
                    case "2": list[i].Status = "已完成";
                        break;
                    //default: list[i].Status = "未派工";
                    //    break;
                }
            }
            //this.dgvTaskList.DataSource = list;
            //dgvTaskList.Columns[0].Visible = false;
            //dgvTaskList.Columns[7].Visible = false;
            //dgvTaskList.Columns[9].Visible = false;
            //dgvTaskList.Columns[11].Visible = false;
            //dgvTaskList.Columns[1].HeaderText = "车型";
            //dgvTaskList.Columns[2].HeaderText = "车号";
            //dgvTaskList.Columns[3].HeaderText = "修程";
            //dgvTaskList.Columns[4].HeaderText = "设备类型";
            //dgvTaskList.Columns[5].HeaderText = "设备编号";
            //dgvTaskList.Columns[6].HeaderText = "接收人";
            //dgvTaskList.Columns[8].HeaderText = "接收时间";
            //dgvTaskList.Columns[10].HeaderText = "状态";
        }
        #endregion
        */
        private void btnEngineType_Click(object sender, EventArgs e)
        {

            List<DeviceReceive> list = new List<DeviceReceive>();
            string where = String.Empty;
            Button btn = (Button)sender;
            switch(btn.Name)
            {
                case "btnHXD1BC5":
                    where = "where EngineType = \'HXD1B\' and XC = \'C5\'";
                    btnHXD1BC5.BackColor = Color.DodgerBlue;
                    btnHXD1DC5.BackColor = Color.White;
                    btnHXD1C5.BackColor = Color.White;
                    btnHXD3CC4.BackColor = Color.White;
                    btnHXD3CC5.BackColor = Color.White;
                    btnHXD3C5.BackColor = Color.White;
                    break;              
                case "btnHXD1DC5":      
                    where = "where EngineType = \'HXD1D\' and XC = \'C5\'";
                    btnHXD1BC5.BackColor = Color.White;
                    btnHXD1DC5.BackColor = Color.DodgerBlue;
                    btnHXD1C5.BackColor = Color.White;
                    btnHXD3CC4.BackColor = Color.White;
                    btnHXD3CC5.BackColor = Color.White;
                    btnHXD3C5.BackColor = Color.White;
                    break;              
                case "btnHXD1C5":       
                    where = "where EngineType = \'HXD1\' and XC = \'C5\'";
                    btnHXD1BC5.BackColor = Color.White;
                    btnHXD1DC5.BackColor = Color.White;
                    btnHXD1C5.BackColor = Color.DodgerBlue;
                    btnHXD3CC4.BackColor = Color.White;
                    btnHXD3CC5.BackColor = Color.White;
                    btnHXD3C5.BackColor = Color.White;
                    break;              
                case "btnHXD3CC4":      
                    where = "where EngineType = \'HXD3C\' and XC = \'C4\'";
                    btnHXD1BC5.BackColor = Color.White;
                    btnHXD1DC5.BackColor = Color.White;
                    btnHXD1C5.BackColor = Color.White;
                    btnHXD3CC4.BackColor = Color.DodgerBlue;
                    btnHXD3CC5.BackColor = Color.White;
                    btnHXD3C5.BackColor = Color.White;
                    break;              
                case "btnHXD3CC5":      
                    where = "where EngineType = \'HXD3C\' and XC = \'C5\'";
                    btnHXD1BC5.BackColor = Color.White;
                    btnHXD1DC5.BackColor = Color.White;
                    btnHXD1C5.BackColor = Color.White;
                    btnHXD3CC4.BackColor = Color.White;
                    btnHXD3CC5.BackColor = Color.DodgerBlue;
                    btnHXD3C5.BackColor = Color.White;
                    break;              
                case "btnHXD3C5":       
                    where = "where EngineType = \'HXD3\' and XC = \'C5\'";
                    btnHXD1BC5.BackColor = Color.White;
                    btnHXD1DC5.BackColor = Color.White;
                    btnHXD1C5.BackColor = Color.White;
                    btnHXD3CC4.BackColor = Color.White;
                    btnHXD3CC5.BackColor = Color.White;
                    btnHXD3C5.BackColor = Color.DodgerBlue;
                    break;
            }
            list = DeviceReceive.GetList(where);
            //获取车号字段
            List<string> EngineCodeStrList = new List<string>(); 
            for (int i = 0; i < list.Count; i++)
            {
                EngineCodeStrList.Add(list[i].EngineCode);
            }
            if (list.Count > 0)//去除重复的车号
            {
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
                tvEngineCode.Nodes.Clear();
                for(int i = 0; i < EngineCodeStrList.Count; i++)
                {
                    tvEngineCode.Nodes.Add(EngineCodeStrList[i]);
                    for (int j = 0; j < list.Count; j++)
                    {
                        if (EngineCodeStrList[i] == list[j].EngineCode)
                        {
                            tvEngineCode.Nodes[i].Nodes.Add(list[j].DeviceType);
                            tvEngineCode.Nodes[i].LastNode.Name = list[j].EngineType + "," + list[j].XC + "," + list[j].DeviceType + "," + list[j].EngineCode;
                        }
                    }
                }
            }
        }

        private void tvEngineCode_AfterSelect(object sender, TreeViewEventArgs e)
        {
            dgvTemplateMain.Rows.Clear();
            TreeView treeView = (TreeView)sender;
            TreeNode selectedNode = treeView.SelectedNode;
            if (selectedNode.Level != 1)
            {
                return;
            }
            string[] parameters = selectedNode.Name.Split(',');
            string where = "where Enginetype = \'" + parameters[0] + "\' and XC = \'" + parameters[1] + "\' and DeviceType = \'" + parameters[2] + "\' order by Component ASC, DisplayOrder ASC";
            List<FlowTemplateMain> flowTemplateMainList = FlowTemplateMain.GetList(where);
            string temp = "";

            for (int i = 0; i < flowTemplateMainList.Count; i++)
            {
                DataGridViewRow dr = new DataGridViewRow();
                DataGridViewTextBoxCell cellID = new DataGridViewTextBoxCell();
                cellID.Value = flowTemplateMainList[i].ID;
                dr.Cells.Add(cellID);
                DataGridViewTextBoxCell cellComponent = new DataGridViewTextBoxCell();
                cellComponent.Value = flowTemplateMainList[i].Component;
                dr.Cells.Add(cellComponent);
                DataGridViewTextBoxCell cellProcedureName = new DataGridViewTextBoxCell();
                cellProcedureName.Value = flowTemplateMainList[i].ProcedureName;
                dr.Cells.Add(cellProcedureName);
                DataGridViewTextBoxCell cellOperateTime = new DataGridViewTextBoxCell();
                cellOperateTime.Value = flowTemplateMainList[i].OperateTime + " min";
                dr.Cells.Add(cellOperateTime);
                DataGridViewComboBoxCell cellLastChecker = new DataGridViewComboBoxCell();
                cellLastChecker.Items.Clear();
                UserInfo user1 = new UserInfo();
                user1.ID = 111;
                user1.UserName = "张三";
                UserInfo user2 = new UserInfo();
                user2.ID = 222;
                user2.UserName = "李四";
                cellLastChecker.Items.Add(user1);
                cellLastChecker.Items.Add(user2);
                //cellLastChecker.Items.Add("789");
                dr.Cells.Add(cellLastChecker);
                cellLastChecker.ValueMember = "ID";
                cellLastChecker.DisplayMember = "UserName";
                cellLastChecker.Value = user2;
                dgvTemplateMain.Rows.Add(dr);
            }

            
            /*
            TreeListViewItem itemA = new TreeListViewItem();;
            TreeListViewItem itemA0;
            for (int i = 0; i < flowTemplateMainList.Count; i++)
            {
                if (flowTemplateMainList[i].Component != temp)
                {
                    temp = flowTemplateMainList[i].Component;
                    treeListView1.Items.Add(itemA);
                    itemA = new TreeListViewItem(temp);
                    itemA.Expand();//展开
                }
                itemA0 = new TreeListViewItem();
                itemA0.SubItems.Add(flowTemplateMainList[i].DisplayOrder.ToString());
                itemA0.SubItems.Add(flowTemplateMainList[i].ProcedureName);
                itemA0.SubItems.Add(flowTemplateMainList[i].OperateTime.ToString() + " min");
                itemA.Items.Add(itemA0);
            }
            treeListView1.Items.Add(itemA);
             */
        }

        //绘制单元格
        private void dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            // 对第1列相同单元格进行合并
            if (e.ColumnIndex == 1 && e.RowIndex != -1)
            {
                using
                    (
                    Brush gridBrush = new SolidBrush(dgv.GridColor),
                    backColorBrush = new SolidBrush(e.CellStyle.BackColor)
                    )
                {
                    using (Pen gridLinePen = new Pen(gridBrush))
                    {
                        // 清除单元格
                        e.Graphics.FillRectangle(backColorBrush, e.CellBounds);

                        // 画 Grid 边线（仅画单元格的底边线和右边线）
                        //   如果下一行和当前行的数据不同，则在当前的单元格画一条底边线
                        if (e.RowIndex < dgv.Rows.Count - 1 &&
                        dgv.Rows[e.RowIndex + 1].Cells[e.ColumnIndex].Value.ToString() != e.Value.ToString())
                            e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left,
                            e.CellBounds.Bottom - 1, e.CellBounds.Right - 1,
                            e.CellBounds.Bottom - 1);
                        // 画右边线
                        e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1,
                            e.CellBounds.Top, e.CellBounds.Right - 1,
                            e.CellBounds.Bottom);

                        // 画（填写）单元格内容，相同的内容的单元格只填写第一个
                        if (e.Value != null)
                        {
                            if (e.RowIndex > 0 && dgv.Rows[e.RowIndex - 1].Cells[e.ColumnIndex].Value.ToString() == e.Value.ToString())
                            { }
                            else
                            {
                                e.Graphics.DrawString((String)e.Value, e.CellStyle.Font,
                                    Brushes.Black, e.CellBounds.X + 2,
                                    e.CellBounds.Y + 5, StringFormat.GenericTypographic);
                            }
                        }
                        e.Handled = true;
                    }
                }
            }
        }
    }
}
