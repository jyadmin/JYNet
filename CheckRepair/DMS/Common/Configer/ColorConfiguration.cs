/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/13/2009 9:37:43 PM
 * */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Xml.Serialization;

namespace DMS.Common
{
    public class ColorConfiguration
    {
        private static ArrayList m_colorInfoList;

        private static ColorConfiguration instance;

        public static Color GetColor(string key)
        {
            if (instance == null)
                Initialize();
            return (Color)m_colors[key];
        }

        private static void Initialize()
        {
            instance = (ColorConfiguration)XmlConfigurationManager.GetConfigObject(typeof(ColorConfiguration));
            foreach (ColorInfo colorInfo in instance.ColorInfos)
            {
                Color color = new Color();
                try
                {
                    color = Color.FromArgb(colorInfo.Color.R, colorInfo.Color.G, colorInfo.Color.B);
                    m_colors.Add(colorInfo.Key, color);
                }
                catch (System.ArgumentException)
                {
                }
            }
        }

        static Hashtable m_colors;

        static ColorConfiguration()
        {
            m_colors = new Hashtable();
        }

        [XmlElement("ColorInfo", typeof(ColorInfo))]
        public ArrayList ColorInfos
        {
            get { return m_colorInfoList; }
            set { m_colorInfoList = value; }
        }
    }
}
