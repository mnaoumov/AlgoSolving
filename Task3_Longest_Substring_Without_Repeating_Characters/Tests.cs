using NUnit.Framework;

namespace AlgoSolving.Task3_Longest_Substring_Without_Repeating_Characters
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().LengthOfLongestSubstring("abcabcbb"), Is.EqualTo(3));
        }

        [Test]
        public void AcceptanceTest2()
        {
            Assert.That(new Solution().LengthOfLongestSubstring("bbbbb"), Is.EqualTo(1));
        }

        [Test]
        public void AcceptanceTest3()
        {
            Assert.That(new Solution().LengthOfLongestSubstring("pwwkew"), Is.EqualTo(3));
        }
    }
}