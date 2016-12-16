/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/16/2009 11:31:28 PM
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DMS.BaseORMappers.Mapping;

namespace DMS.ORMappers.BasicInfo
{
    /// <summary>
    /// 版本功能
    /// </summary>
    [Table("C_DMS_EditionModule")]
    public class EditionModuleDA : BaseEntity<EditionModuleDA>
    {
        /// <summary>
        /// 版本
        /// </summary>
        [Column(IsChangeable = true, IsPrimaryKey = true)]
        public int Edition
        {
            get;
            set;
        }

        /// <summary>
        /// 模块
        /// </summary>
        [Column(IsChangeable = true, IsPrimaryKey = true)]
        public int Module
        {
            get;
            set;
        }        
    }
}
