namespace AlgoSolving.Task322_Coin_Change
{
    public class Solution
    {
        public int CoinChange(int[] coins, int amount)
        {
            var dp = new int?[amount + 1];
            return CoinChange(coins, amount, dp);
        }

        private int CoinChange(int[] coins, int amount, int?[] dp)
        {
            const int impossibleChange = -1;

            if (amount < 0)
            {
                return impossibleChange;
            }

            if (amount == 0)
            {
                return 0;
            }

            if (dp[amount] != null)
            {
                return dp[amount].Value;
            }

            int result = impossibleChange;

            foreach (var coin in coins)
            {
                var subResult = CoinChange(coins, amount - coin, dp);
                if (subResult != impossibleChange)
                {
                    if (result == impossibleChange || result > subResult + 1)
                    {
                        result = subResult + 1;
                    }
                }
            }

            dp[amount] = result;
            return result;
        }
    }
}