/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/17/2009 5:33:09 PM
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DMS.UI.CustomerControl
{
    public class DMSMutilineTextbox:TextBox
    {
        public DMSMutilineTextbox()
        {
            this.Margin = new Padding(0, 0, 0, 0);
            this.Dock = DockStyle.Fill;
            this.Multiline = true;
            this.ScrollBars = ScrollBars.Vertical;
        }

    }
}
