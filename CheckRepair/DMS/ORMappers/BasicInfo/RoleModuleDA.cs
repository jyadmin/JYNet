/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/12/2009 5:42:21 PM
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DMS.BaseORMappers.Mapping;

namespace DMS.ORMappers.BasicInfo
{
    /// <summary>
    /// 角色模块
    /// </summary>
    [Table("C_DMS_RoleModule")]
    public class RoleModuleDA : BaseEntity<RoleModuleDA>
    {
        /// <summary>
        /// 角色
        /// </summary>
        [Column(IsChangeable = true, IsPrimaryKey = true)]
        public int Role
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
