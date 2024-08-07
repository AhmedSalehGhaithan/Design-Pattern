namespace Decorator_Design_Pattern.IceCreamedExample
{
    public class ChocolateChips_IceCream : IceCreamDecorator
    {
        public ChocolateChips_IceCream(IceCream iceCream) : base(iceCream)
        {
        }

        public override string Description => $"{base.Description} + Chocolate Chips";
        public override decimal CalculateCost() => base._iceCream.CalculateCost() + .45m;
    }

}
