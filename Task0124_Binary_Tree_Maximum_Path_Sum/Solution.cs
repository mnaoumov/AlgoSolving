﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgoSolving.Task0124_Binary_Tree_Maximum_Path_Sum
{
    public class Solution
    {
        public int MaxPathSum(TreeNode root)
        {
            var maxPathSumDowns = new Dictionary<TreeNode, int>();
            return MaxPathSum(root, maxPathSumDowns);
        }

        private int MaxPathSum(TreeNode root, Dictionary<TreeNode, int> maxPathSumDowns)
        {
            if (root == null)
            {
                return 0;
            }

            int result =
                root.val
                + Math.Max(MaxPathSumDown(root.left, maxPathSumDowns), 0)
                + Math.Max(MaxPathSumDown(root.right, maxPathSumDowns), 0);

            if (root.left != null)
            {
                result = Math.Max(result, MaxPathSum(root.left, maxPathSumDowns));
            }

            if (root.right != null)
            {
                result = Math.Max(result, MaxPathSum(root.right, maxPathSumDowns));
            }

            return result;
        }

        private int MaxPathSumDown(TreeNode root, Dictionary<TreeNode, int> maxPathSumDowns)
        {
            if (root == null)
            {
                return 0;
            }

            if (!maxPathSumDowns.ContainsKey(root))
            {
                maxPathSumDowns[root] = root.val + new[]
                {
                    0,
                    MaxPathSumDown(root.left, maxPathSumDowns),
                    MaxPathSumDown(root.right, maxPathSumDowns)
                }.Max();
            }

            return maxPathSumDowns[root];
        }
    }
}