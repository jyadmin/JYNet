/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/13/2009 9:36:45 PM
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMS.Common
{
    public class ConfigSectionErrorException : ConfigSectionException
    {
        public ConfigSectionErrorException(string sectionName)
            : base(sectionName)
        {
        }

        public override string Message
        {
            get { return "配置项错误: " + SectionName; }
        }
    }
}
