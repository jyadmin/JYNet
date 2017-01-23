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
    [Table("C_DMS_FlowTemplateDetail")]
    public class FlowTemplateDetailDA : BaseEntity<FlowTemplateDetailDA>
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
        /// 关联ID
        /// </summary>
        [Column(IsChangeable = true)]
        public int LinkId
        {
            get;
            set;
        }

        /// <summary>
        /// 操作顺序
        /// </summary>
        [Column(IsChangeable = true)]
        public int OperateOrder
        {
            get;
            set;
        }

        /// <summary>
        /// 作业项点
        /// </summary>
        [Column(IsChangeable = true)]
        public string OperateItem
        {
            get;
            set;
        }

        /// <summary>
        /// 作业内容与技术标准
        /// </summary>
        [Column(IsChangeable = true)]
        public string OperateContentAndStandard
        {
            get;
            set;
        }
    }
}
