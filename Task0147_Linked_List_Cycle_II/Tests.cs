using NUnit.Framework;

namespace AlgoSolving.Task0147_Linked_List_Cycle_II
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            ListNode cycleNode;
            ListNode tailNode;
            var head = new ListNode(3)
            {
                next = cycleNode = new ListNode(2)
                {
                    next = new ListNode(0)
                    {
                        next = tailNode = new ListNode(-4)
                    }
                }
            };
            tailNode.next = cycleNode;

            Assert.That(new Solution().DetectCycle(head), Is.EqualTo(cycleNode));
        }

        [Test]
        public void AcceptanceTest2()
        {
            ListNode cycleNode;
            ListNode tailNode;
            var head = cycleNode = new ListNode(1)
            {
                next = tailNode = new ListNode(2)
            };
            tailNode.next = cycleNode;

            Assert.That(new Solution().DetectCycle(head), Is.EqualTo(cycleNode));
        }

        [Test]
        public void AcceptanceTest3()
        {
            Assert.That(new Solution().DetectCycle(new ListNode(1)), Is.EqualTo(null));
        }

        [Test]
        public void Work_for_empty_list()
        {
            Assert.That(new Solution().DetectCycle(null), Is.EqualTo(null));
        }
    }
}