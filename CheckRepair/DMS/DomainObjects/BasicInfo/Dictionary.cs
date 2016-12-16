/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/21/2009 9:21:08 AM
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
    /// 数据字典
    /// </summary>
    public class Dictionary : DomainObject
    {
        private DictionaryDA m_DictionaryDA;

        #region Constractor
        public Dictionary()
        {
            m_DictionaryDA = new DictionaryDA();
        }

        private Dictionary(DictionaryDA dictionaryDA)
        {
            m_DictionaryDA = dictionaryDA;
        }
        #endregion

        #region Field
        /// <summary>
        /// 主键
        /// </summary>
        public override int ID
        {
            get { return m_DictionaryDA.ID; }
            set { m_DictionaryDA.ID = value; }
        }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name
        {
            get { return m_DictionaryDA.StringValue; }
            set { m_DictionaryDA.StringValue = value; }
        }

        /// <summary>
        /// 显示顺序
        /// </summary>
        public int DisplayOrder
        {
            get { return m_DictionaryDA.DisplayOrder; }
            set { m_DictionaryDA.DisplayOrder = value; }
        }

        /// <summary>
        /// 父键
        /// </summary>
        public int ParentID
        {
            get { return m_DictionaryDA.ParentID; }
            set { m_DictionaryDA.ParentID = value; }
        }
        
        /// <summary>
        /// 描述
        /// </summary>
        public string Type
        {
            get { return m_DictionaryDA.Type; }
            set { m_DictionaryDA.Type = value; }
        }
        #endregion

        #region CURD
        public void Retrieve(int id)
        {
            m_DictionaryDA = DictionaryDA.Get(id);
        }

        public static List<Dictionary> GetList()
        {
            return GetList(string.Empty);
        }

        public static List<Dictionary> GetList(string where)
        {
            List<Dictionary> dictionaryList = new List<Dictionary>();
            foreach (DictionaryDA dictionaryDA in DictionaryDA.FindAll(where))
            {
                Dictionary dictionary = new Dictionary(dictionaryDA);

                dictionaryList.Add(dictionary);
            }

            dictionaryList.Sort();

            return dictionaryList;
        }

        public bool Add()
        {
            try
            {
                m_DictionaryDA.Insert();
                m_DictionaryDA.Save();

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
                m_DictionaryDA.Update();
                m_DictionaryDA.Save();

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
                foreach (DictionaryDA dictionaryDA in DictionaryDA.FindAll(string.Format("where [ParentID]={0}", ID)))
                {
                    dictionaryDA.Delete();
                    dictionaryDA.Save();
                }

                m_DictionaryDA.Delete();
                m_DictionaryDA.Save();
                return true;
            }
            catch (Exception exception)
            {
                Loger.Instance.WriteErrorLog(exception.Message);
                return false;
            }
        }
        #endregion

        #region ICompare
        public override int CompareTo(object dictionary)
        {
            if (dictionary == null)
            {
                return 1;
            }

            if ((dictionary as Dictionary).ParentID == ParentID)
            {
                return DisplayOrder.CompareTo((dictionary as Dictionary).DisplayOrder);
            }

            return ParentID.CompareTo((dictionary as Dictionary).ParentID);
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
