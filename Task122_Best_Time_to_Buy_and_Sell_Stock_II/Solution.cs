namespace AlgoSolving.Task122_Best_Time_to_Buy_and_Sell_Stock_II
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int result = 0;
            bool hasStockToSell = false;

            for (int i = 0; i < prices.Length; i++)
            {

                if (!hasStockToSell)
                {
                    bool isLocalMinimum = i + 1 < prices.Length && prices[i] < prices[i + 1];

                    if (isLocalMinimum)
                    {
                        hasStockToSell = true;
                        result -= prices[i];
                    }
                }
                else
                {
                    bool isLocalMaximum = i + 1 == prices.Length || prices[i] > prices[i + 1];

                    if (isLocalMaximum)
                    {
                        hasStockToSell = false;
                        result += prices[i];
                    }
                }
            }

            return result;
        }
    }
}
