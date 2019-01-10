using NUnit.Framework;

namespace AlgoSolving.Task84_Largest_Rectangle_in_Histogram
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().LargestRectangleArea(new[] { 2, 1, 5, 6, 2, 3 }), Is.EqualTo(10));
        }
    }
}