namespace Decorator_Design_Pattern.IceCreamedExample
{
    public class FruitMix_IceCream : IceCreamDecorator
    {
        public FruitMix_IceCream(IceCream iceCream) : base(iceCream)
        {
        }

        public override string Description => $"{base.Description} + Fruit Mix";
        public override decimal CalculateCost() => base._iceCream.CalculateCost() + .75m;
    }

}
