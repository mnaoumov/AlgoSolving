using NUnit.Framework;

namespace AlgoSolving.Task301_Remove_Invalid_Parentheses
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().RemoveInvalidParentheses("()())()"),
                Is.EquivalentTo(new[] { "()()()", "(())()" }));
        }

        [Test]
        public void AcceptanceTest2()
        {
            Assert.That(new Solution().RemoveInvalidParentheses("(a)())()"),
                Is.EquivalentTo(new[] { "(a)()()", "(a())()" }));
        }

        [Test]
        public void AcceptanceTest3()
        {
            Assert.That(new Solution().RemoveInvalidParentheses(")("),
                Is.EquivalentTo(new[] { "" }));
        }
    }
}