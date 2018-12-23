// https://pastebin.com/Nat3EcZc

    int combinationSum4(vector<int>& nums, int target) {
        vector<int> memo(target + 1);
        memo[0] = 1;
        
        for (int s = 1; s < memo.size(); ++s) {
            for (auto x : nums) {
                if (s - x >= 0) memo[s] += memo[s - x];
            }
        }
        
        return memo.back();
    }