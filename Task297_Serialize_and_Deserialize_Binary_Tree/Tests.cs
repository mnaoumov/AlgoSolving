using NUnit.Framework;

namespace AlgoSolving.Task297_Serialize_and_Deserialize_Binary_Tree
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            TreeNode root = null;
            var serialized = new Codec().serialize(root);
            var deserialized = new Codec().deserialize(serialized);
            Assert.That(deserialized, Is.EqualTo(root).Using(new TreeNodeEqualityComparer()));
        }
    }
}