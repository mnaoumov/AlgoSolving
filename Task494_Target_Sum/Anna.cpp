// https://pastebin.com/V4pJATar

int findTargetSumWays(vector<int>& nums, int S) {
        int total_sum = accumulate(nums.begin(), nums.end(), 0);
        if (total_sum < abs(S)) return 0;

        // total_sum will correspond to zero in dp array, so we can safely add and substract nums[i]
        int max_sum_possible = 2 * total_sum;
        vector<int> target_sum_ways_dp_prev(max_sum_possible + 1);
        vector<int> target_sum_ways_dp_curr(max_sum_possible + 1);
        target_sum_ways_dp_prev[total_sum + nums[0]] = 1;
        target_sum_ways_dp_prev[total_sum - nums[0]] += 1;

        for (int i = 1; i < nums.size(); ++i) {
            for (int s = 0; s <= max_sum_possible; ++s) {
                target_sum_ways_dp_curr[s] = 0;
                if (s - nums[i] >= 0)
                    target_sum_ways_dp_curr[s] += target_sum_ways_dp_prev[s - nums[i]]; // take with positive sgn
                if (s + nums[i] <= max_sum_possible)
                    target_sum_ways_dp_curr[s] += target_sum_ways_dp_prev[s + nums[i]]; // take with negative sgn
            }

            swap(target_sum_ways_dp_curr, target_sum_ways_dp_prev);
        }

        return target_sum_ways_dp_prev[total_sum + S];
    }