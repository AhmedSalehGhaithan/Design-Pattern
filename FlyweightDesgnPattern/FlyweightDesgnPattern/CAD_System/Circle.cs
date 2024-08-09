using System;

namespace FlyweightDesignPattern.CAD_System
{
    // The ConcreteFlyweight class with external states.
    public class Circle
    {
        private readonly ShapeStyle _style;
        public int X { get; }
        public int Y { get; }
        public int Radius { get; }
        public Circle(int x, int y, int radius, ShapeStyle style)
        {
            X = x;
            Y = y;
            Radius = radius;
            _style = style;
        }
        public void Draw()
        {
            Console.WriteLine($"Drawing Circle at ({X}, {Y}) with Radius {Radius}");
            _style.DisplayProperties();
        }
    }
}
