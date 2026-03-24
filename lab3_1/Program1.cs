using pr3_1;
using System;
using System.IO;

namespace pr3_1
{

    class Program
    {
        static void Main(string[] args)
        {
            string inputPath = @"C:\Users\Mary\Desktop\prog\pr3\story.txt";
            string outputPath = @"C:\Users\Mary\Desktop\prog\pr3\report.txt";

            FileRead reader = new FileRead();
            TextAnalyzer analyzer = new TextAnalyzer();
            Writer writer = new Writer();

            string[] lines = reader.ReadFile(inputPath);

            analyzer.Analyze(lines);

            writer.WriteReport(outputPath, analyzer);

            Console.WriteLine("Report created.");
        }
    }
}
   

