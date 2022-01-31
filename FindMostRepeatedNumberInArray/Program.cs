using System;

namespace FindMostRepeatedNumberInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = GenerateArray(size);

           // int[] array = new int[5] { 10, 10, 11, 11, 11 };

            Console.WriteLine(MostRepatedNumber(array) + " number is most repated in array");
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

        static int MostRepatedNumber(int[] array)
        {
            int numberCount = 0;
            int mostRepeatedNumber = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int counter = 0;
                
                for (int j = i+1; j < array.Length; j++)
                {
                    if(array[i]==array[j])
                    {
                        counter++;
                    }
                }

                if(counter> numberCount)
                {
                    numberCount = counter;
                    mostRepeatedNumber = array[i];
                }
            }

            return mostRepeatedNumber;
        }
    }
}
