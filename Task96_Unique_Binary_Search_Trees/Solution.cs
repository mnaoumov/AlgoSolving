﻿using System.Collections.Generic;

namespace AlgoSolving.Task96_Unique_Binary_Search_Trees
{
    public class Solution
    {
        public int NumTrees(int n)
        {
            var resultsCache = new Dictionary<int, int>();
            return NumTrees(n, resultsCache);
        }

        private int NumTrees(int n, Dictionary<int, int> resultsCache)
        {
            if (!resultsCache.ContainsKey(n))
            {
                resultsCache[n] = NumTreesInternal(n, resultsCache);
            }

            return resultsCache[n];
        }

        private int NumTreesInternal(int n, Dictionary<int, int> resultsCache)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }

            var result = 0;

            for (int i = 0; i <= n - 1; i++)
            {
                result += NumTrees(i, resultsCache) * NumTrees(n - 1 - i, resultsCache);
            }

            return result;
        }
    }
}