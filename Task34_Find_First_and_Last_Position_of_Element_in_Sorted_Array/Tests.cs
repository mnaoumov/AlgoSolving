using NUnit.Framework;

namespace AlgoSolving.Task34_Find_First_and_Last_Position_of_Element_in_Sorted_Array
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().SearchRange(new[] { 5, 7, 7, 8, 8, 10 }, 8), Is.EqualTo(new[] { 3, 4 }));
        }

        [Test]
        public void AcceptanceTest2()
        {
            Assert.That(new Solution().SearchRange(new[] { 5, 7, 7, 8, 8, 10 }, 6), Is.EqualTo(new[] { -1, -1 }));
        }

        [Test]
        public void Empty_array()
        {
            Assert.That(new Solution().SearchRange(new int[] { }, 0), Is.EqualTo(new[] { -1, -1 }));
        }
    }
}