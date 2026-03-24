using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using pr3_1;

namespace pr3_1
{
    internal class Writer
    {
        public void WriteReport(string path, TextAnalyzer analyzer)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("Lines: " + analyzer.LineCounter);
                writer.WriteLine("Words: " + analyzer.WordCounter);
                writer.WriteLine("Characters: " + analyzer.CharCounter);
            }
        }
    }
}

