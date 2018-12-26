﻿namespace AlgoSolving.Task689_Maximum_Sum_of_3_Non_Overlapping_Subarrays
{
    public class Solution
    {
        public int[] MaxSumOfThreeSubarrays(int[] nums, int k)
        {
            var n = nums.Length;
            var kSums = new int[n - k + 1];

            var kSum = 0;

            for (int i = 0; i < n; i++)
            {
                kSum += nums[i];
                if (i >= k)
                {
                    kSum -= nums[i - k];
                }

                if (i >= k - 1)
                {
                    kSums[i - k + 1] = kSum;
                }
            }

            var minPossibleLeftSubarrayIndex = 0;
            var maxPossibleLeftSubarrayIndex = n - 3 * k;
            var minPossibleMiddleSubarrayIndex = k;
            var maxPossibleMiddleSubarrayIndex = n - 2 * k;
            var minPossibleRightSubarrayIndex = 2 * k;
            var maxPossibleRightSubarrayIndex = n - k;

            var indicesForTheBestSumOnLeft = new int[maxPossibleLeftSubarrayIndex + 1];
            indicesForTheBestSumOnLeft[0] = 0;

            for (int i = minPossibleLeftSubarrayIndex + 1; i <= maxPossibleLeftSubarrayIndex; i++)
            {
                var previousBestIndex = indicesForTheBestSumOnLeft[i - 1];
                var previousBestKSum = kSums[previousBestIndex];
                var currentKSum = kSums[i];
                indicesForTheBestSumOnLeft[i] = currentKSum > previousBestKSum ? i : previousBestIndex;
            }

            var indicesForTheBestSumOnRight = new int[maxPossibleRightSubarrayIndex + 1];
            indicesForTheBestSumOnRight[maxPossibleRightSubarrayIndex] = maxPossibleRightSubarrayIndex;

            for (int i = maxPossibleRightSubarrayIndex - 1; i >= minPossibleRightSubarrayIndex; i--)
            {
                var previousBestIndex = indicesForTheBestSumOnRight[i + 1];
                var previousBestKSum = kSums[previousBestIndex];
                var currentKSum = kSums[i];
                indicesForTheBestSumOnLeft[i] = currentKSum >= previousBestKSum ? i : previousBestIndex;
            }
            
            var bestSum = int.MinValue;
            int bestLeftSubarrayIndex = -1;
            int bestMiddleSubarrayIndex = -1;
            int bestRightSubarrayIndex = -1;

            for (var middleSubarrayIndex = minPossibleMiddleSubarrayIndex; middleSubarrayIndex <= maxPossibleMiddleSubarrayIndex; middleSubarrayIndex++)
            {
                var leftSubarrayIndex = indicesForTheBestSumOnLeft[middleSubarrayIndex - 1];
                var rightSubarrayIndex = indicesForTheBestSumOnRight[middleSubarrayIndex + k];
                var sum = kSums[leftSubarrayIndex] + kSums[middleSubarrayIndex] + kSums[rightSubarrayIndex];
                if (sum > bestSum)
                {
                    bestLeftSubarrayIndex = leftSubarrayIndex;
                    bestMiddleSubarrayIndex = middleSubarrayIndex;
                    bestRightSubarrayIndex = rightSubarrayIndex;
                }
            }

            return new[] { bestLeftSubarrayIndex, bestMiddleSubarrayIndex, bestRightSubarrayIndex };
        }
    }
}