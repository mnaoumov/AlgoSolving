using System.Collections.Generic;

namespace AlgoSolving.Task0236_Lowest_Common_Ancestor_of_a_Binary_Tree
{
    public class Solution
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            var parents = new Dictionary<TreeNode, TreeNode>();

            FillParents(parents, root, null);

            var pAncestors = GetAncestors(parents, p);
            var qAncestors = GetAncestors(parents, q);

            var i = 0;
            while (i < pAncestors.Count && i < qAncestors.Count && pAncestors[i] == qAncestors[i])
            {
                i++;
            }

            return pAncestors[i - 1];
        }

        private IList<TreeNode> GetAncestors(Dictionary<TreeNode, TreeNode> parents, TreeNode node)
        {
            var ancestors = new List<TreeNode>();
            while (node != null)
            {
                ancestors.Insert(0, node);
                node = parents[node];
            }

            return ancestors;
        }

        private void FillParents(Dictionary<TreeNode, TreeNode> parents, TreeNode node, TreeNode parent)
        {
            if (node == null)
            {
                return;
            }

            parents[node] = parent;

            FillParents(parents, node.left, node);
            FillParents(parents, node.right, node);
        }
    }
}