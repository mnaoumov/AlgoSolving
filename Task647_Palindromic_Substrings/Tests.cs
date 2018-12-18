using NUnit.Framework;

namespace AlgoSolving.Task647_Palindromic_Substrings
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().CountSubstrings("abc"), Is.EqualTo(3));
        }

        [Test]
        public void AcceptanceTest2()
        {
            Assert.That(new Solution().CountSubstrings("aaa"), Is.EqualTo(6));
        }
    }
}