/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/19/2009 2:30:24 PM
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DMS.DomainObjects.BasicInfo;

namespace DMS.UI.Common
{
    public class CommonModule
    {
        #region Load Modules
        public static void LoadModule(TreeView tvModule, List<Module> modules)
        {
            TreeNode root = new TreeNode("功能列表");
            tvModule.Nodes.Clear();
            tvModule.Nodes.Add(root);

            LoadModules(modules, root.Nodes, 0);
            tvModule.Nodes[0].Expand();
        }

        private static void LoadModules(List<Module> modules, TreeNodeCollection nodes, int parentModuleNO)
        {
            foreach (Module module in modules)
            {
                if (module.PriorModule == parentModuleNO)
                {
                    TreeNode node = new TreeNode(module.Name);                 
                    node.Tag = module;
                    nodes.Add(node);
                    LoadModules(modules, node.Nodes, module.ID);
                }
            }
        }
        #endregion

        #region SetModule
        public static void SetModule(TreeView tvModule, List<Module> modules)
        {
            SetModules(modules, tvModule.Nodes[0].Nodes);
        }

        private static void SetModules(List<Module> modules, TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                foreach (Module module in modules)
                {
                    if (module.ID == ((Module)node.Tag).ID)
                    {
                        node.Checked = true;
                        break;
                    }
                }

                SetModules(modules, node.Nodes);
            }
        }
        #endregion

        #region GetModules
        public static List<Module> GetModule(TreeView tvModule)
        {
            List<Module> modules = new List<Module>();
            GetModules(modules, tvModule.Nodes[0].Nodes);

            return modules;
        }

        private static void GetModules(List<Module> modules, TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Checked && (node.Tag is Module))
                {
                    modules.Add(((Module)node.Tag));
                    GetModules(modules, node.Nodes);
                }
            }
        }
        #endregion

        #region SelectChildNodes
        public static void SelectAllChildNodesOfCurrentNode(TreeNode currentNode)
        {
            if (currentNode == null)
                return;
            CheckNodes(currentNode.Nodes);
        }

        private static void CheckNodes(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                node.Checked = true;
                CheckNodes(node.Nodes);
            }
        }
        #endregion
    }
}
