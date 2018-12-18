// https://pastebin.com/hmSTB5Vk

class Solution {
public:
    vector<vector<int>> combinationSum(vector<int>& candidates, int target) {
        if (candidates.empty()) return {};
        
        vector<int> curr;
        vector<vector<int>> res;
        
        solveCombinationSum(candidates, 0, target, curr, res);
        
        return res;
    }
private:
    void solveCombinationSum(const vector<int>& candidates, int pos, int target, 
                             vector<int>& curr, vector<vector<int>>& res) {
        if (pos == candidates.size()) {
            if (target == 0) res.push_back(curr);
            return;
        }
        
        // skip current number
        solveCombinationSum(candidates, pos + 1, target, curr, res);
        
        // include curr number
        for (int s = candidates[pos]; s <= target; s += candidates[pos]) {
            curr.push_back(candidates[pos]);
            solveCombinationSum(candidates, pos + 1, target - s, curr, res);
        }
        
        while(!curr.empty() && curr.back() == candidates[pos])
            curr.pop_back();
    }
};