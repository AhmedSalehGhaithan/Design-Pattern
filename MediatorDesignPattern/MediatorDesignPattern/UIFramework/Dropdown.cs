using System;

namespace MediatorDesignPattern.UIFramework
{
    // Concrete Colleagues
    public class Dropdown : UIComponent
    {
        public Dropdown(IUIController controller) : base(controller) { }
        public void SelectOption(string option)
        {
            Console.WriteLine($"Option {option} selected.");
            _controller.Notify(this, $"{option}_selected");
        }
    }
}
