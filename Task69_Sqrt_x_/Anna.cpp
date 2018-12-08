// https://pastebin.com/GtHXwLbT
// Newtons Method?

class Solution {
public:
    int mySqrt(int x) {
        if (x == 0) return x;
        int lo = 1;
        int hi = x;
        
        while (hi - lo > 1) {
            long long mid = lo + (hi - lo)/2;
            if (mid*mid > x) hi = mid;
            else if (mid*mid < x) lo = mid;
            else return mid;
        }
        
        return lo;
    }
};