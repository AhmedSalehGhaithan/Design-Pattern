using System;

namespace MediatorDesignPattern.UIFramework
{
    public class UIController : IUIController
    {
        public void Notify(UIComponent sender, string eventInfo)
        {
            if (sender is Dropdown && eventInfo == "option1_selected")
            {
                Console.WriteLine("Displaying additional text fields...");
            }
            // More interactions as needed...
        }
    }
}
