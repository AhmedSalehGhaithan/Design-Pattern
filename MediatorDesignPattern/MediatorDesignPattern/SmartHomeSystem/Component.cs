namespace MediatorDesignPattern.SmartHomeSystem
{
    // Abstract Colleague
    public abstract class Component
    {
        protected IHomeController _controller;
        public Component(IHomeController controller)
        {
            _controller = controller;
        }
    }
    
}
