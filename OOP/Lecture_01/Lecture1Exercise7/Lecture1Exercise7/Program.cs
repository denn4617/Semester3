using System;

namespace Lecture1Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            const int LOTTOTAL = 7;
            Console.WriteLine("LOTTOTAL!");
            //Console.WriteLine("_________");

            int[,] lottoArray = new int[7, 7];

            for (int i = 1; i < LOTTOTAL + 1; i++)
            {
                Console.Write("#" + i + ": ");
                for (int j = 0; j < LOTTOTAL; j++)
                {
                    lottoArray[j, j] = randomLotto();
                    if (lottoArray[j, j] < 10)
                    {
                        Console.Write("0");
                    }
                    Console.Write(lottoArray[j, j] + " ");
                }
                Console.WriteLine();
            }


        }
        static int randomLotto()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 100);
            return randomNumber;
        }
    }
}