using System.Collections.Generic;
using NUnit.Framework;

namespace AlgoSolving.Task49_Group_Anagram
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().GroupAnagrams(new[] { "eat", "tea", "tan", "ate", "nat", "bat" }),
                TestHelper.IsEquivalentTo(new IList<string>[]
                {
                    new[] { "ate", "eat", "tea" },
                    new[] { "nat", "tan" },
                    new[] { "bat" }
                }));
        }
    }
}