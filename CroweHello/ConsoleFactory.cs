namespace CroweHello
{
    public interface IConsoleFactory
    {
        IConsole CreateConsole();
    }

    public class ConsoleFactory : IConsoleFactory
    {
        public ConsoleFactory()
        {
            TestMode = false;
        }

        public bool TestMode { get; set; }

        public IConsole CreateConsole()
        {
            if (TestMode)
                return new TestConsole();
            else
                return new SystemConsole();
        }
    }
}
