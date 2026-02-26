namespace pr1_5
{
    internal class Program
    {
        static void Main()
        {
            Logger logger = new Logger();
            logger.LogHandler = Console.WriteLine;
            logger.Log("Hello world");
            logger.Log("First message");
            logger.LogHandler = message =>
            {
                Console.WriteLine(message.ToUpper());
            };
            logger.Log("Hello hello");
            logger.Log("Second message");
        }
    }
}
