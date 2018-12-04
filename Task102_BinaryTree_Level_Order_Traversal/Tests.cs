using System;
using System.Linq;
using NUnit.Framework;

namespace AlgoSolving.Task102_BinaryTree_Level_Order_Traversal
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest()
        {
            var root = new TreeNode(3)
            {
                left = new TreeNode(9),
                right = new TreeNode(20)
                {
                    left = new TreeNode(15),
                    right = new TreeNode(7)
                }
            };

            var expectedResult = new[]
            {
                new[] {3},
                new[] {9, 20},
                new[] {15, 7},
            };

            Assert.That(new Solution().LevelOrder(root), Is.EquivalentTo(expectedResult));
        }
    }
}