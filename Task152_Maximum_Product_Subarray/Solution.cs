using System;

namespace AlgoSolving.Task152_Maximum_Product_Subarray
{
    public class Solution
    {
        public int MaxProduct(int[] nums)
        {
            var n = nums.Length;
            if (n == 0)
            {
                return 0;
            }

            var lastMaxSuffixProduct = nums[n - 1];
            var lastMinSuffixProduct = nums[n - 1];
            var globalMaxProduct = nums[n - 1];

            for (int i = n - 2; i >= 0; i--)
            {
                var value = nums[i];
                lastMaxSuffixProduct = Math.Max(value, value * (value >= 0 ? lastMaxSuffixProduct : lastMinSuffixProduct));
                lastMinSuffixProduct = Math.Min(value, value * (value >= 0 ? lastMinSuffixProduct : lastMaxSuffixProduct));
                globalMaxProduct = Math.Max(globalMaxProduct, lastMaxSuffixProduct);
            }

            return globalMaxProduct;
        }
    }
}