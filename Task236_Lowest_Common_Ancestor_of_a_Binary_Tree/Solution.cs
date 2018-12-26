using System.Linq;

namespace AlgoSolving.Task236_Lowest_Common_Ancestor_of_a_Binary_Tree
{
    public class Solution
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (new[] { null, p, q }.Contains(root))
            {
                return root;
            }

            return LowestCommonAncestor(root.left, p, q) ?? LowestCommonAncestor(root.right, p, q) ?? root;
        }
    }
}