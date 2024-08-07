namespace Decorator_Design_Pattern.JuiceExample
{
    public class IceDecorator : JuiceDecorator
    {
        public IceDecorator(IJuice juice) : base(juice)
        {
        }
        public override string MakeJuice()
        {
            return _juice.MakeJuice() + AddIce();
        }
        private string AddIce()
        {
            return ", Ice Added to the juice.";
        }
    }
}
