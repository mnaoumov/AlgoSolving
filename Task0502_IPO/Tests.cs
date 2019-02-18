using System.Linq;
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

        [Test]
        [Timeout(1000)]
        public void Timeout()
        {
            Assert.That(new Solution().FindMaximizedCapital(50000, 50000, Enumerable.Range(0, 50000).ToArray(), Enumerable.Range(0, 50000).ToArray()), Is.EqualTo(1250025000));
        }

        [Test]
        public void More_attempts_than_projects()
        {
            Assert.That(new Solution().FindMaximizedCapital(10, 0, new[] { 1, 2, 3 }, new[] { 0, 1, 2 }), Is.EqualTo(6));
        }
    }
}