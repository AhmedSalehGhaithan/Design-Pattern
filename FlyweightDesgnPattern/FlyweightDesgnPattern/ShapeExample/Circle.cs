using System;

namespace FlyweightDesignPattern.ShapeExample
{
    public class Circle : IShape
    {
        private readonly string _color;
        private readonly int _radius;

        public Circle(string color,int radius)
        {
            _color = color;
            _radius = radius;
        }
        public void Draw(int x, int y)
        {
            Console.WriteLine($"Drawing a {_color} circle with radius {_radius} at position ({x}, {y})");
        }
    }
}
