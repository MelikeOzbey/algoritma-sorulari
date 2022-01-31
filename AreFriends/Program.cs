using System;

namespace AreFriends
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Are_Friends(number1, number2);
        }

        static void Are_Friends(int num1, int num2)
        {
            int numTotal1 = 0;
            int numTotal2 = 0;

            for (int i = 1; i < num1; i++)
            {
                if(num1%i==0)
                {
                    numTotal1 = numTotal1 + i;
                }
            }

            for (int i = 1; i < num2; i++)
            {
                if (num2 % i == 0)
                {
                    numTotal2 = numTotal2 + i;
                }
            }

            if(numTotal1==num2 && numTotal2==num1)
            {
                Console.WriteLine(string.Format("{0} nad {1} numbers are friends",num1,num2));
            }
        }
    }
}
