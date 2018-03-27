using System;

namespace CroweHello
{
    public class SystemConsole : IConsole
    {
        public void WriteLine(string value)
        {
            Console.WriteLine(value);   
        }
    }
}
