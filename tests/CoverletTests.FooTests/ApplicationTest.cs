using CoverletTest;
using NUnit.Framework;

namespace CoverletTests.FooTests
{
    [TestFixture]
    public class ApplicationTest
    {
        [Test]
        public void TestDoSomething_ActionB()
        {
            var instance = new Application();

            Assert.IsFalse(instance.DoSomething(false));
        }
    }
}
