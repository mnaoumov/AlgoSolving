using NUnit.Framework;

namespace AlgoSolving.Task152_Maximum_Product_Subarray
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().MaxProduct(new[] { 2, 3, -2, 4 }), Is.EqualTo(6));
        }

        [Test]
        public void AcceptanceTest2()
        {
            Assert.That(new Solution().MaxProduct(new[] { -2, 0, -1 }), Is.EqualTo(0));
        }

        [Test]
        public void AcceptanceTest3()
        {
            Assert.That(new Solution().MaxProduct(new[] { 0, 2 }), Is.EqualTo(2));
        }

        [Test]
        public void AcceptanceTest4()
        {
            Assert.That(new Solution().MaxProduct(new[] { -4, -3, -2 }), Is.EqualTo(12));
        }
    }
}