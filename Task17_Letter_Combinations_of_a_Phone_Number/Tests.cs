using NUnit.Framework;

namespace AlgoSolving.Task17_Letter_Combinations_of_a_Phone_Number
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().LetterCombinations("23"),
                Is.EquivalentTo(new[] { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" }));
        }

        [Test]
        public void Empty_string_returns_empty_list()
        {
            Assert.That(new Solution().LetterCombinations(""), Is.Empty);
        }
    }
}