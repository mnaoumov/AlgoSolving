using System;

namespace AlgoSolving.Task394_Decode_Strings
{
    public class Solution
    {
        public string DecodeString(string s)
        {
            var context = new ParsingContext();
            foreach (var symbol in s)
            {
                if (char.IsDigit(symbol))
                {
                    context.RepeatCount = 10 * context.RepeatCount + (symbol - '0');
                }
                else if (symbol == '[')
                {
                    context = new ParsingContext(context);
                }
                else if (symbol == ']')
                {
                    var parent = context.Parent;
                    for (int i = 0; i < parent.RepeatCount; i++)
                    {
                        parent.Text += context.Text;
                    }

                    parent.RepeatCount = 0;
                    context = parent;
                }
                else
                {
                    context.Text += symbol;
                }
            }

            return context.Text;
        }

        private class ParsingContext
        {
            public ParsingContext(ParsingContext parent = null)
            {
                Parent = parent;
            }

            public ParsingContext Parent { get; }

            public int RepeatCount { get; set; }
            public string Text { get; set; } = "";
        }
    }
}