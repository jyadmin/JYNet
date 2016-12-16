/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/13/2009 9:38:29 PM
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace DMS.Common
{
    public class ColorInfo
    {
        string m_key;
        DMSColor m_color;

        public ColorInfo()
        {
            m_color = new DMSColor();
        }

        [XmlAttribute]
        public string Key
        {
            get { return m_key; }
            set { m_key = value; }
        }

        public DMSColor Color
        {
            get { return m_color; }
            set { m_color = value; }
        }
    }
}
