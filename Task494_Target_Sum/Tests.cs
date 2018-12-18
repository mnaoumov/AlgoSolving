using NUnit.Framework;

namespace AlgoSolving.Task494_Target_Sum
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().FindTargetSumWays(new[] {1, 1, 1, 1, 1}, 3), Is.EqualTo(5));
        }
    }
}