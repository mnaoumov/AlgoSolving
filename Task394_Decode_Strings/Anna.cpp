// https://pastebin.com/VNx9nyGR

class Solution {
public:
    string decodeString(string s) {
        int last_parsed = 0;
        return solveDecode(s, last_parsed);
    }
    
private:
    string solveDecode(const string& s, int& i) {
        string res = "";

        while (i < s.size() && s[i] != ']') {
            if (!isdigit(s[i])) res += s[i++];
            else {
                int count = 0;
                while (isdigit(s[i]))
                    count = count * 10 + (s[i++] - '0');

                ++i; // '['
                auto sub_expression = solveDecode(s, i);
                ++i; // ']'

                res.reserve(res.size() + count * sub_expression.size());
                while (count--) 
                    res += sub_expression;
            }
        }
        return res;
    }
};