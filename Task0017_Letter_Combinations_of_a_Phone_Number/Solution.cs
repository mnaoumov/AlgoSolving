﻿using System.Collections.Generic;

namespace AlgoSolving.Task0017_Letter_Combinations_of_a_Phone_Number
{
    public class Solution
    {
        public IList<string> LetterCombinations(string digits)
        {
            if (digits == "")
            {
                return new List<string>();
            }

            var mapping = new Dictionary<char, string>
            {
                ['2'] = "abc",
                ['3'] = "def",
                ['4'] = "ghi",
                ['5'] = "jkl",
                ['6'] = "mno",
                ['7'] = "pqrs",
                ['8'] = "tuv",
                ['9'] = "wxyz"
            };

            var combinations = new List<string> { "" };

            foreach (var digit in digits)
            {
                var nextCombinations = new List<string>();
                foreach (var letter in mapping[digit])
                {
                    foreach (var combination in combinations)
                    {
                        nextCombinations.Add(combination + letter);
                    }
                }

                combinations = nextCombinations;
            }

            return combinations;
        }
    }
}