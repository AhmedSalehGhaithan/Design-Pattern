using BridgeDesignPattern.ColorExample.Implementer;
using System;

namespace BridgeDesignPattern.ColorExample.ConcreteImplementation
{
    public class YellowColor : IColor
    {
        public void ApplyColor()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Applying Yellow color.");
        }
       
    }
}
