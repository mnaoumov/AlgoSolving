﻿using System.Linq;

namespace AlgoSolving.Task221_Maximal_Square
{
    public class Solution
    {
        public int MaximalSquare(char[,] matrix)
        {
            const char squareSymbol = '1';

            var m = matrix.GetLength(0);
            var n = matrix.GetLength(1);

            int[,] leftTopSquareSizes = new int[m + 1, n + 1];
            var maxSize = 0;

            for (int i = m - 1; i >= 0 ; i--)
            {
                for (int j = n - 1; j >= 0; j--)
                {
                    var previousSquareSize = leftTopSquareSizes[i + 1, j + 1];

                    var areLeftTopSidesFull =
                        Enumerable.Range(i, previousSquareSize + 1).All(k => matrix[k, j] == squareSymbol) &&
                        Enumerable.Range(j, previousSquareSize + 1).All(k => matrix[i, k] == squareSymbol);

                    leftTopSquareSizes[i, j] =
                        areLeftTopSidesFull ? previousSquareSize + 1 :
                        matrix[i, j] == squareSymbol ? 1 : 0;
                    if (leftTopSquareSizes[i, j] > maxSize)
                    {
                        maxSize = leftTopSquareSizes[i, j];
                    }
                }
            }

            return maxSize * maxSize;
        }
    }
}