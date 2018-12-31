namespace AlgoSolving.Task148_Sort_List
{
    public class Solution
    {
        public ListNode SortList(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            var middle = GetMiddleNode(head);
            var nextAfterMiddle = middle.next;
            middle.next = null;
            var leftHalfSortedHead = SortList(head);
            var rightHalfSortedHead = SortList(nextAfterMiddle);

            var mergedSortedHead = MergeSorted(leftHalfSortedHead, rightHalfSortedHead);
            return mergedSortedHead;
        }

        private ListNode MergeSorted(ListNode sortedHead1, ListNode sortedHead2)
        {
            if (sortedHead1 == null)
            {
                return sortedHead2;
            }

            if (sortedHead2 == null)
            {
                return sortedHead1;
            }

            if (sortedHead1.val > sortedHead2.val)
            {
                (sortedHead1, sortedHead2) = (sortedHead2, sortedHead1);
            }

            sortedHead1.next = MergeSorted(sortedHead1.next, sortedHead2);

            return sortedHead1;
        }

        private static ListNode GetMiddleNode(ListNode head)
        {
            var slowPointer = head;
            var fastPointer = head.next;

            while (fastPointer.next != null)
            {
                slowPointer = slowPointer.next;
                fastPointer = fastPointer.next.next;
            }

            return slowPointer;
        }
    }
}