using System;

namespace Factory_Design_Pattern.UIThemeSystem
{
    public class LightMode : ITheme
    {
        public string BackgroundColor => "#FFFFFF";
        public string TextColor => "#000000";
        public void ApplyTheme()
        {
            Console.WriteLine("Applying Light Mode...");
            // Logic for applying light theme elements
        }
    }
}
