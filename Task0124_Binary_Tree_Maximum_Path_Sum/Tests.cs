using NUnit.Framework;

namespace AlgoSolving.Task0124_Binary_Tree_Maximum_Path_Sum
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            TreeNode root = new TreeNode(1)
            {
                left = new TreeNode(2),
                right = new TreeNode(3)
            };
            Assert.That(new Solution().MaxPathSum(root), Is.EqualTo(6));
        }

        [Test]
        public void AcceptanceTest2()
        {
            TreeNode root = new TreeNode(-10)
            {
                left = new TreeNode(9),
                right = new TreeNode(20)
                {
                    left = new TreeNode(15),
                    right = new TreeNode(7)
                }
            };
            Assert.That(new Solution().MaxPathSum(root), Is.EqualTo(42));
        }
    }
}