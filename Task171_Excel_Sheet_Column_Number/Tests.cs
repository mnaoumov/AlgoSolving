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

        [Test]
        public void Support_more_than_two_characters()
        {
            Assert.That(new Solution().TitleToNumber("AAA"), Is.EqualTo(703));
        }
    }
}