using NUnit.Framework;

namespace AlgoSolving.Task79_Word_Search
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            var board = new[,]
            {
                {'A', 'B', 'C', 'E'},
                {'S', 'F', 'C', 'S'},
                {'A', 'D', 'E', 'E'}
            };

            Assert.Multiple(() =>
            {
                Assert.That(new Solution().Exist(board, "ABCCED"), Is.True);
                Assert.That(new Solution().Exist(board, "SEE"), Is.True);
                Assert.That(new Solution().Exist(board, "ABCB"), Is.True);
            });
        }
    }
}