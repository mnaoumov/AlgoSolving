using NUnit.Framework;

namespace AlgoSolving.Task394_Decode_Strings
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(new Solution().DecodeString("3[a]2[bc]"), Is.EqualTo("aaabcbc"));
        }

        [Test]
        public void AcceptanceTest2()
        {
            Assert.That(new Solution().DecodeString("3[a2[c]]"), Is.EqualTo("accaccacc"));
        }

        [Test]
        public void AcceptanceTest3()
        {
            Assert.That(new Solution().DecodeString("2[abc]3[cd]ef"), Is.EqualTo("abcabccdcdcdef"));
        }

        [Test]
        public void For_empty_string_return_itself()
        {
            Assert.That(new Solution().DecodeString(""), Is.EqualTo(""));
        }
    }
}