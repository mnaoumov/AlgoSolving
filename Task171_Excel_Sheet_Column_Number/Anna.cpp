// https://pastebin.com/TYUGcfjB

 int titleToNumber(string s) {
    const int kBase = 26;
    int res = 0;
    for (auto c : s)
        res = res * kBase + (c - 'A' + 1);
    return res;
}