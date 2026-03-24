namespace pr3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Mary\Desktop";

            BiggestFinder finder = new BiggestFinder();
            finder.Find(path);
        }
    }
}
