using System.Linq;

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
                    if (matrix[i, j] != squareSymbol)
                    {
                        leftTopSquareSizes[i, j] = 0;
                        continue;
                    }

                    var previousSquareSize = leftTopSquareSizes[i + 1, j + 1];

                    var areLeftAndTopSidesFull =
                        Enumerable.Range(i + 1, previousSquareSize).All(k => matrix[k, j] == squareSymbol) &&
                        Enumerable.Range(j + 1, previousSquareSize).All(k => matrix[i, k] == squareSymbol);

                    leftTopSquareSizes[i, j] = previousSquareSize + (areLeftAndTopSidesFull ? 1 : 0);
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