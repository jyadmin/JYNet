using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DMS.UI.Common;
using DMS.DomainObjects;
using DMS.DomainObjects.BasicInfo;
using DMS.Common;

namespace DMS.UI.SystemManage
{
    public partial class SystemSetForm : TX.Framework.WindowUI.Forms.BaseForm
    {
        #region Signle Contract
        private static SystemSetForm m_Current;

        public static SystemSetForm Current
        {
            get 
            {
                if (m_Current == null)
                {
                    m_Current = new SystemSetForm();
                }

                return m_Current;
            }
        }

        public SystemSetForm()
        {
            InitializeComponent();
        }
        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitTreeView();
            LoadItemModules();
        }

        private void LoadFunction()
        {
            SystemManage.UserForm userForm = new DMS.UI.SystemManage.UserForm();
            userForm.WindowState = FormWindowState.Maximized;
            userForm.MdiParent = this;
            userForm.Show();
        }

        private void InitTreeView()
        {
            tv.Nodes.Clear();
            tv.ImageList = new ImageList();
            tv.ImageList.Images.Add(DMSImageManager.GetImage("module"));
            tv.ImageList.Images.Add(DMSImageManager.GetImage("module_select"));
            tv.ImageIndex = 0;
            tv.SelectedImageIndex = 1;
        }

        private void LoadItemModules()
        {
            LoadItemModules(CurrentUser.Instance.Modules, 0, tv.Nodes, menuItem.Items);
        }

        public void LoadItemModules(List<Module> modules, int parentModuleNO, TreeNodeCollection nodes, ToolStripItemCollection items)
        {
            foreach (Module module in modules)
            {
                //加载所有的功能模块
                if (module.PriorModule == parentModuleNO && module.IsDisplay == 1 && module.Level == 2)
                {
                    ToolStripMenuItem item = new ToolStripMenuItem();
                    TreeNode node = new TreeNode();
                    node.Text = module.Name;
                    item.Text = module.Name;

                    object runner = Reflector.Reflect(module.TypeFullName);
                    item.Tag = runner;
                    node.Tag = runner;
                    items.Add(item);
                    nodes.Add(node);

                    item.Click += new EventHandler(item_Click);

                    LoadItemModules(modules, module.ID, node.Nodes, item.DropDownItems);
                }
            }
        }

        private void item_Click(object sender, EventArgs e)
        {
            IModule runner = (IModule)((ToolStripMenuItem)sender).Tag;
            if (runner != null)
                runner.Run();
        }

        private void tv_AfterSelect(object sender, TreeViewEventArgs e)
        {
            IModule runner = e.Node.Tag as IModule;
            if (runner != null)
                runner.Run();

        }

        public void AddChild(ChildrenForm form)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            form.WindowState = FormWindowState.Maximized;
            form.MdiParent = this;
            this.SuspendLayout();
            form.Show();
            this.ResumeLayout();
            RefreshToolBar();
            this.PerformLayout();
        }

        public void RefreshToolBar()
        {
            this.toolstrip.SuspendLayout();
            this.toolstrip.Items.Clear();
            ChildrenForm children = (ChildrenForm)this.ActiveMdiChild;
            if (children != null)
            {
                ToolBarCommand[] commands = children.GetCommands();
                if (commands != null)
                {
                    foreach (ToolBarCommand command in commands)
                    {
                        ToolStripButton tsb = ToolStripButtonBuilder.BuildToolStripButton(command);
                        tsb.Click += new EventHandler(tsb_Click);
                        this.toolstrip.Items.Add(tsb);
                    }
                }
            }

            this.toolstrip.ResumeLayout();
        }

        private void tsb_Click(object sender, EventArgs e)
        {
            ((ToolBarCommand)((ToolStripButton)sender).Tag).Command();
        }

        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
            RefreshToolBar();
        }
    }
}