using BridgeDesignPattern.ColorExample.Abstraction;
using BridgeDesignPattern.ColorExample.ConcreteAbstraction;
using BridgeDesignPattern.ColorExample.ConcreteImplementation;

namespace BridgeDesignPattern.ColorExample.Factory
{
    public class YellowShapeFactory : IShapeFactory
    {
        public AbstractShape CreateCircle()
        {
            AbstractShape YellowCircle = new Circle(new YellowColor());
            return YellowCircle;
        }
        public AbstractShape CreateRectangle()
        {
            AbstractShape YellowRectangle = new Rectangle(new YellowColor());
            return YellowRectangle;
        }
        public AbstractShape CreateSquare()
        {
            AbstractShape YellowSquare = new Square(new YellowColor());
            return YellowSquare;
        }
    }
}
