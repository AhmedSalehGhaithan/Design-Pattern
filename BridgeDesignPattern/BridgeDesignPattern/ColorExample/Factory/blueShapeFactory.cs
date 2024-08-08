using BridgeDesignPattern.ColorExample.Abstraction;
using BridgeDesignPattern.ColorExample.ConcreteAbstraction;
using BridgeDesignPattern.ColorExample.ConcreteImplementation;

namespace BridgeDesignPattern.ColorExample.Factory
{
    public class blueShapeFactory : IShapeFactory
    {
        public AbstractShape CreateCircle()
        {
            AbstractShape blueCircle = new Circle(new BlueColor());
            return blueCircle;
        }
        public AbstractShape CreateRectangle()
        {
            AbstractShape blueRectangle = new Rectangle(new BlueColor());
            return blueRectangle;
        }
        public AbstractShape CreateSquare()
        {
            AbstractShape blueSquare = new Square(new BlueColor());
            return blueSquare;
        }
    }
}
