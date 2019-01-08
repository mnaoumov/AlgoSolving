using System;

namespace AlgoSolving.Task42_Trapping_Rain_Water
{
    public class Solution
    {
        public int Trap(int[] height)
        {
            var rightMaxHeights = new int[height.Length];

            for (int i = rightMaxHeights.Length - 2; i >= 0; i--)
            {
                rightMaxHeights[i] = Math.Max(rightMaxHeights[i + 1], height[i + 1]);
            }

            int result = 0;
            int maxLeft = 0;

            for (int i = 0; i < height.Length; i++)
            {
                if (height[i] >= maxLeft)
                {
                    maxLeft = height[i];
                }
                else
                {
                    result += (Math.Min(maxLeft, rightMaxHeights[i]) - height[i]);
                }
            }

            return result;
        }
    }
}