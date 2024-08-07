using System;

namespace Factory_Design_Pattern.UIThemeSystem
{
    //Factory Class to Produce the Products
    public static class ThemeFactory
    {
        public static ITheme CreateTheme(int themeName)
        {
            switch (themeName)
            {
                case 1:
                    return new DarkMode();
                case 2:
                    return new LightMode();
                case 3:
                    return new BlueMode();
                default:
                    throw new ArgumentException("Invalid theme specified");
            }
        }
    }
}
