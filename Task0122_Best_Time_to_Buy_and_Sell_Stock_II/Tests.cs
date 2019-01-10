using NUnit.Framework;

namespace AlgoSolving.Task0122_Best_Time_to_Buy_and_Sell_Stock_II
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().MaxProfit(new[] { 7, 1, 5, 3, 6, 4 }), Is.EqualTo(7));
        }

        [Test]
        public void AcceptanceTest2()
        {
            Assert.That(new Solution().MaxProfit(new[] { 1, 2, 3, 4, 5 }), Is.EqualTo(4));
        }

        [Test]
        public void AcceptanceTest3()
        {
            Assert.That(new Solution().MaxProfit(new[] { 7, 6, 4, 3, 1 }), Is.EqualTo(0));
        }
    }
}