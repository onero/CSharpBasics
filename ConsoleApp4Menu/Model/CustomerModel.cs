using ConsoleApp4Menu.BE;
using System;
using System.Collections.Generic;

namespace ConsoleApp4Menu.Model
{
    public class CustomerModel
    {
        private readonly List<Customer> _customers;

        public CustomerModel()
        {
            _customers = new List<Customer>();
        }

        /// <summary>
        /// Adds the parsed customer to the list, if customer is not already in list
        /// </summary>
        /// <param name="customerToAdd"></param>
        public void AddCustomer(Customer customerToAdd)
        {
            if (!_customers.Exists(c => c.FullName.Equals(customerToAdd.FullName)))
            {
                _customers.Add(customerToAdd);
            }
            else
            {
                throw new ArgumentException("Customer already exists!");
            }
        }

        public List<Customer> GetCustomers()
        {
            return new List<Customer>(_customers);
        }

        public Customer GetCustomerById(int id)
        {
            return _customers.Find(c => c.Id == id);
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
    }
}