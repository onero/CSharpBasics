using ConsoleApp4Menu.BE;
using ConsoleApp4Menu.BLL;
using ConsoleApp4Menu.Model;
using System;
using System.Linq;
using MenuBLL;


namespace ConsoleApp4Menu
{
    static class ConsoleMenuProgram
    {
        private static bool _userDone;
        private static readonly MenuModel MenuModel = new MenuModel();
        private static readonly CustomerModel CustomerModel = new CustomerModel();

        private static void Main(string[] args)
        {

            Console.WriteLine();
            while (!_userDone)
            {
                MenuManager.DisplayMenu(MenuModel.MenuItems);

                var userSelection = MenuManager.GetUserMenuSelection(MenuModel.MenuItems.Length);

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
                case 1:
                    Console.WriteLine("Exiting program, goodbye!");
                    _userDone = true;
                    break;
                case 2:
                    ListAllCustomers();
                    break;
                case 3:
                    DisplayAddCustomer();
                    break;
                case 4:
                    DisplayDeleteCustomer();
                    break;
                case 5:
                    DisplayEditCustomer();
                    break;
                case 6:
                    SearchForCustomer();
                    break;
                default:
                    throw new ArgumentException("Not a valid command!");
            }

            Console.WriteLine();
        }

        private static void SearchForCustomer()
        {
            Console.WriteLine($"Please enter a name to search for");
            var searchString = MenuManager.GetValidString();
            var customerFromSearch = CustomerModel.SearchForCustomerName(searchString);
            customerFromSearch.DisplayInfo();
        }

        /// <summary>
        /// Give user option to edit a customer
        /// </summary>
        private static void DisplayEditCustomer()
        {
            ListAllCustomers();

            Console.WriteLine();

            if (CustomerModel.GetCustomers().Any())
            {
                Console.WriteLine("Please write id of customer to edit:");

                var customerIdInput = MenuManager.GetSelectedCustomerId(CustomerModel.GetCustomers());

                var selectedCustomer = CustomerModel.GetCustomerById(customerIdInput);

                CustomerManager.EditCustomer(selectedCustomer);

                Console.WriteLine("New customer info:");

                selectedCustomer.DisplayInfo();

            }
        }

        /// <summary>
        /// Give user option to delete a customer
        /// </summary>
        private static void DisplayDeleteCustomer()
        {
            ListAllCustomers();

            Console.WriteLine();

            if (CustomerModel.GetCustomers().Any())
            {
                Console.WriteLine("Please write id of customer to delete");

                var customerIdInput = MenuManager.GetSelectedCustomerId(CustomerModel.GetCustomers());

                CustomerModel.DeleteCustomerById(customerIdInput);

                Console.WriteLine("Customer Deleted!");
            }

        }

        /// <summary>
        /// Give user option to add a customer
        /// </summary>
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
        }

        /// <summary>
        /// List all customers in model
        /// </summary>
        private static void ListAllCustomers()
        {
            var customers = CustomerModel.GetCustomers();

            Console.WriteLine("Listing all customers:\n");

            if (customers.Any())
            {
                foreach (var customer in customers)
                {
                    customer.DisplayInfo();
                }
            }
            else
            {
                Console.WriteLine("Ain't got no customers...");
            }
        }

    }
}