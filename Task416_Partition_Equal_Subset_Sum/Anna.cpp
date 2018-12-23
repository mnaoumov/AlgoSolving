// https://pastebin.com/bapuKpAm

    bool canPartition(vector<int>& nums) {
        int total_sum = accumulate(nums.begin(), nums.end(), 0);
        if (total_sum % 2 != 0) return false;
        int target_sum = total_sum / 2;
        
        vector<bool> can_compose_sum(target_sum + 1);
        can_compose_sum[0] = true;
        
        for (int i = 0; i < nums.size(); ++i) {
            for (int s = target_sum; s >= nums[i]; --s) {
                can_compose_sum[s] = can_compose_sum[s] || can_compose_sum[s - nums[i]];
            }
        }
        
        return can_compose_sum.back();
    }