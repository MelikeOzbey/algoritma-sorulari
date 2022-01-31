using System;

namespace CelToFahr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            double number = Convert.ToDouble(Console.ReadLine());
            cel_to_fahr(number);
        }

        static void cel_to_fahr(double num)
        {
            //T(°F) = T(°C) × 1.8 + 32
            double fahr = num * 1.8 + 32;
            Console.Write(num+" C is "+fahr+" F");
        }
    }
}
