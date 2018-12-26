using NUnit.Framework;

namespace AlgoSolving.Task689_Maximum_Sum_of_3_Non_Overlapping_Subarrays
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().MaxSumOfThreeSubarrays(new[] {1, 2, 1, 2, 6, 7, 5, 1}, 2),
                Is.EqualTo(new[] {0, 3, 5}));
        }
    }
}