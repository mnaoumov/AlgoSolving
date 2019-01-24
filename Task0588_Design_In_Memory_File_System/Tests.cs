using NUnit.Framework;

namespace AlgoSolving.Task0588_Design_In_Memory_File_System
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            var fs = new FileSystem();

            Assert.Multiple(() =>
            {
                Assert.That(fs.ls("/"), Is.EqualTo(new string[] { }));
                fs.mkdir("/a/b/c");
                fs.addContentToFile("/a/b/c/d", "hello");
                Assert.That(fs.ls("/"), Is.EqualTo(new[] { "a" }));
                Assert.That(fs.readContentFromFile("/a/b/c/d"), Is.EqualTo("hello"));
            });
        }
    }
}