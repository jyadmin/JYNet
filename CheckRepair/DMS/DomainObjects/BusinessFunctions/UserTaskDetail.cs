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
    public class UserTaskDetail : DomainObject
    {
        private UserTaskDetailDA m_UserTaskDetailTaskDA;

        #region constract
        public UserTaskDetail()
        {
            m_UserTaskDetailTaskDA = new UserTaskDetailDA();
        }

        private UserTaskDetail(UserTaskDetailDA userTaskDetailDA)
        {
            this.m_UserTaskDetailTaskDA = userTaskDetailDA;
        }
        #endregion

        #region Field
        /// <summary>
        /// 主键
        /// </summary>
        public override int ID
        {
            get { return m_UserTaskDetailTaskDA.ID; }
            set { m_UserTaskDetailTaskDA.ID = value; }
        }

        /// <summary>
        /// 任务分配人员ID拼接字符串
        /// </summary>
        public string UserIds
        {
            get { return m_UserTaskDetailTaskDA.UserIds; }
            set { m_UserTaskDetailTaskDA.UserIds = value; }
        }

        /// <summary>
        /// 主模板ID
        /// </summary>
        public int TemplateMainId
        {
            get { return m_UserTaskDetailTaskDA.TemplateMainId; }
            set { m_UserTaskDetailTaskDA.TemplateMainId = value; }
        }

        /// <summary>
        /// 详细步骤模板ID
        /// </summary>
        public int TemplateDetailId
        {
            get { return m_UserTaskDetailTaskDA.TemplateDetailId; }
            set { m_UserTaskDetailTaskDA.TemplateDetailId = value; }
        }

        /// <summary>
        /// 具体步骤状态，2表示已执行，0表示未执行
        /// </summary>
        public string Status
        {
            get { return m_UserTaskDetailTaskDA.Status; }
            set { m_UserTaskDetailTaskDA.Status = value; }
        }

        /// <summary>
        ///派工时间
        /// </summary>
        public long AssignTime
        {
            get { return m_UserTaskDetailTaskDA.AssignTime; }
            set { m_UserTaskDetailTaskDA.AssignTime = value; }
        }

        /// <summary>
        /// 完成时间
        /// </summary>
        public long FinishTime
        {
            get { return m_UserTaskDetailTaskDA.FinishTime; }
            set { m_UserTaskDetailTaskDA.FinishTime = value; }
        }

        /// <summary>
        /// 设备接收ID
        /// </summary>
        public int DeviceReceiveID
        {
            get { return m_UserTaskDetailTaskDA.DeviceReceiveID; }
            set { m_UserTaskDetailTaskDA.DeviceReceiveID = value; }
        }

        /// <summary>
        /// 任务分配ID
        /// </summary>
        public int AssignedTaskID
        {
            get { return m_UserTaskDetailTaskDA.AssignedTaskID; }
            set { m_UserTaskDetailTaskDA.AssignedTaskID = value; }
        }

        /// <summary>
        /// 具体步骤方框的背景色状态，0标识默认的灰色，1绿色符合标准，2红色不符合标准
        /// </summary>
        public int statusColor
        {
            get { return m_UserTaskDetailTaskDA.statusColor; }
            set { m_UserTaskDetailTaskDA.statusColor = value; }
        }
        #endregion

        #region CURD
        public void Retrieve(int id)
        {
            m_UserTaskDetailTaskDA = UserTaskDetailDA.Get(id);
        }

        public static List<UserTaskDetail> GetList(string where)
        {
            List<UserTaskDetail> userTaskDetailList = new List<UserTaskDetail>();
            foreach (UserTaskDetailDA userTaskDetailDA in UserTaskDetailDA.FindAll(where))
            {
                UserTaskDetail UserTaskDetail = new UserTaskDetail(userTaskDetailDA);

                userTaskDetailList.Add(UserTaskDetail);
            }

            //assignedTaskList.Sort();

            return userTaskDetailList;
        }

        public bool Add()
        {
            try
            {
                m_UserTaskDetailTaskDA.Insert();
                m_UserTaskDetailTaskDA.Save();
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
                m_UserTaskDetailTaskDA.Update();
                m_UserTaskDetailTaskDA.Save();

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
                m_UserTaskDetailTaskDA.Delete();
                m_UserTaskDetailTaskDA.Save();
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
