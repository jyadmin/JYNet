/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/17/2009 11:39:08 PM
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DMS.DomainObjects.BasicInfo;

namespace DMS.UI.Common
{
    public class DataGridDictionary
    {
        private Dictionary<string, List<string>> dataGridPropertyDictionary;

        private Dictionary<string, string> dataGridPropertyTitleDictionary;

        #region Instance
        private DataGridDictionary()
        {
            LoadDictionary();
        }

        static DataGridDictionary instance;

        public static DataGridDictionary Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (typeof(DataGridDictionary))
                    {
                        instance = new DataGridDictionary();
                    }
                }

                return instance;
            }
        }
        #endregion

        public string[] GetDataGridPropertys(string type)
        {
            if(dataGridPropertyDictionary.ContainsKey(type))
            {
                return dataGridPropertyDictionary[type].ToArray();
            }

            return new List<string>().ToArray();
        }

        public string GetDataGridPropertyTitle(string property)
        {
            if (dataGridPropertyTitleDictionary.ContainsKey(property))
            {
                return dataGridPropertyTitleDictionary[property];
            }

            return "未知";
        }

        private void LoadDictionary()
        {
            LoadDataGridProperty();
            LoadDataGridPropertyTitle();
        }

        private void LoadDataGridProperty()
        {
            dataGridPropertyDictionary = new Dictionary<string, List<string>>();
            LoadSystemManageDataGridProperty();
        }

        private void LoadDataGridPropertyTitle()
        {
            dataGridPropertyTitleDictionary = new Dictionary<string, string>();
            LoadSystemManageDataGridPropertyTitle();
        }

        /// <summary>
        /// 加载系统管理信息的显示属性
        /// </summary>
        private void LoadSystemManageDataGridProperty()
        {
            //用户信息
            string type = typeof(UserInfo).FullName;
            dataGridPropertyDictionary.Add(type, new List<string>());
            dataGridPropertyDictionary[type].Add("UserName");
            dataGridPropertyDictionary[type].Add("LoginName");
            dataGridPropertyDictionary[type].Add("Password");
            dataGridPropertyDictionary[type].Add("Duty");
            dataGridPropertyDictionary[type].Add("Description");

            //功能模块
            type = typeof(Module).FullName;
            dataGridPropertyDictionary.Add(type, new List<string>());
            dataGridPropertyDictionary[type].Add("ID");
            dataGridPropertyDictionary[type].Add("Name");
            dataGridPropertyDictionary[type].Add("TypeFullName");
            dataGridPropertyDictionary[type].Add("PriorModule");
            dataGridPropertyDictionary[type].Add("IsDisplay");
            dataGridPropertyDictionary[type].Add("DisplayOrder");

            //角色信息
            type = typeof(Role).FullName;
            dataGridPropertyDictionary.Add(type, new List<string>());
            dataGridPropertyDictionary[type].Add("Name");
            dataGridPropertyDictionary[type].Add("Description");

            //版本信息
            type = typeof(Edition).FullName;
            dataGridPropertyDictionary.Add(type, new List<string>());
            dataGridPropertyDictionary[type].Add("Name");
            dataGridPropertyDictionary[type].Add("IsDefault");
            dataGridPropertyDictionary[type].Add("Description");

            //数据字典
            type = typeof(Dictionary).FullName;
            dataGridPropertyDictionary.Add(type, new List<string>());
            dataGridPropertyDictionary[type].Add("ID");
            dataGridPropertyDictionary[type].Add("ParentID");
            dataGridPropertyDictionary[type].Add("Name");
            dataGridPropertyDictionary[type].Add("Type");
            dataGridPropertyDictionary[type].Add("DisplayOrder");
        }

        /// <summary>
        /// 加载系统管理信息的显示属性标题
        /// </summary>
        private void LoadSystemManageDataGridPropertyTitle()
        {
            string type = typeof(UserInfo).FullName;
            //用户信息
            dataGridPropertyTitleDictionary.Add(string.Format("{0}.UserName", type), "用户名");
            dataGridPropertyTitleDictionary.Add(string.Format("{0}.LoginName", type), "登陆帐号");
            dataGridPropertyTitleDictionary.Add(string.Format("{0}.Password", type), "密码");
            dataGridPropertyTitleDictionary.Add(string.Format("{0}.Duty", type), "职责");
            dataGridPropertyTitleDictionary.Add(string.Format("{0}.Description", type), "描述");


            //功能模块
            type = typeof(Module).FullName;
            dataGridPropertyTitleDictionary.Add(string.Format("{0}.ID", type), "模块ID");
            dataGridPropertyTitleDictionary.Add(string.Format("{0}.Name", type), "模块名称");
            dataGridPropertyTitleDictionary.Add(string.Format("{0}.TypeFullName", type), "启动类");
            dataGridPropertyTitleDictionary.Add(string.Format("{0}.PriorModule", type), "上级模块");
            dataGridPropertyTitleDictionary.Add(string.Format("{0}.IsDisplay", type), "是否显示");
            dataGridPropertyTitleDictionary.Add(string.Format("{0}.DisplayOrder", type), "显示顺序");

            //角色信息
            type = typeof(Role).FullName;
            dataGridPropertyTitleDictionary.Add(string.Format("{0}.Name", type), "角色名称");
            dataGridPropertyTitleDictionary.Add(string.Format("{0}.Description", type), "描述");

            //版本信息
            type = typeof(Edition).FullName;
            dataGridPropertyTitleDictionary.Add(string.Format("{0}.Name", type), "版本名称");
            dataGridPropertyTitleDictionary.Add(string.Format("{0}.IsDefault", type), "是否默认");
            dataGridPropertyTitleDictionary.Add(string.Format("{0}.Description", type), "描述");

            //数据字典
            type = typeof(Dictionary).FullName;
            dataGridPropertyTitleDictionary.Add(string.Format("{0}.ID", type), "数据项ID");
            dataGridPropertyTitleDictionary.Add(string.Format("{0}.ParentID", type), "父数据项");
            dataGridPropertyTitleDictionary.Add(string.Format("{0}.Name", type), "名称");
            dataGridPropertyTitleDictionary.Add(string.Format("{0}.Type", type), "数据项类型");
            dataGridPropertyTitleDictionary.Add(string.Format("{0}.DisplayOrder", type), "显示顺序");
        }
    }
}
