/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/19/2009 11:32:26 AM
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DMS.UI.CustomerControl
{
    public class DMSTreeView : TreeView
    {
        public DMSTreeView()
        {
            this.Margin = new Padding(0, 0, 0, 3);
            this.Dock = DockStyle.Fill;
            this.CheckBoxes = true;
            this.AfterCheck += new TreeViewEventHandler(DMSTreeView_AfterCheck);
        }

        private void DMSTreeView_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Checked)
            {
                if (e.Node.Parent != null)
                {
                    e.Node.Parent.Checked = true;
                }
            }
            else
            {
                foreach (TreeNode childNode in e.Node.Nodes)
                {
                    childNode.Checked = false;
                }
            }
        }
    }
}
