namespace Decorator_Design_Pattern.IceCreamedExample
{
    public abstract class IceCreamDecorator : IceCream
    {
        public IceCreamDecorator(IceCream iceCream)
        {
            _iceCream = iceCream;
        }
        protected IceCream _iceCream { get; }

        public override string Description => _iceCream.Description;
        public override decimal CalculateCost() => _iceCream.CalculateCost();
    
    }

}
