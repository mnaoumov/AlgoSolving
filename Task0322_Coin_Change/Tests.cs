using NUnit.Framework;

namespace AlgoSolving.Task0322_Coin_Change
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().CoinChange(new[] { 1, 2, 5 }, 11), Is.EqualTo(3));
        }

        [Test]
        public void AcceptanceTest2()
        {
            Assert.That(new Solution().CoinChange(new[] { 2 }, 3), Is.EqualTo(-1));
        }
    }
}