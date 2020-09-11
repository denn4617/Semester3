using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Lecture1Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Select 1 if you want to enter the amount of group member or 2 if you don't: ");
            string programMode = Console.ReadLine();
            if (programMode == "1")
            {
                Console.Write("\nEnter the amount of group members: ");
                string userInput = Console.ReadLine();
                int members = int.Parse(userInput);

                string[] memberName = new string[members];

                for (int i = 0; i < members; i++)
                {
                    int iContainer = i + 1;

                    Console.Write("\nType the name of group member #" + iContainer + ": ");
                    memberName[i] = Console.ReadLine();

                }
                for (int i = 0; i < members; i++)
                {
                    Console.WriteLine(memberName[i]);
                }
            }
            else if (programMode == "2")
            {
                List<string> memberNameList = new List<string>();
                int iContainer = 1;
                while (true)
                {
                    Console.Write("\nType the name of group member #" + iContainer++ + ": ");
                    string memberName = Console.ReadLine();
                    if (memberName == "")
                    {
                        break;
                    }
                    memberNameList.Add(memberName);
                }
                foreach (var i in memberNameList)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}