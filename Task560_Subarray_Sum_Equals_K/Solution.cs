namespace AlgoSolving.Task560_Subarray_Sum_Equals_K
{
    public class Solution
    {
        public int SubarraySum(int[] nums, int k)
        {
            var result = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i; j < nums.Length; j++)
                {
                    var sum = 0;
                    for (int m = i; m <= j; m++)
                    {
                        sum += nums[m];
                    }

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