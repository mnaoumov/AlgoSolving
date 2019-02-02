using NUnit.Framework;

namespace AlgoSolving.Task0050_Pow_x_n
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().MyPow(2.0, 10), Is.EqualTo(1024.0));
        }

        [Test]
        public void AcceptanceTest2()
        {
            Assert.That(new Solution().MyPow(2.1, 3), Is.EqualTo(9.261));
        }

        [Test]
        public void AcceptanceTest3()
        {
            Assert.That(new Solution().MyPow(2.0, -2), Is.EqualTo(0.25));
        }

        [Test]
        [Timeout(1000)]
        public void Underflow()
        {
            Assert.That(new Solution().MyPow(0.00001, int.MaxValue), Is.EqualTo(0.0));
        }
    }
}