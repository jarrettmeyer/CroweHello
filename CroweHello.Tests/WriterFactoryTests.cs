using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CroweHello
{
    [TestClass]
    public class WriterFactoryTests
    {
        private IWriter writer;
        private WriterFactory writerFactory;

        [TestMethod]
        public void CreateWriterReturnsConsoleWriterInstance()
        {
            writerFactory = new WriterFactory();
            writer = writerFactory.CreateWriter();
            Assert.AreEqual("CroweHello.ConsoleWriter", writer.GetType().FullName);
        }
    }
}
