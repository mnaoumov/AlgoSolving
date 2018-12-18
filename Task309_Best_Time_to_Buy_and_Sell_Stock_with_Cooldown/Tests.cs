using NUnit.Framework;

namespace AlgoSolving.Task309_Best_Time_to_Buy_and_Sell_Stock_with_Cooldown
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().MaxProfit(new[] { 1, 2, 3, 0, 2 }), Is.EqualTo(3));
        }
    }
}