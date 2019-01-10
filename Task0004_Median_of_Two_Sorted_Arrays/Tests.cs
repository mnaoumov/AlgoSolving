using NUnit.Framework;

namespace AlgoSolving.Task0004_Median_of_Two_Sorted_Arrays
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().FindMedianSortedArrays(new[] { 1, 3 }, new[] { 2 }), Is.EqualTo(2.0));
        }

        [Test]
        public void AcceptanceTest2()
        {
            Assert.That(new Solution().FindMedianSortedArrays(new[] { 1, 2 }, new[] { 3, 4 }), Is.EqualTo(2.5));
        }
    }
}