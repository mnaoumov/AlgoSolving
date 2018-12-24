using NUnit.Framework;

namespace AlgoSolving.Task11_Container_With_Most_Water
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().MaxArea(new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }), Is.EqualTo(49));
        }
    }
}