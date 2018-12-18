namespace AlgoSolving.Task171_Excel_Sheet_Column_Number
{
    public class Solution
    {
        public int TitleToNumber(string s)
        {
            const int lettersCount = 26;
            int result = 0;
            foreach (var letter in s)
            {
                result = result * lettersCount + TitleToNumber(letter);
            }
            return result;
        }

        private static int TitleToNumber(char letter)
        {
            const char firstTitleLetter = 'A';
            const int firstTitleNumber = 1;
            return letter - firstTitleLetter + firstTitleNumber;
        }
    }
}