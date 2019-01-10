using NUnit.Framework;

namespace AlgoSolving.Task0032_Longest_Valid_Parentheses
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().LongestValidParentheses("(()"), Is.EqualTo(2));
        }

        [Test]
        public void AcceptanceTest2()
        {
            Assert.That(new Solution().LongestValidParentheses(")()())"), Is.EqualTo(4));
        }

        [Test]
        public void AcceptanceTest3()
        {
            Assert.That(new Solution().LongestValidParentheses("((()))())"), Is.EqualTo(8));
        }
    }
}