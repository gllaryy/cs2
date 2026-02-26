namespace pr1_2
{
    public delegate void NotificationHandle(string message);
    internal class Program
    {
        static void Main()
        {
            NotificationHandle del = SendEmail;
            del += SendSMS;
            del("babulya");



        }
        private static void SendEmail(string message)
        {
            Console.WriteLine($"Email sent: {message}");
        }

        private static void SendSMS(string message)
        {
            Console.WriteLine($"SMS sent: {message}");
        }

    }
}
