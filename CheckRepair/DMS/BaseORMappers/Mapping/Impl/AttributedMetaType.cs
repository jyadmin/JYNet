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
	internal class AttributedMetaType : MetaType
	{
		private TableAttribute table;

		internal AttributedMetaType(Type type)
			: base(type)
		{
			table = Attribute.GetCustomAttribute(type, typeof(TableAttribute)) as TableAttribute;
		}

		public override string TableName
		{
			get { return table == null ? EntityType.Name : table.Name; }
		}

		//public override string HistoryName
		//{
		//    get { return table == null ? String.Empty : table.History; }
		//}

		public override MetaType BaseMetaType
		{
			get { return new AttributedMetaType(EntityType.BaseType); }
		}

		protected override List<MetaParameter> GetMetaParameters()
		{
			List<MetaParameter> parameters = new List<MetaParameter>();
			foreach (var pi in EntityType.GetProperties())
			{
				if (pi.CanWrite && !pi.PropertyType.IsArray
					&& !pi.PropertyType.IsGenericType
					&& !pi.PropertyType.IsInterface)
				{
					ColumnAttribute column = Attribute.GetCustomAttribute(
						pi, typeof(ColumnAttribute)) as ColumnAttribute;
					MetaParameter param = new MetaParameter();
					param.PropertyName = pi.Name;
					param.MappedName = pi.Name;
					if (column != null)
					{
						param.MappedName = String.IsNullOrEmpty(column.Name) ? pi.Name : column.Name;
						param.DefaultValue = column.DefaultValue;
						param.IsPrimaryKey = column.IsPrimaryKey;
						param.IsNullable = column.IsNullable;
						param.IsDbGenerated = column.IsDbGenerated;
						param.IsChangeable = column.IsChangeable;
					}
					parameters.Add(param);
				}
			}
			return parameters;
		}
	}
}
