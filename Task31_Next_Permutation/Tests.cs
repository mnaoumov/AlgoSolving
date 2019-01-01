using NUnit.Framework;

namespace AlgoSolving.Task31_Next_Permutation
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            int[] nums = new[] { 1, 2, 3 };
            new Solution().NextPermutation(nums);
            Assert.That(nums, Is.EqualTo(new[] { 1, 3, 2 }));
        }

        [Test]
        public void AcceptanceTest2()
        {
            int[] nums = new[] { 3, 2, 1 };
            new Solution().NextPermutation(nums);
            Assert.That(nums, Is.EqualTo(new[] { 1, 2, 3 }));
        }

        [Test]
        public void AcceptanceTest3()
        {
            int[] nums = new[] { 1, 1, 5 };
            new Solution().NextPermutation(nums);
            Assert.That(nums, Is.EqualTo(new[] { 1, 5, 1 }));
        }

        [Test]
        public void AcceptanceTest4()
        {
            int[] nums = new[] { 1, 3, 2 };
            new Solution().NextPermutation(nums);
            Assert.That(nums, Is.EqualTo(new[] { 2, 1, 3 }));
        }

        [Test]
        public void AcceptanceTest5()
        {
            int[] nums = new[] { 2, 3, 1 };
            new Solution().NextPermutation(nums);
            Assert.That(nums, Is.EqualTo(new[] { 3, 1, 2 }));
        }
    }
}