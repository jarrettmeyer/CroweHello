using CroweHello.Properties;
using System;

namespace CroweHello
{
    class Program
    {
        public static void Main(string[] args)
        {
            var writerFactory = new WriterFactory();
            string writerType = Settings.Default.WriterType;
            IWriter writer = writerFactory.CreateWriter();
            writer.Write("Hello World");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
