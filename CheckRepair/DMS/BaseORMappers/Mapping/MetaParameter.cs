/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/11/2009 5:00:31 PM
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMS.BaseORMappers.Mapping
{
	public class MetaParameter
	{
		public string PropertyName { get; set; }
		public string MappedName { get; set; }
		public object DefaultValue { get; set; }
		public bool IsPrimaryKey { get; set; }
		public bool IsNullable { get; set; }
		public bool IsDbGenerated { get; set; }
		public bool IsChangeable { get; set; }

		internal MetaParameter()
		{
			IsPrimaryKey = false;
			IsNullable = false;
			IsDbGenerated = false;
		}
	}
}
