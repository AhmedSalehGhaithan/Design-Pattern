using System;

namespace MediatorDesignPattern.UIFramework
{
    public class TextField : UIComponent
    {
        public TextField(IUIController controller) : base(controller) { }
        public void Display()
        {
            Console.WriteLine("Text field displayed.");
        }
    }
}
