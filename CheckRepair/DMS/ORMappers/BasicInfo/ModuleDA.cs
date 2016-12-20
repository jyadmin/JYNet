/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/12/2009 10:30:06 AM
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DMS.BaseORMappers.Mapping;

namespace DMS.ORMappers.BasicInfo
{
    /// <summary>
    /// 模板
    /// </summary>
    [Table("C_DMS_Module")]
    public class ModuleDA : BaseEntity<ModuleDA>
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
        /// 名称
        /// </summary>
        [Column(IsChangeable = true)]
        public string ModuleName
        {
            get;
            set;
        }

        /// <summary>
        /// 类型名称
        /// </summary>
        [Column(IsChangeable = true)]
        public string TypeFullName
        {
            get;
            set;
        }

        /// <summary>
        /// 父键
        /// </summary>
        [Column(IsChangeable = true)]
        public int PriorModule
        {
            get;
            set;
        }

        /// <summary>
        /// 是否显示
        /// </summary>
        [Column(IsChangeable = true)]
        public Int16 IsDisplay
        {
            get;
            set;
        }

        /// <summary>
        /// 显示顺序
        /// </summary>
        [Column(IsChangeable = true)]
        public int DisplayOrder
        {
            get;
            set;
        }

        /// <summary>
        /// 描述
        /// </summary>
        [Column(IsChangeable = true)]
        public string Description
        {
            get;
            set;
        }

        /// <summary>
        /// 等级
        /// </summary>
        [Column(IsChangeable = true)]
        public int Level
        {
            get;
            set;
        }

        
        /// <summary>
        /// 占用空间大小
        /// </summary>
        [Column(IsChangeable = true)]
        public int Size
        {
            get;
            set;
        }
    }
}
