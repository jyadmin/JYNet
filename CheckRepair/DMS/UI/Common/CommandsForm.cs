/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/12/2009 11:15:05 PM
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DMS.DomainObjects;

namespace DMS.UI.Common
{
    public class CommandsForm:BaseForm
    {
        CommandVisibleStateManager cvsm;

        bool m_autoRefreshCommands = true;

        public CommandsForm()
        {
            this.Load += new EventHandler(CommandsForm_Load);
            this.BackColor = System.Drawing.Color.AliceBlue;
        }

        void CommandsForm_Load(object sender, EventArgs e)
        {
            cvsm = new CommandVisibleStateManager();
            ToolBarCommand[] commands = GetCommands();
            if (commands != null)
            {
                //在按钮状态管理器中为每个按钮创建两层状态
                foreach (ToolBarCommand command in commands)
                {
                    if (command != null)
                    {
                        cvsm.AddCommand(command, new string[] { "permission", "logic" });
                    }
                }
            }
        }

        /// 获取所有的功能按钮
        /// </summary>
        /// <returns></returns>
        public virtual ToolBarCommand[] GetCommands()
        {
            return null;
        }

        /// <summary>
        /// 刷新所有的功能按钮
        /// </summary>
        public virtual void RefreshCommands()
        {

        }

        public void SetPermissionsVisible(ToolBarCommand[] cmds, bool[] visibles)
        {
            SetLayVisible("permission", cmds, visibles);
        }

        public void SetLogicVisible(ToolBarCommand[] cmds, bool[] visibles)
        {
            SetLayVisible("logic", cmds, visibles);
        }

        public void BeginEditCommands()
        {
            this.m_autoRefreshCommands = false;
        }

        public void EndEditCommands()
        {
            this.RefreshCommands();
            this.m_autoRefreshCommands = true;
        }

        private void SetLayVisible(string layName, ToolBarCommand[] cmds, bool[] visibles)
        {
            if (cmds == null)
                throw new ArgumentNullException();
            if (visibles == null)
                throw new ArgumentNullException();
            if (cmds.Length != visibles.Length)
                throw new ArgumentException("按钮与按钮状态数量不一致!");
            for (int i = 0; i < cmds.Length; i++)
            {
                cvsm.SetCommandVisibleState(cmds[i], layName, visibles[i]);
            }
            if (m_autoRefreshCommands)
                RefreshCommands();
        }

        public void SetPermission(ToolBarCommand[] tbcs, int[] moduleNOs)
        {
            if (tbcs == null)
                throw new ArgumentNullException();
            if (moduleNOs == null)
                throw new ArgumentNullException();
            if (tbcs.Length != moduleNOs.Length)
                throw new ArgumentException("按钮数量与模块数量不一致!");
            for (int i = 0; i < tbcs.Length; i++)
            {
                cvsm.SetCommandVisibleState(tbcs[i], "permission", CurrentUser.Instance.CanUseModule(moduleNOs[i]));
            }
            RefreshCommands();
        }
    }
}
