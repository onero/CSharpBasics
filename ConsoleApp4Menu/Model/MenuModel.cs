namespace ConsoleApp4Menu.Model
{
    public class MenuModel
    {
        public string[] MenuItems { get; }

        public MenuModel()
        {
            MenuItems = new[]
            {
                "List All Customers",
                "Add Customer",
                "Delete Customer",
                "Edit Customer",
                "Exit"
            };
        }
    }
}