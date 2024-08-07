namespace Decorator_Design_Pattern.IceCreamedExample
{
    public class Strawberry_IceCream : IceCreamDecorator
    {
        public Strawberry_IceCream(IceCream iceCream) : base(iceCream)
        {
        }

        public override string Description => $"{base.Description} + Strawberry";
        public override decimal CalculateCost() => base._iceCream.CalculateCost() + 1.12m;
    }

}
