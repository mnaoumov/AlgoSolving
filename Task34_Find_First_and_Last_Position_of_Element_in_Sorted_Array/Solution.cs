using System;

namespace AlgoSolving.Task34_Find_First_and_Last_Position_of_Element_in_Sorted_Array
{
    public class Solution
    {
        public int[] SearchRange(int[] nums, int target)
        {
            const int notFoundIndex = -1;
            var notFoundResult = new[] { notFoundIndex, notFoundIndex };

            if (nums.Length == 0 || nums[0] > target || nums[nums.Length - 1] < target)
            {
                return notFoundResult;
            }

            var left = 0;
            var right = nums.Length - 1;

            while (left < right)
            {
                var middle = (left + right) / 2;
                var value = nums[middle];

                if (value < target)
                {
                    left = middle + 1;
                }
                else if (value > target)
                {
                    right = middle - 1;
                }
                else
                {
                    right = middle;
                }
            }

            if (nums[right] != target)
            {
                return notFoundResult;
            }

            var firstIndex = right;

            left = 0;
            right = nums.Length - 1;

            while (left < right)
            {
                var middle = (left + right) / 2;
                var value = nums[middle];

                if (value < target)
                {
                    left = middle + 1;
                }
                else if (value > target)
                {
                    right = middle - 1;
                }
                else if (left == middle)
                {
                    break;
                }
                else
                {
                    left = middle;
                }
            }

            var lastIndex = left;

            return new[] { firstIndex, lastIndex };

        }
    }
}