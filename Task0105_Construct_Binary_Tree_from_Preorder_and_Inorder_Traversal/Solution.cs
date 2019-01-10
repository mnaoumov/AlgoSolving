﻿namespace AlgoSolving.Task0105_Construct_Binary_Tree_from_Preorder_and_Inorder_Traversal
{
    public class Solution
    {
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            return BuildTree(preorder, inorder, 0, 0, preorder.Length);
        }

        private TreeNode BuildTree(int[] preorder, int[] inorder, int preorderIndexFrom, int inorderIndexFrom, int childrenCount)
        {
            if (childrenCount == 0)
            {
                return null;
            }

            var root = new TreeNode(preorder[preorderIndexFrom]);

            int leftNodeInorderIndex = inorderIndexFrom;
            while (inorder[leftNodeInorderIndex] != root.val)
            {
                leftNodeInorderIndex++;
            }

            var leftNodeChildrenCount = leftNodeInorderIndex - inorderIndexFrom;
            root.left = BuildTree(preorder, inorder, preorderIndexFrom + 1, inorderIndexFrom,
                leftNodeChildrenCount);
            root.right = BuildTree(preorder, inorder, preorderIndexFrom + leftNodeChildrenCount + 1, leftNodeInorderIndex + 1,
                childrenCount - leftNodeChildrenCount - 1);

            return root;
        }
    }
}