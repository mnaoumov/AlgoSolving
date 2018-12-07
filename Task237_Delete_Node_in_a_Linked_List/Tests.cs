using NUnit.Framework;

namespace AlgoSolving.Task237_Delete_Node_in_a_Linked_List
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            ListNode nodeToDelete;
            ListNode head = new ListNode(4)
            {
                next = nodeToDelete = new ListNode(5)
                {
                    next = new ListNode(1)
                    {
                        next = new ListNode(9)
                    }
                }
            };

            new Solution().DeleteNode(nodeToDelete);
            Assert.Multiple(() =>
            {
                Assert.That(head.val, Is.EqualTo(4));
                Assert.That(head.next.val, Is.EqualTo(1));
                Assert.That(head.next.next.val, Is.EqualTo(9));
                Assert.That(head.next.next.next, Is.Null);
            });
        }

        [Test]
        public void AcceptanceTest2()
        {
            ListNode nodeToDelete;
            ListNode head = new ListNode(4)
            {
                next = new ListNode(5)
                {
                    next = nodeToDelete = new ListNode(1)
                    {
                        next = new ListNode(9)
                    }
                }
            };

            new Solution().DeleteNode(nodeToDelete);
            Assert.Multiple(() =>
            {
                Assert.That(head.val, Is.EqualTo(4));
                Assert.That(head.next.val, Is.EqualTo(5));
                Assert.That(head.next.next.val, Is.EqualTo(9));
                Assert.That(head.next.next.next, Is.Null);
            });
        }
    }
}