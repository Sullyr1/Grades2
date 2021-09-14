// Programmer: Raleigh Sullivan
// Class: Managing Information Resourses
// Date: 14 Sept 2021
// Project: The grade you expect

using System;

namespace Grades2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter what grade you expect to get...");

            string input = Console.ReadLine();

            switch (input.ToUpper())
            {
                case "A":
                    Console.WriteLine("You would be an above average student, with 90 to 100");
                    Console.WriteLine("Press any key to exit the program.");
                    Console.ReadKey();
                    break;
                case "B":
                    Console.WriteLine("You would be a slightly above average student, with 80 to 89");
                    Console.WriteLine("Press any key to exit program.");
                    Console.ReadKey();
                    break;
                case "C":
                    Console.WriteLine("You would be an average student, with 70 to 79");
                    Console.WriteLine("Press any key to exit program.");
                    Console.ReadKey();
                    break;
                case "D":
                    Console.WriteLine("You would be an below average student, with 60 to 69");
                    Console.WriteLine("Press any key to exit program.");
                    Console.ReadKey();
                    break;
                case "F":
                    Console.WriteLine("You would FAIL! 59 or Below");
                    Console.WriteLine("Press any key to exit program.");
                    Console.ReadKey();
                    break;
                default:
                    break;

            }
        }
    }
}
