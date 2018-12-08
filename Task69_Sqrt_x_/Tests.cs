using NUnit.Framework;

namespace AlgoSolving.Task69_Sqrt_x_
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().MySqrt(4), Is.EqualTo(2));
        }

        [Test]
        public void AcceptanceTest2()
        {
            Assert.That(new Solution().MySqrt(8), Is.EqualTo(2));
        }

        [Test]
        public void Avoid_dividing_by_zero()
        {
            Assert.That(() => new Solution().MySqrt(1), Throws.Nothing);
        }

        [Test, Timeout(1000)]
        public void No_timeout()
        {
            Assert.That(new Solution().MySqrt(2147395600), Is.EqualTo(46340));
        }
    }
}