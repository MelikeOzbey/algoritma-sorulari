using System;

namespace PositiveMultipliers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int number=Convert.ToInt32(Console.ReadLine());
            sum_factors(number);
        }

        static void sum_factors(int num)
        {
            int total = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    Console.Write(" " + i);
                    total = total + i;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Sum of positive factors : " + total);

        }
    }
}
