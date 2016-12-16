/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/11/2009 5:43:35 PM
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DMS.ORMappers.BasicInfo;
using DMS.Common;

namespace DMS.DomainObjects.BasicInfo
{
    public class UserInfo : DomainObject
    {
        private UserInfoDA m_UserInfoDA;

        #region constract
        public UserInfo()
        {
            m_UserInfoDA = new UserInfoDA();
        }

        private UserInfo(UserInfoDA userInfoDA)
        {
            this.m_UserInfoDA = userInfoDA;
        }
        #endregion

        #region Field
        /// <summary>
        /// 主键
        /// </summary>
        public override int ID  
        {
            get { return m_UserInfoDA.ID; }
            set { m_UserInfoDA.ID = value; }
        }

        /// <summary>
        /// 名称
        /// </summary>
        public string UserName
        {
            get { return m_UserInfoDA.UserName; }
            set { m_UserInfoDA.UserName = value; }
        }

        /// <summary>
        /// 登陆帐号
        /// </summary>
        public string LoginName
        {
            get { return m_UserInfoDA.LoginName; }
            set { m_UserInfoDA.LoginName = value; }        
        }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password
        {
            get { return m_UserInfoDA.Password; }
            set { m_UserInfoDA.Password = value; }
        }

        /// <summary>
        /// 职责
        /// </summary>
        public string Duty
        {
            get { return m_UserInfoDA.Duty; }
            set { m_UserInfoDA.Duty = value; }
        }

        /// <summary>
        /// 备注
        /// </summary>
        public string Description
        {
            get { return m_UserInfoDA.Description; }
            set { m_UserInfoDA.Description = value; }
        }

        /// <summary>
        /// 是否默认
        /// </summary>
        public Int16 IsDefault
        {
            get { return m_UserInfoDA.IsDefault; }
            set { m_UserInfoDA.IsDefault = value; }
        }

        /// <summary>
        /// 角色
        /// </summary>
        public int Role
        {
            get { return m_UserInfoDA.Role; }
            set { m_UserInfoDA.Role = value; }
        }

        /// <summary>
        /// 版本
        /// </summary>
        public int Edition
        {
            get { return m_UserInfoDA.Edition; }
            set { m_UserInfoDA.Edition = value; }
        }

        /// <summary>
        /// 角色名称
        /// </summary>
        public string RoleName
        {
            get;
            set;
        }

        #endregion

        #region CURDL
        public bool IsExist()
        {
            return m_UserInfoDA != null;
        }

        public void Retrieve(int id)
        {
            m_UserInfoDA = UserInfoDA.Get(id);
        }

        public void Retrieve(string where)
        {
            m_UserInfoDA = UserInfoDA.Get(where);
        }

        public static List<UserInfo> GetList()
        {
            if (CurrentUser.Instance.Edition.IsDefault == 1)
            {
                return GetList(string.Format("where ([Edition] <> {0} and [IsDefault] = -1) or  ([Edition]= {0} and [IsDefault] = 0)", CurrentUser.Instance.User.Edition));
            }
            else
            {
                return GetList(string.Format("where [Edition]={0} and [IsDefault]=0", CurrentUser.Instance.User.Edition));
            }
        }

        public static List<UserInfo> GetList(string where)
        {
            List<UserInfo> userInfoList = new List<UserInfo>();
            foreach (UserInfoDA userDA in UserInfoDA.FindAll(where))
            {
                UserInfo userInfo = new UserInfo(userDA);

                userInfoList.Add(userInfo);
            }

            userInfoList.Sort();

            return userInfoList;
        }

        public bool Add(out string message)
        {
            try
            {
                if (UserInfoDA.FindAll(string.Format("where [LoginName]='{0}'", LoginName)).Count > 0)
                {
                    message = "登陆帐号已经存在！";
                    return false;
                }

                m_UserInfoDA.Edition = CurrentUser.Instance.User.Edition;
                m_UserInfoDA.Insert();
                m_UserInfoDA.Save();

                message = "添加用户成功！";

                return true;
            }
            catch (Exception exception)
            {
                Loger.Instance.WriteErrorLog(exception.Message);
                message = "添加用户失败！";
                return false;
            }
        }

        public bool Update()
        {
            try
            {
                m_UserInfoDA.Update();
                m_UserInfoDA.Save();

                return true;
            }
            catch (Exception exception)
            {
                Loger.Instance.WriteErrorLog(exception.Message);
                return false;
            }
        }

        public bool Delete()
        {
            try
            {
                m_UserInfoDA.Delete();
                m_UserInfoDA.Save();
                return true;
            }
            catch (Exception exception)
            {
                Loger.Instance.WriteErrorLog(exception.Message);
                return false;
            }
        }
        #endregion

        #region Login
        public string Login(string loginName, string password)
        {
            string message = string.Empty;

            try
            {
                m_UserInfoDA = UserInfoDA.Get(string.Format("where [LoginName]='{0}'", loginName));

                if (m_UserInfoDA == null)
                {
                    message = "登陆帐号不存在！";
                }

                if (string.IsNullOrEmpty(message) && !Password.Equals(password))
                {
                    message = "登陆密码不正确！";
                }

                if (string.IsNullOrEmpty(message) && Role == 0)
                {
                    message = "用户没有权限,使用本系统！";
                }

                if (string.IsNullOrEmpty(message))
                {
                    CurrentUser.Instance.User = this;
                    CurrentUser.Instance.Role = new Role();
                    CurrentUser.Instance.Role.Retrieve(Role);
                    CurrentUser.Instance.Modules = CurrentUser.Instance.Role.Modules;
                    CurrentUser.Instance.Edition = new Edition();
                    CurrentUser.Instance.Edition.Retrieve(Edition);
                }
            }
            catch(Exception e)
            {
                message = e.Message.ToString();
                //message = "请与管理员联系！非正常错误！";
            }

            return message;
        }
        #endregion
    }
}
