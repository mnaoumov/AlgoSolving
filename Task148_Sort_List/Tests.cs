using NUnit.Framework;

namespace AlgoSolving.Task148_Sort_List
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            var head = new ListNode(4)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(1)
                    {
                        next = new ListNode(3)
                    }
                }
            };
            var afterSorting = new Solution().SortList(head);
            Assert.Multiple(() =>
            {
                Assert.That(afterSorting.val, Is.EqualTo(1));
                Assert.That(afterSorting.next.val, Is.EqualTo(2));
                Assert.That(afterSorting.next.next.val, Is.EqualTo(3));
                Assert.That(afterSorting.next.next.next.val, Is.EqualTo(4));
                Assert.That(afterSorting.next.next.next.next, Is.Null);
            });
        }

        [Test]
        public void AcceptanceTest2()
        {
            var head = new ListNode(-1)
            {
                next = new ListNode(5)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                        {
                            next = new ListNode(0)
                        }
                    }
                }
            };
            var afterSorting = new Solution().SortList(head);
            Assert.Multiple(() =>
            {
                Assert.That(afterSorting.val, Is.EqualTo(-1));
                Assert.That(afterSorting.next.val, Is.EqualTo(0));
                Assert.That(afterSorting.next.next.val, Is.EqualTo(3));
                Assert.That(afterSorting.next.next.next.val, Is.EqualTo(4));
                Assert.That(afterSorting.next.next.next.next.val, Is.EqualTo(5));
                Assert.That(afterSorting.next.next.next.next.next, Is.Null);
            });        }
    }
}