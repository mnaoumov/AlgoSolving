using NUnit.Framework;

namespace AlgoSolving.Task0057_Insert_Interval
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().Insert(new[] { new Interval(1, 3), new Interval(6, 9) }, new Interval(2, 5)),
                Is.EqualTo(new[] { new Interval(1, 5), new Interval(6, 9) }));
        }

        [Test]
        public void AcceptanceTest2()
        {
            Assert.That(new Solution().Insert(new[] { new Interval(1, 2), new Interval(3, 5), new Interval(6, 7), new Interval(8, 10), new Interval(12, 16) }, new Interval(4, 8)),
                Is.EqualTo(new[] { new Interval(1, 2), new Interval(3, 10), new Interval(12, 16) }));
        }
    }
}