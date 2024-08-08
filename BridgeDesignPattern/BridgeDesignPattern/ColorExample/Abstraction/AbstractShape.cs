using BridgeDesignPattern.ColorExample.Implementer;

namespace BridgeDesignPattern.ColorExample.Abstraction
{
    public abstract class AbstractShape
    {
        protected IColor _color;
        public AbstractShape(IColor color) => _color = color;
        public abstract void Draw();
    }
}
