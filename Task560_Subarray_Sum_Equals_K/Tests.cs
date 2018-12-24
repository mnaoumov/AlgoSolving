using NUnit.Framework;

namespace AlgoSolving.Task560_Subarray_Sum_Equals_K
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().SubarraySum(new[] {1, 1, 1}, 2), Is.EqualTo(2));
        }
    }
}