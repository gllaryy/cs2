using System.Transactions;

namespace pr1_1
{
    internal class Program
    {
        public delegate double MathOperation(double x, double y);

        private static double Add(double x, double y)
        {
            return x + y;
        }

        private static double Substract(double x, double y)
        {
            return x - y;
        }

        private static double Multiply(double x, double y)
        {
            return x * y;
        }


        private static double Divide(double x, double y)
        {
            return x / y;
        }

        static void Main()
        {
            MathOperation operation = Add;
            double result = operation(2.5, 5.5);
            Console.WriteLine($"Result: {result}");

            operation = Substract;
            result = operation(5.5, 2.5);
            Console.WriteLine($"Result: {result}");

            operation = Multiply;
            result = operation(5.5, 2.2);
            Console.WriteLine($"Result: {result}");

            operation = Divide;
            result = operation(10.5, 2.5);
            Console.WriteLine($"Result: {result}");







        }
    }


}

