/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/12/2009 10:39:00 PM
 * */
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Drawing;

using DMS.Properties;

namespace DMS.UI.Common
{
    public class DMSImageManager
    {
        public static Image GetImage(string key)
        {
            Image img = (Image)Resources.ResourceManager.GetObject(key);
            if (img == null)
                return Resources.ToolButton_ErrorImage;
            return img;
        }
    }
}
