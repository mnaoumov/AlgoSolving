using System;

namespace AlgoSolving
{
    public class Solution
    {
        public int MySqrt(int x)
        {
            double temp = x / 2.0;
            int floor;
            int ceil;

            do
            {
                floor = (int) Math.Floor(temp);
                ceil = floor + 1;
                temp = (temp + (x / temp)) / 2;
            } while (floor * floor > x || ceil * ceil <= x);

            return floor;
        }
    }
}