using System;

namespace AlgoSolving.Task34_Find_First_and_Last_Position_of_Element_in_Sorted_Array
{
    public class Solution
    {
        public int[] SearchRange(int[] nums, int target)
        {
            const int notFoundIndex = -1;

            if (nums.Length == 0 || nums[0] > target || nums[nums.Length - 1] < target)
            {
                return new[] { notFoundIndex, notFoundIndex };
            }

            var left = 0;
            var right = nums.Length;

            while (right - left > 1)
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

            if (right < nums.Length && nums[right] == target)
            {
                return new[] { right, right };
            }

            return new[] { notFoundIndex, notFoundIndex };
        }
    }
}