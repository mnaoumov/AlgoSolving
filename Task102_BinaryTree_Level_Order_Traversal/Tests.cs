using NUnit.Framework;

namespace AlgoSolving.Task102_BinaryTree_Level_Order_Traversal
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest()
        {
            var root = CreateTreeRoot(3, 9, 20, null, null, 15, 7);
            var expectedResult = new[]
            {
                new[] {3},
                new[] {9, 20},
                new[] {15, 7},
            };

            Assert.That(new Solution().LevelOrder(root), Is.EquivalentTo(expectedResult));
        }

        private static TreeNode CreateTreeRoot(params int?[] values)
        {
            throw new System.NotImplementedException();
        }
    }
}