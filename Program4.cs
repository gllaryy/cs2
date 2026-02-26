namespace pr1_4
{
    internal class Program
    {
        static void Main()
        {
             Func<double, double, double> _operation;
             Predicate<string> _nameFilter;
            _operation = Add;
            Console.WriteLine("Add:" + _operation(2.5, 5.5));
            _operation = Subtract;
            Console.WriteLine("Subtract:" + _operation(10, 3));
            _operation = Multiply;
            Console.WriteLine("Multiply:" + _operation(4, 2));
            _operation = Divide;
            Console.WriteLine("Divide:" + _operation(8, 2));

            List<string> students = new List<string>
            {
                "Petro",
                "Ihor",
                "Vasyl",
                "Olena",
                "Anna"
            };
            Predicate<string> filter = name => name.StartsWith("A");
            List<string> result = students.FindAll(filter);
            Console.WriteLine("Iмена на A:");

            foreach (string name in result)
            {
                Console.WriteLine(name);
            }
        }

        static double Add(double a, double b)
        {
            return a + b;
        }
        static double Subtract(double a, double b)
        {
            return a - b;
        }
        static double Multiply(double a, double b)
        {
            return a * b;
        }
        static double Divide(double a, double b)
        {
            return a / b;
        }

    }
    }

