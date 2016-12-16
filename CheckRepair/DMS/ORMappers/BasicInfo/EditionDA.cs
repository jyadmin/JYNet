/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/16/2009 10:13:25 PM
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DMS.BaseORMappers.Mapping;

namespace DMS.ORMappers.BasicInfo
{
    /// <summary>
    /// 版本
    /// </summary>
    [Table("C_DMS_Edition")]
    public class EditionDA : BaseEntity<EditionDA>
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
        /// 版本名称
        /// </summary>
        [Column(IsChangeable = true)]
        public string EditionName
        {
            get;
            set;
        }

        /// <summary>
        /// 是否黙认版本
        /// </summary>
        [Column(IsNullable = true)]
        public Int16 IsDefault
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
    }
}
