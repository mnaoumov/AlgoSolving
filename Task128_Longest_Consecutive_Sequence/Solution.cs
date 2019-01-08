using System;
using System.Collections.Generic;

namespace AlgoSolving.Task128_Longest_Consecutive_Sequence
{
    public class Solution
    {
        public int LongestConsecutive(int[] nums)
        {
            var result = 0;

            var ranges = new Dictionary<int, (int left, int right)>();

            foreach (var num in nums)
            {
                if (ranges.ContainsKey(num))
                {
                    continue;
                }

                var left = num;
                var right = num;

                if (ranges.ContainsKey(num + 1))
                {
                    right = ranges[num + 1].right;
                }

                if (ranges.ContainsKey(num - 1))
                {
                    left = ranges[num - 1].left;
                }

                ranges[num] = (left, right);

                if (ranges.ContainsKey(num + 1))
                {
                    ranges[num + 1] = (left, right);
                }

                if (ranges.ContainsKey(num - 1))
                {
                    ranges[num - 1] = (left, right);
                }

                result = Math.Max(result, right - left + 1);
            }

            return result;
        }
    }
}