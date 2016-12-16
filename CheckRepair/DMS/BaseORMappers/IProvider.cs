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

namespace DMS.BaseORMappers
{
	public interface IProvider : IDisposable
	{
		string Database { get; }
		string ParamPrefix { get; }
		string ConnString { get; set; }

		void Execute(Command command);
		void Execute(List<Command> commands);
		object QueryScalar(Command command);
		IDataReader QueryData(Command command);
	}
}
