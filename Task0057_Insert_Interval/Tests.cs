using NUnit.Framework;

namespace AlgoSolving.Task0057_Insert_Interval
{
    public class Tests
    {
        [SetUp]
        public void BeforeEachTests()
        {
            TestContext.AddFormatter<Interval>(val =>
            {
                var interval = (Interval)val;
                return $"[{interval.start}, {interval.end}]";
            });
        }

        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().Insert(new[] { new Interval(1, 3), new Interval(6, 9) }, new Interval(2, 5)),
                Is.EquivalentTo(new[] { new Interval(1, 5), new Interval(6, 9) }).Using<Interval, Interval>(IntervalComparer));
        }

        [Test]
        public void AcceptanceTest2()
        {
            Assert.That(new Solution().Insert(new[] { new Interval(1, 2), new Interval(3, 5), new Interval(6, 7), new Interval(8, 10), new Interval(12, 16) }, new Interval(4, 8)),
                Is.EquivalentTo(new[] { new Interval(1, 2), new Interval(3, 10), new Interval(12, 16) }).Using<Interval, Interval>(IntervalComparer));
        }

        private static bool IntervalComparer(Interval interval1, Interval interval2)
        {
            return interval1.start == interval2.start && interval1.end == interval2.end;
        }

        [Test]
        public void Inserted_includes_in_previous()
        {
            Assert.That(new Solution().Insert(new[] { new Interval(1, 5) }, new Interval(2, 3)),
                Is.EquivalentTo(new[] { new Interval(1, 5) }).Using<Interval, Interval>(IntervalComparer));
        }

        [Test]
        public void AcceptanceTest3()
        {
            Assert.That(new Solution().Insert(new[] { new Interval(1, 5), new Interval(6, 8) }, new Interval(0, 9)),
                Is.EquivalentTo(new[] { new Interval(0, 9) }).Using<Interval, Interval>(IntervalComparer));
        }
    }
}