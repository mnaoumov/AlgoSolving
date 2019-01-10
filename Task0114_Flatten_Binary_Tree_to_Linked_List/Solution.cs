namespace AlgoSolving.Task0114_Flatten_Binary_Tree_to_Linked_List
{
    public class Solution
    {
        public void Flatten(TreeNode root)
        {
            var node = root;
            while (node != null)
            {
                if (node.left != null)
                {
                    GetRightmostNode(node.left).right = node.right;
                    node.right = node.left;
                    node.left = null;
                }
                node = node.right;
            }
        }

        private static TreeNode GetRightmostNode(TreeNode root)
        {
            var node = root;
            while (node.right != null)
            {
                node = node.right;
            }

            return node;
        }
    }
}