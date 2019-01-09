using NUnit.Framework;

namespace AlgoSolving.Task49_Group_Anagram
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().GroupAnagrams(new[] { "eat", "tea", "tan", "ate", "nat", "bat" }),
                TestHelper.IsEquivalentTo(new[]
                {
                    new[] { "ate", "eat", "tea" },
                    new[] { "nat", "tan" },
                    new[] { "bat" }
                }));
        }
    }
}