namespace AlgoSolving.Task0048_Rotate_Image
{
    public class Solution
    {
        public void Rotate(int[,] matrix)
        {
            int n = matrix.GetLength(0);

            // i,j -> n-1-j,i
            // n-1-j,i <- i,j

            var middleRowInclusive = (n - 1) / 2;
            var middleRowExclusive = n / 2 - 1;
            for (int i = 0; i <= middleRowInclusive; i++)
            {
                for (int j = 0; j <= middleRowExclusive; j++)
                {
                    const int cycleLength = 4;
                    int iCycle = i;
                    int jCycle = j;
                    int value = matrix[iCycle, jCycle];

                    for (int k = 0; k < cycleLength; k++)
                    {
                        (iCycle, jCycle) = (jCycle, n - 1 - iCycle);
                        var nextValue = matrix[iCycle, jCycle];
                        matrix[iCycle, jCycle] = value;
                        value = nextValue;
                    }
                }
            }
        }
    }
}