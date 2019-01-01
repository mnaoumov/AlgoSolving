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

            for (int i = lastLocalMaximum; i < (nums.Length - 1 + lastLocalMaximum) / 2; i++)
            {
                var nextI = nums.Length - 1 - i + lastLocalMaximum;

                (nums[i], nums[nextI]) = (nums[nextI], nums[i]);
            }

            if (lastLocalMaximum > 0)
            {
                (nums[lastLocalMaximum - 1], nums[lastLocalMaximum]) =
                    (nums[lastLocalMaximum], nums[lastLocalMaximum - 1]);
            }
        }
    }
}