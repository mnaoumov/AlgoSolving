using System.Collections.Generic;
using System.Linq;

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
            var projects = new List<Project>();

            for (int i = 0; i < n; i++)
            {
                projects.Add(new Project
                {
                    Capital = Capital[i],
                    Profit = Profits[i]
                });
            }

            projects = projects.OrderByDescending(p => p.Profit).ThenBy(p => p.Capital).ToList();

            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    var project = projects[j];
                    if (project.Capital <= companyCapital)
                    {
                        companyCapital += project.Profit;
                        projects.RemoveAt(j);
                        break;
                    }
                }
            }

            return companyCapital;
        }

        private struct Project
        {
            public int Capital;
            public int Profit;
        }
    }
}