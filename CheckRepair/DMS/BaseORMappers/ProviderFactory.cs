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
	public class ProviderFactory
	{
		const string DEFAULT_PROVIDER = "DefaultProvider";
		//static Dictionary<string, IProvider> cachedProviders;

		static ProviderFactory()
		{
			//cachedProviders = new Dictionary<string, IProvider>();
		}

		public static IProvider GetProvider()
		{
			return GetProvider(DEFAULT_PROVIDER);
		}

		public static IProvider GetProvider(string name)
		{
			//if (cachedProviders.ContainsKey(name))
			//{
			//    return cachedProviders[name];
			//}
			ProviderConfigItem item = ProviderConfig.GetConfigItem(name);
			IProvider provider = GetProvider(item.Assembly, item.Provider, item.ConnString);
			//cachedProviders.Add(name, provider);
			return provider;
		}

		public static IProvider GetProvider(string assembly, string provider, string connString)
		{
            if (assembly =="")
            {
                assembly = null;
            }
            object temp = Activator.CreateInstance(assembly, provider).Unwrap();
			if (temp == null)
			{
				throw new NotFindProviderException();
			}
			if (!(temp is IProvider))
			{
				throw new NotMatchProviderException();
			}
			IProvider instance = temp as IProvider;
			instance.ConnString = connString;
			return instance;
		}
	}
}
