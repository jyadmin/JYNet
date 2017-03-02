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
    [Table("C_DMS_CheckResultContent")]
    public class CheckResultContentDA : BaseEntity<CheckResultContentDA>
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
        /// 标识
        /// </summary>
        [Column(IsChangeable = true)]
        public string CheckKeys
        {
            get;
            set;
        }

        /// <summary>
        /// 检查值
        /// </summary>
        [Column(IsChangeable = true)]
        public string CheckValue
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
        /// 批次号
        /// </summary>
        [Column(IsChangeable = true)]
        public int DeviceReceiveID
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
        /// 步骤编号
        /// </summary>
        [Column(IsChangeable = true)]
        public int StepCode
        {
            get;
            set;
        }

        /// <summary>
        /// 小步骤编号
        /// </summary>
        [Column(IsChangeable = true)]
        public int SubStepCode
        {
            get;
            set;
        }

        /// <summary>
        /// 关联UserTaskDetailID
        /// </summary>
        [Column(IsChangeable = true)]
        public int UserTaskDetailID
        {
            get;
            set;
        }
    }
}
