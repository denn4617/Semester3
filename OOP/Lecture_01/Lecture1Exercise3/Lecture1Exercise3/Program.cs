using System;

namespace Lecture1Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the amount of asterisk, you want to print out: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            char[] arr = new char[amount];
            char asterisk = '*';
            for (int i = amount - 1; i > 0; i--)
            {
                arr[i] = asterisk;
                Console.WriteLine(arr);
            }

        }
    }
}