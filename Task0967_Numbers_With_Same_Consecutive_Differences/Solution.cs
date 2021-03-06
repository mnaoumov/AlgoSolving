﻿using System.Collections.Generic;
using System.Linq;

namespace AlgoSolving.Task0967_Numbers_With_Same_Consecutive_Differences
{
    public class Solution
    {
        // ReSharper disable InconsistentNaming
        public int[] NumsSameConsecDiff(int N, int K)
        // ReSharper restore InconsistentNaming
        {
            if (N == 1)
            {
                return Enumerable.Range(0, 10).ToArray();
            }

            var results = Enumerable.Range(1, 9).ToList();
            for (int i = 1; i < N; i++)
            {
                var nextResults = new List<int>();
                foreach (var result in results)
                {
                    var digit = result % 10;
                    if (K != 0 && digit >= K)
                    {
                        nextResults.Add(10 * result + digit - K);
                    }

                    if (digit <= 9 - K)
                    {
                        nextResults.Add(10 * result + digit + K);
                    }
                }

                results = nextResults;
            }

            return results.ToArray();
        }
    }
}