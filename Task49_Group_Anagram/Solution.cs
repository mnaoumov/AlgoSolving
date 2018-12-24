using System.Collections.Generic;
using System.Linq;

namespace AlgoSolving.Task49_Group_Anagram
{
    public class Solution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var dict = new Dictionary<string, IList<string>>();

            foreach (var str in strs)
            {
                var sorted = Sort(str);
                if (!dict.ContainsKey(sorted))
                {
                    dict[sorted] = new List<string>();
                }

                dict[sorted].Add(str);
            }
            return dict.Values.ToArray();
        }

        private string Sort(string str)
        {
            return string.Join("", str.ToCharArray().OrderBy(x => x));
        }
    }
}