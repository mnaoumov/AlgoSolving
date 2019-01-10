using NUnit.Framework;

namespace AlgoSolving.Task0967_Numbers_With_Same_Consecutive_Differences
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().NumsSameConsecDiff(3, 7), Is.EqualTo(new[] { 181, 292, 707, 818, 929 }));
        }

        [Test]
        public void AcceptanceTest2()
        {
            Assert.That(new Solution().NumsSameConsecDiff(2, 1),
                Is.EqualTo(new[] { 10, 12, 21, 23, 32, 34, 43, 45, 54, 56, 65, 67, 76, 78, 87, 89, 98 }));
        }

        [Test]
        public void Zero_should_be_included()
        {
            Assert.That(new Solution().NumsSameConsecDiff(1, 0),
                Is.EqualTo(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }));
        }

        [Test]
        public void No_duplicates()
        {
            Assert.That(new Solution().NumsSameConsecDiff(2, 0),
                Is.EqualTo(new[] { 11, 22, 33, 44, 55, 66, 77, 88, 99 }));
        }
    }
}