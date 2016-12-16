/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/16/2009 10:24:20 PM
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
    /// 版本
    /// </summary>
    public class Edition : DomainObject
    {
        private EditionDA m_EditionDA;

        #region constract
        public Edition()
        {
            m_EditionDA = new EditionDA();
            Modules = new List<Module>();
        }

        private Edition(EditionDA editionDA)
        {
            this.m_EditionDA = editionDA;
        }
        #endregion

        #region Field
        /// <summary>
        /// 主键
        /// </summary>
        public override int ID
        {
            get { return m_EditionDA.ID; }
            set { m_EditionDA.ID = value; }
        }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name
        {
            get { return m_EditionDA.EditionName; }
            set { m_EditionDA.EditionName = value; }
        }

        /// <summary>
        /// 是否默认
        /// </summary>
        public Int16 IsDefault
        {
            get {  return m_EditionDA.IsDefault; }
            set { m_EditionDA.IsDefault = value; }
        }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description
        {
            get { return m_EditionDA.Description; }
            set { m_EditionDA.Description = value; }
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

        #region CURDL
        public void Retrieve(int id)
        {
            m_EditionDA = EditionDA.Get(id);
            Modules = Module.GetModulesByEdition(id);
        }

        public static List<Edition> GetList()
        {
            return GetList(string.Empty);
        }

        public static List<Edition> GetList(string where)
        {
            List<Edition> editionInfoList = new List<Edition>();
            foreach (EditionDA editionDA in EditionDA.FindAll(where))
            {
                Edition edition = new Edition(editionDA);

                editionInfoList.Add(edition);
            }

            editionInfoList.Sort();

            return editionInfoList;
        }

        public bool Add()
        {
            try
            {   
                //版本
                m_EditionDA.Insert();
                m_EditionDA.Save();

                //版本功能
                m_EditionDA.ID = m_EditionDA.GetInsertID();
                InsertEditionModule();
                
                //角色
                Role role = new Role();
                role.Name = "系统管理员角色";                
                role.IsDefault = 1;
                role.Modules = Modules;
                role.Add(ID);                

                //用户
                UserInfoDA userInfo = new UserInfoDA();
                userInfo.UserName = "系统管理员";
                userInfo.LoginName = string.Format("admin_{0}_{1}", ID, role.ID);
                userInfo.Password = "147";
                userInfo.Role = role.ID;
                userInfo.Edition = ID;
                userInfo.IsDefault = 1;
                userInfo.Description = Name;
                userInfo.Insert();
                userInfo.Save();

                return true;
            }
            catch(Exception exception)
            {
                Loger.Instance.WriteErrorLog(exception.Message);
                return false;
            }
        }

        public bool Update()
        {
            try
            {
                m_EditionDA.Update();
                m_EditionDA.Save();

                ClearEditionModule();
                InsertEditionModule();

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
                ClearEditionModule();

                foreach (UserInfo userInfo in UserInfo.GetList(string.Format("where [Edition]={0}", ID)))
                {
                    userInfo.Delete(); 
                }

                foreach (Role role in Role.GetList(string.Format("where [Edition]={0}", ID)))
                {
                    role.Delete();
                }

                m_EditionDA.Delete();
                m_EditionDA.Save();
                return true;
            }
            catch (Exception exception)
            {
                Loger.Instance.WriteErrorLog(exception.Message);
                return false;
            }

        }

        private void InsertEditionModule()
        {
            foreach (Module module in Modules)
            {
                EditionModuleDA editionModuleDA = new EditionModuleDA();
                editionModuleDA.Edition = ID;
                editionModuleDA.Module = module.ID;
                editionModuleDA.Insert();
                editionModuleDA.Save();
            }
        }       

        private void ClearEditionModule()
        {
            foreach (Module module in Module.GetModulesByEdition(ID))
            {
                EditionModuleDA editionModuleDA = new EditionModuleDA();
                editionModuleDA.Edition = ID;
                editionModuleDA.Module = module.ID;
                editionModuleDA.Delete();
                editionModuleDA.Save();
            }
        }

        private void InsertRoleModule()
        {
            List<Role> roles = Role.GetList(string.Format("where [Edition]={0} and [IsDefault]=-1", ID));
            if (roles.Count == 0)
            {
                return;
            }

            Role role = roles[0];
            role.Retrieve(role.ID);

            role.ClearRoleModule();

            role.Modules.Clear();
            role.Modules = Modules;
            role.InsertRoleModule();
        }
        #endregion
    }
}
