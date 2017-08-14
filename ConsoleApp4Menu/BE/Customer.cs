namespace ConsoleApp4Menu.BE
{
    public class Customer
    {
        public string FullName { get; }

        public string Address { get; set; }

        public Customer(string firstName, string lastName)
        {
            FullName = $"{firstName} {lastName}";
        }
    }
}