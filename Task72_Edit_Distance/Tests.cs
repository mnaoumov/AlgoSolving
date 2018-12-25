using NUnit.Framework;

namespace AlgoSolving.Task72_Edit_Distance
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().MinDistance("horse", "ros"), Is.EqualTo(3));
        }

        [Test]
        public void AcceptanceTest2()
        {
            Assert.That(new Solution().MinDistance("intention", "execution"), Is.EqualTo(5));
        }
    }
}