using System;

namespace ConsoleApp4Menu
{
    static class ConsoleProgram
    {
        static void Main(string[] args)
        {
            var menuItems = new[]
            {
                "List All Customers",
                "Add Customer",
                "Delete Customer",
                "Edit Customer",
                "Exit"
            };

            Console.WriteLine("Select what you want to do:");
            //foreach (var menuItem in menuItems)
            //{
            //    Console.WriteLine(menuItem);
            //}

            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.WriteLine($"{i + 1}: {menuItems[i]}");
            }

            var userInput = Console.ReadLine();
        }
    }
}