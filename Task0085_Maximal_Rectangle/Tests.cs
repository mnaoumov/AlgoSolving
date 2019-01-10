using NUnit.Framework;

namespace AlgoSolving.Task0085_Maximal_Rectangle
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().MaximalRectangle(new[,]
            {
                { '1', '0', '1', '0', '0' },
                { '1', '0', '1', '1', '1' },
                { '1', '1', '1', '1', '1' },
                { '1', '0', '0', '1', '0' }
            }), Is.EqualTo(6));
        }
    }
}