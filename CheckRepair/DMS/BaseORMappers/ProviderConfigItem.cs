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
	public class ProviderConfigItem
	{
		public string Name { get; set; }
		public string Assembly { get; set; }
		public string Provider { get; set; }
		public string ConnString { get; set; }

		public ProviderConfigItem() { }

		public ProviderConfigItem(string name, string assembly, string provider, string connString)
		{
			Name = name;
			Assembly = assembly;
			Provider = provider;
			ConnString = connString;
		}
	}
}
