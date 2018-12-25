using NUnit.Framework;

namespace AlgoSolving.Task279_Perfect_Squares
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
           Assert.That(new Solution().NumSquares(12), Is.EqualTo(3));
        }

        [Test]
        public void AcceptanceTest2()
        {
           Assert.That(new Solution().NumSquares(13), Is.EqualTo(2));
        }
    }
}