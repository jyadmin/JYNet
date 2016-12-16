/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/13/2009 9:35:35 PM
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMS.Common
{
    public class ConfigSectionException : System.ApplicationException
    {
        string sectionName;

        public ConfigSectionException(string sectionName)
        {
            this.sectionName = sectionName;
        }

        public override string Message
        {
            get { return "配置项 ; " + sectionName + " 发生错误"; }
        }

        public string SectionName
        {
            get { return sectionName; }
            set { sectionName = value; }
        }
    }
}
