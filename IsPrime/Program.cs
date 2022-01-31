using System;

namespace IsPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                if (IsPrime(number) == 0)
                {
                    Console.WriteLine(number + " is not a prime number");
                }
                else
                {
                    Console.WriteLine(number + " is a prime number");
                }
            }
            else
            {
                Console.Write("Enter positive integer, please! ");
            }
        }

        static int IsPrime(int number)
        {

            int counter = 0;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    counter++;
                }

            }

            if (counter > 0)
                return 0;
            else
                return number;

        }
    }
}
