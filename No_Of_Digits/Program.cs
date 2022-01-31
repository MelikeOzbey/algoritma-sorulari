using System;
using System.Linq;

namespace No_Of_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine("{0} number is {1} digit(s)", number,no_of_digits(number));
            Console.WriteLine("{0} number is {1} digit(s)", number, no_of_digits(Convert.ToInt32(number)));


        }

        public static int no_of_digits(string number)
        {
            int numberCount = number.ToCharArray().Count();
            return numberCount;
        }
        public static int no_of_digits(int number)
        {
            int count = 0;
            while (number>0)
            {
                number = number / 10;
                count++;
            }
            return count;
        }

    }
}
