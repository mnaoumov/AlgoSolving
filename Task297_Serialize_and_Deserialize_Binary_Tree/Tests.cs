using NUnit.Framework;

namespace AlgoSolving.Task297_Serialize_and_Deserialize_Binary_Tree
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            TreeNode root = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(4)
                },
                right = new TreeNode(3)
                {
                    right = new TreeNode(5)
                }
            };
            var serialized = new Codec().serialize(root);
            var deserialized = new Codec().deserialize(serialized);
            Assert.That(deserialized, Is.EqualTo(root).Using(new TreeNodeEqualityComparer()));
        }
    }
}