namespace Decorator_Design_Pattern.JuiceExample
{
    public class HoneyDecorator : JuiceDecorator
    {
        public HoneyDecorator(IJuice juice) : base(juice)
        {
        }
        public override string MakeJuice()
        {
            return _juice.MakeJuice() + AddHoney();
        }
        private string AddHoney()
        {
            return ", Honey added to the juice.";
        }
    }
}
