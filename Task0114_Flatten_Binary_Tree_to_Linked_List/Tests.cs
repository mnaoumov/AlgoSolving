using NUnit.Framework;

namespace AlgoSolving.Task0114_Flatten_Binary_Tree_to_Linked_List
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            var root = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(3),
                    right = new TreeNode(4)
                },
                right = new TreeNode(5)
                {
                    right = new TreeNode(6)
                }
            };

            new Solution().Flatten(root);

            Assert.Multiple(() =>
            {
                Assert.That(root.val, Is.EqualTo(1));
                Assert.That(root.right.val, Is.EqualTo(2));
                Assert.That(root.right.right.val, Is.EqualTo(3));
                Assert.That(root.right.right.right.val, Is.EqualTo(4));
                Assert.That(root.right.right.right.right.val, Is.EqualTo(5));
                Assert.That(root.right.right.right.right.right.val, Is.EqualTo(6));
                Assert.That(root.right.right.right.right.right.right, Is.Null);
            });
        }

    }
}