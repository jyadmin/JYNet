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

using DMS.Common;
using DMS.UI.Common;
using DMS.DomainObjects;
using DMS.DomainObjects.BasicInfo;

namespace DMS.UI.SystemManage.UserManage
{
    public partial class UserFormBase : DetailForm
    {
        protected UserInfo m_UserInfo;

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
            SetEnable(cmbRole, false);
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
            txtDescript.Text = m_UserInfo.Description;

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
            m_UserInfo.Description = txtDescript.Text;

            if (!(m_UserInfo.IsDefault == 1))
            {
                m_UserInfo.Role = (cmbRole.SelectedItem as Role).ID;
            }
        }
    }
}
