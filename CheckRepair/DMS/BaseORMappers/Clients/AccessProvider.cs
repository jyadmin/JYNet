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
using System.Data.OleDb;

namespace DMS.BaseORMappers.Clients
{
	public class AccessProvider : IProvider
	{
		private string connString;
		private OleDbConnection conn;

		public AccessProvider() { }

		public AccessProvider(string connString)
		{
			this.connString = connString;
			conn = new OleDbConnection(connString);
		}

		public OleDbConnection Connection
		{
			get
			{
				if (conn == null)
				{
					conn = new OleDbConnection(connString);
				}
				return conn;
			}
		}

		public string Database
		{
			get { return "Access"; }
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
			using (OleDbCommand cmd = Connection.CreateCommand())
			{
				PrepareCommand(cmd, null, command);
				cmd.ExecuteNonQuery();
			}
		}

		public void Execute(List<Command> commands)
		{
			OpenConnection();
			using (OleDbTransaction trans = Connection.BeginTransaction())
			{
				OleDbCommand cmd = Connection.CreateCommand();
				try
				{
					foreach (Command command in commands)
					{
						PrepareCommand(cmd, trans, command);
						cmd.ExecuteNonQuery();
					}
					trans.Commit();
				}
				catch (OleDbException e)
				{
					trans.Rollback();
					cmd.Dispose();
					throw new Exception(e.Message);
				}
			}
		}

		public object QueryScalar(Command command)
		{
			using (OleDbCommand cmd = Connection.CreateCommand())
			{
				PrepareCommand(cmd, null, command);
				return cmd.ExecuteScalar();
			}
		}

		public IDataReader QueryData(Command command)
		{
			using (OleDbCommand cmd = Connection.CreateCommand())
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

		private void PrepareCommand(OleDbCommand cmd, OleDbTransaction trans, Command command)
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
					cmd.Parameters.Add(new OleDbParameter(param.Name, param.Value));
				}
			}
			OpenConnection();
		}
	}
}
