using System.Collections.Generic;

namespace FlyweightDesignPattern.CAD_System
{
    // Flyweight Factory
    public class StyleFactory
    {
        private readonly Dictionary<string, ShapeStyle> _styles = new Dictionary<string, ShapeStyle>();
        public ShapeStyle GetStyle(string color, string pattern, int thickness)
        {
            var key = $"{color}_{pattern}_{thickness}";
            if (!_styles.ContainsKey(key))
            {
                _styles[key] = new ShapeStyle(color, pattern, thickness);
            }
            return _styles[key];
        }
    }
}
