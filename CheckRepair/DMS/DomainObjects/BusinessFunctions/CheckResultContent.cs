using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DMS.ORMappers.BusinessFunctions;
using DMS.Common;

namespace DMS.DomainObjects.BusinessFunctions
{
    /// <summary>
    /// 任务分配人员关联具体步骤
    /// </summary>
    public class CheckResultContent : DomainObject
    {
        private CheckResultContentDA m_CheckResultContentDA;

        #region constract
        public CheckResultContent()
        {
            m_CheckResultContentDA = new CheckResultContentDA();
        }

        private CheckResultContent(CheckResultContentDA checkResultContentDA)
        {
            this.m_CheckResultContentDA = checkResultContentDA;
        }
        #endregion

        #region Field
        /// <summary>
        /// 主键
        /// </summary>
        public override int ID
        {
            get { return m_CheckResultContentDA.ID; }
            set { m_CheckResultContentDA.ID = value; }
        }

        /// <summary>
        /// 标识
        /// </summary>
        public string CheckKeys
        {
            get { return m_CheckResultContentDA.CheckKeys; }
            set { m_CheckResultContentDA.CheckKeys = value; }
        }

        /// <summary>
        /// 检查值
        /// </summary>
        public string CheckValue
        {
            get { return m_CheckResultContentDA.CheckValue; }
            set { m_CheckResultContentDA.CheckValue = value; }
        }

        /// <summary>
        /// 设备类型
        /// </summary>
        public string DeviceType
        {
            get { return m_CheckResultContentDA.DeviceType; }
            set { m_CheckResultContentDA.DeviceType = value; }
        }
        
        /// <summary>
        /// 设备接收ID
        /// </summary>
        public int DeviceReceiveID
        {
            get { return m_CheckResultContentDA.DeviceReceiveID; }
            set { m_CheckResultContentDA.DeviceReceiveID = value; }
        }

        /// <summary>
        /// 批次号
        /// </summary>
        public string BatchCode
        {
            get { return m_CheckResultContentDA.BatchCode; }
            set { m_CheckResultContentDA.BatchCode = value; }
        }

        /// <summary>
        /// 修程
        /// </summary>
        public string XC
        {
            get { return m_CheckResultContentDA.XC; }
            set { m_CheckResultContentDA.XC = value; }
        }

        /// <summary>
        /// 步骤编号
        /// </summary>
        public int StepCode
        {
            get { return m_CheckResultContentDA.StepCode; }
            set { m_CheckResultContentDA.StepCode = value; }
        }

        /// <summary>
        /// 小步骤编号
        /// </summary>
        public int SubStepCode
        {
            get { return m_CheckResultContentDA.SubStepCode; }
            set { m_CheckResultContentDA.SubStepCode = value; }
        }

        /// <summary>
        /// 关联UserTaskDetailID
        /// </summary>
        public int UserTaskDetailID
        {
            get { return m_CheckResultContentDA.UserTaskDetailID; }
            set { m_CheckResultContentDA.UserTaskDetailID = value; }
        }
        #endregion

        #region CURD
        public void Retrieve(int id)
        {
            m_CheckResultContentDA = CheckResultContentDA.Get(id);
        }

        public static List<CheckResultContent> GetList(string where)
        {
            List<CheckResultContent> checkResultContentList = new List<CheckResultContent>();
            foreach (CheckResultContentDA checkResultContentDA in CheckResultContentDA.FindAll(where))
            {
                CheckResultContent checkResultContent = new CheckResultContent(checkResultContentDA);

                checkResultContentList.Add(checkResultContent);
            }

            return checkResultContentList;
        }

        public bool Add()
        {
            try
            {
                m_CheckResultContentDA.Insert();
                m_CheckResultContentDA.Save();
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
                m_CheckResultContentDA.Update();
                m_CheckResultContentDA.Save();

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
                m_CheckResultContentDA.Delete();
                m_CheckResultContentDA.Save();
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
