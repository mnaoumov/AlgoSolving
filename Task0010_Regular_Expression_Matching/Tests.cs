using NUnit.Framework;

namespace AlgoSolving.Task0010_Regular_Expression_Matching
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
            Assert.That(new Solution().IsMatch("aa", "a*"), Is.True);
        }

        [Test]
        public void AcceptanceTest3()
        {
            Assert.That(new Solution().IsMatch("ab", ".*"), Is.True);
        }

        [Test]
        public void AcceptanceTest4()
        {
            Assert.That(new Solution().IsMatch("aab", "c*a*b"), Is.True);
        }

        [Test]
        public void AcceptanceTest5()
        {
            Assert.That(new Solution().IsMatch("mississippi", "mis*is*p*."), Is.False);
        }

        [Test]
        public void AcceptanceTest6()
        {
            Assert.That(new Solution().IsMatch("ab", ".*c"), Is.False);
        }

        [Test]
        public void Optional_pattern_after_string()
        {
            Assert.That(new Solution().IsMatch("a", "ab*"), Is.True);
        }
    }
}