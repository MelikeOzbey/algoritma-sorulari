using System;

namespace CrapsPlay
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            PlayCraps(number);
        }

        static void PlayCraps(int numb)
        {
            int num = numb;
            int counter = numb;

            int win = 0;


            while (counter > 0)
            {
                Console.WriteLine(counter + ". Oyun Başladı");

                int total = TotalNumberOfDices();

                if (total == 7 || total == 11)
                {
                    win++;

                    Console.WriteLine(counter + ".Oyun Kazanıldı");
                    Console.WriteLine();
                    counter--;


                }
                else if (total == 2 || total == 3 || total == 12)
                {

                    Console.WriteLine(counter + ".Oyun Kaybedildi");
                    Console.WriteLine();
                    counter--;

                }
                else
                {
                    var firsTotal = total;
                    int start = 1;

                    int total2 = TotalNumberOfDices();

                    for (int i = 0; i < start; i++)
                    {
                        if (firsTotal == total2)
                        {
                            win++;

                            Console.WriteLine(counter + ".Oyun Kazanıldı");
                            Console.WriteLine();
                            counter--;

                        }
                        else if (total2 == 7)
                        {

                            Console.WriteLine(counter + ".Oyun Kaybedildi");
                            Console.WriteLine();
                            counter--;

                        }
                        else
                        {

                            total2 = TotalNumberOfDices();
                            start++;
                        }
                    }

                }


            }

            Console.WriteLine(num+" oyunda kazanma olasılığı : " +(100*win)/ num);

        }
        static int TotalNumberOfDices()
        {
            int dice1, dice2, total;
            Random rnd = new Random();
            dice1 = rnd.Next(0, 6);
            dice2 = rnd.Next(0, 6);
            return total = dice1 + dice2;
        }
    }
}
