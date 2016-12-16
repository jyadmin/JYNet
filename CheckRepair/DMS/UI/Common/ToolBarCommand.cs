using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace DMS.UI.Common
{
    public class ToolBarCommand : Component
    {
        protected string name;
        protected string commandName;
        protected string imagePath;
        protected bool isEnable = true;
        protected bool isVisible = true;
        CommandType m_type = CommandType.Other;

        public ToolBarCommand()
        {
        }

        public ToolBarCommand(string text)
        {
            this.CommandName = text;
        }

        public void Command()
        {
            OnCommand();
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string CommandName
        {
            get
            {
                return this.commandName;
            }
            set
            {
                this.commandName = value;
            }
        }

        public string ImagePath
        {
            get
            {
                return this.imagePath;
            }
            set
            {
                this.imagePath = value;
            }
        }

        public bool IsEnable
        {
            get
            {
                return this.isEnable;
            }
            set
            {
                this.isEnable = value;
            }
        }

        public bool IsVisible
        {
            get
            {
                return this.isVisible;
            }
            set
            {
                this.isVisible = value;
            }
        }

        public CommandType Type
        {
            get { return m_type; }
            set { m_type = value; }
        }

        public void OnCommand()
        {
            if (this.Commanded != null)
                this.Commanded(this, EventArgs.Empty);
        }

        public event EventHandler Commanded;
    }
}
