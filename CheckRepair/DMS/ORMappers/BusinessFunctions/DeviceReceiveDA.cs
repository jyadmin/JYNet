using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DMS.BaseORMappers.Mapping;

namespace DMS.ORMappers.BusinessFunctions
{
    /// <summary>
    /// 设备接收表
    /// </summary>
    [Table("C_DMS_DeviceReceive")]
    public class DeviceReceiveDA : BaseEntity<DeviceReceiveDA>
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Column(IsDbGenerated = true, IsPrimaryKey = true)]
        public int ID
        {
            get;
            set;
        }

        /// <summary>
        /// 车型
        /// </summary>
        [Column(IsChangeable = true)]
        public string EngineType
        {
            get;
            set;
        }

        /// <summary>
        /// 车号
        /// </summary>
        [Column(IsChangeable = true)]
        public string EngineCode
        {
            get;
            set;
        }

        /// <summary>
        /// 修程
        /// </summary>
        [Column(IsChangeable = true)]
        public string XC
        {
            get;
            set;
        }

        /// <summary>
        /// 设备类型
        /// </summary>
        [Column(IsChangeable = true)]
        public string DeviceType
        {
            get;
            set;
        }

        /// <summary>
        /// 设备编号
        /// </summary>
        [Column(IsChangeable = true)]
        public string DeviceCode
        {
            get;
            set;
        }

        /// <summary>
        /// 接收人
        /// </summary>
        [Column(IsChangeable = true)]
        public string Receiver
        {
            get;
            set;
        }

        /// <summary>
        /// 接收人编号
        /// </summary>
        [Column(IsChangeable = true)]
        public int ReceiverCode
        {
            get;
            set;
        }

        /// <summary>
        /// 接收时间
        /// </summary>
        [Column(IsChangeable = true)]
        public long ReceiveTime
        {
            get;
            set;
        }

        /// <summary>
        /// 状态
        /// </summary>
        [Column(IsChangeable = true)]
        public string Status
        {
            get;
            set;
        }

        /// <summary>
        /// 批次号
        /// </summary>
        [Column(IsChangeable = true)]
        public string BatchCode
        {
            get;
            set;
        }
    }
}
