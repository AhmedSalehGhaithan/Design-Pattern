using BridgeDesignPattern.ColorExample.Abstraction;
namespace BridgeDesignPattern.ColorExample.Factory
{
    public interface IShapeFactory
    {
        AbstractShape CreateCircle();
        AbstractShape CreateRectangle();
        AbstractShape CreateSquare();
    }
}
