using NUnit.Framework;

namespace AlgoSolving.Task23_Merge_k_Sorted_Lists
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            var list1 = new ListNode(1)
            {
                next = new ListNode(4)
                {
                    next = new ListNode(5)
                }
            };

            var list2 = new ListNode(1)
            {
                next = new ListNode(3)
                {
                    next = new ListNode(4)
                }
            };

            var list3 = new ListNode(2)
            {
                next = new ListNode(6)
            };

            var merged = new Solution().MergeKLists(new[] { list1, list2, list3 });

            Assert.Multiple(() =>
            {
                Assert.That(merged.val, Is.EqualTo(1));
                Assert.That(merged.next.val, Is.EqualTo(1));
                Assert.That(merged.next.next.val, Is.EqualTo(2));
                Assert.That(merged.next.next.next.val, Is.EqualTo(3));
                Assert.That(merged.next.next.next.next.val, Is.EqualTo(4));
                Assert.That(merged.next.next.next.next.next.val, Is.EqualTo(4));
                Assert.That(merged.next.next.next.next.next.next.val, Is.EqualTo(5));
                Assert.That(merged.next.next.next.next.next.next.next.val, Is.EqualTo(6));
                Assert.That(merged.next.next.next.next.next.next.next.next, Is.Null);
            });
        }
    }
}