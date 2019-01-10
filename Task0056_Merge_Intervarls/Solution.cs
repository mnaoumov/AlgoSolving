using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgoSolving.Task0056_Merge_Intervarls
{
    public class Solution
    {
        public IList<Interval> Merge(IList<Interval> intervals)
        {
            var results = intervals.OrderBy(x => x.start).ThenBy(x => x.end).ToList();

            for (int i = 1; i < results.Count; i++)
            {
                var previous = results[i - 1];
                var current = results[i];
                if (current.start <= previous.end)
                {
                    results[i - 1] = new Interval(previous.start, Math.Max(previous.end, current.end));
                    results.RemoveAt(i);
                    i--;
                }
            }

            return results;
        }
    }
}