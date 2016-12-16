/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/11/2009 5:46:03 PM
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMS.DomainObjects
{
    public abstract class DomainObject : IComparable
    {
        public abstract int ID
        {
            get;
            set;
        }

        public virtual int CompareTo(object obj)
        {
            return ID.CompareTo((obj as DomainObject).ID);
        }
    }
}
