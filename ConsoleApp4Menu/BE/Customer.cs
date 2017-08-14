namespace ConsoleApp4Menu.BE
{
    public class Customer
    {
        public string FullName { get; }

        public string Address { get; }

        public Customer(string firstName, string lastName, string address)
        {
            FullName = $"{firstName} {lastName}";
            Address = address;
        }
    }
}