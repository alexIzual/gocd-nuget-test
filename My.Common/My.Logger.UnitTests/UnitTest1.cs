using NUnit.Framework;

namespace My.Logger.UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Logger_Always_Pass()
        {
            Assert.Pass();
        }
    }
}