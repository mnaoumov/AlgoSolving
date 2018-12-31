﻿using System;

namespace AlgoSolving.Task34_Find_First_and_Last_Position_of_Element_in_Sorted_Array
{
    public class Solution
    {
        public int[] SearchRange(int[] nums, int target)
        {
            const int notFoundIndex = -1;

            var firstIndex = FindLast(nums, x => x < target) + 1;
            var lastIndex = FindLast(nums, x => x <= target);

            if (firstIndex >= nums.Length || nums[firstIndex] != target)
            {
                firstIndex = notFoundIndex;
            }

            if (lastIndex >= nums.Length || nums[lastIndex] != target)
            {
                lastIndex = notFoundIndex;
            }

            return new[] { firstIndex, lastIndex };
        }

        private static int FindLast(int[] nums, Func<int, bool> condition)
        {
            var left = 0;
            var right = nums.Length;

            while (right - left > 1)
            {
                var middle = (left + right) / 2;

                if (condition(nums[middle]))
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }

            return left;
        }
    }
}