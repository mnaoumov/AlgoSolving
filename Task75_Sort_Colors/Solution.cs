namespace AlgoSolving.Task75_Sort_Colors
{
    public class Solution
    {
        public void SortColors(int[] nums)
        {
            var counts = new int[3];
            foreach (var num in nums)
            {
                counts[num]++;
            }

            var lastColor = 0;
            var lastColorIndexShift = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                while (i >= counts[lastColor] + lastColorIndexShift)
                {
                    lastColor++;
                    lastColorIndexShift = i;
                }

                nums[i] = lastColor;
            }
        }
    }
}