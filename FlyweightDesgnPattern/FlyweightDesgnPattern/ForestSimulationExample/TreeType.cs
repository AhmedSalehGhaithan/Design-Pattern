using System.Xml.Linq;
using System;

namespace FlyweightDesignPattern.ForestSimulationExample
{
    public class TreeType
    {
        public string _name { get; }
        public string _color { get; }
        public string _texture { get; }
        public TreeType(string name,string color,string texture)
        {
            _color = color;
            _name = name;
            _texture = texture;
        }
        public void Draw(int x, int y)
        {
            Console.WriteLine($"Drawn a {_name} tree with {_color} color and {_texture} texture at ({x}, {y})");
        }
    }
}
