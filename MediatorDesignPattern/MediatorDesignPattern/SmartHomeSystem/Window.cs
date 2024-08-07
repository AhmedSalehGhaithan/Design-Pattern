using System;
namespace MediatorDesignPattern.SmartHomeSystem
{
    // Concrete Colleagues
    public class Window : Component
    {
        public Window(IHomeController controller) : base(controller) { }
        public void Open()
        {
            Console.WriteLine("Window opened.");
            _controller.Notify(this, "opened");
        }
    }
    
}
