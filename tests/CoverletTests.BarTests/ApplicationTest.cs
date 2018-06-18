using CoverletTest;
using NUnit.Framework;

namespace CoverletTests.BarTests
{
    [TestFixture]
    public class ApplicationTest
    {
        [Test]
        public void TestDoSomething_ActionA()
        {
            var instance = new Application();

            Assert.IsTrue(instance.DoSomething(true));
        }
    }
}
