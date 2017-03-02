using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DMS.BaseORMappers.Mapping;

namespace DMS.ORMappers.BusinessFunctions
{
    /// <summary>
    /// 任务分配人员与具体步骤关联表
    /// </summary>
    [Table("C_DMS_UserTaskDetail")]
    public class UserTaskDetailDA : BaseEntity<UserTaskDetailDA>
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
        /// 任务分配人员ID拼接字符串
        /// </summary>
        [Column(IsChangeable = true)]
        public string UserIds
        {
            get;
            set;
        }

        /// <summary>
        /// 主模板ID
        /// </summary>
        [Column(IsChangeable = true)]
        public int TemplateMainId
        {
            get;
            set;
        }

        /// <summary>
        /// 详细步骤模板ID
        /// </summary>
        [Column(IsChangeable = true)]
        public int TemplateDetailId
        {
            get;
            set;
        }

        /// <summary>
        /// 具体步骤状态，2表示已执行，0表示未执行
        /// </summary>
        [Column(IsChangeable = true)]
        public string Status
        {
            get;
            set;
        }

        /// <summary>
        /// 派工时间
        /// </summary>
        [Column(IsChangeable = true)]
        public long AssignTime
        {
            get;
            set;
        }

        /// <summary>
        /// 完成时间
        /// </summary>
        [Column(IsChangeable = true)]
        public long FinishTime
        {
            get;
            set;
        }

        /// <summary>
        /// 设备接收ID
        /// </summary>
        [Column(IsChangeable = true)]
        public int DeviceReceiveID
        {
            get;
            set;
        }

        /// <summary>
        /// 任务分配ID
        /// </summary>
        public int AssignedTaskID
        {
            get;
            set;
        }

        /// <summary>
        /// 具体步骤方框的背景色状态，1标识有颜色，红色或绿色，0标识默认的灰色
        /// </summary>
        [Column(IsChangeable = true)]
        public int statusColor
        {
            get;
            set;
        }
    }
}
