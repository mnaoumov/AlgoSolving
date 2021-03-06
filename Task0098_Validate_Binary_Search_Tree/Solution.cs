﻿namespace AlgoSolving.Task0098_Validate_Binary_Search_Tree
{
    public class Solution
    {
        public bool IsValidBST(TreeNode root)
        {
            return IsValidBST(root, null, null);
        }

        private bool IsValidBST(TreeNode root, int? min, int? max)
        {
            if (root == null)
            {
                return true;
            }

            return (min == null || min < root.val) && 
                   (max == null || root.val < max) &&
                   IsValidBST(root.left, min, root.val) &&
                   IsValidBST(root.right, root.val, max);
        }
    }
}