using System;
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

        [Test]
        public void After_last_task_left_rest_has_to_filled_with_blanks()
        {
            Assert.That(new Solution().LeastInterval(new[] { 'A', 'A', 'A', 'A', 'A', 'A', 'B', 'C', 'D', 'E', 'F', 'G' }, 2), Is.EqualTo(16));
        }

        [Test]
        public void For_zero_cooling_should_output_length()
        {
            Assert.That(new Solution().LeastInterval(new[] { 'A', 'A', 'A', 'B', 'B', 'B' },0), Is.EqualTo(6));
        }
    }
}