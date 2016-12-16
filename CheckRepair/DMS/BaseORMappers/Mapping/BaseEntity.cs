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
	[Serializable]
	public abstract class BaseEntity<TEntity> : IComparable<TEntity>
		where TEntity : BaseEntity<TEntity>, new()
	{
        private static List<TEntity> allEntities;
		private static object asyncLick = new object();
		private Transaction trans;

		protected BaseEntity() 
        { 
        }
        
		public void Insert()
		{
			LoadTransaction();
			TEntity entity = GetEntity();
			trans.Insert<TEntity>(entity);
		}

        public int GetInsertID()
        {
            object identify;
            KQuery query = new KQuery();
            identify = query.Scalar<TEntity>("max(ID)", string.Empty);

            return Convert.ToInt32(identify);
        }

		public void Update()
		{
			LoadTransaction();
			TEntity entity = GetEntity();
			trans.Update<TEntity>(entity);
		}

		public void Delete()
		{
			LoadTransaction();
			TEntity entity = GetEntity();
			trans.Delete<TEntity>(entity);
		}

		public void Save()
		{
            try
            {
                if (trans != null)
                {
                    trans.SubmitChanges();
                    trans.Dispose();
                }
            }
            catch (Exception e)
            {
                trans.Commands.Clear();
                throw e;
            }
		}

        public static TEntity Get(params object[] id)
        {
            KQuery query = new KQuery();
            TEntity entity = query.Get<TEntity>(id);
            return entity;
        }

        public static TEntity Get(string where)
        {
            KQuery query = new KQuery();
            TEntity entity = query.Get<TEntity>(where);
            return entity;
        }

        public static List<TEntity> FindAll()
        {
            return FindAll(string.Empty);
        }

        public static List<TEntity> FindAll(string where)
        {
            KQuery query = new KQuery();
            return query.FindAll<TEntity>(where);
        }

		public virtual string ToJson()
		{
			TEntity entity = GetEntity();
			StringBuilder sb = new StringBuilder();
			sb.Append("{");
			foreach (var property in typeof(TEntity).GetProperties())
			{
				string name = property.Name;
				object value = property.GetValue(entity, null);
				sb.Append("'" + name + "':'" + value + "',");
			}
			return sb.ToString().TrimEnd(',') + "}";
		}

		public int CompareTo(TEntity other)
		{
			return GetHashCode().CompareTo(other.GetHashCode());
		}

		public override string ToString()
		{
			return GetKeyValueString(GetEntity());
		}

		public override int GetHashCode()
		{
			return GetKeyValueString(GetEntity()).GetHashCode();
		}

		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			if (obj.GetType() == typeof(TEntity))
			{
				return obj.GetHashCode() == GetEntity().GetHashCode();
			}
			return false;
		}

		private void LoadTransaction()
		{
			if (trans == null)
			{
				trans = new Transaction();
			}
		}

		private TEntity GetEntity()
		{
			TEntity entity = new TEntity();
			entity = this as TEntity;
			return entity;
		}

		private static TEntity GetFromList(params object[] id)
		{
			if (allEntities != null)
			{
				foreach (TEntity item in allEntities)
				{
					if (GetKeyValueString(id) == GetKeyValueString(item))
					{
						return item;
					}
				}
			}
			return null;
		}

		private static string GetKeyValueString(TEntity entity)
		{
			MetaType type = MetaManager.GetMetaType(typeof(TEntity));
			object[] keys = type.MetaParameters.Where(p => p.IsPrimaryKey).Select(
				p => type.EntityType.GetProperty(p.PropertyName).GetValue(entity, null)
			).ToArray();
			return GetKeyValueString(keys);
		}

		private static string GetKeyValueString(params object[] id)
		{
			StringBuilder sb = new StringBuilder();
			foreach (object key in id)
			{
				if (key != null)
				{
					sb.Append(key.ToString());
				}
			}
			return sb.ToString();
		}
	}
}
