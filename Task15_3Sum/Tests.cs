using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace AlgoSolving.Task15_3Sum
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().ThreeSum(new[] { -1, 0, 1, 2, -1, -4 }), Is.EquivalentTo(new[]
            {
                new[] { -1, 0, 1 },
                new[] { -1, -1, 2 }
            }).Using<IList<int>>((ints1, ints2) => ints1.Count == ints2.Count && !ints1.Except(ints2).Any()));
        }
    }
}