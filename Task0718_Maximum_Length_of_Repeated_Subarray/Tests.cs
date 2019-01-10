using NUnit.Framework;

namespace AlgoSolving.Task0718_Maximum_Length_of_Repeated_Subarray
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().FindLength(new[] {1, 2, 3, 2, 1}, new[] {3, 2, 1, 4, 7}), Is.EqualTo(3));
        }

        [Test]
        public void AcceptanceTest2()
        {
            Assert.That(new Solution().FindLength(new[] {0,1,1,1,1}, new[] {1,0,1,0,1}), Is.EqualTo(2));
        }
    }
}