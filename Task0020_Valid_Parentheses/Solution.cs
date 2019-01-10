using System.Collections.Generic;

namespace AlgoSolving.Task0020_Valid_Parentheses
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            var openBrackets = new Dictionary<char, BracketType>
            {
                ['('] = BracketType.Round,
                ['['] = BracketType.Square,
                ['{'] = BracketType.Curly
            };

            var closeBrackets = new Dictionary<char, BracketType>
            {
                [')'] = BracketType.Round,
                [']'] = BracketType.Square,
                ['}'] = BracketType.Curly
            };

            var brackets = new Stack<BracketType>();

            foreach (var symbol in s)
            {
                if (openBrackets.ContainsKey(symbol))
                {
                    brackets.Push(openBrackets[symbol]);
                }
                else if (closeBrackets.ContainsKey(symbol))
                {
                    if (brackets.Count == 0)
                    {
                        return false;
                    }

                    var closeBracketType = closeBrackets[symbol];
                    var lastBracketType = brackets.Pop();

                    if (closeBracketType != lastBracketType)
                    {
                        return false;
                    }
                }
            }

            return brackets.Count == 0;
        }

        private enum BracketType
        {
            Round,
            Square,
            Curly

        }
    }
}