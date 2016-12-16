/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/12/2009 11:25:59 PM
 * */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace DMS.UI.Common
{
    public class ToolStripButtonBuilder
    {
        public static ToolStripButton BuildToolStripButton(ToolBarCommand cmd)
        {
            ToolStripButton btn = new ToolStripButton();
            btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            btn.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;

            btn.Text = cmd.CommandName;
            btn.Visible = cmd.IsVisible;
            btn.Enabled = cmd.IsEnable;
            btn.Tag = cmd;

            btn.Image = DMSImageManager.GetImage("ToolButton_" + cmd.Type.ToString());

            return btn;
        }
    }
}
