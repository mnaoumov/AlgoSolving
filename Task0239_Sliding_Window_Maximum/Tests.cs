﻿using NUnit.Framework;

namespace AlgoSolving.Task0239_Sliding_Window_Maximum
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().MaxSlidingWindow(new[] { 1, 3, -1, -3, 5, 3, 6, 7 }, 3),
                Is.EqualTo(new[] { 3, 3, 5, 5, 6, 7 }));
        }

        [Test]
        public void Empty_array()
        {
            Assert.That(new Solution().MaxSlidingWindow(new int[] { }, 0),
                Is.EqualTo(new int[] { }));
        }
    }
}