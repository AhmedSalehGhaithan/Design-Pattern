using BridgeDesignPattern.ColorExample.Abstraction;
using BridgeDesignPattern.ColorExample.ConcreteAbstraction;
using BridgeDesignPattern.ColorExample.ConcreteImplementation;
namespace BridgeDesignPattern.ColorExample.Factory
{
    public class RedShapeFactory : IShapeFactory
    {
        public AbstractShape CreateCircle()
        {
            AbstractShape redCircle = new Circle(new RedColor());
            return redCircle;
        }
        public AbstractShape CreateRectangle()
        {
            AbstractShape redRectangle = new Rectangle(new RedColor());
            return redRectangle;
        }
        public AbstractShape CreateSquare()
        {
            AbstractShape redSquare = new Square(new RedColor());
            return redSquare;
        }
    }
}
