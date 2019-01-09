﻿using System;
using System.Collections.Generic;

namespace AlgoSolving.Task15_3Sum
{
    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var numCounts = new Dictionary<int, int>();

            foreach (var num in nums)
            {
                if (!numCounts.ContainsKey(num))
                {
                    numCounts[num] = 0;
                }

                numCounts[num]++;
            }

            var keys = new HashSet<string>();

            var results = new List<IList<int>>();

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    var first = nums[i];
                    var second = nums[j];
                    var third = -(first + second);
                    int requiredCount;

                    if (third != first && third != second)
                    {
                        requiredCount = 1;
                    }
                    else if (third == first && third == second)
                    {
                        requiredCount = 3;
                    }
                    else
                    {
                        requiredCount = 2;
                    }

                    if (numCounts.ContainsKey(third) && numCounts[third] >= requiredCount)
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