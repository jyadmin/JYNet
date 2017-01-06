using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;
using Microsoft.Office.Interop.Word;
using System.Diagnostics;

namespace DMS.UI.FileManage
{
    public partial class FileManageMainForm : TX.Framework.WindowUI.Forms.BaseForm
    {
        #region Signle Contract
        
        //共享目录地址
        private string url = @"\\192.168.1.199\CheckRepair";
        //共享目录子目录名
        public string dir;
        //form Text
        public string text;

        public FileManageMainForm(string dir, string text)
        {
            this.dir = dir;
            this.text = text;
            InitializeComponent();
            this.Text = text;
            LoadData();
        }
        #endregion

        public void LoadData(){
           
            //连接共享文件夹
            bool status = true;
            DirectoryInfo f = new DirectoryInfo(url);
            if (!f.Exists)//判断是否已经连接到共享目录，若没有则打开共享目录
            {
                status = false;
                status = FileShare.connectState(url, "Administrator", "");
            }
            try
            {
                if (status)
                {
                    DirectoryInfo theFolder = new DirectoryInfo(url + "\\" + dir);
                    if (!theFolder.Exists)
                    {
                        theFolder.Create();
                    };
                    //清空dataGridView
                    dgvFileManange.Rows.Clear();
                    //遍历共享文件夹，把共享文件夹下的文件列表列到listbox
                    foreach (FileInfo NextFile in theFolder.GetFiles())
                    {
                        if ((NextFile.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)//判断文件是否有隐藏属性
                        {
                            DataGridViewRow dr = new DataGridViewRow();
                            DataGridViewTextBoxCell cellFileName = new DataGridViewTextBoxCell();
                            cellFileName.Value = NextFile.Name;
                            DataGridViewTextBoxCell cellFileTime = new DataGridViewTextBoxCell();
                            cellFileTime.Value = NextFile.LastAccessTime.ToString();
                            dr.Cells.Add(cellFileName);
                            dr.Cells.Add(cellFileTime);
                            dr.Cells[0].Value = NextFile.Name;
                            dr.Cells[1].Value = NextFile.LastAccessTime.ToString();
                            dgvFileManange.Rows.Add(dr);
                        }
                    }
                    //设置按时间排序
                    dgvFileManange.Sort(dgvFileManange.Columns[1], ListSortDirection.Descending);
                }
            }
            catch
            {
                MessageBox.Show("未能连接！");
            }
        }

        #region 按钮点击事件
        
        private void dgvAffairsOpen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            //查看按钮或双击数据
            if (e.RowIndex != -1 && (e.ColumnIndex == 2))
            {
                try
                {
                    object fileName = url + @"\" + dir + @"\" + dgv.Rows[dgv.CurrentCell.RowIndex].Cells[0].Value;
                    object missing = System.Reflection.Missing.Value;
                    object readOnly = true;
                    object isVisable = true;
                    //打开word文档
                    if (fileName.ToString().EndsWith(".doc") || fileName.ToString().EndsWith(".docx"))
                    {
                        // 打开WORD
                        Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
                        // 禁止Word界面启动
                        app.Visible = false;
                        // 打开文档
                        Microsoft.Office.Interop.Word.Document doc = app.Documents.Open(ref fileName, ref missing, ref missing,
                                               ref missing, ref missing, ref missing, ref missing, ref missing,
                                               ref missing, ref missing, ref missing, ref missing, ref missing,
                                               ref missing, ref missing, ref missing);
                    }
                    //打开excel文件
                    else if (fileName.ToString().EndsWith(".xls") || fileName.ToString().EndsWith(".xlsx"))
                    {
                        //引用Excel对象
                        Microsoft.Office.Interop.Excel.Application excel =
                        new Microsoft.Office.Interop.Excel.Application();
                        //引用Excel工作簿
                        Microsoft.Office.Interop.Excel.Workbook book =
                        excel.Application.Workbooks.Add(fileName);
                        //使Excel可视
                        excel.Visible = true; 
                    }
                    //打开图片文件
                    else if (fileName.ToString().EndsWith(".jpg") || fileName.ToString().EndsWith(".bmp") || fileName.ToString().EndsWith(".png")
                        ||fileName.ToString().EndsWith(".JPG") || fileName.ToString().EndsWith(".BMP") || fileName.ToString().EndsWith(".PNG"))
                    {
                        PictureShowForm picFrm = new PictureShowForm();
                        picFrm.pictureBox1.Image = Image.FromFile((string)fileName);
                        picFrm.Text = text + "-" + dgv.Rows[dgv.CurrentCell.RowIndex].Cells[0].Value.ToString();
                        picFrm.ShowDialog();
                    }
                }
                catch(Exception excp)
                {
                    MessageBox.Show(excp.ToString());
                }
            }
            else if (e.RowIndex != -1 && e.ColumnIndex == 3/*dgv.CurrentCell != null && dgv.CurrentCell.ColumnIndex == 3*/)//删除按钮
            {
                if (MessageBox.Show("确定删除\"" + dgv.Rows[dgv.CurrentCell.RowIndex].Cells[0].Value + "\"吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //判断文件是不是存在
                    if (File.Exists(url + @"\" + dir + @"\" + dgv.Rows[dgv.CurrentCell.RowIndex].Cells[0].Value))
                    {
                        //如果存在则删除
                        File.Delete(url + @"\" + dir + @"\" + dgv.Rows[dgv.CurrentCell.RowIndex].Cells[0].Value);
                        if (!File.Exists(url + @"\" + dir + @"\" + dgv.Rows[dgv.CurrentCell.RowIndex].Cells[0].Value))
                        {
                            MessageBox.Show("删除文件\"" + dgv.Rows[dgv.CurrentCell.RowIndex].Cells[0].Value + "\"成功！");
                        }
                    }
                    else
                    {
                        MessageBox.Show("删除文件\"" + dgv.Rows[dgv.CurrentCell.RowIndex].Cells[0].Value + "\"失败！文件不存在或已被删除");
                    }
                    LoadData();
                }
            }
            
        }
        #endregion

        public string FilePathStr = "";
        private void newFile_Click(object sender, EventArgs e)
        {
            Thread InvokeThread = new Thread(new ThreadStart(InvokeMethod));
            InvokeThread.SetApartmentState(ApartmentState.STA);
            InvokeThread.Start();
            InvokeThread.Join();
            //判断照片文件格式：.jpg/.JPG
            Regex regex = new Regex(@"^([a-zA-Z]\:[\\a-zA-Z0-9_\\]*)([a-zA-Z0-9_\-\s\u4E00-\u9FA5]+)[\.]((jpg)|(JPG)|(png)|(PNG)|(bmp)|(BMP)|(doc)|(docx)|(xls)|(xlsx))$");
            Match m = regex.Match(FilePathStr);
            if (m.Success)
            {
                string[] strs = FilePathStr.Split('\\');
                string fileName = strs[strs.Length - 1];
                if (!System.IO.Directory.Exists(url + @"\" + dir + @"\" ))
                {
                    // 目录不存在，建立目录
                    System.IO.Directory.CreateDirectory(url + @"\" + dir + @"\");
                }
                //判断是否存在同名文件
                if (System.IO.File.Exists(url + @"\" + dir + @"\" + fileName))
                {
                    bool b = MessageBox.Show("存在同名文件，确定覆盖吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes;
                    if (b)
                    {
                        String sourcePath = FilePathStr;
                        String targetPath = url + @"\" + dir + @"\" + fileName;
                        // true=覆盖已存在的同名文件,false则反之
                        bool isrewrite = true; 
                        System.IO.File.Copy(sourcePath, targetPath, isrewrite);
                    }
                    else 
                    { 
                        return;
                    }
                   
                }
                else
                {
                    String sourcePath = FilePathStr;
                    String targetPath = url + @"\" + dir + @"\" + fileName;
                    // true=覆盖已存在的同名文件,false则反之
                    bool isrewrite = true; 
                    System.IO.File.Copy(sourcePath, targetPath, isrewrite);
                }
                LoadData();
            }
            else
            {
                MessageBox.Show("只能选择jpg、png、bmp、doc、docx、xls、xlsx格式的文件！");
            }
        }

        private void InvokeMethod()
        {
            OpenFileDialog InvokeDialog = new OpenFileDialog();
            if (InvokeDialog.ShowDialog() == DialogResult.OK)
            {
                FilePathStr = InvokeDialog.FileName;
            }
        }

    }
}
