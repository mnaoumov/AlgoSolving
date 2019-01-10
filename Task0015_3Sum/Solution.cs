﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgoSolving.Task0015_3Sum
{
    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
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

            var n = nums.Length;

            for (int i = 0; i < n; i++)
            {
                if (i + 2 < n && nums[i] == nums[i + 2])
                {
                    continue;
                }

                for (int j = i + 1; j < n; j++)
                {
                    if (j > i + 1 && nums[i] == nums[i + 1])
                    {
                        break;
                    }

                    if (j + 1 < n && nums[j] == nums[j + 1])
                    {
                        continue;
                    }

                    var first = nums[i];
                    var second = nums[j];
                    var third = -(first + second);

                    if (third < second)
                    {
                        continue;
                    }

                    var triplet = new[] { first, second, third };

                    if (numCounts.ContainsKey(third) && numCounts[third] >= triplet.Count(x => x == third))
                    {
                        results.Add(triplet);
                    }
                }
            }

            return results;
        }
    }
}