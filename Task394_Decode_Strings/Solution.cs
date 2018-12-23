﻿using System;

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
                    context.NestedContext.RepeatCount = 10 * context.NestedContext.RepeatCount + (symbol - '0');
                }
                else if (symbol == '[')
                {
                    context = context.NestedContext;
                }
                else if (symbol == ']')
                {
                    var parent = context.Parent;
                    for (int i = 0; i < context.RepeatCount; i++)
                    {
                        parent.Text += context.Text;
                    }

                    parent.ResetNestedContext();
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
            private ParsingContext _nestedContext;
            public ParsingContext Parent { get; private set; }

            public ParsingContext()
            {
                ResetNestedContext();
            }

            public void ResetNestedContext()
            {
                _lazyNestedContext =
                    new Lazy<ParsingContext>(() => new ParsingContext() {Parent = this});
            }

            public int RepeatCount { get; set; }
            public string Text { get; set; }

            public ParsingContext NestedContext => _lazyNestedContext.Value;
            private Lazy<ParsingContext> _lazyNestedContext;
        }
    }
}