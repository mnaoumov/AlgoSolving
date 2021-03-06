﻿using System;

namespace AlgoSolving.Task0621_Task_Scheduler
{
    public class Solution
    {
        public int LeastInterval(char[] tasks, int n)
        {
            int[] counts = new int[26];

            foreach (var task in tasks)
            {
                counts[task - 'A']++;
            }

            Array.Sort(counts);
            Array.Reverse(counts);

            var result = 0;

            while (counts[0] > 0)
            {
                int i;
                for (i = 0; i <= n && counts[i] > 0; i++)
                {
                    counts[i]--;
                    result++;
                }

                if (counts[0] == 0 && counts[i] == 0)
                {
                    break;
                }

                result += n + 1 - i;
                
                Array.Sort(counts);
                Array.Reverse(counts);
            }

            return result;
        }
    }
}