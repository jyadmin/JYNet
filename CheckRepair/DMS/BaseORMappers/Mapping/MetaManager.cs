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
	public class MetaManager
	{
		private static Dictionary<Type, MetaType> cachedTypes;
		private static Dictionary<Type, MetaTable> cachedTables;
		private static Dictionary<Type, List<MetaParameter>> cachedParams;

		static MetaManager()
		{
			cachedTypes = new Dictionary<Type, MetaType>();
			cachedTables = new Dictionary<Type, MetaTable>();
			cachedParams = new Dictionary<Type, List<MetaParameter>>();
		}

		public static MetaType GetMetaType(Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			if (cachedTypes.ContainsKey(type))
			{
				return cachedTypes[type];
			}
			MetaType metaType = new AttributedMetaType(type);
			cachedTypes.Add(type, metaType);
			return metaType;
		}

		public static MetaTable GetMetaTable(Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			if (cachedTables.ContainsKey(type))
			{
				return cachedTables[type];
			}
			MetaTable table = new MetaTable(GetMetaType(type));
			cachedTables.Add(type, table);
			return table;
		}

		public static List<MetaParameter> GetMetaParameters(Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			if (cachedParams.ContainsKey(type))
			{
				return cachedParams[type];
			}
			List<MetaParameter> parameters = GetMetaType(type).MetaParameters;
			cachedParams.Add(type, parameters);
			return parameters;
		}

		//public static Type GetType(string typeName)
		//{
		//    Type type = Type.GetType(typeName);
		//    if (type != null)
		//    {
		//        return type;
		//    }
		//    foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
		//    {
		//        type = assembly.GetType(typeName);
		//        if (type != null)
		//        {
		//            return type;
		//        }
		//    }
		//    return null;
		//}
	}
}
