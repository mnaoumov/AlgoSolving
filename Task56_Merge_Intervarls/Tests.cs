using NUnit.Framework;

namespace AlgoSolving.Task56_Merge_Intervarls
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().Merge(new[]
            {
                new Interval(1, 3),
                new Interval(2, 6),
                new Interval(8, 10),
                new Interval(15, 18)
            }), Is.EqualTo(new[]
            {
                new Interval(1, 6),
                new Interval(8, 10),
                new Interval(8, 10),
                new Interval(15, 18)
            }));
        }

        [Test]
        public void AcceptanceTest2()
        {
            Assert.That(new Solution().Merge(new[]
            {
                new Interval(1, 4),
                new Interval(4, 5)
            }), Is.EqualTo(new[]
            {
                new Interval(1, 5)
            }));
        }
    }
}