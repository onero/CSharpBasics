using ConsoleApp4Menu.BE;
using ConsoleApp4Menu.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
        [ExpectedException(typeof(ArgumentException))]
        public void TestAddDuplicateCustomerToModelFailure()
        {
            var customer = new Customer("Adam", "Hansen", "Test");
            var customerDuplicate = new Customer("Adam", "Hansen", "Test");

            _customerModel.AddCustomer(customer);
            _customerModel.AddCustomer(customerDuplicate);
        }
    }
}
