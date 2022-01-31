using System;

namespace TriangleOfPascal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Binomial Expansion");
            int a = 0; int b = number;
            while (b >= 0)
            {
                for (int c = 0; c < b; c++)
                {
                    Console.Write(" ");
                }
                BinomialExpansion(a); a++;
                Console.WriteLine();
                b--;
            }

        }

        static void BinomialExpansion(int a)
        {
            int x = 1; int y = 1;
            for (int i = 0; i < a; i++)
            {
                double number = C(a, i) * Math.Pow(x, i) * Math.Pow(y, a - i);
                Console.Write(" "+number);
               
            }
            Console.Write(" 1");
        }

        static double C(int n, int i)
        {
            return factorial(n) / (factorial(i) * factorial(n - i));
        }
        static double factorial(int num)
        {
            double result = 1;
            for (int i = 1; i <= num; i++)
            {
                result = result * i;
            }
            return result;
        }

    }
}
