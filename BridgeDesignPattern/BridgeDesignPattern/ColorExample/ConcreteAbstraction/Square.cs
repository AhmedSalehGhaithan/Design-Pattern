using BridgeDesignPattern.ColorExample.Abstraction;
using BridgeDesignPattern.ColorExample.Implementer;
using System;

namespace BridgeDesignPattern.ColorExample.ConcreteAbstraction
{
    public class Square : AbstractShape
    {
        public Square(IColor color) : base(color) {}

        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Drawing a Rectangle. ");
            _color.ApplyColor();
        }
    }
}
