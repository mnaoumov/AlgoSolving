using NUnit.Framework;

namespace AlgoSolving.Task0289_Game_of_Life
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            var board = new[]
            {
                new[] { 0, 1, 0 },
                new[] { 0, 0, 1 },
                new[] { 1, 1, 1 },
                new[] { 0, 0, 0 }
            };
            new Solution().GameOfLife(board);

            Assert.That(board, Is.EqualTo(new[]
            {
                new[] { 0, 0, 0 },
                new[] { 1, 0, 1 },
                new[] { 0, 1, 1 },
                new[] { 0, 1, 0 }
            }));
        }
    }
}