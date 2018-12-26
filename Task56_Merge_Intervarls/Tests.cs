using NUnit.Framework;

namespace AlgoSolving.Task56_Merge_Intervarls
{
    public class Tests
    {
        [SetUp]
        public void BeforeEachTests()
        {
            TestContext.AddFormatter<Interval>(val =>
            {
                var interval = (Interval) val;
                return $"[{interval.start}, {interval.end}]";
            });
        }

        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().Merge(new[]
            {
                new Interval(1, 3),
                new Interval(2, 6),
                new Interval(8, 10),
                new Interval(15, 18)
            }), Is.EquivalentTo(new[]
            {
                new Interval(1, 6),
                new Interval(8, 10),
                new Interval(15, 18)
            }).Using<Interval, Interval>(IntervalComparer));
        }

        [Test]
        public void AcceptanceTest2()
        {
            Assert.That(new Solution().Merge(new[]
            {
                new Interval(1, 4),
                new Interval(4, 5)
            }), Is.EquivalentTo(new[]
            {
                new Interval(1, 5)
            }).Using<Interval, Interval>(IntervalComparer));
        }

        private static bool IntervalComparer(Interval interval1, Interval interval2)
        {
            return interval1.start == interval2.start && interval1.end == interval2.end;
        }
    }
}