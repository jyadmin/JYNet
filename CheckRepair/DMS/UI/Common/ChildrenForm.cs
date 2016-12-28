/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/12/2009 11:14:22 PM
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace DMS.UI.Common
{
    public class ChildrenForm:CommandsForm
    {
        public override void RefreshCommands()
        {
            base.RefreshCommands();
            DMS.UI.SystemManage.SystemSetForm.Current.RefreshToolBar();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ChildrenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(514, 364);
            this.Name = "ChildrenForm";
            this.ResumeLayout(false);

        }
    }
}
