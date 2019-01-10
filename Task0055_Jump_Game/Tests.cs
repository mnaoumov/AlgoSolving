using NUnit.Framework;

namespace AlgoSolving.Task0055_Jump_Game
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().CanJump(new[] { 2, 3, 1, 1, 4 }), Is.True);
        }

        [Test]
        public void AcceptanceTest2()
        {
            Assert.That(new Solution().CanJump(new[] { 3, 2, 1, 0, 4 }), Is.False);
        }
    }
}