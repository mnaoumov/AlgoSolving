using NUnit.Framework;

namespace AlgoSolving.Task171_Excel_Sheet_Column_Number
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().TitleToNumber("A"), Is.EqualTo(1));
        }

        [Test]
        public void AcceptanceTest2()
        {
            Assert.That(new Solution().TitleToNumber("AB"), Is.EqualTo(28));
        }

        [Test]
        public void AcceptanceTest3()
        {
            Assert.That(new Solution().TitleToNumber("ZY"), Is.EqualTo(701));
        }
    }
}