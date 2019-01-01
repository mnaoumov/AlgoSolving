using NUnit.Framework;

namespace AlgoSolving.Task221_Maximal_Square
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            var matrix = new[,]
            {
                {'1', '0', '1', '0', '0'},
                {'1', '0', '1', '1', '1'},
                {'1', '1', '1', '1', '1'},
                {'1', '0', '0', '1', '0'}
            };
            Assert.That(new Solution().MaximalSquare(matrix), Is.EqualTo(4));
        }
    }
}