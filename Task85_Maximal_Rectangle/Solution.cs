using System;

namespace AlgoSolving.Task85_Maximal_Rectangle
{
    public class Solution
    {
        public int MaximalRectangle(char[,] matrix)
        {
            var m = matrix.GetLength(0);
            var n = matrix.GetLength(1);

            var maximalRectanglesStartsInLeftTopCorner = new(int width, int height)[m + 1, n + 1];
            var result = 0;

            for (int i = m - 1; i >= 0; i--)
            {
                for (int j = n - 1; j >= 0; j--)
                {
                    const char rectangleSymbol = '1';
                    if (matrix[i, j] != rectangleSymbol)
                    {
                        maximalRectanglesStartsInLeftTopCorner[i, j] = (0, 0);
                        continue;
                    }

                    var previousRectangle = maximalRectanglesStartsInLeftTopCorner[i + 1, j + 1];
                    var width = 1;
                    while (width < previousRectangle.width + 1 && matrix[i + width, j] == rectangleSymbol)
                    {
                        width++;
                    }

                    var height = 1;
                    while (height < previousRectangle.height + 1 && matrix[i, j + height] == rectangleSymbol)
                    {
                        height++;
                    }

                    maximalRectanglesStartsInLeftTopCorner[i, j] = (width, height);
                    result = Math.Max(result, width * height);
                }
            }

            return result;
        }
    }
}