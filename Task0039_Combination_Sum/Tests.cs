using NUnit.Framework;

namespace AlgoSolving.Task0039_Combination_Sum
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().CombinationSum(new[] { 2, 3, 6, 7 }, 7), Is.EquivalentTo(new[]
            {
                new[] {7},
                new[] {2, 2, 3}
            }));
        }

        [Test]
        public void AcceptanceTest2()
        {
            Assert.That(new Solution().CombinationSum(new[] { 2, 3, 5 }, 8), Is.EquivalentTo(new[]
            {
                new[] {2, 2, 2, 2},
                new[] {2, 3, 3},
                new[] {3, 5}
            }));
        }
    }
}