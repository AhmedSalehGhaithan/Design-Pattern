using System;
namespace MediatorDesignPattern.SmartHomeSystem
{
    public class Heater : Component
    {
        public Heater(IHomeController controller) : base(controller) { }
        public void TurnOn()
        {
            Console.WriteLine("Heater turned on.");
        }
    }
    
}
