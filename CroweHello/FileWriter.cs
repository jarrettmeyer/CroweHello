using System;
using System.IO;
using System.Text;

namespace CroweHello
{
    public class FileWriter : IWriter
    {
        private readonly string _filename;

        public FileWriter(string filename)
        {
            _filename = filename;
        }

        public void Write(string message)
        {
            using (var file = File.Open(_filename, FileMode.Append))
            {
                message += Environment.NewLine;
                var bytes = Encoding.UTF8.GetBytes(message);
                var byteLength = bytes.Length;
                file.Write(bytes, 0, byteLength);
            }
        }
    }
}
