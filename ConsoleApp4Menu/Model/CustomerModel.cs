using ConsoleApp4Menu.BE;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp4Menu.Model
{
    public class CustomerModel
    {
        private readonly HashSet<Customer> _customers;

        public CustomerModel()
        {
            _customers = new HashSet<Customer>();
        }

        /// <summary>
        /// Adds the parsed customer to the list, if customer is not already in list
        /// </summary>
        /// <param name="customerToAdd"></param>
        public void AddCustomer(Customer customerToAdd)
        {
            _customers.Add(customerToAdd);
        }

        public List<Customer> GetCustomers()
        {
            return new List<Customer>(_customers);
        }

        public Customer GetCustomerById(int id)
        {
            return _customers.First(c => c.Id == id);
        }

        /// <summary>
        /// Removes a customer by provided id
        /// </summary>
        /// <param name="idToRemove"></param>
        public void DeleteCustomerById(int idToRemove)
        {
            var customerToDelete = GetCustomerById(idToRemove);
            _customers.Remove(customerToDelete);
        }

        /// <summary>
        /// Search for customer by name
        /// </summary>
        /// <param name="searchString"></param>
        /// <returns></returns>
        public Customer SearchForCustomerName(string searchString)
        {
            return _customers.FirstOrDefault(c => c.FullName.Contains(searchString));
        }
    }
}