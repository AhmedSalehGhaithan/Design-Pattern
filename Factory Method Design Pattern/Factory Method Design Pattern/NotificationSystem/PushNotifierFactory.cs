namespace Notification_System.NotificationSystem
{
    public class PushNotifierFactory : NotifierFactory
    {
        public override INotifier CreateNotifier()
        {
            return new PushNotifier();
        }
    }
}
