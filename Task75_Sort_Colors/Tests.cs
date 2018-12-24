using NUnit.Framework;

namespace AlgoSolving.Task75_Sort_Colors
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            var nums = new[] { 2, 0, 2, 1, 1, 0 };
            new Solution().SortColors(nums);
            Assert.That(nums, Is.EqualTo(new[] { 0, 0, 1, 1, 2, 2 }));
        }

        [Test]
        public void Work_properly_for_single_last_color()
        {
            var nums = new[] { 2 };
            new Solution().SortColors(nums);
            Assert.That(nums, Is.EqualTo(new[] { 2 }));
        }
    }
}