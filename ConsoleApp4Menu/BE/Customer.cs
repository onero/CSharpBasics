using System;

namespace ConsoleApp4Menu.BE
{
    public class Customer
    {
        public string FullName { get; set; }

        public string Address { get; set; }

        public Customer(string firstName, string lastName, string address)
        {
            FullName = $"{firstName} {lastName}";
            Address = address;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {FullName}");
            Console.WriteLine($"Address: {Address}");
        }
    }
}