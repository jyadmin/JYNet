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
using System.Data.SqlClient;

namespace DMS.BaseORMappers.Clients
{
	public class SqlProvider : IProvider
	{
		private string connString;
		private SqlConnection conn;

		public SqlProvider() { }

		public SqlProvider(string connString)
		{
			this.connString = connString;
			conn = new SqlConnection(connString);
		}

		public SqlConnection Connection
		{
			get
			{
				if (conn == null)
				{
					conn = new SqlConnection(connString);
				}
				return conn;
			}
		}

		public string Database
		{
			get { return "SQL Server"; }
		}

		public string ParamPrefix
		{
			get { return "@"; }
		}

		public string ConnString
		{
			get { return connString; }
			set { connString = value; }
		}

		public void Execute(Command command)
		{
			using (SqlCommand cmd = Connection.CreateCommand())
			{
				PrepareCommand(cmd, null, command);
				cmd.ExecuteNonQuery();
			}
		}

		public void Execute(List<Command> commands)
		{
			OpenConnection();
            //using (SqlTransaction trans = Connection.BeginTransaction())
            //{
				SqlCommand cmd = Connection.CreateCommand();
				try
				{
					foreach (Command command in commands)
					{
                        PrepareCommand(cmd, null, command);
                        //PrepareCommand(cmd, trans, command);
						cmd.ExecuteNonQuery();
					}
                    //trans.Commit();
				}
				catch (SqlException e)
				{
                    //trans.Rollback();
					cmd.Dispose();
					throw new Exception(e.Message);
				}
            //}
		}

		public object QueryScalar(Command command)
		{
			using (SqlCommand cmd = Connection.CreateCommand())
			{
				PrepareCommand(cmd, null, command);
				return cmd.ExecuteScalar();
			}
		}

		public IDataReader QueryData(Command command)
		{
			using (SqlCommand cmd = Connection.CreateCommand())
			{
				PrepareCommand(cmd, null, command);
				return cmd.ExecuteReader(CommandBehavior.CloseConnection);
			}
		}

		public void Dispose()
		{
			if (Connection != null)
			{
				if (Connection.State != ConnectionState.Closed)
				{
					Connection.Close();
				}
				Connection.Dispose();
			}
		}

		private void OpenConnection()
		{
			if (Connection.State != ConnectionState.Open)
			{
				Connection.Open();
			}
		}

		private void PrepareCommand(SqlCommand cmd, SqlTransaction trans, Command command)
		{
			if (trans != null)
			{
				cmd.Transaction = trans;
			}
			cmd.CommandText = command.Text;
			if (command.HasParameter)
			{
				cmd.Parameters.Clear();
				foreach (Parameter param in command.Parameters)
				{
					cmd.Parameters.Add(new SqlParameter(param.Name, param.Value));
				}
			}
			OpenConnection();
		}
	}
}
