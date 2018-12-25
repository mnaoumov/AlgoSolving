namespace AlgoSolving.Task56_Merge_Intervarls
{
    /// <summary>
    /// Definition for an interval.
    /// </summary>
    public class Interval
    {
        public int end;
        public int start;

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