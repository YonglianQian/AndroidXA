using NUnit.Framework;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass("Hello");
        }
        [Test]
        public void Test2()
        {
            Assert.Pass("ABD");
        }
    }
}