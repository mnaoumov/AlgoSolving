using NUnit.Framework;

namespace AlgoSolving.Task207_Course_Schedule
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().CanFinish(2, new[,]
            {
                { 1, 0 }
            }), Is.True);
        }

        [Test]
        public void AcceptanceTest2()
        {
            Assert.That(new Solution().CanFinish(2, new[,]
            {
                { 1, 0 },
                { 0, 1 }
            }), Is.False);
        }
    }
}