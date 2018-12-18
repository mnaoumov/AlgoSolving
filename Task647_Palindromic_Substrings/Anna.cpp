// https://pastebin.com/C1yB2WCq
// O(N^2)
// -Manacher’s algo

class Solution {
public:
    int countSubstrings(string s) {
        int res = 0;
        for (int i = 0; i < s.size(); ++i) {
            res += numOfPalindromes(s, i, i);
            res += numOfPalindromes(s, i, i + 1);
        }
        return res;
    }
private:
    int numOfPalindromes(const string& s, int left, int right) {
        int res = 0;
        
        while(left >= 0 && right < s.size() && s[left] == s[right]) {
            ++res;
            --left;
            ++right;
        }
        
        return res;
    }
};