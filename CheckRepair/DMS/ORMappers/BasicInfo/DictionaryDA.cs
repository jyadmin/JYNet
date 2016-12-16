/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/21/2009 9:13:36 AM
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DMS.BaseORMappers.Mapping;

namespace DMS.ORMappers.BasicInfo
{
    /// <summary>
    /// 数据字典
    /// </summary>
    [Table("C_DMS_Dictionary")]
    public class DictionaryDA : BaseEntity<DictionaryDA>
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
        /// 数据项
        /// </summary>
        [Column(IsChangeable = true)]
        public string StringValue
        {
            get;
            set;
        }

        /// <summary>
        /// 顺序
        /// </summary>
        [Column(IsChangeable = true)]
        public int DisplayOrder
        {
            get;
            set;
        }

        /// <summary>
        /// 父键
        /// </summary>
        [Column(IsChangeable = true)]
        public int ParentID
        {
            get;
            set;
        }

        /// <summary>
        /// 数据项类型
        /// </summary>
        [Column(IsChangeable = true)]
        public string Type
        {
            get;
            set;
        }
    }
}
