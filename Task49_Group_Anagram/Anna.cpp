// https://pastebin.com/B3tsZdLd
// N*M*log(N)

vector<vector<string>> groupAnagrams(const vector<string>& input) {
        const int kAlphabetRadix = 26;
        map<vector<int>, vector<string>> letters_count_to_words;

        for (auto word : input) {
            vector<int> alphabet_count(kAlphabetRadix);
            for (auto letter : word)
                ++alphabet_count[letter - 'a'];

            letters_count_to_words[alphabet_count].push_back(word);
        }

        vector<vector<string>> res(letters_count_to_words.size());
        int i = 0;
        for (auto key_val : letters_count_to_words)
            res[i++] = key_val.second;

        return res;
    }

// https://pastebin.com/zqpPpsG8
// N*M using hash map

 vector<vector<string>> groupAnagrams(const vector<string>& input) {
        const int kAlphabetRadix = 26;
        unordered_map<string, vector<string>> letters_count_to_words;

        for (auto word : input) {
            vector<int> alphabet_count(kAlphabetRadix);
            for (auto letter : word)
                ++alphabet_count[letter - 'a'];
            string alphabet_count_str(alphabet_count.begin(), alphabet_count.end());
            letters_count_to_words[alphabet_count_str].push_back(word);
        }

        vector<vector<string>> res;
        transform(letters_count_to_words.begin(), letters_count_to_words.end(), back_inserter(res), 
                  [] (auto& map_pair) { return map_pair.second; });

        return res;
    }