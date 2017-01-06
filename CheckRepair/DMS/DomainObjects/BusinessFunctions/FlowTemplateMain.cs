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
    public class FlowTemplateMain : DomainObject
    {
        private FlowTemplateMainDA m_FlowTemplateMainDA;

        #region constract
        public FlowTemplateMain()
        {
            m_FlowTemplateMainDA = new FlowTemplateMainDA();
        }

        private FlowTemplateMain(FlowTemplateMainDA flowTemplateMainDA)
        {
            this.m_FlowTemplateMainDA = flowTemplateMainDA;
        }
        #endregion

        #region Field
        /// <summary>
        /// 主键
        /// </summary>
        public override int ID
        {
            get { return m_FlowTemplateMainDA.ID; }
            set { m_FlowTemplateMainDA.ID = value; }
        }

        /// <summary>
        /// 排序
        /// </summary>
        public int DispalyOrder
        {
            get { return m_FlowTemplateMainDA.DispalyOrder; }
            set { m_FlowTemplateMainDA.DispalyOrder = value; }
        }

        /// <summary>
        /// 车型
        /// </summary>
        public string EngineType
        {
            get { return m_FlowTemplateMainDA.EngineType; }
            set { m_FlowTemplateMainDA.EngineType = value; }
        }

        /// <summary>
        /// 修程
        /// </summary>
        public string XC
        {
            get { return m_FlowTemplateMainDA.XC; }
            set { m_FlowTemplateMainDA.XC = value; }
        }

        /// <summary>
        /// 设备类型
        /// </summary>
        public string DeviceType
        {
            get { return m_FlowTemplateMainDA.DeviceType; }
            set { m_FlowTemplateMainDA.DeviceType = value; }
        }

        /// <summary>
        /// 设备部件
        /// </summary>
        public string Component
        {
            get { return m_FlowTemplateMainDA.Component; }
            set { m_FlowTemplateMainDA.Component = value; }
        }

        /// <summary>
        /// 工位名称
        /// </summary>
        public string ProcedureName
        {
            get { return m_FlowTemplateMainDA.ProcedureName; }
            set { m_FlowTemplateMainDA.ProcedureName = value; }
        }

        /// <summary>
        /// 作业时间
        /// </summary>
        public int OperateTime
        {
            get { return m_FlowTemplateMainDA.OperateTime; }
            set { m_FlowTemplateMainDA.OperateTime = value; }
        }

         /// <summary>
        /// 生产
        /// </summary>
        public Int16 IsProduction
        {
            get { return m_FlowTemplateMainDA.IsProduction; }
            set { m_FlowTemplateMainDA.IsProduction = value; }
        }

        /// <summary>
        /// 数据
        /// </summary>
        public Int16 IsData
        {
            get { return m_FlowTemplateMainDA.IsData; }
            set { m_FlowTemplateMainDA.IsData = value; }
        }

        /// <summary>
        /// 质量
        /// </summary>
        public Int16 Quality
        {
            get { return m_FlowTemplateMainDA.Quality; }
            set { m_FlowTemplateMainDA.Quality = value; }
        }

        /// <summary>
        /// 配件材料
        /// </summary>
        public Int16 IsMaterial
        {
            get { return m_FlowTemplateMainDA.IsMaterial; }
            set { m_FlowTemplateMainDA.IsMaterial = value; }
        }

        /// <summary>
        /// 资质
        /// </summary>
        public Int16 IsQualification
        {
            get { return m_FlowTemplateMainDA.IsQualification; }
            set { m_FlowTemplateMainDA.IsQualification = value; }
        }

        /// <summary>
        /// 设备
        /// </summary>
        public Int16 IsEquipment
        {
            get { return m_FlowTemplateMainDA.IsEquipment; }
            set { m_FlowTemplateMainDA.IsEquipment = value; }
        }

        /// <summary>
        /// 记名
        /// </summary>
        public Int16 IsSignName
        {
            get { return m_FlowTemplateMainDA.IsSignName; }
            set { m_FlowTemplateMainDA.IsSignName = value; }
        }

        /// <summary>
        /// 履历
        /// </summary>
        public Int16 IsResume
        {
            get { return m_FlowTemplateMainDA.IsResume; }
            set { m_FlowTemplateMainDA.IsResume = value; }
        }

        /// <summary>
        /// 指导
        /// </summary>
        public Int16 Guidance
        {
            get { return m_FlowTemplateMainDA.Guidance; }
            set { m_FlowTemplateMainDA.Guidance = value; }
        }

        /// <summary>
        /// 判断
        /// </summary>
        public Int16 IsJudgement
        {
            get { return m_FlowTemplateMainDA.IsJudgement; }
            set { m_FlowTemplateMainDA.IsJudgement = value; }
        }

        /// <summary>
        /// 评价
        /// </summary>
        public Int16 IsEvaluate
        {
            get { return m_FlowTemplateMainDA.IsEvaluate; }
            set { m_FlowTemplateMainDA.IsEvaluate = value; }
        }

        /// <summary>
        /// 上次检查人
        /// </summary>
        public string LastChecker
        {
            get { return m_FlowTemplateMainDA.LastChecker; }
            set { m_FlowTemplateMainDA.LastChecker = value; }
        }

        /// <summary>
        /// 上次检查人编号
        /// </summary>
        public int LastCheckerCode
        {
            get { return m_FlowTemplateMainDA.LastCheckerCode; }
            set { m_FlowTemplateMainDA.LastCheckerCode = value; }
        }
        #endregion

        #region CURD
        public void Retrieve(int id)
        {
            m_FlowTemplateMainDA = FlowTemplateMainDA.Get(id);
        }

        public static List<FlowTemplateMain> GetList(string where)
        {
            List<FlowTemplateMain> flowTemplateMainList = new List<FlowTemplateMain>();
            foreach (FlowTemplateMainDA flowTemplateMainDA in FlowTemplateMainDA.FindAll(where))
            {
                FlowTemplateMain FlowTemplateMain = new FlowTemplateMain(flowTemplateMainDA);

                flowTemplateMainList.Add(FlowTemplateMain);
            }

            flowTemplateMainList.Sort();

            return flowTemplateMainList;
        }

        public bool Add()
        {
            try
            {
                m_FlowTemplateMainDA.Insert();
                m_FlowTemplateMainDA.Save();
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
                m_FlowTemplateMainDA.Update();
                m_FlowTemplateMainDA.Save();

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
                m_FlowTemplateMainDA.Delete();
                m_FlowTemplateMainDA.Save();
                return true;
            }
            catch (Exception exception)
            {
                Loger.Instance.WriteErrorLog(exception.Message);
                return false;
            }
        }

        #endregion

        #region override
        public override string ToString()
        {
            return EngineType + "," + XC + "," + DeviceType + "," + Component + "," + ProcedureName;
        }
        #endregion
    }
}
