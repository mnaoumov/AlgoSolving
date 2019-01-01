using System.Linq;

namespace AlgoSolving.Task31_Next_Permutation
{
    public class Solution
    {
        public void NextPermutation(int[] nums)
        {
            if (nums.Length < 2)
            {
                return;
            }

            var lastLocalMaximum = nums.Length - 1;

            while (lastLocalMaximum > 0 && nums[lastLocalMaximum] < nums[lastLocalMaximum - 1])
            {
                lastLocalMaximum--;
            }

            var copy = nums.ToArray();

            if (lastLocalMaximum > 0)
            {
                nums[lastLocalMaximum - 1] = copy[nums.Length - 1];
                nums[lastLocalMaximum] = copy[lastLocalMaximum - 1];
                for (int i = lastLocalMaximum + 1; i < nums.Length; i++)
                {
                    nums[i] = copy[nums.Length - 1 - (i - lastLocalMaximum)];
                }
            }
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    nums[i] = copy[nums.Length - 1 - i];
                }
            }
        }
    }
}