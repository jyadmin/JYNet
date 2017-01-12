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
    [Table("C_DMS_FlowTemplateMain")]
    public class FlowTemplateMainDA : BaseEntity<FlowTemplateMainDA>
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
        /// 排序
        /// </summary>
        [Column(IsChangeable = true)]
        public int DisplayOrder
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
        /// 设备部件
        /// </summary>
        [Column(IsChangeable = true)]
        public string Component
        {
            get;
            set;
        }

        /// <summary>
        /// 工位名称
        /// </summary>
        [Column(IsChangeable = true)]
        public string ProcedureName
        {
            get;
            set;
        }

        /// <summary>
        /// 作业时间
        /// </summary>
        [Column(IsChangeable = true)]
        public int OperateTime
        {
            get;
            set;
        }

        /// <summary>
        /// 生产
        /// </summary>
        [Column(IsChangeable = true)]
        public Int16 IsProduction
        {
            get;
            set;
        }

        /// <summary>
        /// 数据
        /// </summary>
        [Column(IsChangeable = true)]
        public Int16 IsData
        {
            get;
            set;
        }

        /// <summary>
        /// 质量
        /// </summary>
        [Column(IsChangeable = true)]
        public Int16 Quality
        {
            get;
            set;
        }

        /// <summary>
        /// 配件材料
        /// </summary>
        [Column(IsChangeable = true)]
        public Int16 IsMaterial
        {
            get;
            set;
        }

        /// <summary>
        /// 资质
        /// </summary>
        [Column(IsChangeable = true)]
        public Int16 IsQualification
        {
            get;
            set;
        }

        /// <summary>
        /// 设备
        /// </summary>
        [Column(IsChangeable = true)]
        public Int16 IsEquipment
        {
            get;
            set;
        }

        /// <summary>
        /// 记名
        /// </summary>
        [Column(IsChangeable = true)]
        public Int16 IsSignName
        {
            get;
            set;
        }


        /// <summary>
        /// 履历
        /// </summary>
        [Column(IsChangeable = true)]
        public Int16 IsResume
        {
            get;
            set;
        }

        /// <summary>
        /// 指导
        /// </summary>
        [Column(IsChangeable = true)]
        public Int16 Guidance
        {
            get;
            set;
        }

        /// <summary>
        /// 判断
        /// </summary>
        [Column(IsChangeable = true)]
        public Int16 IsJudgement
        {
            get;
            set;
        }

        /// <summary>
        /// 评价
        /// </summary>
        [Column(IsChangeable = true)]
        public Int16 IsEvaluate
        {
            get;
            set;
        }

        /// <summary>
        /// 上次检查人
        /// </summary>
        [Column(IsChangeable = true)]
        public string LastChecker
        {
            get;
            set;
        }

        /// <summary>
        /// 上次检查人编号
        /// </summary>
        [Column(IsChangeable = true)]
        public string LastCheckerCode
        {
            get;
            set;
        }
    }
}
