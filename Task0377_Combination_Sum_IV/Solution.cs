namespace AlgoSolving.Task0377_Combination_Sum_IV
{
    public class Solution
    {
        public int CombinationSum4(int[] nums, int target)
        {
            var partialResults = new int[target + 1];
            partialResults[0] = 1;

            for (int sum = 0; sum <= target; sum++)
            {
                foreach (var num in nums)
                {
                    if (num > sum)
                    {
                        continue;
                    }

                    partialResults[sum] += partialResults[sum - num];
                }
            }

            return partialResults[target];
        }
    }
}