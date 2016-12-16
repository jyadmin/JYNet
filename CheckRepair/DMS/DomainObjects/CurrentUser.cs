/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/12/2009 5:30:31 PM
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DMS.DomainObjects.BasicInfo;

namespace DMS.DomainObjects
{
    public class CurrentUser
    {
        #region Instance
        private static CurrentUser m_Instnace;

        public static CurrentUser Instance
        {
            get
            {
                if (m_Instnace == null)
                {
                    m_Instnace = new CurrentUser();
                }

                return m_Instnace;
            }
        }

        private CurrentUser()
        { }
        #endregion

        public UserInfo User { get; set; }

        public Role Role { get; set; }

        public Edition Edition { get; set; }

        public List<Module> Modules { get; set; }

        public bool CanUseModule(int moduleNO)
        {
            foreach (Module module in this.Modules)
            {
                if (module.ID == moduleNO)
                    return true;
            }
            return false;
        }
    }
}
