using FlyweightDesignPattern.ShapeExample;
using System.Collections.Generic;

namespace FlyweightDesignPattern.ShapeExample
{
    public class ShapeFactory
    {
        private readonly Dictionary<string, IShape> _shapes = new Dictionary<string, IShape>();

        public IShape GetCircle(string color ,int radius)
        {
            string key = $"{color}_{radius}";
            if (!_shapes.ContainsKey(key))
            {
                _shapes[key] = new Circle(color, radius);
            }
            return _shapes[key];
        }
    }
}
