using System;

namespace Lecture1Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number you want the square root of: ");
            string userInput = Console.ReadLine();
            double number = Convert.ToDouble(userInput);

            double squareRoot = Math.Sqrt(number);

            Console.WriteLine("Square root: " + squareRoot);
        }
    }
}