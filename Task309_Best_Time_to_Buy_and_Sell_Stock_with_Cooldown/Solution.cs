using System;

namespace AlgoSolving.Task309_Best_Time_to_Buy_and_Sell_Stock_with_Cooldown
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int maxProfitAfterBuying = Int32.MinValue;
            int maxProfitAfterSelling = 0;
            int maxProfitAfterSellingTwoDaysAgo = 0;
            foreach (var price in prices)
            {
                int maxProfitAfterSellingOneDayAgo = maxProfitAfterSelling;
                int maxProfitAfterBuyingOneDayAgo = maxProfitAfterBuying;
                maxProfitAfterBuying =
                    Math.Max(maxProfitAfterBuyingOneDayAgo, maxProfitAfterSellingTwoDaysAgo - price);
                maxProfitAfterSelling = Math.Max(maxProfitAfterSellingOneDayAgo, maxProfitAfterBuying + price);
                maxProfitAfterSellingTwoDaysAgo = maxProfitAfterSellingOneDayAgo;
            }

            return maxProfitAfterSelling;
        }
    }
}