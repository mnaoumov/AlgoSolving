namespace AlgoSolving.Task236_Lowest_Common_Ancestor_of_a_Binary_Tree
{
    public class Solution
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            return LowestCommonAncestor(root, p, q, parent: null, pFound: false);
        }

        private TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q, TreeNode parent, bool pFound)
        {
            if (root == null)
            {
                return null;
            }

            if (root == p)
            {
                pFound = true;
            }

            if (root == q)
            {
                if (pFound)
                {
                    return p;
                }

                (p, q) = (q, p);
                pFound = true;
            }

            return LowestCommonAncestor(root.left, p, q, root, pFound)
                   ?? LowestCommonAncestor(root.right, p, q, root, pFound)
                   ?? (pFound && parent != null && parent.left == root &&
                       LowestCommonAncestor(parent.right, p, q, parent, pFound: true) != null
                       ? parent
                       : null);
        }
    }
}