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
    public class DeviceReceive : DomainObject
    {
        private DeviceReceiveDA m_DeviceReceiveDA;

        #region constract
        public DeviceReceive()
        {
            m_DeviceReceiveDA = new DeviceReceiveDA();
        }

        private DeviceReceive(DeviceReceiveDA deviceReceiveDA)
        {
            this.m_DeviceReceiveDA = deviceReceiveDA;
        }
        #endregion

        #region Field
        /// <summary>
        /// 主键
        /// </summary>
        public override int ID
        {
            get { return m_DeviceReceiveDA.ID; }
            set { m_DeviceReceiveDA.ID = value; }
        }

        /// <summary>
        /// 车型
        /// </summary>
        public string EngineType
        {
            get { return m_DeviceReceiveDA.EngineType; }
            set { m_DeviceReceiveDA.EngineType = value; }
        }

        /// <summary>
        /// 车号
        /// </summary>
        public string EngineCode
        {
            get { return m_DeviceReceiveDA.EngineCode; }
            set { m_DeviceReceiveDA.EngineCode = value; }
        }

        /// <summary>
        /// 修程
        /// </summary>
        public string XC
        {
            get { return m_DeviceReceiveDA.XC; }
            set { m_DeviceReceiveDA.XC = value; }
        }

        /// <summary>
        /// 设备类型
        /// </summary>
        public string DeviceType
        {
            get { return m_DeviceReceiveDA.DeviceType; }
            set { m_DeviceReceiveDA.DeviceType = value; }
        }

        /// <summary>
        /// 设备编号
        /// </summary>
        public string DeviceCode
        {
            get { return m_DeviceReceiveDA.DeviceCode; }
            set { m_DeviceReceiveDA.DeviceCode = value; }
        }

        /// <summary>
        /// 接收人
        /// </summary>
        public string Receiver
        {
            get { return m_DeviceReceiveDA.Receiver; }
            set { m_DeviceReceiveDA.Receiver = value; }
        }

        /// <summary>
        /// 接收人编号
        /// </summary>
        public int ReceiverCode
        {
            get { return m_DeviceReceiveDA.ReceiverCode; }
            set { m_DeviceReceiveDA.ReceiverCode = value; }
        }

        /// <summary>
        /// 接收时间
        /// </summary>
        public string ReceiveTimeStr
        {
            get;
            set;
        }

        /// <summary>
        /// 接收时间
        /// </summary>
        public long ReceiveTime
        {
            get { return m_DeviceReceiveDA.ReceiveTime; }
            set { m_DeviceReceiveDA.ReceiveTime = value; }
        }

        /// <summary>
        /// 状态
        /// </summary>
        public string Status
        {
            get { return m_DeviceReceiveDA.Status; }
            set { m_DeviceReceiveDA.Status = value; }
        }

        /// <summary>
        /// 批次号
        /// </summary>
        public string BatchCode
        {
            get { return m_DeviceReceiveDA.BatchCode; }
            set { m_DeviceReceiveDA.BatchCode = value; }
        }
        #endregion

        #region CURD
        public void Retrieve(int id)
        {
            m_DeviceReceiveDA = DeviceReceiveDA.Get(id);
        }

        public static List<DeviceReceive> GetList(string where)
        {
            List<DeviceReceive> deviceReceiveList = new List<DeviceReceive>();
            foreach (DeviceReceiveDA deviceReceiveDA in DeviceReceiveDA.FindAll(where))
            {
                DeviceReceive DeviceReceive = new DeviceReceive(deviceReceiveDA);

                deviceReceiveList.Add(DeviceReceive);
            }

            deviceReceiveList.Sort();

            return deviceReceiveList;
        }

        public static List<DeviceReceive> GetPageList(int pageSize, int pageIndex, string where)
        {
            List<DeviceReceive> deviceReceiveList = new List<DeviceReceive>();
            foreach (DeviceReceiveDA deviceReceiveDA in DeviceReceiveDA.FindPage(pageSize, pageIndex, where))
            {
                DeviceReceive DeviceReceive = new DeviceReceive(deviceReceiveDA);

                deviceReceiveList.Add(DeviceReceive);
            }

            deviceReceiveList.Sort();

            return deviceReceiveList;
        }

        public bool Add()
        {
            try
            {
                m_DeviceReceiveDA.Insert();
                m_DeviceReceiveDA.Save();
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
                m_DeviceReceiveDA.Update();
                m_DeviceReceiveDA.Save();

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
                m_DeviceReceiveDA.Delete();
                m_DeviceReceiveDA.Save();
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
            return EngineType + "," + EngineCode + "," + XC + "," + DeviceType + "," + DeviceCode + "," + Receiver + "," + new DateTime(ReceiveTime);
        }
        #endregion
    }
}
