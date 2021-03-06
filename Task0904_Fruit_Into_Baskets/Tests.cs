﻿using System.Linq;
using NUnit.Framework;

namespace AlgoSolving.Task0904_Fruit_Into_Baskets
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().TotalFruit(new[] { 1, 2, 1 }), Is.EqualTo(3));
        }

        [Test]
        public void AcceptanceTest2()
        {
            Assert.That(new Solution().TotalFruit(new[] { 0, 1, 2, 2 }), Is.EqualTo(3));
        }

        [Test]
        public void AcceptanceTest3()
        {
            Assert.That(new Solution().TotalFruit(new[] { 1, 2, 3, 2, 2 }), Is.EqualTo(4));
        }

        [Test]
        public void AcceptanceTest4()
        {
            Assert.That(new Solution().TotalFruit(new[] { 3, 3, 3, 1, 2, 1, 1, 2, 3, 3, 4 }), Is.EqualTo(5));
        }

        [Test]
        [Timeout(1000)]
        public void Many_same_items()
        {
            Assert.That(new Solution().TotalFruit(Enumerable.Repeat(0, 10000).ToArray()), Is.EqualTo(10000));
        }
    }
}