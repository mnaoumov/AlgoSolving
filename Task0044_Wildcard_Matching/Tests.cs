using NUnit.Framework;

namespace AlgoSolving.Task0044_Wildcard_Matching
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().IsMatch("aa", "a"), Is.False);
        }

        [Test]
        public void AcceptanceTest2()
        {
            Assert.That(new Solution().IsMatch("aa", "*"), Is.True);
        }

        [Test]
        public void AcceptanceTest3()
        {
            Assert.That(new Solution().IsMatch("cb", "?a"), Is.False);
        }

        [Test]
        public void AcceptanceTest4()
        {
            Assert.That(new Solution().IsMatch("adecb", "*a*b"), Is.True);
        }

        [Test]
        public void AcceptanceTest5()
        {
            Assert.That(new Solution().IsMatch("acdcb", "a*c?b"), Is.False);
        }
    }
}