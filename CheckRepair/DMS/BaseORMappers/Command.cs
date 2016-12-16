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
	public class Command
	{
		public string Text { get; set; }
		public List<Parameter> Parameters { get; set; }

		public bool HasParameter
		{
			get
			{
				if (Parameters == null)
				{
					return false;
				}
				return Parameters.Count > 0;
			}
		}

		public Command() { }

		public Command(string text)
			: this(text, null)
		{
		}

		public Command(string text, List<Parameter> parameters)
		{
			Text = text;
			Parameters = parameters;
		}

		public void AddParameter(Parameter parameter)
		{
			if (Parameters == null)
			{
				Parameters = new List<Parameter>();
			}
			Parameters.Add(parameter);
		}

		public void AddParameter(string name, object value)
		{
			AddParameter(new Parameter(name, value));
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("Text=" + Text);
			if (HasParameter)
			{
				sb.AppendLine("Parameters:");
				foreach (Parameter param in Parameters)
				{
					sb.AppendLine(param.ToString());
				}
			}
			return sb.ToString();
		}
	}
}
