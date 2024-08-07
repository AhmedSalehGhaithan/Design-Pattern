namespace MediatorDesignPattern.UIFramework
{
    // Abstract Colleague
    public abstract class UIComponent
    {
        protected IUIController _controller;
        public UIComponent(IUIController controller)
        {
            _controller = controller;
        }
    }
}
