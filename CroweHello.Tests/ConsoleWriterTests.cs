using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CroweHello
{
    [TestClass]
    public class ConsoleWriterTests
    {
        TestConsole console;
        ConsoleWriter consoleWriter;

        [TestMethod]
        public void WriteWritesToConsole()
        {
            console = new TestConsole();
            consoleWriter = new ConsoleWriter(console);
            consoleWriter.Write("Hello from Unit Test!");
            Assert.AreEqual("Hello from Unit Test!" + Environment.NewLine, console.ToString());
        }
    }
}
