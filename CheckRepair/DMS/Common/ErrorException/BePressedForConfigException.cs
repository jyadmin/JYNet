/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/11/2009 5:04:24 PM
 * */
using System;
using System.Diagnostics;

namespace DMS.Common
{
    /// <summary>
    /// BePressedForConfig 的摘要说明。
    /// </summary>
    public class BePressedForConfigException : System.ApplicationException
    {
        string m_sectionName;

        public BePressedForConfigException(string sectionName, string message)
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
