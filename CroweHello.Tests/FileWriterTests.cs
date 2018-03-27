using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text;

namespace CroweHello
{
    [TestClass]
    public class FileWriterTests
    {
        private string _filename;
        private FileWriter _fileWriter;

        [TestInitialize]
        public void BeforeEachTest()
        {
            _filename = "C:\\temp\\" + Guid.NewGuid() + ".txt";
            _fileWriter = new FileWriter(_filename);
        }

        [TestCleanup]
        public void AfterEachTest()
        {
            File.Delete(_filename);
        }

        [TestMethod]
        public void WriteWritesToFile()
        {
            _fileWriter.Write("This is written to a file.");
            var bytes = File.ReadAllBytes(_filename);
            var message = Encoding.UTF8.GetString(bytes);
            Assert.AreEqual("This is written to a file." + Environment.NewLine, message);
        }
    }
}
