/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/17/2009 5:09:27 PM
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using DMS.Common;
using DMS.UI.Common;
using DMS.DomainObjects;
using DMS.DomainObjects.BasicInfo;
using System.IO;
using System.Text.RegularExpressions;

namespace DMS.UI.SystemManage.UserManage
{
    public partial class UserFormBase : DetailForm
    {
        protected UserInfo m_UserInfo;
        protected byte[] byteFile = {0};

        public UserFormBase()
        {
            InitializeComponent();
            m_UserInfo = new UserInfo();        
        }

        public override void AddCommands(List<ToolBarCommand> commands)
        {
            base.AddCommands(commands);
            commands.Insert(0, tbcCancel);
        }

        private void UserFormBase_Load(object sender, EventArgs e)
        {
            InitControl();
            LoadRoleInfo();
        }

        public void InitControl()
        {
            AddRequiredTextItem(txtLoginName, "登陆帐号不能为空!");
            AddRequiredTextItem(txtPassword, "登陆密码不能为空!");
            AddRequiredTextItem(txtUserName, "用户名称不能为空!");
            AddRequiredTextItem(cmbRole, "角色不能为空!");
            AddRequiredTextItem(txtWorkingAge, "工龄不能为空!", @"^\d{1,5}$", "必须为数字!");
        }
        private void LoadRoleInfo()
        {
            List<Role> roleList = Role.GetList(string.Format("where [Edition]={0}", CurrentUser.Instance.User.Edition));
            Role role = new Role();
            role.ID = 0;
            role.Name = string.Empty;
            roleList.Insert(0, role);

            cmbRole.DataSource = roleList;
            cmbRole.DataBindings.Add("Name", roleList, "ID");
        }

        protected void SetReadonlyControl()
        {
            SetEditReadonlyControl();
            SetReadOnly(txtUserName, true, Color.White);
            SetReadOnly(txtPassword, true, Color.White);
            SetReadOnly(txtDuty, true, Color.White);
            SetReadOnly(txtDescript, true, Color.White);
            SetReadOnly(txtEmployeeNumber, true, Color.White);
            SetReadOnly(txtWorkingAge, true, Color.White);
            SetReadOnly(txtQualification, true, Color.White);
            SetReadOnly(txtGrade, true, Color.White);
            SetEnable(cmbRole, false);
            SetEnable(cbLoginAllowed, false);
            userPhoto.DoubleClick -= choosePhoto_Click;
            photoTipLabel.Visible = false;

        }

        protected void SetEditReadonlyControl()
        {
            SetReadOnly(txtLoginName, true, Color.White);

            if (m_UserInfo.IsDefault == 1)
            {
                SetEnable(cmbRole, false);
            }
        }

        public void SetUserToForm()
        {
            txtuserId.Text = m_UserInfo.ID.ToString();
            txtUserName.Text = m_UserInfo.UserName;
            txtLoginName.Text = m_UserInfo.LoginName;
            txtPassword.Text = m_UserInfo.Password;
            txtDuty.Text = m_UserInfo.Duty;
            txtEmployeeNumber.Text = m_UserInfo.EmployeeNumber;
            txtWorkingAge.Text = m_UserInfo.WorkingAge.ToString();
            txtQualification.Text = m_UserInfo.Qualification;
            txtGrade.Text = m_UserInfo.Grade;
            cbLoginAllowed.Checked = (m_UserInfo.LoginAllowed == 1 ? true : false);
            txtDescript.Text = m_UserInfo.Description;
            try
            {
                byte[] b = (byte[])m_UserInfo.Photo;
                if (b.Length > 1)
                {
                    MemoryStream buf = new MemoryStream((byte[])m_UserInfo.Photo);
                    Image image = Image.FromStream(buf, true);
                    userPhoto.Image = image;
                    byteFile = m_UserInfo.Photo;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            if (!(m_UserInfo.IsDefault == 1))
            {
                bool display = false;
                foreach (Role role in this.cmbRole.Items)
                {
                    if (role.ID == m_UserInfo.Role)
                    {
                        cmbRole.SelectedItem = role;
                        display = true;
                        break;
                    }
                }

                if (!display)
                {
                    cmbRole.SelectedIndex = 0;
                }
            }
        }

        public void GetFormToUser()
        {
            m_UserInfo.UserName = txtUserName.Text;
            m_UserInfo.LoginName = txtLoginName.Text;
            m_UserInfo.Password = txtPassword.Text;
            m_UserInfo.Duty = txtDuty.Text;
            m_UserInfo.EmployeeNumber = txtEmployeeNumber.Text;
            m_UserInfo.WorkingAge = int.Parse( txtWorkingAge.Text);
            m_UserInfo.Qualification = txtQualification.Text;
            m_UserInfo.Grade = txtGrade.Text;
            m_UserInfo.LoginAllowed = Int16.Parse((cbLoginAllowed.Checked == true ? 1 : 0).ToString());
            m_UserInfo.Description = txtDescript.Text;
            m_UserInfo.Photo = byteFile;

            if (!(m_UserInfo.IsDefault == 1))
            {
                m_UserInfo.Role = (cmbRole.SelectedItem as Role).ID;
            }
        }

        public string PhotoPathStr = "";
        private void choosePhoto_Click(object sender, EventArgs e)
        {
            
            Thread InvokeThread = new Thread(new ThreadStart(InvokeMethod));
            InvokeThread.SetApartmentState(ApartmentState.STA);
            InvokeThread.Start();
            InvokeThread.Join();
            //判断照片文件格式：.jpg/.JPG
            Regex regex = new Regex(@"^([a-zA-Z]\:[\\a-zA-Z0-9_\\]*)([a-zA-Z0-9_\u4E00-\u9FA5]+)[\.]((jpg)|(JPG)|(png)|(PNG)|(bmp)|(BMP))$");
            Match m = regex.Match(PhotoPathStr);
            if (m.Success)
            {
                //读取照片文件
                FileStream fs = new FileStream(PhotoPathStr, FileMode.Open, FileAccess.Read);
                byteFile = new byte[fs.Length];
                fs.Read(byteFile, 0, (int)fs.Length);
                fs.Close();
                userPhoto.ImageLocation = PhotoPathStr;
            }
            else
            {
                MessageBox.Show("只能选择jpg、png、bmp格式的图片文件！");
            }
        }
        private void InvokeMethod()
        {
            OpenFileDialog InvokeDialog = new OpenFileDialog();
            if (InvokeDialog.ShowDialog() == DialogResult.OK)
            {
                PhotoPathStr = InvokeDialog.FileName;
            }
        }

    }
}
