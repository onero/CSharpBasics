using System.Text.RegularExpressions;

namespace ConsoleApp4Menu.BLL
{
    public static class InputValidation
    {
        // Filter numbers in string
        private static readonly Regex RegexNumbers = new Regex("^(?=.*[0-9])");

        public static bool IsValidName(string name)
        {
            return !RegexNumbers.IsMatch(name);
        }
    }
}