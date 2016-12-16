/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/17/2009 4:46:33 PM
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DMS.UI.CustomerControl
{
    public class DMSButton:Button
    {
        public DMSButton()
        {
            this.Text = "...";
            this.Margin = new Padding(0, 0, 0, 0);
            this.Width = 30;
            this.Height = 22;
            this.Anchor = AnchorStyles.Left;
        }
    }
}
