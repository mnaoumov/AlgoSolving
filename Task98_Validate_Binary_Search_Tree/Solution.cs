namespace AlgoSolving.Task98_Validate_Binary_Search_Tree
{
    public class Solution
    {
        public bool IsValidBST(TreeNode root)
        {
            return IsValidBST(root, int.MinValue, int.MaxValue);
        }

        private bool IsValidBST(TreeNode root, int min, int max)
        {
            if (root == null)
            {
                return true;
            }

            return min < root.val && root.val < max &&
                   IsValidBST(root.left, min, root.val) &&
                   IsValidBST(root.right, root.val, max);
        }
    }
}