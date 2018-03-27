using System.Text;

namespace CroweHello
{
    public class TestConsole : IConsole
    {
        private StringBuilder _stringBuilder = new StringBuilder();

        public void WriteLine(string value)
        {
            _stringBuilder.AppendLine(value);
        }

        public override string ToString()
        {
            return _stringBuilder.ToString();
        }
    }
}
