using NUnit.Framework;

namespace AlgoSolving.Task42_Trapping_Rain_Water
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().Trap(new[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }), Is.EqualTo(6));
        }

        [Test]
        public void AcceptanceTest2()
        {
            Assert.That(new Solution().Trap(new[] { 2, 0, 2, 0, 1, 0 }), Is.EqualTo(3));
        }
    }
}