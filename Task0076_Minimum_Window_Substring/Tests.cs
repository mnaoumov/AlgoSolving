﻿using NUnit.Framework;

namespace AlgoSolving.Task0076_Minimum_Window_Substring
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().MinWindow("ADOBECODEBANC", "ABC"), Is.EqualTo("BANC"));
        }
    }
}