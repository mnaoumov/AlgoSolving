using NUnit.Framework;

namespace AlgoSolving.Task0096_Unique_Binary_Search_Trees
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().NumTrees(3), Is.EqualTo(5));
        }
    }
}