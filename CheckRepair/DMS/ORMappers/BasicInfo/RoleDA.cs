/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/12/2009 10:26:53 AM
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DMS.BaseORMappers.Mapping;

namespace DMS.ORMappers.BasicInfo
{
    /// <summary>
    /// 角色
    /// </summary>
    [Table("C_DMS_Role")]
    public class RoleDA : BaseEntity<RoleDA>
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
        /// 角色名称
        /// </summary>
        [Column(IsChangeable = true)]
        public string RoleName
        {
            get;
            set;
        }

        /// <summary>
        /// 是否黙认角色
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

        [Column(IsNullable = true)]
        public int Edition { get; set; }
    }
}
