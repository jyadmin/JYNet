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
using System.Data;
using DMS.BaseORMappers.Mapping;

namespace DMS.BaseORMappers
{
	public class KQuery
	{
		private string sql = String.Empty;
		private Type entityType;

		public IProvider Provider { get; set; }
		public Command Command { get; set; }

		public KQuery()
			: this(ProviderFactory.GetProvider())
		{
		}

		public KQuery(IProvider provider)
		{
			if (provider == null)
			{
				throw new ArgumentNullException("provider");
			}
			Provider = provider;
		}

		public KQuery Select<T>(string where)
		{
			entityType = typeof(T);
			MetaType metaType = MetaManager.GetMetaType(entityType);
			sql = String.Format("select * from {0} {1}", metaType.TableName, where);
			return this;
		}

		public KQuery Union<T>(string where)
		{
			MetaType metaType = MetaManager.GetMetaType(typeof(T));
			sql += String.Format(" union select * from {0} {1}", metaType.TableName, where);
			return this;
		}

		public List<T> FindAll<T>(string where)
		{
			MetaType metaType = MetaManager.GetMetaType(typeof(T));
			Command = new Command(
				String.Format("select * from {0} {1}", metaType.TableName, where)
			);
			return List<T>();
		}

		public List<T> FindAll<T>()
		{
			MetaType metaType = MetaManager.GetMetaType(typeof(T));
			Command = new Command(String.Format("select * from {0}", metaType.TableName));
			return List<T>();
		}

		public T Get<T>(string where)
		{
			MetaType metaType = MetaManager.GetMetaType(typeof(T));
			Command = new Command(
				String.Format("select * from {0} {1}", metaType.TableName, where)
			);
			return Get<T>();
		}

		public T Get<T>(params object[] id)
		{
			Command = GetCommand<T>(id);
			return Get<T>();
		}

		public object Scalar<T>(string propertyName, string where)
		{
			MetaType metaType = MetaManager.GetMetaType(typeof(T));
			Command = new Command(
				String.Format("select {0} from {1} {2}", propertyName, metaType.TableName, where)
			);
			return Provider.QueryScalar(Command);
		}

		public int Count<T>(string where)
		{
			MetaType metaType = MetaManager.GetMetaType(typeof(T));
			Command = new Command(
				String.Format("select count(*) from {0} {1}", metaType.TableName, where)
			);
			object result = Provider.QueryScalar(Command);
			int count = 0;
			int.TryParse(result.ToString(), out count);
			return count;
		}

		public T Get<T>()
		{
			if (Command == null)
			{
				return default(T);
			}
			T entity = default(T);
			using (IDataReader reader = Provider.QueryData(Command))
			{
				if (reader.Read())
				{
					entity = Activator.CreateInstance<T>();
					SetEntity<T>(entity, reader);
				}
			}
			return entity;
		}

		public List<T> List<T>()
		{
			if (!String.IsNullOrEmpty(sql))
			{
				Command = new Command(sql);
			}
			if (Command == null)
			{
				return null;
			}
			List<T> entities = new List<T>();
			using (IDataReader reader = Provider.QueryData(Command))
			{
				while (reader.Read())
				{
					T entity = Activator.CreateInstance<T>();
					SetEntity<T>(entity, reader);
					entities.Add(entity);
				}
			}
			return entities;
		}

		public override string ToString()
		{
			if (Command == null)
			{
				return String.Empty;
			}
			return Command.ToString();
		}

		private Command GetCommand<T>(params object[] id)
		{
			MetaTable table = MetaManager.GetMetaTable(typeof(T));
			return new Command(
				String.Format(
					"SELECT * FROM {0} WHERE {1}",
					table.RowType.TableName,
					table.GetKeyFieldString(Provider.ParamPrefix)
				),
				table.GetKeyParameters(Provider.ParamPrefix, id)
			);
		}

		private void SetEntity<T>(T entity, IDataReader reader)
		{
			Type type = typeof(T);
			foreach (MetaParameter param in MetaManager.GetMetaParameters(type))
			{
				object value = reader[param.MappedName];
				if (value == DBNull.Value)
				{
					value = String.Empty;
				}
				type.GetProperty(param.PropertyName).SetValue(entity, value, null);
			}
		}
	}
}
