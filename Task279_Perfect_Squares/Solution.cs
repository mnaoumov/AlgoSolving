using System;
using System.Collections.Generic;

namespace AlgoSolving.Task279_Perfect_Squares
{
    public class Solution
    {
        public int NumSquares(int n)
        {
            return CalculateWithCache<int, int>(NumSquares)(n);
        }

        private static int NumSquares(int n, Func<int, int> calculateWithCache)
        {
            if (n == 0)
            {
                return 0;
            }

            var result = int.MaxValue;
            for (int i = 1; i * i <= n; i++)
            {
                result = Math.Min(result, calculateWithCache(n - i * i) + 1);
            }

            return result;
        }

        private static Func<TArgument, TResult> CalculateWithCache<TArgument, TResult>(Func<TArgument, Func<TArgument, TResult>, TResult> calculate)
        {
            var cache = new Dictionary<TArgument, TResult>();

            TResult CalculateWithCache(TArgument argument)
            {
                if (!cache.ContainsKey(argument))
                {
                    cache[argument] = calculate(argument, CalculateWithCache);
                }

                return cache[argument];
            }

            return CalculateWithCache;
        }
    }
}