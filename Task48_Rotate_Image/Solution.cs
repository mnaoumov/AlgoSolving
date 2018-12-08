namespace AlgoSolving.Task48_Rotate_Image
{
    public class Solution
    {
        public void Rotate(int[,] matrix)
        {
            int n = matrix.GetLength(0);

            // i,j -> n-1-j,i

            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < n / 2; j++)
                {
                    const int cycleLength = 4;
                    int[] cycleValues = new int[cycleLength];
                    int iCycle = i;
                    int jCycle = j;

                    void UpdateCycleVariables()
                    {
                        (iCycle, jCycle) = (n - 1 - jCycle, iCycle);
                    }

                    for (int k = 0; k < cycleLength; k++)
                    {
                        cycleValues[k] = matrix[iCycle, jCycle];
                        UpdateCycleVariables();
                    }

                    for (int k = 0; k < cycleLength; k++)
                    {
                        matrix[iCycle, jCycle] = cycleValues[(k + 1) % cycleLength];
                        UpdateCycleVariables();
                    }
                }
            }


        }
    }
}