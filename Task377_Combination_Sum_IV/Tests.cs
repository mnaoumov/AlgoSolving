using NUnit.Framework;

namespace AlgoSolving.Task377_Combination_Sum_IV
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().CombinationSum4(new[] { 1, 2, 3 }, 4), Is.EqualTo(7));
        }
    }
}