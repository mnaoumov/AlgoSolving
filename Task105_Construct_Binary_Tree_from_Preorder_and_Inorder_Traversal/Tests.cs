using NUnit.Framework;

namespace AlgoSolving.Task105_Construct_Binary_Tree_from_Preorder_and_Inorder_Traversal
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            var root = new Solution().BuildTree(new[] { 3, 9, 20, 15, 7 }, new[] { 9, 3, 15, 20, 7 });
            Assert.Multiple(() =>
            {
                Assert.That(root.val, Is.EqualTo(3));
                Assert.That(root.left.val, Is.EqualTo(9));
                Assert.That(root.left.left, Is.Null);
                Assert.That(root.left.right, Is.Null);
                Assert.That(root.right.val, Is.EqualTo(20));
                Assert.That(root.right.left.val, Is.EqualTo(15));
                Assert.That(root.right.left.left, Is.Null);
                Assert.That(root.right.left.right, Is.Null);
                Assert.That(root.right.right.val, Is.EqualTo(7));
                Assert.That(root.right.right.left, Is.Null);
                Assert.That(root.right.right.right, Is.Null);
            });
        }
    }
}