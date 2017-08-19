using System;
using System.Linq;
using ConsoleApp4Menu.BE;
using ConsoleApp4Menu.Model;
using Xunit;

namespace XunitMenuTests
{
    public class CustomerModelTests
    {
        private CustomerModel _customerModel;

        [Fact]
        public void TestAddToModelSuccess()
        {
            _customerModel = new CustomerModel();

            var customer = new Customer("Adam", "Hansen", "Test");

            _customerModel.AddCustomer(customer);

            Assert.True(_customerModel.GetCustomers().Contains(customer));
        }

        [Fact]
        public void TestDeleteFromModelSuccess()
        {
            _customerModel = new CustomerModel();

            var customer = new Customer("Adam", "Hansen", "Test");

            var customerId = customer.Id;

            _customerModel.AddCustomer(customer);

            _customerModel.DeleteCustomerById(customerId);

            Assert.False(_customerModel.GetCustomers().Any());
        }

        [Fact]
        public void TestGetCustomerById()
        {
            _customerModel = new CustomerModel();

            var customer = new Customer("Adam", "Hansen", "Test");
            var customerId = customer.Id;

            _customerModel.AddCustomer(customer);

            var customerFromModel = _customerModel.GetCustomerById(customerId);

            Assert.True(customer.Id == customerFromModel.Id);
        }
    }
}
