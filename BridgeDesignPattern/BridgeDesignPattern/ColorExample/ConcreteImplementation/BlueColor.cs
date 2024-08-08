using BridgeDesignPattern.ColorExample.Implementer;
using System;

namespace BridgeDesignPattern.ColorExample.ConcreteImplementation
{
    public class BlueColor : IColor
    {
        public void ApplyColor()
        {
            Console.ForegroundColor = ConsoleColor.Blue; 
            Console.WriteLine("Applying Blue color.");
        }
    }
}
