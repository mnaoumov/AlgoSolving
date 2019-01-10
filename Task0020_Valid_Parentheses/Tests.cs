using NUnit.Framework;

namespace AlgoSolving.Task0020_Valid_Parentheses
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().IsValid("()"), Is.True);
        }

        [Test]
        public void AcceptanceTest2()
        {
            Assert.That(new Solution().IsValid("()[]{}"), Is.True);
        }

        [Test]
        public void AcceptanceTest3()
        {
            Assert.That(new Solution().IsValid("(]"), Is.False);
        }

        [Test]
        public void AcceptanceTest4()
        {
            Assert.That(new Solution().IsValid("([)]"), Is.False);
        }

        [Test]
        public void AcceptanceTest5()
        {
            Assert.That(new Solution().IsValid("{[]}"), Is.True);
        }
    }
}