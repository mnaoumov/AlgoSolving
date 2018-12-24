// https://pastebin.com/bCk2jWCB
   
   int maxProfit(const vector<int>& prices) {
        if (prices.empty()) return 0;
        int best_profit_open = -prices[0];
        int best_profit_closed_2_days_ago = 0;
        int best_profit_closed = 0;

        for (int i = 1; i < prices.size(); ++i) {
            auto best_closed_day_ago = best_profit_closed;
            best_profit_closed = max(best_closed_day_ago, best_profit_open + prices[i]);
            best_profit_open = max(best_profit_open, best_profit_closed_2_days_ago - prices[i]);
            best_profit_closed_2_days_ago = best_closed_day_ago;
        }

        return best_profit_closed;
    }