namespace AlgoSolving.Task647_Palindromic_Substrings
{
    public class Solution
    {
        public int CountSubstrings(string s)
        {
            var count = 0;
            for (int doubledMiddlePoint = 0; doubledMiddlePoint < 2 * s.Length - 1; doubledMiddlePoint++)
            {
                var left = doubledMiddlePoint / 2;
                var right = doubledMiddlePoint / 2 + doubledMiddlePoint % 2;

                while (left >= 0 && right < s.Length && s[left] == s[right])
                {
                    left--;
                    right++;
                    count++;
                }
            }
            return count;
        }
    }
}