using System;
using System.Collections.Generic;

namespace AlgoSolving.Task200_Number_of_Islands
{
    public class Solution
    {
        public int NumIslands(char[,] grid)
        {
            var result = 0;
            var m = grid.GetLength(0);
            var n = grid.GetLength(1);
            int[,] islandNumbers = new int[m, n];
            var islandNumberMappings = new Dictionary<int, int>
            {
                [0] = 0
            };

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    const char land = '1';
                    if (grid[i, j] == land)
                    {
                        var topIslandNumber = GetIslandNumber(i - 1, j);
                        var leftIslandNumber = GetIslandNumber(i, j - 1);

                        if (topIslandNumber != 0)
                        {
                            islandNumbers[i, j] = topIslandNumber;
                        }
                        else if (leftIslandNumber != 0)
                        {
                            islandNumbers[i, j] = leftIslandNumber;
                        }
                        else
                        {
                            result++;
                            islandNumbers[i, j] = result;
                            islandNumberMappings[result] = result;
                        }

                        if (topIslandNumber != 0 && leftIslandNumber != 0 && topIslandNumber != leftIslandNumber)
                        {
                            result--;
                            islandNumberMappings[topIslandNumber] = leftIslandNumber;
                        }
                    }
                }
            }

            return result;

            int GetIslandNumber(int i, int j)
            {
                if (i < 0 || j < 0)
                {
                    return 0;
                }

                var islandNumber = islandNumbers[i, j];
                while (islandNumberMappings[islandNumber] != islandNumber)
                {
                    islandNumber = islandNumberMappings[islandNumber];
                }

                return islandNumber;
            }
        }
    }
}