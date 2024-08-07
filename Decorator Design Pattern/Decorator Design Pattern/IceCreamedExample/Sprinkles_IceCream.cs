namespace Decorator_Design_Pattern.IceCreamedExample
{
    public class Sprinkles_IceCream : IceCreamDecorator
    {
        public Sprinkles_IceCream(IceCream iceCream) : base(iceCream)
        {
        }

        public override string Description => $"{base.Description} + Sprinkles";
        public override decimal CalculateCost() => base._iceCream.CalculateCost() + .25m;
    }

}
