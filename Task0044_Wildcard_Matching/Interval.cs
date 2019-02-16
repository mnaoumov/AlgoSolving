namespace AlgoSolving.Task0044_Wildcard_Matching
{
    /// <summary>
    /// Definition for an interval.
    /// </summary>
    public class Interval
    {
        // ReSharper disable once InconsistentNaming
        public int start;
        // ReSharper disable once InconsistentNaming
        public int end;

        public Interval()
        {
            start = 0;
            end = 0;
        }

        public Interval(int s, int e)
        {
            start = s;
            end = e;
        }
    }
}