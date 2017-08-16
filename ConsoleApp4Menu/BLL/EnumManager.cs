using System;
using System.Reflection;

namespace ConsoleApp4Menu.BLL
{
    public static class EnumManager
    {
        /// <summary>
        /// Class to display the text of an attribute
        /// </summary>
        public class DisplayText : Attribute
        {
            /// <summary>
            /// If attribute has text, display it
            /// </summary>
            /// <param name="text"></param>
            public DisplayText(string text)
            {
                this.Text = text ?? throw new ArgumentNullException($"Couldn't find text: {nameof(text)}");
            }

            public string Text { get; private set; }
        }

    }

    /// <summary>
    /// Get assign description of the ENUM
    /// </summary>
    public static class GetDescription
    {
        /// <summary>
        /// Enum to description
        /// </summary>
        /// <param name="en"></param>
        /// <returns></returns>
        public static string ToDescription(this Enum en)
        {
            var type = en.GetType();

            var memInfo = type.GetMember(en.ToString());
            if (memInfo == null || memInfo.Length <= 0) return en.ToString();
            var attrs = (object[])memInfo[0].GetCustomAttributes(
                typeof(EnumManager.DisplayText),
                false);

            if (attrs != null && attrs.Length > 0)

                return ((EnumManager.DisplayText)attrs[0]).Text;
            return en.ToString();
        }
    }
}