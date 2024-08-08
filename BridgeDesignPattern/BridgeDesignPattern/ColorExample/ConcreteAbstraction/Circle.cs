using BridgeDesignPattern.ColorExample.Abstraction;
using BridgeDesignPattern.ColorExample.Implementer;
using System;
namespace BridgeDesignPattern.ColorExample.ConcreteAbstraction
{
    public class Circle : AbstractShape
    {
        public Circle(IColor color) : base(color) {}
        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Drawing a circle. ");
            _color.ApplyColor();
        }
    }
}
