// https://pastebin.com/cExSChfj
// slow, we can do better. TODO

    int coinChange(vector<int>& coins, int amount) {
        vector<int> dp(amount + 1, amount + 1);
        dp[0] = 0;
            
        for (int i = 0; i < coins.size(); ++i) {
            for (int s = coins[i]; s <= amount; ++s) {
                dp[s] = min(dp[s], dp[s - coins[i]] + 1);
            }
        }
        
        return dp.back() == amount + 1 ? -1 : dp.back();
    }