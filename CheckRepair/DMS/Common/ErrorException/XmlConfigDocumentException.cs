/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/11/2009 5:04:56 PM
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMS.Common
{
    /// <summary>
    /// XmlConfigDocumentException 的摘要说明。
    /// </summary>
    public class XmlConfigDocumentException : System.ApplicationException
    {
        string m_sectionName;
        public XmlConfigDocumentException(string sectionName, string message)
            : base(message)
        {
            m_sectionName = sectionName;
        }

        public string SectionName
        {
            get { return m_sectionName; }
            set { m_sectionName = value; }
        }
    }
}
