using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TX.Framework.WindowUI.Forms;
using System.Data.SqlClient;
using TX.Framework.WindowUI.Controls;

namespace DMS
{
    public partial class DictionaryListForm : BaseForm
    {
        public SqlConnection conn;
        public DictionaryListForm(SqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
            findData();

        }

        private void txPager1_OnPaging(object sender, TX.Framework.WindowUI.Controls.PagerEventArgs e)
        {
            int PageSize = (int)e.PageSize;
            int PageIndex = (int)e.PageIndex;
            findData();
        }

        public void findData()
        {
            //查询总数
            string selectCountSql = "select count(*) as ct from C_DMS_Dictionary";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = selectCountSql;
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int count = (int)reader.GetValue(0);
            txPager1.Total = count;
            cmd.Dispose();
            reader.Dispose();
            //分页查询
            DataSet ds = new DataSet();
            SqlDataAdapter da = null;
            string selectByPageSql = "SELECT TOP " + txPager1.PageSize + " *  FROM ( SELECT ROW_NUMBER() OVER (ORDER BY DisplayOrder, ID) AS RowNumber, * FROM C_DMS_Dictionary) A WHERE RowNumber > " + txPager1.PageSize + " * (" + txPager1.PageIndex + "-1)";
            da = new SqlDataAdapter(selectByPageSql, conn);
            da.Fill(ds, "table");
            this.DicDataGridView.DataSource = ds.Tables["table"].DefaultView;
            DicDataGridView.Columns[0].HeaderCell.Value = "序号";
            DicDataGridView.Columns[1].Visible = false;
            DicDataGridView.Columns[2].HeaderCell.Value = "描述";
            DicDataGridView.Columns[3].HeaderCell.Value = "排序";
            DicDataGridView.Columns[4].Visible = false;
            DicDataGridView.Columns[5].HeaderCell.Value = "类型";  
            //定义文本居中显示
            DicDataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DicDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DicDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DicDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            int count = DicDataGridView.SelectedRows.Count;
            int deletedCount = 0;
            for (int i = 0; i < count; i++ )
            {
                //删除数据
                string deleteByIdSql = "delete from C_DMS_Dictionary where id = '" + DicDataGridView.SelectedRows[i].Cells["ID"].Value.ToString()+"'";
                SqlCommand DeleteCommand=new SqlCommand(deleteByIdSql,conn);
                try
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                    int t = DeleteCommand.ExecuteNonQuery();
                    if (t == 1)
                    {
                        deletedCount++;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("{0} Exception caught.", ex.ToString());
                }
            }
            MessageBox.Show("成功删除 "+deletedCount+" 条数据");
            findData();
        }

        private void tsbNew_Update_Click(object sender, EventArgs e)
        {
            ToolStripButton tsb = (ToolStripButton)sender;
            if (tsb.Name == "tsbUpdate" && DicDataGridView.SelectedRows.Count != 1)//更新数据，但没有选中或选中多行数据
            {
                this.Warning("请选中一行数据");
            }
            else
            {
                Dictionary dictionary = new Dictionary(); ;
                if (tsb.Name != "tsbNew")
                {
                    dictionary.id = this.DicDataGridView.SelectedRows[0].Cells["ID"].Value.ToString();
                    dictionary.stringValue = this.DicDataGridView.SelectedRows[0].Cells["StringValue"].Value.ToString();
                    dictionary.displayOrder = Int16.Parse(this.DicDataGridView.SelectedRows[0].Cells["DisplayOrder"].Value.ToString());
                    dictionary.type = this.DicDataGridView.SelectedRows[0].Cells["Type"].Value.ToString();
                }
                else
                {
                    dictionary = null;
                }
                DictionaryInsertForm DicInstFrm = new DictionaryInsertForm(conn, this, dictionary);
                DicInstFrm.ShowDialog();
            }
        }

        private void tsbSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
