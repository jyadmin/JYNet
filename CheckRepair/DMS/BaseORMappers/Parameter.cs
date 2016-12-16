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

namespace DMS.BaseORMappers
{
	public class Parameter
	{
		public string Name { get; set; }
		public object Value { get; set; }

		public Parameter() { }

		public Parameter(string name, object value)
		{
			Name = name;
			Value = value;
		}

		public override string ToString()
		{
			return String.Format("  {0}={1}", Name, Value);
		}
	}
}
