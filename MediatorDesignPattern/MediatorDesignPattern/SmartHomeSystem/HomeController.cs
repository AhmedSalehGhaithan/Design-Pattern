using System;
namespace MediatorDesignPattern.SmartHomeSystem
{
    public class HomeController : IHomeController
    {
        public void Notify(Component sender, string eventInfo)
        {
            if (sender is Window && eventInfo == "opened")
            {
                Console.WriteLine("Turning off heater...");
                Console.WriteLine("Turning off lights...");
            }
            // Add more interactions as needed...
        }
    }
    
}
