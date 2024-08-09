using System.Collections.Generic;

namespace FlyweightDesignPattern.CAD_System
{
    // Client
    class CADSystem
    {
        private readonly List<Circle> _circles = new List<Circle>();
        private readonly StyleFactory _styleFactory = new StyleFactory();
        public void AddCircle(int x, int y, int radius, string color, string pattern, int thickness)
        {
            var style = _styleFactory.GetStyle(color, pattern, thickness);
            _circles.Add(new Circle(x, y, radius, style));
        }
        public void DrawAllShapes()
        {
            foreach (var circle in _circles)
            {
                circle.Draw();
            }
        }
    }
}
