namespace AlgoSolving.Task0050_Pow_x_n
{
    public class Solution
    {
        public double MyPow(double x, int n)
        {
            if (n == 0)
            {
                return 1;
            }

            if (n < 0)
            {
                return MyPow(1 / x, -n);
            }

            var result = 1m;
            for (int i = 0; i < n; i++)
            {
                result *= (decimal) x;
            }

            return (double) result;
        }
    }
}