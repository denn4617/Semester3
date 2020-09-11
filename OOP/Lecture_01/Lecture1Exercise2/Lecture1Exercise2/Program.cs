using System;

namespace Lecture1Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            inputChecker();
        }

        // Converts radians to degrees
        static double radiansConverter()
        {
            Console.Write("\nEnter radians: ");
            double inputRadians = Double.Parse(Console.ReadLine());

            double degrees = inputRadians * (180 / Math.PI);

            Console.Write(inputRadians + " radians is equal to: ");

            return degrees;
        }

        // Converts degrees to radians
        static double degreeConverter()
        {
            Console.WriteLine("\nEnter degrees: ");
            double inputDegrees = Double.Parse(Console.ReadLine());

            double radians = inputDegrees * (Math.PI / 180);

            Console.Write(inputDegrees + " degrees is equal to: ");

            return radians;
        }

        static void inputChecker()
        {
            Console.WriteLine("Enter 'd' to convert degrees to radians");
            Console.WriteLine("Enter 'r' to convert radians to degrees");

            string userInput = Console.ReadLine();

            if (userInput == "r")
            {
                double degrees = radiansConverter();
                if (0 <= degrees && degrees <= 360)
                {
                    Console.WriteLine(degrees + " degrees");
                }
                else
                {
                    Console.WriteLine("The 'degrees' result is not a value in the interval between 0 and 360 degrees");
                }
            }
            else if (userInput == "d")
            {
                double radians = degreeConverter();
                if (0 <= radians && radians <= Math.PI * 2)
                {
                    Console.WriteLine(radians + " radians");
                }
                else
                {
                    Console.WriteLine("The 'radians' result is not a value in the interval between 0 and 2*PI");
                }

            }
            Console.WriteLine("\nWould you like to convert again?(y/n)");
            string convertAgain = Console.ReadLine();
            if (convertAgain == "y")
            {
                inputChecker();
            }
        }
    }
}