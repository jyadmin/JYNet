/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/11/2009 6:23:14 PM
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DMS.BaseORMappers.Mapping;

namespace DMS.ORMappers.BasicInfo
{
    /// <summary>
    /// 用户信息
    /// </summary>
    [Table("C_DMS_User")]
    public class UserInfoDA : BaseEntity<UserInfoDA>
    {
        [Column(IsDbGenerated = true, IsPrimaryKey = true)]
        public int ID { get; set; }

        [Column(IsChangeable = true)]
        public string UserName { get; set; }

        [Column(IsChangeable = true)]
        public string LoginName { get; set; }

        [Column(IsChangeable = true)]
        public string Password { get; set; }

        [Column(IsNullable = true)]
        public string Duty { get; set; }

        [Column(IsNullable = true)]
        public string Description { get; set; }

        [Column(IsNullable = true)]
        public int Role { get; set; }

        [Column(IsNullable = true)]
        public int Edition { get; set; }

        [Column(IsNullable = true)]
        public Int16 LoginAllowed { get; set; }
        
        /// <summary>
        /// 是否黙认用户
        /// </summary>
        [Column(IsNullable = true)]
        public Int16 IsDefault
        {
            get;
            set;
        }

        [Column(IsNullable = true)]
        public string EmployeeNumber { get; set; }

        [Column(IsNullable = true)]
        public int WorkingAge { get; set; }

        [Column(IsNullable = true)]
        public string Qualification { get; set; }

        [Column(IsNullable = true)]
        public string Grade { get; set; }

        [Column(IsNullable = true)]
        public byte[] Photo { get; set; }
    }
}
