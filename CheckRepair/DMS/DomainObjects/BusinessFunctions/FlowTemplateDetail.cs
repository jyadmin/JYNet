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

using DMS.ORMappers.BusinessFunctions;
using DMS.Common;

namespace DMS.DomainObjects.BusinessFunctions
{
    /// <summary>
    /// 角色
    /// </summary>
    public class FlowTemplateDetail : DomainObject
    {
        private FlowTemplateDetailDA m_FlowTemplateDetailDA;

        #region constract
        public FlowTemplateDetail()
        {
            m_FlowTemplateDetailDA = new FlowTemplateDetailDA();
        }

        private FlowTemplateDetail(FlowTemplateDetailDA flowTemplateDetailDA)
        {
            this.m_FlowTemplateDetailDA = flowTemplateDetailDA;
        }
        #endregion

        #region Field
        /// <summary>
        /// 主键
        /// </summary>
        public override int ID
        {
            get { return m_FlowTemplateDetailDA.ID; }
            set { m_FlowTemplateDetailDA.ID = value; }
        }

        /// <summary>
        /// 关联ID
        /// </summary>
        public int LinkId
        {
            get { return m_FlowTemplateDetailDA.LinkId; }
            set { m_FlowTemplateDetailDA.LinkId = value; }
        }

        /// <summary>
        /// 操作顺序
        /// </summary>
        public int OperateOrder
        {
            get { return m_FlowTemplateDetailDA.OperateOrder; }
            set { m_FlowTemplateDetailDA.OperateOrder = value; }
        }

        /// <summary>
        /// 作业项点
        /// </summary>
        public string OperateItem
        {
            get { return m_FlowTemplateDetailDA.OperateItem; }
            set { m_FlowTemplateDetailDA.OperateItem = value; }
        }

        /// <summary>
        /// 作业内容与技术标准
        /// </summary>
        public string OperateContentAndStandard
        {
            get { return m_FlowTemplateDetailDA.OperateContentAndStandard; }
            set { m_FlowTemplateDetailDA.OperateContentAndStandard = value; }
        }
        #endregion

        #region CURD
        public void Retrieve(int id)
        {
            m_FlowTemplateDetailDA = FlowTemplateDetailDA.Get(id);
        }

        public static List<FlowTemplateDetail> GetList(string where)
        {
            List<FlowTemplateDetail> flowTemplateDetailList = new List<FlowTemplateDetail>();
            foreach (FlowTemplateDetailDA flowTemplateDetailDA in FlowTemplateDetailDA.FindAll(where))
            {
                FlowTemplateDetail FlowTemplateDetail = new FlowTemplateDetail(flowTemplateDetailDA);

                flowTemplateDetailList.Add(FlowTemplateDetail);
            }

            return flowTemplateDetailList;
        }

        public bool Add()
        {
            try
            {
                m_FlowTemplateDetailDA.Insert();
                m_FlowTemplateDetailDA.Save();
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
                m_FlowTemplateDetailDA.Update();
                m_FlowTemplateDetailDA.Save();

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
                m_FlowTemplateDetailDA.Delete();
                m_FlowTemplateDetailDA.Save();
                return true;
            }
            catch (Exception exception)
            {
                Loger.Instance.WriteErrorLog(exception.Message);
                return false;
            }
        }
        #endregion
    }
}
