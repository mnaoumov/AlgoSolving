using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace AlgoSolving.Task49_Group_Anagram
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().GroupAnagrams(new[] { "eat", "tea", "tan", "ate", "nat", "bat" }), Is.EquivalentTo(new[]
            {
                new[] {"ate", "eat", "tea"},
                new[] {"nat", "tan"},
                new[] {"bat"}
            }).Using<IList<string>>((strings1, string2) => strings1.Count == string2.Count && !strings1.Except(string2).Any()));
        }
    }
}