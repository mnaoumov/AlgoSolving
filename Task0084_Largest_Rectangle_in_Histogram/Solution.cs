using System;

namespace AlgoSolving.Task0084_Largest_Rectangle_in_Histogram
{
    public class Solution
    {
        public int LargestRectangleArea(int[] heights)
        {
            var result = 0;

            foreach (var height in heights)
            {
                var sequentialBarsNotBelowCurrent = 0;
                foreach (var height2 in heights)
                {
                    if (height2 >= height)
                    {
                        sequentialBarsNotBelowCurrent++;
                        result = Math.Max(result, sequentialBarsNotBelowCurrent * height);
                    }
                    else
                    {
                        sequentialBarsNotBelowCurrent = 0;
                    }
                }
            }

            return result;
        }
    }
}