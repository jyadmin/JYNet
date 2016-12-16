/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/13/2009 9:39:09 PM
 * */
using System;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace DMS.Common
{
   public class DMSColor
    {
        int m_r;
		int m_g;
		int m_b;

		public DMSColor()
		{
		}

		[XmlAttribute]
		public int R
		{
			get { return m_r; }
			set { m_r = value; }
		}

		[XmlAttribute]
		public int G
		{
			get { return m_g; }
			set { m_g = value; }
		}

		[XmlAttribute]
		public int B
		{
			get { return m_b; }
			set { m_b = value; }
		}
    }
}
