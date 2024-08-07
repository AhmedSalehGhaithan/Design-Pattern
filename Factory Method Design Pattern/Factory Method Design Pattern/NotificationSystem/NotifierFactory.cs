namespace Notification_System.NotificationSystem
{
    //Creator (Abstract Class)
    public abstract class NotifierFactory
    {
        public abstract INotifier CreateNotifier();
    }
}
