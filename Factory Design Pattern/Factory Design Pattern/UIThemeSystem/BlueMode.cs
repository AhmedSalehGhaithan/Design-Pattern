using System;

namespace Factory_Design_Pattern.UIThemeSystem
{
    public class BlueMode : ITheme
    {
        public string BackgroundColor => "#0000FF";
        public string TextColor => "#FFFFFF";
        public void ApplyTheme()
        {
            Console.WriteLine("Applying Blue Mode...");
            // Logic for applying blue theme elements
        }
    }
}
