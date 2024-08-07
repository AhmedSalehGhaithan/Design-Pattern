using System;

namespace Factory_Design_Pattern.UIThemeSystem
{
    //Concrete Implementations for the Products
    public class DarkMode : ITheme
    {
        public string BackgroundColor => "#000000";
        public string TextColor => "#FFFFFF";
        public void ApplyTheme()
        {
            Console.WriteLine("Applying Dark Mode...");
            // Logic for applying dark theme elements
        }
    }
}
