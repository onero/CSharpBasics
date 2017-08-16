using ConsoleApp4Menu.BE;
using System;
using System.Collections.Generic;

namespace ConsoleApp4Menu.BLL
{
    public static class MenuManager
    {
        /// <summary>
        /// Get selection from user
        /// </summary>
        /// <param name="numberOfMenuItems"></param>
        /// <returns>Selected menu item as integer</returns>
        public static int GetUserMenuSelection(int numberOfMenuItems)
        {
            Console.Write("Please enter your choice: ");
            int selection;
            while (!InputValidation.ParseIntegerFromConsole(out selection) ||
                   InputValidation.IsSelectionUnderIndex(selection) ||
                   InputValidation.SelectionOverIndex(selection, numberOfMenuItems))
            {
                Console.WriteLine($"You need to select a number between 1 and {numberOfMenuItems}");
                Console.Write("Please enter your choice: ");
            }
            Console.WriteLine();
            return selection;
        }

        /// <summary>
        /// Get selected customer ID
        /// </summary>
        /// <param name="customers"></param>
        /// <returns></returns>
        public static int GetSelectedCustomerId(List<Customer> customers)
        {
            Console.Write("Please enter your choice: ");
            int selection;
            while (!InputValidation.ParseIntegerFromConsole(out selection) || !IdExist(customers, selection))
            {
                Console.WriteLine($"Id {selection} is not a valid Id!");
                Console.Write("Please enter your choice: ");
            }
            Console.WriteLine();
            return selection;
        }

        /// <summary>
        /// Return if the Id exists
        /// </summary>
        /// <param name="customers"></param>
        /// <param name="selectedId"></param>
        /// <returns></returns>
        private static bool IdExist(List<Customer> customers, int selectedId)
        {
            return customers.Exists(c => c.Id == selectedId);
        }

        /// <summary>
        /// Display each item in menu
        /// </summary>
        /// <param name="menuItems"></param>
        public static void DisplayMenu(string[] menuItems)
        {
            //Console.Clear();

            Console.WriteLine("Select what you want to do:");

            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.WriteLine($"{i + 1}: {menuItems[i]}");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Get name from user
        /// </summary>
        /// <returns>valid name from user as string</returns>
        /// <remarks>Will validate against containing numbers</remarks>
        public static string GetValidString()
        {
            bool nameAccepted = false;
            string inputName;

            do
            {
                inputName = Console.ReadLine();

                if (InputValidation.IsValidName(inputName))
                {
                    nameAccepted = true;
                }
            } while (!nameAccepted);
            return inputName;
        }
    }
}