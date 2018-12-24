using NUnit.Framework;

namespace AlgoSolving.Task560_Subarray_Sum_Equals_K
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().SubarraySum(new[] { 1, 1, 1 }, 2), Is.EqualTo(2));
        }

        [Test]
        public void Last_element_equaled_to_sum_should_be_counted()
        {
            Assert.That(new Solution().SubarraySum(new[] { 1, 2, 3 }, 3), Is.EqualTo(2));
        }
    }
}