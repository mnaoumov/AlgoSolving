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

            Assert.That(new Solution().Exist(board, "ABCCED"), Is.True);
        }

        [Test]
        public void AcceptanceTest2()
        {
            var board = new[,]
            {
                {'A', 'B', 'C', 'E'},
                {'S', 'F', 'C', 'S'},
                {'A', 'D', 'E', 'E'}
            };

            Assert.That(new Solution().Exist(board, "SEE"), Is.True);
        }

        [Test]
        public void AcceptanceTest3()
        {
            var board = new[,]
            {
                {'A', 'B', 'C', 'E'},
                {'S', 'F', 'C', 'S'},
                {'A', 'D', 'E', 'E'}
            };

            Assert.That(new Solution().Exist(board, "ABCB"), Is.False);
        }

        [Test]
        public void AcceptanceTest4()
        {
            var board = new[,]
            {
                {'A'}
            };

            Assert.That(new Solution().Exist(board, "A"), Is.True);
        }
    }
}