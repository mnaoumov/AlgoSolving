using NUnit.Framework;

namespace AlgoSolving.Task0146_LRU_Cache
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            LRUCache cache = new LRUCache(2 /* capacity */ );

            Assert.Multiple(() =>
            {
                cache.Put(1, 1);
                cache.Put(2, 2);
                Assert.That(cache.Get(1), Is.EqualTo(1));
                cache.Put(3, 3);    // evicts key 2
                Assert.That(cache.Get(2), Is.EqualTo(-1));
                cache.Put(4, 4);    // evicts key 1
                Assert.That(cache.Get(1), Is.EqualTo(-1));
                Assert.That(cache.Get(3), Is.EqualTo(3));
                Assert.That(cache.Get(4), Is.EqualTo(4));
            });
        }
    }
}