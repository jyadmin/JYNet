using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DMS.ORMappers.BusinessFunctions;
using DMS.Common;

namespace DMS.DomainObjects.BusinessFunctions
{
    /// <summary>
    /// 任务分配
    /// </summary>
    public class AssignedTask : DomainObject
    {
        private AssignedTaskDA m_AssignedTaskDA;

        #region constract
        public AssignedTask()
        {
            m_AssignedTaskDA = new AssignedTaskDA();
        }

        private AssignedTask(AssignedTaskDA assignedTaskDA)
        {
            this.m_AssignedTaskDA = assignedTaskDA;
        }
        #endregion

        #region Field
        /// <summary>
        /// 主键
        /// </summary>
        public override int ID
        {
            get { return m_AssignedTaskDA.ID; }
            set { m_AssignedTaskDA.ID = value; }
        }

        /// <summary>
        /// 设备接收关联ID
        /// </summary>
        public int LinkIdToDeviceReceive
        {
            get { return m_AssignedTaskDA.LinkIdToDeviceReceive; }
            set { m_AssignedTaskDA.LinkIdToDeviceReceive = value; }
        }

        /// <summary>
        /// 信息模板关联ID
        /// </summary>
        public int TemplateID
        {
            get { return m_AssignedTaskDA.TemplateID; }
            set { m_AssignedTaskDA.TemplateID = value; }
        }

        /// <summary>
        /// 部件
        /// </summary>
        public string Component
        {
            get { return m_AssignedTaskDA.Component; }
            set { m_AssignedTaskDA.Component = value; }
        }

        /// <summary>
        /// 检验类型
        /// </summary>
        public Int16 Quality
        {
            get { return m_AssignedTaskDA.Quality; }
            set { m_AssignedTaskDA.Quality = value; }
        }

        /// <summary>
        /// 检验人员ID
        /// </summary>
        public int InspectorID
        {
            get { return m_AssignedTaskDA.InspectorID; }
            set { m_AssignedTaskDA.InspectorID = value; }
        }

        /// <summary>
        /// 任务分配人员ID拼接字符串
        /// </summary>
        public string CheckerIDs
        {
            get { return m_AssignedTaskDA.CheckerIDs; }
            set { m_AssignedTaskDA.CheckerIDs = value; }
        }

        /// <summary>
        /// 派工单状态,0未执行，1待执行，2待检验，3检验合格，4检验不合格
        /// </summary>
        public string Status
        {
            get { return m_AssignedTaskDA.Status; }
            set { m_AssignedTaskDA.Status = value; }
        }

        /// <summary>
        /// 批次号，对应设备接收的批次号
        /// </summary>
        public string BatchCode
        {
            get { return m_AssignedTaskDA.BatchCode; }
            set { m_AssignedTaskDA.BatchCode = value; }
        }

        /// <summary>
        /// 计划开始时间
        /// </summary>
        public long ArrangedStartTime
        {
            get { return m_AssignedTaskDA.ArrangedStartTime; }
            set { m_AssignedTaskDA.ArrangedStartTime = value; }
        }

        /// <summary>
        /// 计划结束时间
        /// </summary>
        public long ArrangedEndTime
        {
            get { return m_AssignedTaskDA.ArrangedEndTime; }
            set { m_AssignedTaskDA.ArrangedEndTime = value; }
        }

        /// <summary>
        /// 实际开始时间
        /// </summary>
        public long ActualStartTime
        {
            get { return m_AssignedTaskDA.ActualStartTime; }
            set { m_AssignedTaskDA.ActualStartTime = value; }
        }

        /// <summary>
        /// 实际结束时间
        /// </summary>
        public long ActualEndTime
        {
            get { return m_AssignedTaskDA.ActualEndTime; }
            set { m_AssignedTaskDA.ActualEndTime = value; }
        }
        #endregion

        #region CURD
        public void Retrieve(int id)
        {
            m_AssignedTaskDA = AssignedTaskDA.Get(id);
        }

        public static List<AssignedTask> GetList(string where)
        {
            List<AssignedTask> assignedTaskList = new List<AssignedTask>();
            foreach (AssignedTaskDA assignedTaskDA in AssignedTaskDA.FindAll(where))
            {
                AssignedTask AssignedTask = new AssignedTask(assignedTaskDA);

                assignedTaskList.Add(AssignedTask);
            }

            //assignedTaskList.Sort();

            return assignedTaskList;
        }

        public static List<AssignedTask> GetPageList(int pageSize, int pageIndex, string where)
        {
            List<AssignedTask> assignedTaskList = new List<AssignedTask>();
            foreach (AssignedTaskDA assignedTaskDA in AssignedTaskDA.FindPage(pageSize, pageIndex, where))
            {
                AssignedTask AssignedTask = new AssignedTask(assignedTaskDA);

                assignedTaskList.Add(AssignedTask);
            }

            assignedTaskList.Sort();

            return assignedTaskList;
        }

        public bool Add()
        {
            try
            {
                m_AssignedTaskDA.Insert();
                m_AssignedTaskDA.Save();
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
                m_AssignedTaskDA.Update();
                m_AssignedTaskDA.Save();

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
                m_AssignedTaskDA.Delete();
                m_AssignedTaskDA.Save();
                return true;
            }
            catch (Exception exception)
            {
                Loger.Instance.WriteErrorLog(exception.Message);
                return false;
            }
        }

        public int GetInsertID()
        {
            return m_AssignedTaskDA.GetInsertID();
        }

        #endregion
    }
}
