
namespace Notification_System.NotificationSystem
{
    public class NotificationSystems
    {
        public void NotifyUser(NotifierFactory factory, string message)
        {
            INotifier notifier = factory.CreateNotifier();
            notifier.SendNotification(message);
        }
    }
}
