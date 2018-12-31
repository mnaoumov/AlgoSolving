using System;

namespace AlgoSolving.Task34_Find_First_and_Last_Position_of_Element_in_Sorted_Array
{
    public class Solution
    {
        public int[] SearchRange(int[] nums, int target)
        {
            const int notFoundIndex = -1;

            int firstIndex = notFoundIndex;
            var lastIndex = notFoundIndex;

            var left = 0;
            var right = nums.Length;

            while (left < right)
            {
                var middle = (left + right) / 2;
                if (nums[middle] < target)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }

            if (nums[left + 1] == target)
            {
                firstIndex = left + 1;
            }

            left = 0;
            right = nums.Length;

            while (left < right)
            {
                var middle = (left + right) / 2;
                if (nums[middle] <= target)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }

            if (nums[left] == target)
            {
                lastIndex = left;
            }

            return new[] { firstIndex, lastIndex };
        }
    }
}