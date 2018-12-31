using NUnit.Framework;

namespace AlgoSolving.Task19_Remove_Nth_Node_From_End_of_List
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            var head = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                        {
                            next = new ListNode(5)
                        }
                    }
                }
            };
            var afterRemoval = new Solution().RemoveNthFromEnd(head, 2);
            Assert.Multiple(() =>
            {
                Assert.That(afterRemoval.val, Is.EqualTo(1));
                Assert.That(afterRemoval.next.val, Is.EqualTo(2));
                Assert.That(afterRemoval.next.next.val, Is.EqualTo(3));
                Assert.That(afterRemoval.next.next.next.val, Is.EqualTo(5));
                Assert.That(afterRemoval.next.next.next.next, Is.Null);
            });
        }

        [Test]
        public void Remove_head()
        {
            var head = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                        {
                            next = new ListNode(5)
                        }
                    }
                }
            };
            var afterRemoval = new Solution().RemoveNthFromEnd(head, 5);
            Assert.Multiple(() =>
            {
                Assert.That(afterRemoval.val, Is.EqualTo(2));
                Assert.That(afterRemoval.next.val, Is.EqualTo(3));
                Assert.That(afterRemoval.next.next.val, Is.EqualTo(4));
                Assert.That(afterRemoval.next.next.next.val, Is.EqualTo(5));
                Assert.That(afterRemoval.next.next.next.next, Is.Null);
            });
        }
    }
}