namespace MediatorDesignPattern.UIFramework
{
    // Mediator
    public interface IUIController
    {
        void Notify(UIComponent sender, string eventInfo);
    }
}
