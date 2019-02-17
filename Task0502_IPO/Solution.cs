using System.Collections.Generic;

namespace AlgoSolving.Task0502_IPO
{
    public class Solution
    {
        // ReSharper disable InconsistentNaming
        public int FindMaximizedCapital(int k, int W, int[] Profits, int[] Capital)
        // ReSharper restore InconsistentNaming
        {
            var companyCapital = W;
            var n = Capital.Length;
            var projectsTakenIndices = new HashSet<int>();

            for (int i = 0; i < k; i++)
            {
                const int noProjectIndex = -1;
                var bestProjectIndex = noProjectIndex;
                var bestProfit = 0;
                for (int j = 0; j < n; j++)
                {
                    if (projectsTakenIndices.Contains(j) || Capital[j] > companyCapital)
                    {
                        continue;
                    }

                    var profit = Profits[j];

                    if (profit > bestProfit)
                    {
                        bestProfit = profit;
                        bestProjectIndex = j;
                    }
                }

                if (bestProjectIndex == noProjectIndex)
                {
                    break;
                }

                projectsTakenIndices.Add(bestProjectIndex);
                companyCapital += bestProfit;
            }

            return companyCapital;
        }
    }
}