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

namespace DMS
{
    public partial class DictionaryInsertForm : MainForm
    {
        private SqlConnection conn;
        private DictionaryListForm DicLstFrm;
        private Dictionary dictionary;
        public DictionaryInsertForm(SqlConnection conn, DictionaryListForm DicLstFrm, Dictionary dictionary)
        {
            InitializeComponent();
            this.conn = conn;
            this.DicLstFrm = DicLstFrm;
            this.dictionary = dictionary;
            if(dictionary != null)
            {//dictionary不为空，修改操作
                this.msTB.Text = dictionary.stringValue;
                this.pxTB.Text = dictionary.displayOrder.ToString();
                this.lxTB.Text = dictionary.type;

            }
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string id = "";
            string sqlStr = "";
            string stringValue = msTB.Text;
            int DisplayOrder = Int16.Parse(pxTB.Text.ToString());
            string Type = lxTB.Text;
            //插入数据
            if (dictionary != null)
            {//dictionary不为空，修改操作
                id = dictionary.id;
                sqlStr = "update C_DMS_Dictionary set ID = '" + dictionary.id + "', StringValue = '" + stringValue + "', DisplayOrder = " + DisplayOrder + ", Type = '" + Type + "' where id = '" + dictionary.id +"'";
            }
            else
            {
                id = System.Guid.NewGuid().ToString("N");
                sqlStr = "insert into C_DMS_Dictionary (ID, StringValue, DisplayOrder, Type) values ('" + id +"','" + stringValue + "'," + DisplayOrder + ",'" + Type +"') ";
            }
            SqlCommand InsertCommand = new SqlCommand(sqlStr, conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                int t = InsertCommand.ExecuteNonQuery();
                if (t == 1)
                {
                    this.Info("操作成功");
                    DicLstFrm.findData();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("{0} Exception caught.", ex.ToString());
                this.Info("{0} Exception caught.", ex.ToString());
            }
            
        }
    }
}
