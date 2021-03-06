﻿using System;

namespace AlgoSolving.Task0011_Container_With_Most_Water
{
    public class Solution
    {
        public int MaxArea(int[] height)
        {
            int xLeft = 0;
            int xRight = height.Length - 1;
            int maxArea = 0;
            while (xLeft < xRight)
            {
                var yLeft = height[xLeft];
                var yRight = height[xRight];
                int area = Math.Min(yLeft, yRight) * (xRight - xLeft);
                maxArea = Math.Max(maxArea, area);
                if (yLeft < yRight)
                {
                    xLeft++;
                }
                else
                {
                    xRight--;
                }
            }

            return maxArea;
        }
    }
}