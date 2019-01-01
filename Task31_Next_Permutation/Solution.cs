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
                Swap(nums, i, nums.Length - 1 - i + lastLocalMaximum);
            }

            if (lastLocalMaximum > 0)
            {
                Swap(nums, lastLocalMaximum - 1, lastLocalMaximum);
            }
        }

        private static void Swap(int[] nums, int i, int j)
        {
            (nums[i], nums[j]) = (nums[j], nums[i]);
        }
    }
}