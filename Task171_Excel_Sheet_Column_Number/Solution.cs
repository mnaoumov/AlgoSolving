using System.Linq;

namespace AlgoSolving.Task171_Excel_Sheet_Column_Number
{
    public class Solution
    {
        public int TitleToNumber(string s)
        {
            const int lettersCount = 26;
            return s.Aggregate(0, (current, letter) => current * lettersCount + TitleToNumber(letter));
        }

        private static int TitleToNumber(char letter)
        {
            const char firstTitleLetter = 'A';
            const int firstTitleNumber = 1;
            return letter - firstTitleLetter + firstTitleNumber;
        }
    }
}