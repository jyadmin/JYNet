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
    [Table("C_DMS_AssignedTask")]
    public class AssignedTaskDA : BaseEntity<AssignedTaskDA>
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
        /// 设备接收关联ID
        /// </summary>
        [Column(IsChangeable = true)]
        public int LinkIdToDeviceReceive
        {
            get;
            set;
        }

        /// <summary>
        /// 信息模板关联ID
        /// </summary>
        [Column(IsChangeable = true)]
        public int TemplateID
        {
            get;
            set;
        }

        /// <summary>
        /// 任务分配人员ID拼接字符串
        /// </summary>
        [Column(IsChangeable = true)]
        public string CheckerIDs
        {
            get;
            set;
        }

        /// <summary>
        /// 派工单状态
        /// </summary>
        [Column(IsChangeable = true)]
        public string Status
        {
            get;
            set;
        }

        /// <summary>
        /// 批次号，对应设备接收的批次号
        /// </summary>
        [Column(IsChangeable = true)]
        public string BatchCode
        {
            get;
            set;
        }

        /// <summary>
        /// 计划开始时间
        /// </summary>
        [Column(IsChangeable = true)]
        public long ArrangedStartTime
        {
            get;
            set;
        }

        /// <summary>
        /// 计划结束时间
        /// </summary>
        [Column(IsChangeable = true)]
        public long ArrangedEndTime
        {
            get;
            set;
        }

        /// <summary>
        /// 实际开始时间
        /// </summary>
        [Column(IsChangeable = true)]
        public long ActualStartTime
        {
            get;
            set;
        }

        /// <summary>
        /// 实际结束时间
        /// </summary>
        [Column(IsChangeable = true)]
        public long ActualEndTime
        {
            get;
            set;
        }
    }
}
