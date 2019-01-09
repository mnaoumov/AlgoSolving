﻿using NUnit.Framework;

namespace AlgoSolving.Task98_Validate_Binary_Search_Tree
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            var root = new TreeNode(2)
            {
                left = new TreeNode(1),
                right = new TreeNode(3)
            };

            Assert.That(new Solution().IsValidBST(root), Is.True);
        }

        [Test]
        public void AcceptanceTest2()
        {
            var root = new TreeNode(5)
            {
                left = new TreeNode(1),
                right = new TreeNode(4)
                {
                    left = new TreeNode(3),
                    right = new TreeNode(6)
                }
            };

            Assert.That(new Solution().IsValidBST(root), Is.False);
        }
    }
}