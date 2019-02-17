using NUnit.Framework;

namespace AlgoSolving.Task0421_Maximum_XOR_of_Two_Numbers_in_an_Array
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().FindMaximumXOR(new[] { 3, 10, 5, 25, 2, 8 }), Is.EqualTo(28));
        }
    }
}