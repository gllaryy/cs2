using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr3_1
{
    internal class TextAnalyzer
    {
        public int LineCounter { get; private set; }
        public int WordCounter { get; private set; }
        public int CharCounter { get; private set; }

        public void Analyze(string[] lines)
        {
            LineCounter = lines.Length;

            foreach (string line in lines)
            {
                CharCounter += line.Length;

                string[] words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                WordCounter += words.Length;
            }
        }

    }
}
