using System;

namespace IsArrayOrdered
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] array = GenerateArray(10);
            //int[] array = new int[5] { 10, 11, 21, 13, 18 };

            foreach (var item in array)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine();

            if (IsSorted(array, 5))
                Console.WriteLine("The numbers ara sorted");
            else
                Console.WriteLine("The numbers are not sorted");
        }

        static bool IsSorted(int[] array, int size)
        {
            bool result = true;
            for (int i = 0; i < size; i++)
            {
                for (int k = i + 1; k < size; k++)
                {
                    if (array[i] > array[k])
                    {
                        result = false;
                        break;

                    }

                }

            }
            return result;

        }

        static int[] GenerateArray(int size)
        {
            Random rnd = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = rnd.Next(1, 20);
            }

            return array;
        }

    }
}
