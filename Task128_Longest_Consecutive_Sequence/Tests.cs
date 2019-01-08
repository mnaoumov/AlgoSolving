using NUnit.Framework;

namespace AlgoSolving.Task128_Longest_Consecutive_Sequence
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest()
        {
            Assert.That(new Solution().LongestConsecutive(new[] { 100, 4, 200, 1, 3, 2 }), Is.EqualTo(4));
        }

        [Test]
        public void AcceptanceTest2()
        {
            Assert.That(new Solution().LongestConsecutive(new[] { 1, 2, 0, 1 }), Is.EqualTo(3));
        }
    }
}