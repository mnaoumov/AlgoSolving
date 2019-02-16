using NUnit.Framework;

namespace AlgoSolving.Task975_Odd_Even_Jump
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().OddEvenJumps(new[] { 10, 13, 12, 14, 15 }), Is.EqualTo(2));
        }

        [Test]
        public void AcceptanceTest2()
        {
            Assert.That(new Solution().OddEvenJumps(new[] { 2, 3, 1, 1, 4 }), Is.EqualTo(3));
        }

        [Test]
        public void AcceptanceTest3()
        {
            Assert.That(new Solution().OddEvenJumps(new[] { 5, 1, 3, 4, 2 }), Is.EqualTo(3));
        }
    }
}