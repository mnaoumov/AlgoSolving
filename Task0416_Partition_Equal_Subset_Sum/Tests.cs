using NUnit.Framework;

namespace AlgoSolving.Task0416_Partition_Equal_Subset_Sum
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().CanPartition(new[] { 1, 5, 11, 5 }), Is.True);
        }

        [Test]
        public void AcceptanceTest2()
        {
            Assert.That(new Solution().CanPartition(new[] { 1, 2, 3, 5 }), Is.False);
        }

        [Test]
        public void Memory_not_exceeded()
        {
            var bigArray = new[]
            {
                100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100,
                100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100,
                100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100,
                100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100,
                100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100
            };

            Assert.That(() => new Solution().CanPartition(bigArray), Throws.Nothing);
        }
    }
}