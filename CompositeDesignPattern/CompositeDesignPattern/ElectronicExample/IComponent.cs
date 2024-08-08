namespace CompositeDesignPattern.ElectronicExample
{
    // The base Component class declares the common operations for both simple and complex objects.
    public interface IComponent
    {
        void DisplayPrice();
    }
    public abstract class Component
    {
        protected string _name;
        public Component(string name) => _name=name;
        public abstract void DisplayPrice();
    }
}
