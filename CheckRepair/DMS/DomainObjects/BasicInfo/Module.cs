/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/12/2009 10:53:52 AM
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
    /// 模块
    /// </summary>
    public class Module : DomainObject
    {
        public ModuleDA m_ModuleDA;

        #region constract
        public Module()
        {
            m_ModuleDA = new ModuleDA();
        }

        private Module(ModuleDA moduleDA)
        {
            this.m_ModuleDA = moduleDA;
        }
        #endregion

        #region Field
        /// <summary>
        /// 主键
        /// </summary>
        public override int ID
        {
            get { return m_ModuleDA.ID; }
            set { m_ModuleDA.ID = value; }
        }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name
        {
            get { return m_ModuleDA.ModuleName; }
            set { m_ModuleDA.ModuleName = value; }
        }

        /// <summary>
        /// 类型名称
        /// </summary>
        public string TypeFullName
        {
            get { return m_ModuleDA.TypeFullName; }
            set { m_ModuleDA.TypeFullName = value; }
        }

        /// <summary>
        /// 父键
        /// </summary>
        public int PriorModule
        {
            get { return m_ModuleDA.PriorModule; }
            set { m_ModuleDA.PriorModule = value; }
        }

        /// <summary>
        /// 是否显示
        /// </summary>
        public Int16 IsDisplay
        {
            get { return m_ModuleDA.IsDisplay; }
            set { m_ModuleDA.IsDisplay = value; }
        }

        /// <summary>
        /// 显示顺序
        /// </summary>
        public int DisplayOrder
        {
            get { return m_ModuleDA.DisplayOrder; }
            set { m_ModuleDA.DisplayOrder = value; }
        }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description
        {
            get { return m_ModuleDA.Description; }
            set { m_ModuleDA.Description = value; }
        }

        /// <summary>
        /// 等级
        /// </summary>
        public int Level
        {
            get { return m_ModuleDA.Level; }
            set { m_ModuleDA.Level = value; }
        }

        /// <summary>
        ///占用空间大小
        /// </summary>
        public int Size
        {
            get { return m_ModuleDA.Size; }
            set { m_ModuleDA.Size = value; }
        }
        #endregion

        #region CURD
        public void Retrieve(int id)
        {
            m_ModuleDA = ModuleDA.Get(id);
        }

        public static List<Module> GetList()
        {
            return GetList(string.Empty);
        }

        public static List<Module> GetList(string where)
        {
            List<Module> moduleInfoList = new List<Module>();
            foreach (ModuleDA moduleDA in ModuleDA.FindAll(where))
            {
                Module module = new Module(moduleDA);

                moduleInfoList.Add(module);
            }

            moduleInfoList.Sort();

            return moduleInfoList;
        }

        public bool Add()
        {
            try
            {
                m_ModuleDA.Insert();
                m_ModuleDA.Save();
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
                m_ModuleDA.Update();
                m_ModuleDA.Save();
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
                foreach(RoleModuleDA roleModule in RoleModuleDA.FindAll(string.Format("where [Module]={0}", ID)))
                {
                    roleModule.Delete();
                    roleModule.Save();
                }

                foreach (EditionModuleDA editionModule in EditionModuleDA.FindAll(string.Format("where [Module]={0}", ID)))
                {
                    editionModule.Delete();
                    editionModule.Save();
                }

                m_ModuleDA.Delete();
                m_ModuleDA.Save();
                return true;
            }
            catch (Exception exception)
            {
                Loger.Instance.WriteErrorLog(exception.Message);
                return false;
            }
        }
        #endregion

        #region other mothod
        public static List<Module> GetModulesByRole(int roleId)
        {
            List<Module> modules = new List<Module>();
            foreach (RoleModuleDA roleModule in RoleModuleDA.FindAll(string.Format("where [Role]={0}", roleId)))
            {
                modules.Add(new Module(ModuleDA.Get(roleModule.Module)));
            }

            modules.Sort();

            return modules;
        }

        public static List<Module> GetModulesByEdition(int editionId)
        {
            List<Module> modules = new List<Module>();
            foreach (EditionModuleDA editionModule in EditionModuleDA.FindAll(string.Format("where [Edition]={0}", editionId)))
            {
                modules.Add(new Module(ModuleDA.Get(editionModule.Module)));
            }

            modules.Sort();

            return modules;
        }
        #endregion

        #region ICompare
        public override int CompareTo(object module)
        {
            if (module == null)
            {
                return 1;
            }

            if ((module as Module).PriorModule == PriorModule)
            {
                return DisplayOrder.CompareTo((module as Module).DisplayOrder);
            }

            return PriorModule.CompareTo((module as Module).PriorModule);
        }
        #endregion
    }
}
