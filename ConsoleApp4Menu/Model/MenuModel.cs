namespace ConsoleApp4Menu.Model
{
    public class MenuModel
    {
        public string[] MenuItems { get; }

        public MenuModel()
        {
            MenuItems = new[]
            {
                "Exit",
                "List All Customers",
                "Add Customer",
                "Delete Customer",
                "Edit Customer", 
                "Search for customer"
            };
        }
    }
}