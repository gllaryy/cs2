using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr3_2
{
    internal class FolderInspector
    {
        public void Inspect(string path)
        {
            if(!Directory.Exists(path))
            {
                Console.WriteLine("Папка не знайдена(((");
                return;
            }
            Console.WriteLine("ПАПКИ:");
            foreach (string dir in Directory.GetDirectories(path))
            {
                Console.WriteLine(dir);
            }

            Console.WriteLine();
            Console.WriteLine("ФАЙЛИ:");

            foreach (string file in Directory.GetFiles(path))
            {
                FileInfo info = new FileInfo(file);

                Console.WriteLine("Файл: " + info.Name);
                Console.WriteLine("Розмір: " + info.Length + " байт");
                Console.WriteLine("Дата створення: " + info.CreationTime);
                Console.WriteLine();
            }
        }
    }
}
