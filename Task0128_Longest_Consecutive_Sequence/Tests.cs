﻿using NUnit.Framework;

namespace AlgoSolving.Task0128_Longest_Consecutive_Sequence
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

        [Test]
        public void AcceptanceTest3()
        {
            Assert.That(new Solution().LongestConsecutive(new[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 }), Is.EqualTo(9));
        }
    }
}