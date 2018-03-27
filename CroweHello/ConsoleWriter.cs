namespace CroweHello
{
    public class ConsoleWriter : IWriter
    {
        private readonly IConsole _console;

        public ConsoleWriter(IConsole console)
        {
            _console = console;
        }

        public void Write(string message)
        {
            _console.WriteLine(message);
        }
    }
}
