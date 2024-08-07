using System;
namespace Decorator_Design_Pattern.JuiceExample
{
    public abstract class JuiceDecorator : IJuice
    {
        protected IJuice _juice;
        public JuiceDecorator(IJuice juice)
        {
            _juice = juice;
        }
        public virtual string MakeJuice()
        {
            return _juice.MakeJuice();
        }
    }
}
