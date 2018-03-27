using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CroweHello.Tests
{
    [TestClass]
    public class ConsoleFactoryTests
    {
        [TestMethod]
        public void CreateConsoleReturnsTestConsoleWhenTestModeIsTrue()
        {
            var consoleFactory = new ConsoleFactory();
            consoleFactory.TestMode = true;
            var console = consoleFactory.CreateConsole();
            Assert.AreEqual("CroweHello.TestConsole", console.GetType().FullName);
        }

        [TestMethod]
        public void CreateConsoleReturnsSystemConsoleWhenTestModeIsFalse()
        {
            var consoleFactory = new ConsoleFactory();
            consoleFactory.TestMode = false;
            var console = consoleFactory.CreateConsole();
            Assert.AreEqual("CroweHello.SystemConsole", console.GetType().FullName);
        }
    }
}
