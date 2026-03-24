using pr3_2;

namespace pr3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Mary\Desktop\prog\pr3";

            FolderInspector inspector = new FolderInspector();
            inspector.Inspect(path);
        }
    }
}
