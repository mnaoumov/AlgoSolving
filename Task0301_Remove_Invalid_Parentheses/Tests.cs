using NUnit.Framework;

namespace AlgoSolving.Task0301_Remove_Invalid_Parentheses
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

        [Test]
        public void AcceptanceTest4()
        {
            Assert.That(new Solution().RemoveInvalidParentheses(")()))())))"),
                Is.EquivalentTo(new[] { "(())", "()()" }));
        }

        [Test]
        public void Open_bracket_removal_not_empty()
        {
            Assert.That(new Solution().RemoveInvalidParentheses("(a(b()"),
                Is.EquivalentTo(new[] { "(ab)", "a(b)", "ab()" }));
        }
    }
}