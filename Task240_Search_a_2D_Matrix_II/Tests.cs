using NUnit.Framework;

namespace AlgoSolving.Task240_Search_a_2D_Matrix_II
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().SearchMatrix(new[,]
            {
                {1, 4, 7, 11, 15},
                {2, 5, 8, 12, 19},
                {3, 6, 9, 16, 22},
                {10, 13, 14, 17, 24},
                {18, 21, 23, 26, 30}
            }, 5), Is.True);
        }

        [Test]
        public void AcceptanceTest2()
        {
            Assert.That(new Solution().SearchMatrix(new[,]
            {
                {1, 4, 7, 11, 15},
                {2, 5, 8, 12, 19},
                {3, 6, 9, 16, 22},
                {10, 13, 14, 17, 24},
                {18, 21, 23, 26, 30}
            }, 20), Is.False);
        }
    }
}