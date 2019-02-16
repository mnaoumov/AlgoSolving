using NUnit.Framework;

namespace AlgoSolving.Task0502_IPO
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().FindMaximizedCapital(2, 0, new[] { 1, 2, 3 }, new[] { 0, 1, 1 }), Is.EqualTo(4));
        }
    }
}