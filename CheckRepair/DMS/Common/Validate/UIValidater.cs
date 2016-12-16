/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/13/2009 8:47:58 PM
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DMS.Common.Validate
{
    internal abstract class UIValidater
    {
        public abstract bool Validate(out string errorMessage, out Control[] errorControls);
    }
}
