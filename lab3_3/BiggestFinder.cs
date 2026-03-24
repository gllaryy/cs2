using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr3_3
{
    internal class BiggestFinder
    {
        public void Find(string path)
        {
            if (!Directory.Exists(path))
            {
                Console.WriteLine("Папка не знайдена!");
                return;
            }
            string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);

            if (files.Length == 0)
            {
                Console.WriteLine("Файлів немає.");
                return;
            }

            FileInfo biggest = new FileInfo(files[0]);

            foreach (string file in files)
            {
                FileInfo info = new FileInfo(file);

                if (info.Length > biggest.Length)
                {
                    biggest = info;
                }
            }

            Console.WriteLine("Name: " + biggest.Name);
            Console.WriteLine("Size: " + biggest.Length + " байт");
            Console.WriteLine("Path: " + biggest.FullName);
        }
    }
}
