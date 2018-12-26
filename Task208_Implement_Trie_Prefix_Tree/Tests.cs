using NUnit.Framework;

namespace AlgoSolving.Task208_Implement_Trie_Prefix_Tree
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Trie trie = new Trie();
            trie.Insert("apple");
            Assert.Multiple(() =>
            {
                Assert.That(trie.Search("apple"), Is.True);
                Assert.That(trie.Search("app"), Is.False);
                Assert.That(trie.StartsWith("app"), Is.True);
            });
        }

        [Test]
        public void AcceptanceTest2()
        {
            Trie trie = new Trie();
            trie.Insert("apple");
            trie.Insert("app");
            Assert.That(trie.Search("app"), Is.True);
        }

        [Test]
        public void Should_not_fail()
        {
            Assert.That(() =>
            {
                var trie = new Trie();
                trie.Search("ab");
                trie.Insert("ab");
                trie.Search("ab");
                trie.Search("ab");
                trie.StartsWith("ab");
                trie.StartsWith("ab");
            }, Throws.Nothing);
        }
    }
}