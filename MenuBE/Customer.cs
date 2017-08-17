using System;

namespace ConsoleApp4Menu.BE
{
    public class Customer
    {
        private static int _currentId;

        public int Id { get; }

        public string FullName { get; set; }

        public string Address { get; set; }

        public Customer(string firstName, string lastName, string address)
        {
            FullName = $"{firstName} {lastName}";
            Address = address;
            Id = _currentId++;

        }

        /// <summary>
        /// Display info about Customer
        /// </summary>
        public void DisplayInfo()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name: {FullName}");
            Console.WriteLine($"Address: {Address}");
        }
    }
}