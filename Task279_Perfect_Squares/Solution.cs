using System;

namespace AlgoSolving.Task279_Perfect_Squares
{
    public class Solution
    {
        public int NumSquares(int n)
        {
            var cache = new int[n + 1];

            for (int k = 1; k <= n; k++)
            {
                cache[k] = int.MaxValue;
                for (int i = 1; i * i <= k; i++)
                {
                    cache[k] = Math.Min(cache[k], cache[k - i * i] + 1);
                }   
            }

            return cache[n];
        }
    }
}