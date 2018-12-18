// https://pastebin.com/q8hPxDxD
// dp O(N^2) time, O(N) memory;

  int findLength(vector<int>& A, vector<int>& B) {
        vector<int> dp(A.size());
        int max_len = 0;
        
        for (auto c : B) {
            for (int i = dp.size() - 1; i >= 0; --i) {
                if (A[i] == c) dp[i] = dp[i - 1] + 1;
                else  dp[i] = 0;
                
                max_len = max(max_len, dp[i]);
            }
        }
        
        return max_len;
    }


// https://pastebin.com/bqiCccVW
// Sln using hashes O(log(min(N, M)*(M+N)) time O(min(N, M)) mem

// Solution with hash
using ull = unsigned long long;

bool EqualSubArrExists(vector<int>& A, vector<int>& B, int length) {
	unordered_set<ull> first_str_hashes;
	const ull kP = 179;
	ull kP_n = 1;
	for (int i = 0; i < length - 1; ++i)
		kP_n *= kP;

	// precompute all hashes of subarrays of length |length| for |A| using rolling hash algo:
	ull h1 = 0;
	for (int i = 0; i < length; ++i)
		h1 = h1 * kP + A[i];

	first_str_hashes.insert(h1);

	for (int i = length; i < A.size(); ++i) {
		h1 = (h1 - A[i - length] * kP_n) * kP + A[i];
		first_str_hashes.insert(h1);
	}

	// traverse all hashes in |B| and see if there is a matching hash in |first_str_hashes|:
	ull h2 = 0;
	for (int i = 0; i < length; ++i)
		h2 = h2 * kP + B[i];
	if (first_str_hashes.count(h2) > 0) return true;

	for (int i = length; i < B.size(); ++i) {
		h2 = (h2 - B[i - length] * kP_n) * kP + B[i];
		if (first_str_hashes.count(h2) > 0) return true;
	}

	return false;
}

int findLength(vector<int>& A, vector<int>& B) {
	int lo = 0;
	int hi = min(A.size(), B.size());
	if (EqualSubArrExists(A, B, hi)) return hi;

	// invariant: lo - sub arr exists of length lo, hi - does not exist
	while (hi - lo > 1) {
		int mid = lo + (hi - lo) / 2;
		if (EqualSubArrExists(A, B, mid)) lo = mid;
		else hi = mid;
	}

	return lo;
}