using NUnit.Framework;

namespace AlgoSolving.Task621_Task_Scheduler
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().LeastInterval(new[] { 'A', 'A', 'A', 'B', 'B', 'B' }, 2), Is.EqualTo(8));
        }
    }
}