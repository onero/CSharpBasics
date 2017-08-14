using ConsoleApp4Menu.BE;
using ConsoleApp4Menu.BLL;
using ConsoleApp4Menu.Model;
using System;
using System.Linq;

namespace ConsoleApp4Menu
{
    static class ConsoleMenuProgram
    {
        private static bool UserDone = false;
        private static readonly MenuModel MenuModel = new MenuModel();
        private static readonly CustomerModel CustomerModel = new CustomerModel();

        private static void Main(string[] args)
        {

            while (!UserDone)
            {
                MenuManager.DisplayMenu(MenuModel.MenuItems);

                var userSelection = MenuManager.GetUserMenuSelection(MenuModel.MenuItems);

                ReactToUserInput(userSelection);
            }


        }

        /// <summary>
        /// Carry out action related to user selection
        /// </summary>
        /// <param name="userSelection"></param>
        private static void ReactToUserInput(int userSelection)
        {
            switch (userSelection)
            {
                case 0:
                    //TODO ALH: Rethink :P
                    Console.WriteLine("You just found the easter egg!\n");
                    break;
                case 1:
                    ListAllCustomers();
                    break;
                case 2:
                    DisplayAddCustomer();
                    break;
                case 3:
                    DisplayDeleteCustomer();
                    break;
                case 4:
                    //TODO ALH: "Edit Customer"
                    break;
                case 5:
                    Console.WriteLine("Exiting program, goodbye!");
                    UserDone = true;
                    break;
                default:
                    throw new ArgumentException("Not a valid command!");
            }
        }

        private static void DisplayDeleteCustomer()
        {
            ListAllCustomers();

            Console.Write("Please write id of customer to delete: ");

            var customerIdInput = MenuManager.GetSelectedCustomerId(CustomerModel.GetCustomers());

            CustomerModel.DeleteCustomerById(customerIdInput);

            Console.WriteLine("Customer Deleted!");

            Console.WriteLine();
        }

        private static void DisplayAddCustomer()
        {
            Console.Write("Please Enter First Name: ");
            var firstName = MenuManager.GetValidString();

            Console.Write("Please Enter Last Name: ");
            var lastName = MenuManager.GetValidString();

            Console.Write("Please Enter Address: ");
            var address = MenuManager.GetValidString();

            var newCustomer = new Customer(firstName, lastName, address);

            try
            {
                CustomerModel.AddCustomer(newCustomer);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// List all customers in model
        /// </summary>
        private static void ListAllCustomers()
        {
            var customers = CustomerModel.GetCustomers();
            //TODO ALH: Test this!
            Console.WriteLine("Listing all customers:\n");

            if (customers.Any())
            {
                for (int i = 0; i < customers.Count; i++)
                {
                    Console.WriteLine($"ID: {i}");
                    Console.WriteLine($"Name: {customers[i].FullName}");
                    Console.WriteLine($"Address: {customers[i].Address}");
                }
            }
            else
            {
                Console.WriteLine("Ain't got no customers...");
            }

            Console.WriteLine();
        }

    }
}