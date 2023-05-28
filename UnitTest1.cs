using NUnit.Framework;

namespace Test2805
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
            Assert.Pass();
        }

        [TearDown]
        public void Cleanup()
        {
            Assert.Pass();
        }
    }
}