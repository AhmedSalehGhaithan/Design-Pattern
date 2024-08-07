namespace MediatorDesignPattern.SmartHomeSystem
{
    public interface IHomeController
    {
        void Notify(Component sender, string eventInfo);
    }
    
}
