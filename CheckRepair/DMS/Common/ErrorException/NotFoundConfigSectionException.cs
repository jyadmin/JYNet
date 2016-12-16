/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/13/2009 9:35:13 PM
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMS.Common
{
    public class NotFoundConfigSectionException : ConfigSectionException
    {
        public NotFoundConfigSectionException(string sectionName)
            : base(sectionName)
        {
        }

        public override string Message
        {
            get { return "没有找到配置项或缺少配置项文件 : " + SectionName; }
        }
    }
}
