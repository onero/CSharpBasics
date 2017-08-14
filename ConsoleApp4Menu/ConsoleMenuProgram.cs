using ConsoleApp4Menu.BE;
using ConsoleApp4Menu.BLL;
using ConsoleApp4Menu.Model;
using System;
using System.Collections.Generic;

namespace ConsoleApp4Menu
{
    static class ConsoleMenuProgram
    {

        private static readonly MenuModel MenuModel = new MenuModel();
        private static readonly CustomerModel CustomerModel = new CustomerModel();

        private static void Main(string[] args)
        {

            var customer1 = new Customer("Adam", "Hansen") { Address = "Da secret place!" };

            MenuManager.DisplayMenu(MenuModel.MenuItems);

            var userSelection = MenuManager.GetUserSelection(MenuModel.MenuItems);

            ReactToUserInput(userSelection);

            Console.ReadLine();
        }

        /// <summary>
        /// Carry out action related to user selection
        /// </summary>
        /// <param name="userSelection"></param>
        private static void ReactToUserInput(int userSelection)
        {
            switch (userSelection)
            {
                case 1:
                    ListAllCustomers(CustomerModel.GetCustomers());
                    break;
                case 2:
                    DisplayAddCustomer();
                    break;
                case 3:
                    //TODO ALH: "Delete Customer"
                    break;
                case 4:
                    //TODO ALH: "Edit Customer"
                    break;
                case 5:
                    Console.WriteLine("Exiting program, goodbye!");
                    Environment.Exit(0);
                    break;
                default:
                    throw new ArgumentException("Not a valid command!");
            }
            // Display main menu again for user
            MenuManager.DisplayMenu(MenuModel.MenuItems);
        }

        private static void DisplayAddCustomer()
        {
            Console.Write("Please enter first name: ");
            var firstName = MenuManager.GetValidName();

            Console.Write("Please enter last name: ");
            var lastName = MenuManager.GetValidName();

            var newCustomer = new Customer(firstName, lastName);

            try
            {
                CustomerModel.AddCustomer(newCustomer);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// List all customers in model
        /// </summary>
        /// <param name="customers"></param>
        public static void ListAllCustomers(List<Customer> customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine($"Name: {customer.FullName}");
                Console.WriteLine($"Address: {customer.Address}");
            }
        }

    }
}