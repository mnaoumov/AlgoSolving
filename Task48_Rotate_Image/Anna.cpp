// https://pastebin.com/urjXC6Rt

	void rotate(vector<vector<int>>& matrix) {
        int N = matrix.size();
        for (int r = 0; r < N / 2; ++r) {
            for (int c = 0; c < (N + 1) / 2; ++c) {
                int val = matrix[r][c];
                for (int i = 0; i < 4; ++i) {
                    int new_r = c;
                    int new_c = N - r - 1;
                    int tmp = matrix[new_r][new_c];
                    matrix[new_r][new_c] = val;
                    r = new_r;
                    c = new_c;
                    val = tmp;
                }
            }
        }
    }