using ConsoleApp4Menu.BE;
using ConsoleApp4Menu.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace MenuTests
{
    [TestClass]
    public class CustomerModelTests
    {
        private CustomerModel _customerModel;

        [TestInitialize]
        public void InitializeTest()
        {
            _customerModel = new CustomerModel();
        }

        [TestMethod]
        public void TestAddToModelSuccess()
        {
            var customer = new Customer("Adam", "Hansen", "Test");

            _customerModel.AddCustomer(customer);

            Assert.IsTrue(_customerModel.GetCustomers().Contains(customer));
        }

        [TestMethod]
        public void TestDeleteFromModelSuccess()
        {
            var customer = new Customer("Adam", "Hansen", "Test");

            var customerId = customer.Id;

            _customerModel.AddCustomer(customer);

            _customerModel.DeleteCustomerById(customerId);

            Assert.IsFalse(_customerModel.GetCustomers().Any());
        }

        [TestMethod]
        public void TestGetCustomerById()
        {
            var customer = new Customer("Adam", "Hansen", "Test");
            var customerId = customer.Id;

            _customerModel.AddCustomer(customer);

            var customerFromModel = _customerModel.GetCustomerById(customerId);

            Assert.IsTrue(customer.Id == customerFromModel.Id);
        }
    }
}
