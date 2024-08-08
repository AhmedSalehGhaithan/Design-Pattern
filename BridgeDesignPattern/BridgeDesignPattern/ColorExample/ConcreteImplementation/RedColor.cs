using BridgeDesignPattern.ColorExample.Implementer;
using System;

namespace BridgeDesignPattern.ColorExample.ConcreteImplementation
{
    public class RedColor : IColor
    {
        public void ApplyColor()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Applying red color.");
        }
       
    }
}
