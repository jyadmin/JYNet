/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/17/2009 4:46:45 PM
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DMS.UI.CustomerControl
{
    public class DMSTextBox:TextBox
    {
        public DMSTextBox()
        {
            this.Margin = new Padding(0, 0, 0, 0);
            this.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        }
    }
}
