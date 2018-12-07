namespace AlgoSolving.Task122_Best_Time_to_Buy_and_Sell_Stock_II
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int result = 0;
            bool stockBought = false;

            for (int i = 0; i < prices.Length; i++)
            {
                if (!stockBought)
                {
                    if (i + 1 < prices.Length && prices[i] < prices[i + 1])
                    {
                        stockBought = true;
                        result -= prices[i];
                    }
                }
                else
                {
                    if (i + 1 == prices.Length || prices[i] >= prices[i + 1])
                    {
                        stockBought = false;
                        result += prices[i];
                    }
                }
            }

            return result;
        }
    }
}
