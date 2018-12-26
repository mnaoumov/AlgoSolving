using NUnit.Framework;

namespace AlgoSolving.Task236_Lowest_Common_Ancestor_of_a_Binary_Tree
{
    public class Tests
    {
        [SetUp]
        public void BeforeEachTest()
        {
            TestContext.AddFormatter<TreeNode>(val =>
            {
                var treeNode = (TreeNode) val;
                return $"{treeNode.val}";
            });
        }
        [Test]
        public void AcceptanceTest1()
        {
            TreeNode p;
            TreeNode q;
            TreeNode lca;
            TreeNode root = lca = new TreeNode(3)
            {
                left = p = new TreeNode(5)
                {
                    left = new TreeNode(6),
                    right = new TreeNode(2)
                    {
                        left = new TreeNode(7),
                        right = new TreeNode(4)
                    }
                },
                right = q = new TreeNode(1)
                {
                    left = new TreeNode(0),
                    right = new TreeNode(8),
                }
            };
            Assert.That(new Solution().LowestCommonAncestor(root, p, q), Is.EqualTo(lca));
        }

        [Test]
        public void AcceptanceTest2()
        {
            TreeNode p;
            TreeNode q;
            TreeNode lca;
            TreeNode root = lca = new TreeNode(3)
            {
                left = p = lca = new TreeNode(5)
                {
                    left = new TreeNode(6),
                    right = new TreeNode(2)
                    {
                        left = new TreeNode(7),
                        right = q = new TreeNode(4)
                    }
                },
                right = new TreeNode(1)
                {
                    left = new TreeNode(0),
                    right = new TreeNode(8),
                }
            };
            Assert.That(new Solution().LowestCommonAncestor(root, p, q), Is.EqualTo(lca));
        }
    }
}