using System;
using System.Text.RegularExpressions;

namespace ConsoleApp2
{
    class Program
    {
        private static readonly Regex RegexNumbers = new Regex("^(?=.*[0-9])");
        private static bool NameAccepted { get; set; }


        static void Main(string[] args)
        {
            string userName;

            do
            {
                Console.Write("Type your name: ");

                userName = Console.ReadLine();

                // Give nice greeting, if user entered valid name, else insult!
                if (!RegexNumbers.IsMatch(userName))
                {
                    Console.WriteLine($"Hello {userName}");
                    NameAccepted = true;
                }
                else
                {
                    Console.WriteLine("That's not a name.... Stupid!");
                    NameAccepted = false;
                }
            } while (!NameAccepted);

            // Give hearty comment
            if (userName.Contains("A") || userName.Contains("F"))
            {
                Console.WriteLine("Your name is so awesome!");
            }

            // Give user possibility to exit
            Console.WriteLine("Please hit enter to exit...");

            // Ensure program keeps running until user hits a key
            Console.ReadLine();

        }
    }
}