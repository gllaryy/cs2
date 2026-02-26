using System.Runtime.CompilerServices;

namespace pr1_6
{
    public delegate bool Validator(string message);
    internal class Program
    {
        static void Main()
        {

            Validator passcodeValidator = GetValidator(8);
            Validator logValidator = GetValidator(3);

            Console.Write("Enter passcode:");
            string passcode = Console.ReadLine();
            Console.Write("Enter login:");
            string login = Console.ReadLine();

            Console.WriteLine("Пароль валідний?:" + passcodeValidator(passcode));
            Console.WriteLine("Логін валідний?:" + logValidator(login));
        }

        static Validator GetValidator(int minLength)
        {
            return message => message.Length >= minLength;
        }
    }
}
