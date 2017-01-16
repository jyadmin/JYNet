using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DMS.DomainObjects.BasicInfo;

namespace DMS.UI.Common
{
    public class CommonUser
    {
        #region Load Users
        public static void LoadModule(TreeView tvModule, List<UserInfo> users)
        {
            TreeNode root = new TreeNode("人员");
            tvModule.Nodes.Clear();
            tvModule.Nodes.Add(root);

            LoadUsers(users, root.Nodes, 0);
            tvModule.Nodes[0].Expand();
        }

        private static void LoadUsers(List<UserInfo> users, TreeNodeCollection nodes, int parentModuleNO)
        {
            foreach (UserInfo user in users)
            {
                TreeNode node = new TreeNode(user.UserName);
                node.Tag = user;
                nodes.Add(node);
            }
        }
        #endregion

        #region SetUser
        public static void SetUser(TreeView tvUser, List<UserInfo> users)
        {
            SetUsers(users, tvUser.Nodes[0].Nodes);
        }

        private static void SetUsers(List<UserInfo> users, TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                foreach (UserInfo user in users)
                {
                    if (user.ID == ((UserInfo)node.Tag).ID)
                    {
                        node.Checked = true;
                        break;
                    }
                }

                SetUsers(users, node.Nodes);
            }
        }
        #endregion

        #region GetUsers
        public static List<UserInfo> GetUser(TreeView tvUser)
        {
            List<UserInfo> users = new List<UserInfo>();
            GetUsers(users, tvUser.Nodes[0].Nodes);

            return users;
        }

        private static void GetUsers(List<UserInfo> users, TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Checked && (node.Tag is Module))
                {
                    users.Add(((UserInfo)node.Tag));
                    GetUsers(users, node.Nodes);
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
