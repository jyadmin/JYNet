/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/13/2009 9:51:02 PM
 * */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMS.UI.Common
{
    public class CommandVisibleStateManager
    {
        Hashtable m_commandMstates;

        public CommandVisibleStateManager()
        {
            m_commandMstates = new Hashtable();
        }

        public void AddCommand(ToolBarCommand cmd, string[] lays)
        {
            if (cmd == null)
                throw new ArgumentNullException();
            LayStates layStates = new LayStates();
            if (lays != null)
            {
                foreach (string lay in lays)
                {
                    layStates.AddLay(lay, true);
                }
            }
            m_commandMstates.Add(cmd, layStates);
        }

        public void SetCommandVisibleState(ToolBarCommand cmd, string layName, bool visible)
        {
            if (cmd == null)
                throw new ArgumentNullException();
            if (!m_commandMstates.Contains(cmd))
                throw new ArgumentException();
            LayStates layStates = (LayStates)m_commandMstates[cmd];
            layStates.SetLayVisible(layName, visible);
            cmd.IsVisible = layStates.Visible;
        }

        class LayStates
        {
            Hashtable m_layNameMcommandStates;

            public LayStates()
            {
                m_layNameMcommandStates = new Hashtable();
            }

            public void AddLay(string layMame, bool visible)
            {
                m_layNameMcommandStates.Add(layMame, visible);
            }

            public void SetLayVisible(string layName, bool visible)
            {
                if (layName == null)
                    throw new ArgumentNullException();
                if (!m_layNameMcommandStates.Contains(layName))
                    throw new ArgumentException();
                m_layNameMcommandStates[layName] = visible;
            }

            public bool Visible
            {
                get
                {
                    if (m_layNameMcommandStates.Count == 0)
                        return true;
                    foreach (bool b in m_layNameMcommandStates.Values)
                    {
                        if (!b)
                            return false;
                    }
                    return true;
                }
            }
        }
    }
}
