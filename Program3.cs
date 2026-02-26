namespace pr1_3
{
    public delegate bool FilterPredicate(int value);
    internal class Program
    {

        static void FilterArray(int[] numbers, FilterPredicate predicate)
        {
            foreach (int n in numbers)
            {
                if (predicate(n))
                {
                    Console.WriteLine(n);
                }
            }
            Console.WriteLine();
        }


        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        static bool IsGreaterThanFive(int number)
        {
            return number > 5;
        }
        static void Main()
        { 
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Парні числа:");
            FilterArray(numbers, IsEven);

            Console.WriteLine("Числа більше 5:");
            FilterArray(numbers, IsGreaterThanFive);

            Console.WriteLine("Непарні числа:");
            FilterArray(numbers, number => number % 2 != 0);
        }
    }
}
