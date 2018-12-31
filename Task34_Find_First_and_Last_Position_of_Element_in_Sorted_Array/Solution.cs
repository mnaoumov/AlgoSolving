using System;

namespace AlgoSolving.Task34_Find_First_and_Last_Position_of_Element_in_Sorted_Array
{
    public class Solution
    {
        public int[] SearchRange(int[] nums, int target)
        {
            var firstIndex = SearchRange(nums, target, x => x < target);
            var lastIndex = SearchRange(nums, target, x => x <= target);

            return new[] { firstIndex, lastIndex };
        }

        private static int SearchRange(int[] nums, int target, Func<int, bool> leftPartCondition)
        {
            var left = 0;
            var right = nums.Length - 1;

            while (left < right)
            {
                var middle = (left + right) / 2;
                if (leftPartCondition(nums[middle]))
                {
                    left = middle;
                }
                else
                {
                    right = middle;
                }
            }

            if (nums[left] == target)
            {
                return left;
            }

            const int notFoundIndex = -1;
            return notFoundIndex;
        }
    }
}