﻿namespace AlgoSolving.Task0147_Linked_List_Cycle_II
{
    public class Solution
    {
        public ListNode DetectCycle(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

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