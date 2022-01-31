using System;

namespace PrimeNumberCrossword
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i < 1000; i++)
            {
                int counter = 0;
                var numberArray = i.ToString().ToCharArray();
                //first Condition
                //cba
                string numString = numberArray[2].ToString() + numberArray[1].ToString() + numberArray[0].ToString();
                int number = Convert.ToInt32(numString);
                if (number > i)
                {
                    counter++;
                }
                //ab
                string numTwoDigitString1 = numberArray[0].ToString() + numberArray[1].ToString();
                int numberTwoDigit1 = Convert.ToInt32(numTwoDigitString1);

                //bc
                string numTwoDigitString2 = numberArray[1].ToString() + numberArray[2].ToString();
                int numberTwoDigit2 = Convert.ToInt32(numTwoDigitString2);
                //cb
                string numTwoDigitString3 = numberArray[2].ToString() + numberArray[1].ToString();
                int numberTwoDigit3 = Convert.ToInt32(numTwoDigitString3);
                //ba
                string numTwoDigitString4 = numberArray[1].ToString() + numberArray[0].ToString();
                int numberTwoDigit4 = Convert.ToInt32(numTwoDigitString4);


                if (counter == 1 && CheckIfPrimeNumber(i) && CheckIfPrimeNumber(numberTwoDigit1) && CheckIfPrimeNumber(numberTwoDigit2) && CheckIfPrimeNumber(numberTwoDigit3) && CheckIfPrimeNumber(numberTwoDigit4))
                {
                    Console.WriteLine(i);
                }
               
            }
        }

        static bool CheckIfPrimeNumber(int num)
        {
            var result = true;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

    }
}
