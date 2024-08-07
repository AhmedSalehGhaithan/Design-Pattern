namespace Decorator_Design_Pattern.IceCreamedExample
{
    public class Basic_IceCream : IceCream
    {
        public override string Description => "Ice cream";
        public override decimal CalculateCost() => + 3.5m;
    }

}
