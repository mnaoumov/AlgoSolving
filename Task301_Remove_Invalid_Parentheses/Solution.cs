using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgoSolving.Task301_Remove_Invalid_Parentheses
{
    public class Solution
    {
        public IList<string> RemoveInvalidParentheses(string s)
        {
            return RemoveInvalidParentheses(s, 0).ToList();
        }

        private IList<string> RemoveInvalidParentheses(string s, int start)
        {
            var results = new List<string>();
            var balance = 0;
            var openBracketIndices = new List<int>();
            var closedBracketIndices = new List<int>();
            var balances = new int[s.Length];
            for (int i = start; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    balance++;
                    openBracketIndices.Add(i);
                }
                else if (s[i] == ')')
                {
                    balance--;
                    closedBracketIndices.Add(i);
                }

                if (balance < 0)
                {
                    var suffixResults = RemoveInvalidParentheses(s, i + 1);
                    var prefixes = new HashSet<string>();
                    var substring = s.Substring(start, i - start + 1);
                    foreach (var closedBracketIndex in closedBracketIndices)
                    {
                        var prefix = substring.Remove(closedBracketIndex - start, 1);
                        prefixes.Add(prefix);
                    }

                    foreach (var prefix in prefixes)
                    {
                        foreach (var suffixResult in suffixResults)
                        {
                            results.Add(prefix + suffixResult);
                        }
                    }

                    return results;
                }

                balances[i] = balance;
            }

            if (balance == 0)
            {
                return new[] { s.Substring(start, s.Length - start) };
            }

            return RemoveOpenBrackets(results, start, openBracketIndices, balances, balance);
        }

        private IList<string> RemoveOpenBrackets(List<string> results, int start, List<int> openBracketIndices,
            int[] balances, int balance)
        {
            return new List<string>{ "" };
        }
    }
}