namespace AlgoSolving.Task42_Trapping_Rain_Water
{
    public class Solution
    {
        public int Trap(int[] height)
        {
            var result = 0;
            var leftIndex = 0;
            var rightIndex = height.Length - 1;
            var maxLeftHeight = 0;
            var maxRightHeight = 0;

            while (leftIndex < rightIndex)
            {
                if (height[leftIndex] >= maxLeftHeight)
                {
                    maxLeftHeight = height[leftIndex];
                    leftIndex++;
                }
                else if (height[rightIndex] >= maxRightHeight)
                {
                    maxRightHeight = height[rightIndex];
                    rightIndex--;
                }
                else
                {
                    if (maxLeftHeight <= maxRightHeight)
                    {
                        result += maxLeftHeight - height[leftIndex];
                    }
                    else
                    {
                        maxLeftHeight = height[leftIndex];
                    }

                    leftIndex++;
                }
            }

            return result;
        }
    }
}