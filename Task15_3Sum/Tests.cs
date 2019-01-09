using System.Collections.Generic;
using NUnit.Framework;

namespace AlgoSolving.Task15_3Sum
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().ThreeSum(new[] { -1, 0, 1, 2, -1, -4 }), TestHelper.IsEquivalentTo(new IList<int>[]
            {
                new[] { -1, 0, 1 },
                new[] { -1, -1, 2 }
            }));
        }
    }
}