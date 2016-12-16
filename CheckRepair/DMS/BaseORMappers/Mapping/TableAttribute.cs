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
	[AttributeUsage(AttributeTargets.Class)]
	public class TableAttribute : Attribute
	{
		public string Name { get; set; }
		//public string History { get; set; }

		public TableAttribute() { }

		public TableAttribute(string name)
		{
			Name = name;
		}

		//public TableAttribute(string name, string history)
		//{
		//    Name = name;
		//    History = history;
		//}
	}
}
