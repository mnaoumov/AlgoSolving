// https://pastebin.com/wL22avFA

int numTrees(int n) {
	if (!n) return 0;
	vector<int> catalan_numbers(n + 1);
	catalan_numbers[0] = 1;
	catalan_numbers[1] = 1;
        
	for (int i = 2; i <= n; ++i) {
		int ith_catalan_num = 0;
		for (int j = 0; j < i; ++j)
			ith_catalan_num += catalan_numbers[j]*catalan_numbers[i - j - 1];
		catalan_numbers[i] = ith_catalan_num;
	}
        
	return catalan_numbers.back();
}