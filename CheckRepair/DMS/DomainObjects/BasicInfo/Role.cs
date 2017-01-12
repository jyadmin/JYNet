/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/12/2009 10:46:06 AM
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DMS.ORMappers.BasicInfo;
using DMS.Common;

namespace DMS.DomainObjects.BasicInfo
{
    /// <summary>
    /// 角色
    /// </summary>
    public class Role : DomainObject
    {
        private RoleDA m_RoleDA;

        #region constract
        public Role()
        {
            m_RoleDA = new RoleDA();
            Modules = new List<Module>();
        }

        private Role(RoleDA roleDA)
        {
            this.m_RoleDA = roleDA;
        }
        #endregion

        #region Field
        /// <summary>
        /// 主键
        /// </summary>
        public override int ID
        {
            get { return m_RoleDA.ID; }
            set { m_RoleDA.ID = value; }
        }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name
        {
            get { return m_RoleDA.RoleName; }
            set { m_RoleDA.RoleName = value; }
        }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description
        {
            get { return m_RoleDA.Description; }
            set { m_RoleDA.Description = value; }
        }

        /// <summary>
        /// 是否默认
        /// </summary>
        public Int16 IsDefault
        {
            get { return m_RoleDA.IsDefault; }
            set { m_RoleDA.IsDefault = value; }
        }

        /// <summary>
        /// 版本
        /// </summary>
        public int Edition
        {
            get { return m_RoleDA.Edition; }
            set { m_RoleDA.Edition = value; }
        }

        /// <summary>
        /// 模块集合
        /// </summary>
        public List<Module> Modules
        {
            get;
            set;
        }
        #endregion

        #region CURD
        public void Retrieve(int id)
        {
            m_RoleDA = RoleDA.Get(id);
            Modules = Module.GetModulesByRole(id);
        }

        public static List<Role> GetList()
        {
            return GetList(string.Format("where [Edition]={0} and [IsDefault]=0", CurrentUser.Instance.User.Edition));
        }

        public static List<Role> GetList(string where)
        {
            List<Role> roleInfoList = new List<Role>();
            foreach (RoleDA roleDA in RoleDA.FindAll(where))
            {
                Role Role = new Role(roleDA);

                roleInfoList.Add(Role);
            }

            roleInfoList.Sort();

            return roleInfoList;
        }

        public static List<Role> GetPageList(int pageSize, int pageIndex, string where)
        {
            List<Role> roleInfoList = new List<Role>();
            foreach (RoleDA roleDA in RoleDA.FindPage(pageSize, pageIndex, where))
            {
                Role Role = new Role(roleDA);

                roleInfoList.Add(Role);
            }

            roleInfoList.Sort();

            return roleInfoList;
        }

        public bool Add(int edition)
        {
            try
            {
                m_RoleDA.Edition = edition;
                m_RoleDA.Insert();
                m_RoleDA.Save();

                m_RoleDA.ID = m_RoleDA.GetInsertID();
                Loger.Instance.WriteErrorLog(m_RoleDA.GetInsertID().ToString());
                InsertRoleModule();

                return true;
            }
            catch (Exception exception)
            {
                Loger.Instance.WriteErrorLog(exception.Message);
                return false;
            }
        }

        public bool Update()
        {
            try
            {
                m_RoleDA.Update();
                m_RoleDA.Save();

                ClearRoleModule();
                InsertRoleModule();

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
                ClearRoleModule();
                
                foreach (UserInfoDA user in UserInfoDA.FindAll(string.Format("where [Role]={0}", ID)))
                {
                    user.Role=0;
                    user.Update();
                    user.Save();
                }

                m_RoleDA.Delete();
                m_RoleDA.Save();
                return true;
            }
            catch (Exception exception)
            {
                Loger.Instance.WriteErrorLog(exception.Message);
                return false;
            }
        }

        public void InsertRoleModule()
        {
            RoleModuleDA roleModule = new RoleModuleDA();

            foreach (Module module in Modules)
            {
                roleModule.Role = ID;
                roleModule.Module = module.ID;
                roleModule.Insert();
            }

            roleModule.Save();
        }

        public void ClearRoleModule()
        {
            RoleModuleDA roleModule = new RoleModuleDA();

            foreach (Module module in Module.GetModulesByRole(ID))
            {
                roleModule.Role = ID;
                roleModule.Module = module.ID;
                roleModule.Delete();
            }

            roleModule.Save();
        }
        #endregion

        #region override
        public override string ToString()
        {
            return Name;
        }
        #endregion
    }
}
