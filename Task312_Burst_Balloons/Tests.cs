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
    }
}