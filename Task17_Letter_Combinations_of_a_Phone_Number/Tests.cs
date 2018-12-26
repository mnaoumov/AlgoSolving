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
    }
}