using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RegistrationServer.Tools
{
    class ConsoleWriter : TextWriter
    {
        private List<string> lines = new List<string>();

        private TextWriter original;
        public ConsoleWriter(TextWriter original)
        {
            this.original = original;
        }
        public override Encoding Encoding
        {
            get { return Encoding.Default; }
        }
        public override void WriteLine(string value)
        {
            lines.Add(value);
            original.WriteLine(value);
        }
        public string[] GetLines()
        {
            return lines.ToArray();
        }
    }
}
