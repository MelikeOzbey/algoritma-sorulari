using System;

namespace AngeBetweenHourAndMinuteHands
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Hour");
            int hour = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Minute");
            int minute = Convert.ToInt32(Console.ReadLine());

            FindAngleBetweenHourANdMinute(hour, minute);
            FindAngleBetweenHourANdMinute2(hour, minute);
        }

        static void FindAngleBetweenHourANdMinute(int hour, int min)
        {
            //formula:(30*hour) - (5.5*min) 
            Console.WriteLine((30 * hour) - (5.5 * min));

            //formula2:(11*min-60*hour) /2
            Console.WriteLine((11 * min - 60 * hour) / 2);

        }
        static void FindAngleBetweenHourANdMinute2(int hour, int min)
        {
           //formula2:(11*min-60*hour) /2
            Console.WriteLine((11 * min - 60 * hour) / 2);

        }
    }
}
