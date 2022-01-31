using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The smallest two digit prime number is " + FindTwoDigitSmallPrimeNum().ToString());
            Console.WriteLine("The largest two digit prime number is " + FindTwoDigitLargePrimeNum().ToString());
            Console.WriteLine("Total number is " + (FindTwoDigitLargePrimeNum()+ FindTwoDigitSmallPrimeNum()).ToString());
            Console.WriteLine();
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
            Console.WriteLine("The smallest three digit prime number is " + FindThreeDigitSmallPrimeNum().ToString());
            Console.WriteLine("The largest three digit prime number is " + FindThreeDigitLargePrimeNum().ToString());
            Console.WriteLine("Total number is " + (FindThreeDigitLargePrimeNum() + FindThreeDigitSmallPrimeNum()).ToString());





        }

        static int FindTwoDigitSmallPrimeNum()
        {
            int smallPrimeNumber = 0;
            for (int i = 10; i < 100; i++)
            {
                int count = 0;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                        break;
                    }

                }
                if (count == 0)
                {
                    smallPrimeNumber = i;
                    break;
                }
            }

            return smallPrimeNumber;
        }

        static int FindTwoDigitLargePrimeNum()
        {
            int largePrimeNumber = 0;
            for (int i = 99; i > 9; i--)
            {
                int count = 0;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                        break;
                    }

                }
                if (count == 0)
                {
                    largePrimeNumber = i;
                    break;
                }
            }

            return largePrimeNumber;
        }

        static int FindThreeDigitSmallPrimeNum()
        {
            int smallPrimeNumber = 0;
            for (int i = 100; i < 1000; i++)
            {
                int count = 0;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                        break;
                    }

                }
                if (count == 0)
                {
                    smallPrimeNumber = i;
                    break;
                }
            }

            return smallPrimeNumber;
        }

        static int FindThreeDigitLargePrimeNum()
        {
            int largePrimeNumber = 0;
            for (int i = 999; i > 99; i--)
            {
                int count = 0;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                        break;
                    }

                }
                if (count == 0)
                {
                    largePrimeNumber = i;
                    break;
                }
            }

            return largePrimeNumber;
        }
    }
}
