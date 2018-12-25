using NUnit.Framework;

namespace AlgoSolving.Task200_Number_of_Islands
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().NumIslands(new[,]
            {
                {'1', '1', '1', '1', '0'}, 
                {'1', '1', '0', '1', '0'},
                {'1', '1', '0', '0', '0'},
                {'0', '0', '0', '0', '0'}
            }), Is.EqualTo(1));
        }

        [Test]
        public void AcceptanceTest2()
        {
            Assert.That(new Solution().NumIslands(new[,]
            {
                {'1', '1', '0', '0', '0'},
                {'1', '1', '0', '0', '0'},
                {'0', '0', '1', '0', '0'},
                {'0', '0', '0', '1', '1'}
            }), Is.EqualTo(3));
        }
    }
}