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
        /// <param name="menuItems"></param>
        /// <returns>Selected menu item as integer</returns>
        public static int GetUserMenuSelection(string[] menuItems)
        {
            Console.Write("Please enter your choice: ");
            int selection;
            int maxIndex = menuItems.Length;
            while (ParseInteger(out selection) || IsSelectionUnderIndex(selection) || SelectionOverIndex(selection, maxIndex))
            {
                Console.WriteLine($"You need to select a number between 1 and {maxIndex}");
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
            int maxIndex = customers.Count - 1;
            while (ParseInteger(out selection) || IsSelectionUnderIndex(selection) || SelectionOverIndex(selection, maxIndex))
            {
                Console.WriteLine($"You need to select a number between 0 and {maxIndex}");
            }
            Console.WriteLine();
            return selection;
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

        private static bool SelectionOverIndex(int selection, int maxIndex)
        {
            return selection > maxIndex;
        }

        private static bool IsSelectionUnderIndex(int selection)
        {
            return selection < 0;
        }

        private static bool ParseInteger(out int selection)
        {

            return !int.TryParse(Console.ReadLine(), out selection);
        }
    }
}