namespace AlgoSolving
{
    public class Solution
    {
        public int MySqrt(int x)
        {
            long result = 1;

            while (!(result * result <= x && (result + 1) * (result + 1) > x))
            {
                result = (result + (x / result)) / 2;
            }

            return (int) result;
        }
    }
}