namespace AlgoSolving.Task0560_Subarray_Sum_Equals_K
{
    public class Solution
    {
        public int SubarraySum(int[] nums, int k)
        {
            var result = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                var sum = 0;
                for (int j = i; j < nums.Length; j++)
                {
                    sum += nums[j];

                    if (sum == k)
                    {
                        result++;
                    }
                }
            }

            return result;
        }
    }
}