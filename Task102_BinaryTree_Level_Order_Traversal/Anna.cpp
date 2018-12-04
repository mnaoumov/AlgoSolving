// https://pastebin.com/WKmkq1Hm

class Solution {
public:
    vector<vector<int>> levelOrder(TreeNode* root) {
		// return levelOrderIter(root);
        vector<vector<int>> res;
        levelOrderRec(root, 0, res);
        return res;
    }
    
private:
    void levelOrderRec(TreeNode* node, int level, vector<vector<int>>& res) {
        if (!node) return;
        if (static_cast<int>(res.size() - 1) < level) 
            res.push_back(vector<int>());
        res[level].push_back(node->val);
        levelOrderRec(node->left, level + 1, res);
        levelOrderRec(node->right, level + 1, res);
    }
    
    vector<vector<int>> levelOrderIter(TreeNode* root) {
        vector<vector<int>> res;
        
        queue<TreeNode*> curr, next;
        if (root) curr.push(root);
        
        while (!curr.empty() || !next.empty()) {
            vector<int> level_vals;
            
            while (!curr.empty()) {   
                auto node = curr.front();
                curr.pop();
                level_vals.push_back(node->val);
                if (node->left) next.push(node->left);
                if (node->right) next.push(node->right);
            }
            
            res.push_back(level_vals);
            swap(curr, next);
        }
        
        return res;
    }
};