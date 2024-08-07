namespace Notification_System.NotificationSystem
{
    //Concrete Creators
    public class EmailNotifierFactory : NotifierFactory
    {
        public override INotifier CreateNotifier()
        {
            return new EmailNotifier();
        }
    }
}
