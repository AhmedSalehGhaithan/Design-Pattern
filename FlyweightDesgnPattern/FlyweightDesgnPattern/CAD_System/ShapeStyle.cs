using System;

namespace FlyweightDesignPattern.CAD_System
{
    // Flyweight: ShapeStyle holds the shared properties
    public class ShapeStyle
    {
        public string Color { get; }
        public string Pattern { get; }
        public int Thickness { get; }
        public ShapeStyle(string color, string pattern, int thickness)
        {
            Color = color;
            Pattern = pattern;
            Thickness = thickness;
        }
        public void DisplayProperties()
        {
            Console.WriteLine($"Style [Color: {Color}, Pattern: {Pattern}, Thickness: {Thickness}]");
        }
    }
}
