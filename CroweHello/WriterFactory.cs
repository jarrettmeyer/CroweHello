using CroweHello.Properties;
using System;

namespace CroweHello
{
    public interface IWriterFactory
    {
        IWriter CreateWriter();
    }

    public class WriterFactory
    {
        public WriterFactory()
        {
            Mode = WriterFactoryMode.TestConsole;
        }

        public WriterFactoryMode Mode { get; set; }

        public IWriter CreateWriter()
        {
            IWriter writer;

            switch (Mode)
            {
                case WriterFactoryMode.Console:
                    writer = GetConsoleWriter(testMode: false);
                    break;
                case WriterFactoryMode.File:
                    writer = GetFileWriter();
                    break;
                case WriterFactoryMode.TestConsole:
                    writer = GetConsoleWriter(testMode: true);
                    break;
                default:
                    throw new NotImplementedException("Unknown writer type requested.");
            }
            return writer;
        }

        private IConsoleFactory GetConsoleFactory(bool testMode)
        {
            var consoleFactory = new ConsoleFactory();
            consoleFactory.TestMode = testMode;
            return consoleFactory;
        }

        private IWriter GetConsoleWriter(bool testMode)
        {
            var consoleFactory = GetConsoleFactory(testMode);
            var console = consoleFactory.CreateConsole();
            var writer = new ConsoleWriter(console);
            return writer;
        }

        private IWriter GetFileWriter()
        {
            var writer = new FileWriter(Settings.Default.Filename);
            return writer;
        }

    }
}
