using NUnit.Framework;

namespace AlgoSolving.Task312_Burst_Balloons
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().MaxCoins(new[] { 3, 1, 5, 8 }), Is.EqualTo(167));
        }

        [Test]
        [Timeout(1000)]
        public void Timeout()
        {
            new Solution().MaxCoins(new[] { 7, 9, 8, 0, 7, 1, 3, 5, 5, 2, 3, 3 });
        }

        [Test]
        [Timeout(1000)]
        public void Timeout2()
        {
            new Solution().MaxCoins(new[] { 8, 2, 6, 8, 9, 8, 1, 4, 1, 5, 3, 0, 7, 7, 0, 4, 2, 2, 5 });
        }
    }
}