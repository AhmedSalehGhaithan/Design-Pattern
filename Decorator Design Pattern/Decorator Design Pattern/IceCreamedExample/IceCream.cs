namespace Decorator_Design_Pattern.IceCreamedExample
{
    public abstract class IceCream
    {
        public abstract string Description { get; }
        public abstract decimal CalculateCost();

        public override string ToString()
        {
            return $"{Description} ({CalculateCost().ToString("C")})";
        }
    }

}
