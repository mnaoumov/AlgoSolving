// https://pastebin.com/pymcrhhy
// need to prove, why greedy approach works

 int maxProfit(vector<int>& prices) {
        if (prices.size() <= 1) return 0;
        
        int res = 0;
        int i = 0;
        while (i < prices.size()) {
            // find best local buy price
            while (i + 1 < prices.size() && prices[i + 1] <= prices[i]) ++i;
            if (i == prices.size() - 1) return res;
            int buy = prices[i];
            
            // find best local sell price
            while (i + 1 < prices.size() && prices[i + 1] >= prices[i]) ++i;
            int sell = prices[i];
            
            res += sell - buy;
        }
        
       return res;
    }