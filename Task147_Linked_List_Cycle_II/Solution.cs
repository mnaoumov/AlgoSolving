namespace AlgoSolving.Task147_Linked_List_Cycle_II
{

    // Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }
 
    public class Solution
    {
        public ListNode DetectCycle(ListNode head)
        {
            var slowNodeCrawler = head;
            var fastNodeCrawler = head.next;

            while (fastNodeCrawler != null && fastNodeCrawler.next != null && fastNodeCrawler != slowNodeCrawler)
            {
                slowNodeCrawler = slowNodeCrawler.next;
                fastNodeCrawler = fastNodeCrawler.next.next;
            }

            if (fastNodeCrawler == null || fastNodeCrawler.next == null)
            {
                return null;
            }

            var cycleFinderAheadCrawler = head;

            do
            {
                slowNodeCrawler = slowNodeCrawler.next;
                fastNodeCrawler = fastNodeCrawler.next.next;
                cycleFinderAheadCrawler = cycleFinderAheadCrawler.next;
            } while (fastNodeCrawler != slowNodeCrawler);

            var cycleFinderBehindCrawler = head;

            while (cycleFinderBehindCrawler != cycleFinderAheadCrawler)
            {
                cycleFinderBehindCrawler = cycleFinderBehindCrawler.next;
                cycleFinderAheadCrawler = cycleFinderAheadCrawler.next;
            }

            return cycleFinderBehindCrawler;
        }
    }
}