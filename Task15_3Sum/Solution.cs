using System;
using System.Collections.Generic;

namespace AlgoSolving.Task15_3Sum
{
    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var set = new HashSet<int>(nums);
            var keys = new HashSet<string>();

            var results = new List<IList<int>>();

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    var first = nums[i];
                    var second = nums[j];
                    var third = -(first + second);
                    if (set.Contains(third))
                    {
                        var triplet = new[] { first, second, third };
                        Array.Sort(triplet);
                        var key = string.Join(",", triplet);

                        if (!keys.Contains(key))
                        {
                            results.Add(triplet);
                            keys.Add(key);
                        }

                    }
                }
            }

            return results;
        }
    }
}